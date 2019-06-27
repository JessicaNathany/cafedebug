using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cafedebug.Configuration
{
    public static class Mensagem
    {
        public static string GetDescription(this Enum enumerationValue)
        {
            Type type = enumerationValue.GetType();
            MemberInfo member = type.GetMembers().Where(w => w.Name == Enum.GetName(type, enumerationValue)).FirstOrDefault();

            var attribute = member?.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault() as DescriptionAttribute;

            return attribute?.Description != null ? attribute.Description : enumerationValue.ToString();
        }

        public static T GetEnumValue<T>(this string description)
        {
            var type = typeof(T);
            if (!type.GetTypeInfo().IsEnum)
                throw new ArgumentException();

            var field = type.GetFields().SelectMany(f => f.GetCustomAttributes(typeof(DescriptionAttribute), false), (f, a) => new { Field = f, Att = a })
                                        .Where(a => ((DescriptionAttribute)a.Att).Description == description).SingleOrDefault();
            return field == null ? default(T) : (T)field.Field.GetRawConstantValue();
        }
    }

    public enum EnumMensagem
    {
        [Description("Ocorreu um erro inesperado, tente novamente mais tarde!")]
        MsgErroGenerico = 1,

        #region Mensagens - Login - Acesso

        [Description("Captcha inválido, tente novamente.")]
        MsgCaptchaInvalid = 2,

        [Description("Login bloqueado por inatividade!")]
        MsgLoginBloq = 3,

        [Description("Login e/ou senha incorretos!")]
        MsgLoginSenhaInc = 4,

        [Description("Informe o login e senha!")]
        MsgInfoLoginSenha = 5,

        #endregion

        #region Mensagens - Login - Alterar Senha (primeiro acesso)

        [Description("A nova senha deve ser diferente das duas últimas informadas.")]
        MsgAltSenhaPADif = 6,

        [Description("Problemas na alteração de senha! Entre em contato com o Administrador do Sistema.")]
        MsgProbAltSenha = 7,

        #endregion

        #region Mensagens - Login - Esqueci Minha Senha

        [Description("Ocorreu um erro durante o processo de recuperação de senha. Por favor, verifique o e-mail e tente novamente. Caso o erro persista, contate o Administrador do Sistema.")]
        MsgErroRepSenha = 8,

        [Description("E-mail não cadastrado no sistema!")]
        MsgEmailNotCad = 9,

        [Description("O endereço de e-mail fornecido é inválido. Por favor, verifique o e-mail e tente novamente.")]
        MsgEmailInvalid = 10,

        #endregion
    }
}

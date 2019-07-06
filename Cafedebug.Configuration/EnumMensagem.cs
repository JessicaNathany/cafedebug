using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Cafedebug.Configuration
{
    public static class Mensagem
    {
        /// <summary>
        /// Retorna a descrição (Name) das mensagens dos pop-ups chamados no controller
        /// </summary>
        /// <param name="enumerationValue"></param>
        /// <returns></returns>
        public static string GetDescription(this Enum enumerationValue)
        {
            Type type = enumerationValue.GetType();
            MemberInfo member = type.GetMembers().Where(w => w.Name == Enum.GetName(type, enumerationValue)).FirstOrDefault();

            var attribute = member?.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault() as DescriptionAttribute;

            return attribute?.Description != null ? attribute.Description : enumerationValue.ToString();
        }

        /// <summary>
        /// Retorna o valor (Id) das mensagens dos pop-ups chamados no controller
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
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

    /// <summary>
    /// Mensagens de validação utilizadas nos popu-ups.
    /// </summary>
    public enum EnumMensagem
    {
        #region  Message - Login

        [Description("Ocorreu um erro inesperado, tente novamente mais tarde!")]
        MsgErroGeneric = 1,

        [Description("Captcha inválido, tente novamente.")]
        MsgCaptchaInvalido = 2,

        [Description("Login bloqueado por inatividade!")]
        MsgLoginBlock = 3,

        [Description("Login e/ou senha incorretos!")]
        MsgLoginSenhaIncorreto = 4,

        [Description("Informe o login e senha!")]
        MsgInfoLoginSenha = 5,

        [Description("A nova senha deve ser diferente das duas últimas informadas.")]
        MsgAlteraSenha = 6,

        [Description("Problemas na alteração de senha! Entre em contato com o Administrador do Sistema.")]
        MsgProblemaAlterarSenha = 7,

        [Description("Ocorreu um erro durante o processo de recuperação de senha. Por favor, verifique o e-mail e tente novamente. Caso o erro persista, contate o Administrador do Sistema.")]
        MsgErroRecuperarSenha = 8,

        [Description("E-mail não cadastrado no sistema!")]
        MsgEmailNaoCadastrado = 9,

        [Description("O endereço de e-mail fornecido não é inválido. Por favor, verifique o e-mail e tente novamente.")]
        MsgEmailInvalido = 10,

        #endregion

        #region Message - Error

        [Description("Erro ao excluir um Usuário!")]
        MsgErroExcluirUsuario = 11,

        [Description("Erro ao excluir um Episódio!")]
        MsgErroExcluirEpisodio = 12,

        [Description("Erro ao excluir uma Notícia!")]
        MsgErroExcluirNoticia = 13,

        [Description("Erro ao excluir uma Categoria!")]
        MsgErroExcluirCategoria = 14,

        [Description("Erro ao excluir um Banner!")]
        MsgErroExcluirBanner = 15,

        [Description("Erro ao excluir um Tipo de Categoria!")]
        MsgErroExcluirTipoCategoria = 16,

        [Description("Ocorreu um erro ao fazer esta requisição! Tente mais tarde.")]
        MsgErroErrorSistema = 17,

        #endregion

        #region Message - Success

        [Description("Usuário cadastrado com sucesso!")]
        MsgCadastroUsuario = 18,

        [Description("Episódio cadastrado com sucesso!")]
        MsgCadastroEpisódio = 19,

        [Description("Categoria cadastrada com sucesso!")]
        MsgCadastroCategoria = 20,

        [Description("Notícia cadastrada com sucesso!")]
        MsgCadastroNoticia = 21,

        [Description("Banner cadastrado com sucesso!")]
        MsgCadastroBanner = 22,

        [Description("Tipo de Categoria cadastrada com sucesso!")]
        MsgCadastroTipoCategoria = 23,

        [Description("Registro alterado com sucesso!")]
        MsgAtualizacaoGenerica = 24,

        [Description("Registro excluído com sucesso!")]
        MsgExclusaoGenerica = 25,

        #endregion

        #region Message - Question

        [Description("Tem certeza que deseja excluir o(s) registro(s)?")]
        MsgPerguntaGenerica = 26,

        [Description("Tem certeza que deseja sair da aplicação?")]
        MsgPerguntaSairSistema = 27,

        #endregion

        #region Message - Alert

        [Description("Você não tem permissão para executar esta ação!")]
        MsgAlerta= 28,

        [Description("Este registro não pode ser excluído!")]
        MsgAlertaExclusao = 29,

        [Description("Já existe um registro deste na base!")]
        MsgAlertaExiste = 30,

        #endregion 
    }
}

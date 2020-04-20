using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using Cafedebug.Business.Models.Validations;
using log4net;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafedebug.Business.Services
{
    public class ContactService : BaseService, IContactService
    {
        private readonly IContactRepository _contactRepository;
        private static readonly ILog Log = LogManager.GetLogger(typeof(ContactService));


        public ContactService(IContactRepository contactRepository, INotifier notifier) : base(notifier)
        {
            _contactRepository = contactRepository;
        }

        public void Save(Contact contact)
        {
            try
            {
                if (!ExecuteValidation(new ContactValidation(), contact)) return;

                _contactRepository.Save(contact);
            }
            catch (Exception ex)
            {
                Notify("Erro ao enviar formulário.");
                Log.ErrorFormat("Erro ao enviar formulário", ex.Message, contact);
                throw;
            }
        }
    }
}

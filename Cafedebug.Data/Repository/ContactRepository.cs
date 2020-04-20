using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using Cafedebug.Data.Context;


namespace Cafedebug.Data.Repository
{
    public class ContactRepository : Repository<Contact>, IContactRepository
    {
        private readonly CafedebugContext _context;
        public ContactRepository(CafedebugContext context) : base(context)
        {
            _context = context;
        }
    }
}

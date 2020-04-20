using Cafedebug.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafedebug.Business.Interfaces
{
    public interface IContactService
    {
         void Save(Contact contact);
    }
}

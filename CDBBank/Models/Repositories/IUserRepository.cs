using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CDBBank.Models.Repositories
{
    public interface IUserRepository
    {
        BankUser GetUser(BankUser user);
    }
}

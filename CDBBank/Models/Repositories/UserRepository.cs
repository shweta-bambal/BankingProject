using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CDBBank.Models.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly CDBBankContext _context;
        public UserRepository(CDBBankContext context)
        {
            _context = context;
        }
        public BankUser GetUser(BankUser user)
        {
            return _context.BankUsers.Where(x => x.Username == user.Username && x.Password == user.Password).FirstOrDefault();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CDBBank.Models.Repositories
{
    public interface ITokenService
    {
        string BuildToken(string key, string issuer, BankUser user);
        bool ValidateToken(string key, string issuer, string token);
    }
}

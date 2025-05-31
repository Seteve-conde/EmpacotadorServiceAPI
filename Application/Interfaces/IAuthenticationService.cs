using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAuthenticationService
    {
        string GenerateJwtToken(string username);
        bool ValidateUser(string username, string password);
    }
}

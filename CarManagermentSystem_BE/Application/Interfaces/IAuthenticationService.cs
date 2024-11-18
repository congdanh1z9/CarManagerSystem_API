using Application.ViewModels.AccountDTOs;
using Application.ViewModels.APIModelResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAuthenticationService
    {
        Task<APIModelReponseDTO> RegisterAsync(RegisterDTO model);
        Task<APIModelReponseDTO> ConfirmEmail(string email, string confirmMail);
    }
}

using Application.Helpers;
using Application.Interfaces;
using Application.ViewModels.AccountDTOs;
using Application.ViewModels.APIModelResponseDTOs;
using AutoMapper;
using Domain.Entities;
using System.Data.Common;


namespace Application.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AuthenticationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<APIModelReponseDTO> ConfirmEmail(string email, string confirmMail)
        {
            var response = new APIModelReponseDTO();
            try
            {
                var userChecked = await _unitOfWork.accountRepository.GetAllAsync(x => x.Email == email);
                if (userChecked.FirstOrDefault() == null)
                {
                    response.IsSuccess = false;
                    response.Message = "Email does not exist.";
                    return response;
                }

                var result = _unitOfWork.accountRepository.checkConfirmEmail(email, confirmMail);
                if (!result)
                {
                    response.IsSuccess = false;
                    response.Message = "Token failed, not confirmed.";
                }
                else
                {
                     userChecked.FirstOrDefault().IsConfirm = true;
                    _unitOfWork.accountRepository.Update(userChecked.FirstOrDefault());
                    if (await _unitOfWork.SaveChangeAsync() > 0)
                    {
                        response.IsSuccess = true;
                        response.Message = "Confirm successful.";
                    }
                    else
                    {
                        response.IsSuccess = false;
                        response.Message = "Update faild, not confirmed.";
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<APIModelReponseDTO> RegisterAsync(RegisterDTO model)
        {
            var response = new APIModelReponseDTO();
            try
            {
                var emailExist = await _unitOfWork.accountRepository.GetAllAsync(x => x.Email == model.Email && x.IsConfirm == true);
                if (emailExist.Any())
                {
                    response.IsSuccess = false;
                    response.Message = "Email is existed";
                    return response;
                }

                var user = _mapper.Map<Account>(model);
                user.ConfirmationToken = Guid.NewGuid().ToString();
                user.RoleId = 1;
                user.Status = true;
                user.Password = PasswordHasher.Hash(model.Password);
                await _unitOfWork.accountRepository.AddAsync(user);
                var confirmationLink = $"https://jewelry-auction-system-bwfbbwdecudgfbd4.centralus-01.azurewebsites.net/api/Authentication/ConfirmEmail/confirm?token={user.ConfirmationToken}&email={user.Email}";
                var emailSent = await SendMail.SendConfirmationEmail(user.Email, confirmationLink);
                if (!emailSent)
                {
                    response.IsSuccess = false;
                    response.Message = "Error sending confirmation email.";
                    return response;
                }
                else
                {
                    var isSuccess = await _unitOfWork.SaveChangeAsync() > 0;

                    if (isSuccess)
                    {
                        response.IsSuccess = true;
                        response.Message = "Register successfully.";
                    }
                    else
                    {
                        response.IsSuccess = false;
                        response.Message = "Error saving the account.";
                    }
                }
            }
            catch (DbException ex)
            {
                response.IsSuccess = false;
                response.Message = "Database error occurred.";
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Error";
            }
            return response;
        }
    }
}

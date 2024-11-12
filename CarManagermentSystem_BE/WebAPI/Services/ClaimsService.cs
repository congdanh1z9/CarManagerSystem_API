using Application.Interfaces;
using System.Security.Claims;

namespace WebAPI.Services
{
    public class ClaimsService : IClaimsService
    {
        public ClaimsService(IHttpContextAccessor httpContextAccessor)
        {
            var idClaim = httpContextAccessor.HttpContext?.User?.FindFirstValue("Id");

            GetCurrentUserId = int.TryParse(idClaim, out var userId) ? userId : 0;
        }

        public int GetCurrentUserId { get; }

    }

}

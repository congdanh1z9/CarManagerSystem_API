using Domain.Entities;

namespace Application.Repositories
{
    public interface IAccountRepository : IGenericRepository<Account>
    {
        bool checkConfirmEmail(string email, string genericToken);
    }
}

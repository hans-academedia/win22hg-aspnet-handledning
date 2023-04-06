using WebApp.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Repositories
{
    public class UserRepository : Repository<UserEntity>
    {
        public UserRepository(DataContext context) : base(context)
        {
        }
    }
}

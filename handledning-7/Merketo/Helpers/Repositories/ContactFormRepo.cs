using Merketo.Contexts;
using Merketo.Models.Entities;

namespace Merketo.Helpers.Repositories
{
    public class ContactFormRepo : Repo<ContactFormEntity>
    {
        public ContactFormRepo(DataContext context) : base(context)
        {
        }
    }
}

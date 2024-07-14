using RaythosAerospace.Data.Base;
using RaythosAerospace.Models;

namespace RaythosAerospace.Data.Services
{
    public class UserService: EntityBaseRepository<User>, IUserService
    {
        public UserService(AppDbContext context): base(context) { }
        
         
    }
}

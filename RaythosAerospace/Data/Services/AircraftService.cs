using Microsoft.EntityFrameworkCore;
using RaythosAerospace.Data.Base;
using RaythosAerospace.Models;

namespace RaythosAerospace.Data.Services
{
    public class AircraftService : EntityBaseRepository<Aircraft>, IAircraftService
    {
        public AircraftService(AppDbContext context) : base(context) { }
       
    }
}

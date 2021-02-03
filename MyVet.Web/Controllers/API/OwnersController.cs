using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyVet.Common.Models;
using MyVet.Web.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class OwnersController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public OwnersController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        // Obtenir le propriétaire via son email
        [HttpPost]
        [Route("GetOwnerByEmail")]
        public async Task<IActionResult> GetOwner(EmailRequest emailRequest)
        {
            // validation des champs
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            // on trouve le propriétaire via son email
            var owner = await _dataContext.Owners
                .Include(o => o.User)
                .Include(o => o.Pets)
                .ThenInclude(p => p.PetType)
                .Include(o => o.Pets)
                .ThenInclude(p => p.Histories)
                .ThenInclude(h => h.ServiceType)
                .FirstOrDefaultAsync(o => o.User.Email.ToLower() == emailRequest.Email.ToLower());
            // si le propriétaire n'est pas trouvé, on retourne une erreur
            if (owner == null)
            {
                return NotFound();
            }

            var response = new OwnerResponse
            {
                Id = owner.Id,
                FirstName = owner.User.FirstName,
                LastName = owner.User.LastName,
                Document = owner.User.Document,
                Address = owner.User.Address,
                PhoneNumber = owner.User.PhoneNumber,
                Email = owner.User.Email,
                Pets = owner.Pets.Select(p => new PetResponse
                {
                    ImageUrl = p.ImageUrl,
                    Id = p.Id,
                    Name = p.Name,
                    Race = p.Race,
                    Born = p.Born,
                    Remarks = p.Remarks,
                    PetType = p.PetType.Name,
                    Histories = p.Histories.Select(h => new HistoryResponse
                    {
                        Date = h.Date,
                        Description = h.Description,
                        Id = h.Id,
                        Remarks = h.Remarks,
                        ServiceType = h.ServiceType.Name
                    }).ToList()
                }).ToList()
            };

            // on retourne le propriétaire avec tous les éléments associés (animaux, type de service ....)
            return Ok(response);
        }
    }
}

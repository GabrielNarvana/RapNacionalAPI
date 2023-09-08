using RapNacionalAPI.Data.UnitOfWorks.Interfaces;
using RapNacionalAPI.Services.Interfaces;

namespace RapNacionalAPI.Services
{
    public class ArtistaService : IArtistaService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ArtistaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}

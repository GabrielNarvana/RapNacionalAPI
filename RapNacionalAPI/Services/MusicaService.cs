using RapNacionalAPI.Data.UnitOfWorks.Interfaces;
using RapNacionalAPI.Services.Interfaces;

namespace RapNacionalAPI.Services
{
    public class MusicaService : IMusicaService
    {
        private readonly IUnitOfWork _unitOfWork;
        public MusicaService(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }
    }
}

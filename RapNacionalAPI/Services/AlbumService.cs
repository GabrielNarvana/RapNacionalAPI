using AutoMapper;
using RapNacionalAPI.Data.Model;
using RapNacionalAPI.Data.UnitOfWorks.Interfaces;
using RapNacionalAPI.DTOs.Response;
using RapNacionalAPI.Services.Interfaces;

namespace RapNacionalAPI.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public AlbumService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<AlbumResponse> GetAllAlbuns()
        {
            IEnumerable<Album> retorno = _unitOfWork.Album.GetAll();
            return _mapper.Map<IEnumerable<AlbumResponse>>(retorno);
        }
    }
}

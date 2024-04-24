using AutoMapper;
using Domain.Dto;
using Entities.Models;

namespace Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Anime , AnimeDto> ();
            CreateMap<AnimeForUpdateDto, Anime>();
            CreateMap<AnimeForCreationDto, Anime>();
            CreateMap<UserForRegistrationDto, User>();
        } 

    }
}

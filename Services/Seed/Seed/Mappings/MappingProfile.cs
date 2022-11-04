using AutoMapper;
using Seed.Entities.DbEntities;
using Seed.Entities.XML;

namespace Seed.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Circuit, CircuitCsv>().ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CircuitId))
                .ForMember(dest => dest.Ref, opt => opt.MapFrom(src => src.CircuitRef));
            CreateMap<Driver, DriverCsv>().ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.driverId))
                .ForMember(dest => dest.Ref, opt => opt.MapFrom(src => src.driverRef));
            CreateMap<Constructor, ConstructorCsv>().ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ConstructorId))
                .ForMember(dest => dest.Ref, opt => opt.MapFrom(src => src.ConstructorRef));
            CreateMap<Race, RaceCsv>().ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.raceId));
        }
    }
}

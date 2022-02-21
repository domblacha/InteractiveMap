using AutoMapper;
using InteractiveMap.Entities;
using InteractiveMap.Models;

namespace InteractiveMap
{
    public class InteractiveMapMappingProfile : Profile
    {
        public InteractiveMapMappingProfile()
        {
            CreateMap<Marker, MarkerDto>()
                .ForMember(d => d.MarkerId, c => c.MapFrom(r => r.Id))
                .ForMember(d => d.AuthorFirstName, c => c.MapFrom(r => r.User.FirstName))
                .ForMember(d => d.AuthorLastName, c => c.MapFrom(r => r.User.LastName));


            CreateMap<Comment, CommentDto>()
               .ForMember(d => d.CommentId, c => c.MapFrom(r => r.Id))
               .ForMember(d => d.AuthorFirstName, c => c.MapFrom(r => r.User.FirstName))
               .ForMember(d => d.AuthorLastName, c => c.MapFrom(r => r.User.LastName))
               .ForMember(d => d.AuthorId, c => c.MapFrom(r => r.User.Id));

            CreateMap<User, UserDto>()
                 .ForMember(d => d.UserId, c => c.MapFrom(r => r.Id));

            CreateMap<CreateMarkerDto, Marker>();
        }
    }
}

using AutoMapper;
using Joylet.API.Domain.Models;
using Joylet.API.Domain.Models.Dto;

namespace Joylet.API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Cart, ResultCartDto>();
            CreateMap<ResultCartDto, Cart>();
            CreateMap<CreateCartDto, Cart>();
            CreateMap<CreateItemsDto, CartItem>();
            CreateMap<CartItem, CreateItemsDto>();
        }
    }
}

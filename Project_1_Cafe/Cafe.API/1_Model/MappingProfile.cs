using AutoMapper;
using Cafe.API.DTOs;

namespace Cafe.API.Items;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Order, OrderOutDTO>()
            .ForMember(s => s.FoodsDTO, c => c.MapFrom(m => m.Items.Where(i => i is Food)));

        CreateMap<Order, OrderInDTO>().ReverseMap();

        CreateMap<Food, FoodOutDTO>();
            //.ForMember(s => s.FoodsDTO, c => c.MapFrom(m => m.Items.Where(i => i is Food)));

        CreateMap<Food, FoodInDTO>().ReverseMap(); 
    }
}
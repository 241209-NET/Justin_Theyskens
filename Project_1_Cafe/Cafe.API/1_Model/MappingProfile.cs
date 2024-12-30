using AutoMapper;
using Cafe.API.DTOs;

namespace Cafe.API.Items;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Order, OrderOutDTO>()
            .ForMember(s => s.FoodsDTO, c => c.MapFrom(m => m.Items.Where(i => i is Food)))
            .ForMember(z => z.DrinksDTO, d => d.MapFrom(n => n.Items.Where(t => t is Drink)));

        CreateMap<Order, OrderInDTO>().ReverseMap();

        CreateMap<Food, FoodOutDTO>();
            //.ForMember(s => s.FoodsDTO, c => c.MapFrom(m => m.Items.Where(i => i is Food)));

        CreateMap<Food, FoodInDTO>().ReverseMap(); 

            CreateMap<Drink, DrinkOutDTO>();
            //.ForMember(s => s.FoodsDTO, c => c.MapFrom(m => m.Items.Where(i => i is Food)));

        CreateMap<Drink, DrinkInDTO>().ReverseMap(); 
    }
}
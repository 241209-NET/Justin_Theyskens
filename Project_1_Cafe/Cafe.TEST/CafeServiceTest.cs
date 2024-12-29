using Moq;
using Cafe.API.Items;
using Cafe.API.Service;
using Cafe.API.Repo;
using AutoMapper;
using Cafe.API.DTOs;

namespace Cafe.Test;

public class UnitTest1
{
    public void TestCreateNewOrder()
    {
        //Arrange
        Mock<IOrderRepo> mockRepo = new();
        Mock<IMapper> mockMapper = new();
        OrderService orderService = new(mockRepo.Object, mockMapper.Object);

        List<OrderInDTO> orderDTOList = 
        [
            new OrderInDTO(){Name = "Justin"},
            new OrderInDTO(){Name = "Sammy"},
            new OrderInDTO(){Name = "Devin"},
            new OrderInDTO(){Name = "Krystel"},
            new OrderInDTO(){Name = "Mike"},
            new OrderInDTO(){Name = "Dan"}
        ];

        OrderInDTO newOrderDTO = new OrderInDTO(){Name = "Anita Weiner"};

        List<Order> orderList = new();

        foreach(OrderInDTO order in orderDTOList)
        {
            orderList.Add(order.DtoToOrder());
        }
        var newOrder = newOrderDTO.DtoToOrder();

        mockRepo.Setup(repo => repo.CreateNewOrder(It.IsAny<Order>()))
            .Callback((Order o) => orderList.Add(o))
            .Returns(newOrder);

    }
}

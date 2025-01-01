using Moq;
using Cafe.API.Items;
using Cafe.API.Service;
using Cafe.API.Repo;
using AutoMapper;
using Cafe.API.DTOs;

namespace Cafe.TEST;

public class UnitTest1
{
    [Fact]
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
        //Act
        var myPet = orderService.CreateNewOrder(newOrder);

        //Assert
        Assert.Contains(newOrder, orderList);
        // if (orderList.Contains(newOrder))
        //     Console.WriteLine("pass");
        // else
        //     Console.WriteLine("fail");

        mockRepo.Verify(x => x.CreateNewOrder(It.IsAny<Order>()), Times.Once());
    }
}
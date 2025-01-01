using Moq;
using Cafe.API.Items;
using Cafe.API.Service;
using Cafe.API.Repo;
using AutoMapper;
using Cafe.API.DTOs;

namespace Cafe.TEST;

public class UnitTest1
{
    
    // [Fact]
    // public void TestCreateNewOrder()
    // {
    //     //Arrange
    //     Mock<IOrderRepo> mockRepo = new();
    //     Mock<IMapper> mockMapper = new();
    //     OrderService orderService = new(mockRepo.Object, mockMapper.Object);

    //     List<OrderInDTO> orderDTOList = 
    //     [
    //         new OrderInDTO(){Name = "Justin"},
    //         new OrderInDTO(){Name = "Sammy"},
    //         new OrderInDTO(){Name = "Devin"},
    //         new OrderInDTO(){Name = "Krystel"},
    //         new OrderInDTO(){Name = "Mike"},
    //         new OrderInDTO(){Name = "Dan"}
    //     ];

    //     OrderInDTO newOrderDTO = new OrderInDTO(){Name = "Anita"};

    //     List<Order> orderList = new();

    //     foreach(OrderInDTO order in orderDTOList)
    //     {
    //         orderList.Add(order.DtoToOrder());
    //     }
    //     var newOrder = newOrderDTO.DtoToOrder();

    //     mockRepo.Setup(repo => repo.CreateNewOrder(It.IsAny<Order>()))
    //         .Callback((Order o) => orderList.Add(o))
    //         .Returns(newOrder);
    //     //Act
    //     var myOrder = orderService.CreateNewOrder(newOrder);

    //     //Assert
    //     Assert.Contains(newOrder, orderList);

    //     mockRepo.Verify(x => x.CreateNewOrder(It.IsAny<Order>()), Times.Once());
    // }
    

    // [Fact]
    // public void TestCreateNewFood()
    // {
    //     //Arrange
    //     Mock<IOrderRepo> mockOrderRepo = new();
    //     Mock<IMapper> mockMapper = new();
    //     OrderService orderService = new(mockOrderRepo.Object, mockMapper.Object);

    //     Mock<IFoodRepo> mockRepo = new();
    //     //Mock<IMapper> mockMapper = new();
    //     FoodService foodService = new(mockRepo.Object, mockMapper.Object);
    //     new OrderInDTO(){Name = "Justin"};

    //     FoodInDTO newFoodDTO = new FoodInDTO()
    //     {
    //         Type = Food.FoodType.BaconEggAndCheddarSandwich,
    //         OrderId = 1
    //     };
        
    //     List<Food> foodList = new();

    //     foodList.Add(newFoodDTO.DtoToFood());
        
    //     var newFood = newFoodDTO.DtoToFood();

    //     mockRepo.Setup(repo => repo.CreateNewFood(It.IsAny<Food>()))
    //         .Callback((Food f) => foodList.Add(f))
    //         .Returns(newFood);

    //     //Act
    //     var myFood = foodService.CreateNewFood(newFood);

    //     //Assert
    //     Assert.Contains(newFood, foodList);

    //     mockRepo.Verify(x => x.CreateNewFood(It.IsAny<Food>()), Times.Once());
    // }
}
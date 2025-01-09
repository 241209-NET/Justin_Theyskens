using Moq;
using Cafe.API.Items;
using Cafe.API.Service;
using Cafe.API.Repo;
using AutoMapper;
using Cafe.API.DTOs;

namespace Cafe.Test;

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

        OrderInDTO newOrderDTO = new OrderInDTO(){Name = "Anita"};

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
        var myOrder = orderService.CreateNewOrder(newOrder);

        //Assert
        Assert.Contains(newOrder, orderList);
        mockRepo.Verify(x => x.CreateNewOrder(It.IsAny<Order>()), Times.Once());
        
    }

    [Fact]
    public void TestAllOrder()
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

        List<Order> orderList = new();

        foreach(OrderInDTO order in orderDTOList)
        {
            orderList.Add(order.DtoToOrder());
        }

        //Act
        var allOrders = orderService.GetAllOrders();

        //Assert
        Assert.Equal(allOrders.Count(), orderDTOList.Count());
    }

    [Fact]
    public void TestCreateNewDrink()
    {
        //Arrange
        Mock<IDrinkRepo> mockRepo = new();
        Mock<IMapper> mockMapper = new();
        DrinkService drinkService = new(mockRepo.Object, mockMapper.Object);

        //AArrage Orders
        Mock<IOrderRepo> mockOrder = new();
        OrderService orderService = new(mockOrder.Object, mockMapper.Object);
        Order order = new Order("Justin"){Id = 1};

        List<DrinkInDTO> drinkDTOList = 
        [
            new DrinkInDTO(){Size = Drink.DrinkSize.Grande, Type = Drink.DrinkType.Cappucino, OrderId = 1},
            new DrinkInDTO(){Size = Drink.DrinkSize.Tall, Type = Drink.DrinkType.Latte, OrderId = 1},
            new DrinkInDTO(){Size = Drink.DrinkSize.Venti, Type = Drink.DrinkType.Coffee, OrderId = 1}
        ];

        DrinkInDTO newDrinkDTO = new DrinkInDTO(){Size = Drink.DrinkSize.Grande, Type = Drink.DrinkType.Tea, OrderId = 1};

        List<Drink> drinkList = new();

        foreach(DrinkInDTO drink in drinkDTOList)
        {
            drinkList.Add(drink.DtoToDrink());
        }
        var newDrink = newDrinkDTO.DtoToDrink();

        mockRepo.Setup(repo => repo.CreateNewDrink(It.IsAny<Drink>()))
            .Callback((Drink d) => drinkList.Add(d))
            .Returns(newDrink);

        //Act
        var myDrink = drinkService.CreateNewDrink(newDrink);

        //Assert
        Assert.Contains(newDrink, drinkList);
        mockRepo.Verify(x => x.CreateNewDrink(It.IsAny<Drink>()), Times.Once());
        
    }

    [Fact]
    public void TestCreateNewFood()
    {
        //Arrange

        Mock<IFoodRepo> mockRepo = new();
        Mock<IMapper> mockMapper = new();
        FoodService foodService = new(mockRepo.Object, mockMapper.Object);
        //new OrderInDTO(){Name = "Justin"};

        List<FoodInDTO> foodDTOList =
        [
            new FoodInDTO()
            {
                Type = Food.FoodType.BaconEggAndGoudaSandwich,
                OrderId = 1
            },
            new FoodInDTO()
            {
                Type = Food.FoodType.ButterCroissant,
                OrderId = 1
            }, 
            new FoodInDTO()
            {
                Type = Food.FoodType.GrilledCheeseSandwich,
                OrderId = 1
            }, 
        ];


        FoodInDTO newFoodDTO = new FoodInDTO()
        {
            Type = Food.FoodType.BaconEggAndCheddarSandwich,
            OrderId = 1
        };
        
        List<Food> foodList = new();

        foreach(FoodInDTO food in foodDTOList)
        {
            foodList.Add(food.DtoToFood());
        }
        
        var newFood = newFoodDTO.DtoToFood();


        mockRepo.Setup(repo => repo.CreateNewFood(It.IsAny<Food>()))
            .Callback((Food f) => foodList.Add(f))
            .Returns(newFood);

        //Act
        var myFood = foodService.CreateNewFood(newFood);
        foodList.Add(newFood);

        //Assert
        Assert.Contains(newFood, foodList);

        mockRepo.Verify(x => x.CreateNewFood(It.IsAny<Food>()), Times.Once());
    }
    
}

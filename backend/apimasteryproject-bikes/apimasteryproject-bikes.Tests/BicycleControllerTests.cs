using apimasteryproject_bikes.Controllers;
using apimasteryproject_bikes.Models;
using apimasteryproject_bikes.Repositories;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace apimasteryproject_bikes.Tests
{
    public class BicycleControllerTests
    {
        private BicycleController underTest;
        IRepository<Bicycle> bicycleRepo;

        public BicycleControllerTests()
        {
            bicycleRepo = Substitute.For<IRepository<Bicycle>>();
            underTest = new BicycleController(bicycleRepo);
        }

        [Fact]
        public void Delete_Removes_Bicycle()
        {
            var bicycleID = 1;
            var deletedBicycle = new Bicycle(1, "name", "image", "description", "style", 1);
            var bicycleList = new List<Bicycle>()
            {
                deletedBicycle,
                new Bicycle(2, "2name", "2image", "2description", "2style", 2)
            };

            bicycleRepo.GetByID(bicycleID).Returns(deletedBicycle);
            bicycleRepo.When(d => d.Delete(deletedBicycle))
                .Do(d => bicycleList.Remove(deletedBicycle));

            bicycleRepo.GetAll().Returns(bicycleList);
            var result = underTest.Delete(bicycleID);
            Assert.DoesNotContain(deletedBicycle, result);
            //Assert.All(result, item => Assert.Contains("second item", item.Name));

        }
    }
}

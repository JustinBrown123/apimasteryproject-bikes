using apimasteryproject_bikes.Controllers;
using apimasteryproject_bikes.Models;
using apimasteryproject_bikes.Repositories;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;

namespace apimasteryproject_bikes.Tests
{
    public class ManufacturerControllerTests
    {
        private ManufacturerController underTest;
        IRepository<Manufacturer> manufacturerRepo;

        public ManufacturerControllerTests()
        {
            manufacturerRepo = Substitute.For<IRepository<Manufacturer>>();
            underTest = new ManufacturerController(manufacturerRepo);
        }

        [Fact]
        public void Post_Creates_New_Manufacturer()
        {
            var newManufacturer = new Manufacturer(1, "New Manufacturer", "recordlabel", "imgage");
            var manufacturerList = new List<Manufacturer>();

            manufacturerRepo.When(t => t.Create(newManufacturer))
                .Do(t => manufacturerList.Add(newManufacturer));

            manufacturerRepo.GetAll().Returns(manufacturerList);

            var result = underTest.Post(newManufacturer);

            Assert.Contains(newManufacturer, result);
        }
        [Fact]
        public void Delete_Removes_Manufacturer()
        {
            var manufacturerId = 1;
            var deletedManufacturer = new Manufacturer(1, "Title", "image", "label");
            var manufacturerList = new List<Manufacturer>()
            {
                deletedManufacturer,
                new Manufacturer(1, "Title", "image", "label")
        };

            manufacturerRepo.GetByID(manufacturerId).Returns(deletedManufacturer);
            manufacturerRepo.When(d => d.Delete(deletedManufacturer))
                .Do(d => manufacturerList.Remove(deletedManufacturer));
            manufacturerRepo.GetAll().Returns(manufacturerList);

            var result = underTest.Delete(manufacturerId);

            Assert.DoesNotContain(deletedManufacturer, result); /*Does not work in all cases*/
            //Assert.All(result, item => Assert.Contains("Second item", item.Title));
        }
        [Fact]
        public void Put_Updates_Manufacturer()
        {
            var originalManufacturer = new Manufacturer(1, "Title", "image", "yapp");
            var expectedManufacturers = new List<Manufacturer>()
            {
                originalManufacturer
            };
            var updatedManufacturer = new Manufacturer(1, "Title", "carrot", "label");

            manufacturerRepo.When(t => manufacturerRepo.Update(updatedManufacturer))
                .Do(Callback.First(t => expectedManufacturers.Remove(originalManufacturer))
                .Then(t => expectedManufacturers.Add(updatedManufacturer)));
            manufacturerRepo.GetAll().Returns(expectedManufacturers);

            var result = underTest.Put(updatedManufacturer);

            // Assert.Equal(expectedTodos, result.ToList());
            Assert.All(result, item => Assert.Contains("Updated item", item.Name));
        }
    }
}

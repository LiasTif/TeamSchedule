using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamScheduleApp.Models;
using TeamScheduleDataManager.Processors;

namespace TeamScheduleTest.DataManagerTests.ProcessorTests
{
    [TestClass]
    public class ComparePeopleProcessorTests
    {
        [TestMethod]
        public void Compare_SamePersons_ReturnsTrue()
        {
            // Arrange
            // Creating two persons that should match
            Person firstPerson = new Person
            {
                Id = 1,
                FName = "John",
                LName = "Doe",
                PinCode = "123456"
            };

            Person secondPerson = new Person
            {
                Id = 1,
                FName = "John",
                LName = "Doe",
                PinCode = "123456"
            };

            ComparePeopleProcessor comparePeopleProcessor = new ComparePeopleProcessor();

            // Act
            // Comparing the two persons
            bool result = comparePeopleProcessor.Compare(firstPerson, secondPerson);

            // Assert
            // Checking that the comparison result is true
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Compare_DifferentPersons_ReturnsFalse()
        {
            // Arrange
            // Creating two persons that should not match
            Person firstPerson = new Person
            {
                Id = 1,
                FName = "John",
                LName = "Doe",
                PinCode = "123456"
            };

            Person secondPerson = new Person
            {
                Id = 2,
                FName = "Jane",
                LName = "Doe",
                PinCode = "654321"
            };

            ComparePeopleProcessor comparePeopleProcessor = new ComparePeopleProcessor();

            // Act
            // Comparing the two persons
            bool result = comparePeopleProcessor.Compare(firstPerson, secondPerson);

            // Assert
            // Checking that the comparison result is false
            Assert.IsFalse(result);
        }
    }
}

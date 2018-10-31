using System;
using Business.Logic;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab07.Test
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void APersonIsCreated()
        {
            //Arrange
            PersonBL logic = new PersonBL();
            Person person = new Person()
            {
                Id = 1,
                Name = "Some Person",
                BirthDate = DateTime.Now
            };

            //Act
            logic.Create(person);
            Person saved = logic.GetById(1);

            //Assert
            Assert.IsNotNull(saved, "Person should have not been null after insert");
        }

        [TestMethod]
        public void APersonMustHaveName()
        {
            //Arrange
            PersonBL logic = new PersonBL();
            Person person = new Person()
            {
                Id = 1,
                Name = "",
                BirthDate = DateTime.Now
            };

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => logic.Create(person));
        }

        [TestMethod]
        public void TheAgeOfAPersonIsCalculatedCorrectly()
        {
            //Arrange
            PersonBL logic = new PersonBL();
            Person person = new Person()
            {
                BirthDate = new DateTime(1998, 1, 1) //YYYY-MM-DD
            };

            //Act & Assert
            Assert.AreEqual(20, person.Age);
        }
    }
}
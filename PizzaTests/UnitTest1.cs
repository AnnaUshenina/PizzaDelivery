using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaDelivery;

namespace PizzaTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstTest()
        {
            var dto = new PizzaRequestDto
            {
                //Filled = DateTime.Now,
                FullName = "Batman",
                Address = "Batcave",
                Price = 700,
                PaymentMethod = PaymentMethod.CreditCardOnline,
                DeliveryTime = new DateTime(2018, 4, 22, 23, 15, 0),
                Pizza = new List<PizzaMaker>()
                {
                    new PizzaMaker
                    {
                        pizza=Pizza.Margherita,
                        size=PizzaSize.large,
                        Dough = DoughType.TraditionalDough,
                        AddMushrooms = false
                    }

                }
            };
            var tempFileName = Path.GetTempFileName();
            try
            {
                PizzaDtoHelper.WriteToFile(tempFileName, dto);
                var readDto = PizzaDtoHelper.LoadFromFile(tempFileName);
               // Assert.AreEqual(dto.Filled, readDto.Filled);
                Assert.AreEqual(dto.Address, readDto.Address);
            }
            finally
            {
                File.Delete(tempFileName);
            }
        }
    }
}

using System;
using System.IO;
using System.Xml.Serialization;

namespace PizzaDelivery
{
    public static class PizzaDtoHelper
    {
        private static readonly XmlSerializer Xs = new XmlSerializer(typeof(PizzaRequestDto));
        public static void WriteToFile(string fileName, PizzaRequestDto data)
        {
            using (var fileStream = File.Create(fileName))
            {
                Xs.Serialize(fileStream, data);
            }
        }

        public static PizzaRequestDto LoadFromFile(string fileName)
        {
            using (var fileStream = File.OpenRead(fileName))
            {
                return (PizzaRequestDto)Xs.Deserialize(fileStream);
            }
        }
    }
}

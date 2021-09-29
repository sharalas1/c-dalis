using System;

namespace projektas
{
    public class Car
    {
        public Car(int documentId, string name, int price, int carDate)
        {
            DocumentId = documentId;
            Name = name;
            Price = price;
            CarDate = carDate;
        }

        public int DocumentId { get; }
        
        public string Name { get; }
        
        public int Price { get; }
        
        public int CarDate { get; }


        public string GetInformation()
        {
            return $"{Name} {Price} {CarDate} ";
        }
    }
}

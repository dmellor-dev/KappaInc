using System;
namespace ClassLibrary
{
    public class clsStock
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public int StockQuantity { get; set; }
        public double Price { get; set; }
        public bool Available { get; set; }
        public  string Supplier { get; set; }
        public DateTime NextRestock { get; set; }
    }
}
using System;

namespace FinishedProductsLibrary
{
    public class Commodity
    {
        public readonly string VendorCode;
        public string Name;
        public double WholesalePrice;
        public double RetailPrice;
        public UnitOfGoods Goods;
        public string Description;
        public double Availability;

        public Commodity(string vendorCode, string name, double wholesalePrice, double retailPrice, UnitOfGoods goods)
        {
            VendorCode = vendorCode;
            Name = name;
            WholesalePrice = wholesalePrice;
            RetailPrice = retailPrice;
            Goods = goods;
        }

        public override string ToString()
        {
            return $"{VendorCode} {Name}";

        }

        public void PrintInfo()
        {
            Console.WriteLine(this);

            var goods = "";
            switch (Goods)
            {
                case UnitOfGoods.Piece:
                    goods = "шт.";
                    break;
                case UnitOfGoods.Package:
                    goods = "уп.";
                    break;
                case UnitOfGoods.Kilogram:
                    goods = "кг.";
                    break;
                case UnitOfGoods.Ton:
                    goods = "т.";
                    break;
            }

            Console.WriteLine($"Оптовая цена: {WholesalePrice}. Розничная цена: {RetailPrice}. Описание: {Description}. В наличии: {Availability} {goods}");
        }
    }
}

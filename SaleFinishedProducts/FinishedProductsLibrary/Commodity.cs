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

        public virtual void PrintInfo()
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
    public class FragileGoods : Commodity 
    { 
        public int MaxInStack;  
        
        public FragileGoods(string vendorCode, string name, double wholesalePrice, double retailPrice, UnitOfGoods goods, int maxInStack) : base(vendorCode, name, wholesalePrice, retailPrice, goods) 
        { 
            MaxInStack = maxInStack; 
        } 
        public override void PrintInfo() 
        { 
            base.PrintInfo(); 
            Console.WriteLine($"Максимальное количество единиц товара в стопке: {MaxInStack} шт.");
        } 
    }
    public class PerishableGoods : Commodity
    {
        public int MaxShelfLife;

        public PerishableGoods(string vendorCode, string name, double wholesalePrice, double retailPrice, UnitOfGoods goods, int maxShelfLife) : base(vendorCode, name, wholesalePrice, retailPrice, goods)
        {
            MaxShelfLife = maxShelfLife;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Максимальный срок хранения: {MaxShelfLife} дн.");
        }
    }
    public class DimensionalGoods : Commodity
    {
        public double Length;
        public double Width;
        public double Heigth;

        public DimensionalGoods(string vendorCode, string name, double wholesalePrice, double retailPrice, UnitOfGoods goods, double length, double width, double heigth) : base(vendorCode, name, wholesalePrice, retailPrice, goods)
        {
            Length = length;
            Width = width;
            Heigth = heigth;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Длина: {Length:F2} см., ширина: {Width:F2} см., высота: {Heigth:F2} см.");
        }
    }
}

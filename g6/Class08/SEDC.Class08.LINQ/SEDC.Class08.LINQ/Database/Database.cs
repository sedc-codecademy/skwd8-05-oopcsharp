using SEDC.Class08.LINQ.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class08.LINQ.Database
{
    public class Database
    {
        protected List<Product> Products;

        public Database()
        {
            Products = new List<Product>
            {
                new Product(1,"Keyboard", 100, Category.ItEquipment),
                new Product(2,"Mouse", 150, Category.ItEquipment),
                new Product(3,"Headphones", 80, Category.ItEquipment),
                new Product(4,"Microphone", 220, Category.ItEquipment),
                new Product(5,"Camera",  1000, Category.ItEquipment),
                new Product(6,"Hp-580",  20000, Category.LapTop),
                new Product(7,"Lenovo G200",  18500, Category.LapTop),
                new Product(8,"Hp ProBook",  12000, Category.LapTop),
                new Product(9,"Acer S1200",  28000, Category.LapTop),
                new Product(10,"Dell MS300",  74000, Category.LapTop),
                new Product(11,"Office 1",  10200, Category.PC),
                new Product(12,"Office 2",  12400, Category.PC),
                new Product(13,"Gaming",  22000, Category.PC),
                new Product(14,"Ultra Gaming",  32200, Category.PC),
                new Product(15,"Ultra Ultra Gaming",  61600, Category.PC),
                new Product(16,"Alienware",  128000, Category.PC),
                new Product(17,"Samsung Proview",  56200, Category.TV),
                new Product(18,"LG LG420MQ8",  32000, Category.TV),
                new Product(19,"SONY Plasma",  18000, Category.TV),
                new Product(20,"SONY RW78OS",  179999,Category.TV),
                new Product(21,"Samsung Oval", 247999,Category.TV)
            };
        }
    }
}

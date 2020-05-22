using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.GettersAndSetters.Models
{
    public class Product
    {
        // Field
        //private int _price;

        #region get and set methods

        // Getter method - GET
        //public int GetPrice()
        //{
        //    return _price;
        //}

        // Setter method - SET
        //public void SetPrice(int value)
        //{
        //    _price = value;
        //}
        #endregion


        #region Property

        //public int Price
        //{
        //    get { return _price; }
        //    set { _price = value; }
        //}
        #endregion

        //Auto implemented property => C#
        //public int Price { get; set; }

        //public int Price { get; }


        //private int _price;
        //public int Price
        //{
        //    get
        //    {
        //        return _price;
        //    }
        //    set
        //    {
        //        if (value > 100)
        //            Discount = 0.1;

        //        if (value > 200)
        //            Discount = 0.3;

        //        _price = value;
        //    }
        //}

        public double Discount { get; private set; }

        //public Product()
        //{
        //    Price = 100;
        //    Discount = 0.2;
        //}

        private int _price;
        public int Price
        {
            get => _price;
            set => _price = value > 100 ? _price : 500;
        }


    }
}

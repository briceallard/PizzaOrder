using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace PizzaShop
{
    class Utilities
    {
        /**
         * 
         *  PRICES OF PIZZA, CRUSTS, SAUCES AND TOPPINGS
         * 
        **/
        // Sizes
        public static readonly double SMALL_PIZZA = 6.99;
        public static readonly double MEDIUM_PIZZA = 8.99;
        public static readonly double LARGE_PIZZA = 10.99;
        // Crusts
        public static readonly double PAN_CRUST = 0.00;
        public static readonly double HANDTOSSED_CRUST = 0.99;
        public static readonly double THINNCRISPY_CRUST = 0.99;
        public static readonly double STUFFED_CRUST = 1.99;
        // Sauces
        public static readonly double MARINARA = 0.00;
        public static readonly double GARLIC_PARMESAN = 0.99;
        public static readonly double BARBEQUE = 0.99;
        public static readonly double BUFFALO = 0.99;
        // Toppings
        public static readonly double PEPPORONI = 0.99;
        public static readonly double ITALIAN_SAUSAGE = 0.99;
        public static readonly double HAM = 0.99;
        public static readonly double BACON = 0.99;
        public static readonly double MUSHROOMS = 0.99;
        public static readonly double ONIONS = 0.99;
        public static readonly double BLACK_OLIVES = 0.99;
        public static readonly double BELL_PEPPERS = 0.99;
        public static readonly double BANANA_PEPPERS = 0.99;
        public static readonly double PINEAPPLE = 0.99;
        public static readonly double JALAPENO = 0.99;
        public static readonly double TOMATOES = 0.99;

        /**
         * 
         *  THEME COLOR SCHEME 
         * 
        **/
        public static Color PRIMARY_COLOR = Color.FromArgb(44, 62, 80);
        public static Color SECONDARY_COLOR = Color.FromArgb(52, 73, 94);
        public static Color BACKGROUND_COLOR = Color.FromArgb(90, 109, 123);
        public static Color ACCENT_COLOR = Color.FromArgb(181, 28, 11);
        public static Color TEXT_COLOR = Color.FromArgb(162, 100, 45);
        public static Color TEXT_HOVOR_COLOR = Color.FromArgb(181, 28, 11);

        public static double getPrice(ComboBox cb)
        {
            string line = cb.GetItemText(cb.SelectedItem);
            List<string> split = new List<string>();

            if (line.Contains('$'))
            {
                split = line.Split('$').ToList();
            }

            if(split.Count > 1)
            {
                Double.TryParse(split[1], out double price);
                return price;
            }

            return 0.00;
        }
    }
}

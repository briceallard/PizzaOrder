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
         *  IMAGES FOR PIZZA CUSTIMIZATION
         * 
        **/
        public static readonly Bitmap CRUST_HANDTOSSED = Properties.Resources.crust_handtossed;
        public static readonly Bitmap CRUST_PAN = Properties.Resources.crust_pan;
        public static readonly Bitmap CRUST_STUFFED = Properties.Resources.crust_stuffed;
        public static readonly Bitmap CRUST_THIN = Properties.Resources.crust_thin;
        public static readonly Bitmap TOP_MOZZ = Properties.Resources.cheese_mozz;
        public static readonly Bitmap TOP_BACON_X = Properties.Resources.topping_Bacon_extra;
        public static readonly Bitmap TOP_BACON = Properties.Resources.topping_Bacon_reg;
        public static readonly Bitmap TOP_BANANA_PEPPER_X = Properties.Resources.topping_BananaPepper_extra;
        public static readonly Bitmap TOP_BANANA_PEPPER = Properties.Resources.topping_BananaPepper_reg;
        public static readonly Bitmap TOP_BELL_PEPPER_X = Properties.Resources.topping_GreenBellPepper_extra;
        public static readonly Bitmap TOP_BELL_PEPPER = Properties.Resources.topping_GreenBellPepper_reg;
        public static readonly Bitmap TOP_HAM_X = Properties.Resources.topping_Ham_extra;
        public static readonly Bitmap TOP_HAM = Properties.Resources.topping_Ham_reg;
        public static readonly Bitmap TOP_SAUSAGE_X = Properties.Resources.topping_ItalianSausage_extra;
        public static readonly Bitmap TOP_SAUSAGE = Properties.Resources.topping_ItalianSausage_reg;
        public static readonly Bitmap TOP_JALEPENO_X = Properties.Resources.topping_Jalepeno_extra;
        public static readonly Bitmap TOP_JALEPENO = Properties.Resources.topping_Jalepeno_reg;
        public static readonly Bitmap TOP_MUSHROOM_X = Properties.Resources.topping_Mushroom_extra;
        public static readonly Bitmap TOP_MUSHROOM = Properties.Resources.topping_Mushroom_reg;
        public static readonly Bitmap TOP_OLIVE_X = Properties.Resources.topping_Olives_extra;
        public static readonly Bitmap TOP_OLIVE = Properties.Resources.topping_Olives_reg;
        public static readonly Bitmap TOP_ONION_X = Properties.Resources.topping_Onion_extra;
        public static readonly Bitmap TOP_ONION = Properties.Resources.topping_Onion_reg;
        public static readonly Bitmap TOP_PEPPERONI_X = Properties.Resources.topping_Pepperoni_extra;
        public static readonly Bitmap TOP_PEPPERONI = Properties.Resources.topping_Pepperoni_reg;
        public static readonly Bitmap TOP_PINEAPPLE_X = Properties.Resources.topping_Pineapple_extra;
        public static readonly Bitmap TOP_PINEAPPLE = Properties.Resources.topping_Pineapple_reg;
        public static readonly Bitmap TOP_TOMATO_X = Properties.Resources.topping_Tomato_extra;
        public static readonly Bitmap TOP_TOMATO = Properties.Resources.topping_Tomato_reg;

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

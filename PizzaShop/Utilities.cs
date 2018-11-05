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
        public static readonly Image PIZZA_WHOLE = Properties.Resources.button_whole;
        public static readonly Image PIZZA_WHOLE_SELECTED = Properties.Resources.button_whole_selected;
        public static readonly Image PIZZA_LEFT = Properties.Resources.button_left;
        public static readonly Image PIZZA_LEFT_SELECTED = Properties.Resources.button_left_selected;
        public static readonly Image PIZZA_RIGHT = Properties.Resources.button_right;
        public static readonly Image PIZZA_RIGHT_SELECTED = Properties.Resources.button_right_selected;
        public static readonly Image CRUST_HANDTOSSED = Properties.Resources.crust_handtossed;
        public static readonly Image CRUST_PAN = Properties.Resources.crust_pan;
        public static readonly Image CRUST_STUFFED = Properties.Resources.crust_stuffed;
        public static readonly Image CRUST_THIN = Properties.Resources.crust_thin;
        public static readonly Image TOP_MOZZ = Properties.Resources.cheese_mozz;
        public static readonly Image TOP_BACON_X = Properties.Resources.topping_Bacon_extra;
        public static readonly Image TOP_BACON_X_L = Properties.Resources.topping_Bacon_extra_L;
        public static readonly Image TOP_BACON_X_R = Properties.Resources.topping_Bacon_extra_R;
        public static readonly Image TOP_BACON = Properties.Resources.topping_Bacon_reg;
        public static readonly Image TOP_BACON_L = Properties.Resources.topping_Bacon_reg_L;
        public static readonly Image TOP_BACON_R = Properties.Resources.topping_Bacon_reg_R;
        public static readonly Image TOP_BANANA_PEPPER_X = Properties.Resources.topping_BananaPepper_extra;
        public static readonly Image TOP_BANANA_PEPPER_X_L = Properties.Resources.topping_BananaPepper_extra_L;
        public static readonly Image TOP_BANANA_PEPPER_X_R = Properties.Resources.topping_BananaPepper_extra_R;
        public static readonly Image TOP_BANANA_PEPPER = Properties.Resources.topping_BananaPepper_reg;
        public static readonly Image TOP_BANANA_PEPPER_L = Properties.Resources.topping_BananaPepper_reg_L;
        public static readonly Image TOP_BANANA_PEPPER_R = Properties.Resources.topping_BananaPepper_reg_R;
        public static readonly Image TOP_BELL_PEPPER_X = Properties.Resources.topping_GreenBellPepper_extra;
        public static readonly Image TOP_BELL_PEPPER_X_L = Properties.Resources.topping_GreenBellPepper_extra_L;
        public static readonly Image TOP_BELL_PEPPER_X_R = Properties.Resources.topping_GreenBellPepper_extra_R;
        public static readonly Image TOP_BELL_PEPPER = Properties.Resources.topping_GreenBellPepper_reg;
        public static readonly Image TOP_BELL_PEPPER_L = Properties.Resources.topping_GreenBellPepper_reg_L;
        public static readonly Image TOP_BELL_PEPPER_R = Properties.Resources.topping_GreenBellPepper_reg_R;
        public static readonly Image TOP_HAM_X = Properties.Resources.topping_Ham_extra;
        public static readonly Image TOP_HAM_X_L = Properties.Resources.topping_Ham_extra_L;
        public static readonly Image TOP_HAM_X_R = Properties.Resources.topping_Ham_extra_R;
        public static readonly Image TOP_HAM = Properties.Resources.topping_Ham_reg;
        public static readonly Image TOP_HAM_L = Properties.Resources.topping_Ham_reg_L;
        public static readonly Image TOP_HAM_R = Properties.Resources.topping_Ham_reg_R;
        public static readonly Image TOP_SAUSAGE_X = Properties.Resources.topping_ItalianSausage_extra;
        public static readonly Image TOP_SAUSAGE_X_L = Properties.Resources.topping_ItalianSausage_extra_L;
        public static readonly Image TOP_SAUSAGE_X_R = Properties.Resources.topping_ItalianSausage_extra_R;
        public static readonly Image TOP_SAUSAGE = Properties.Resources.topping_ItalianSausage_reg;
        public static readonly Image TOP_SAUSAGE_L = Properties.Resources.topping_ItalianSausage_reg_L;
        public static readonly Image TOP_SAUSAGE_R = Properties.Resources.topping_ItalianSausage_reg_R;
        public static readonly Image TOP_JALEPENO_X = Properties.Resources.topping_Jalepeno_extra;
        public static readonly Image TOP_JALEPENO_X_L = Properties.Resources.topping_Jalepeno_extra_L;
        public static readonly Image TOP_JALEPENO_X_R = Properties.Resources.topping_Jalepeno_extra_R;
        public static readonly Image TOP_JALEPENO = Properties.Resources.topping_Jalepeno_reg;
        public static readonly Image TOP_JALEPENO_L = Properties.Resources.topping_Jalepeno_reg_L;
        public static readonly Image TOP_JALEPENO_R = Properties.Resources.topping_Jalepeno_reg_R;
        public static readonly Image TOP_MUSHROOM_X = Properties.Resources.topping_Mushroom_extra;
        public static readonly Image TOP_MUSHROOM_X_L = Properties.Resources.topping_Mushroom_extra_L;
        public static readonly Image TOP_MUSHROOM_X_R = Properties.Resources.topping_Mushroom_extra_R;
        public static readonly Image TOP_MUSHROOM = Properties.Resources.topping_Mushroom_reg;
        public static readonly Image TOP_MUSHROOM_L = Properties.Resources.topping_Mushroom_reg_L;
        public static readonly Image TOP_MUSHROOM_R = Properties.Resources.topping_Mushroom_reg_R;
        public static readonly Image TOP_OLIVE_X = Properties.Resources.topping_Olives_extra;
        public static readonly Image TOP_OLIVE_X_L = Properties.Resources.topping_Olives_extra_L;
        public static readonly Image TOP_OLIVE_X_R = Properties.Resources.topping_Olives_extra_R;
        public static readonly Image TOP_OLIVE = Properties.Resources.topping_Olives_reg;
        public static readonly Image TOP_OLIVE_L = Properties.Resources.topping_Olives_reg_L;
        public static readonly Image TOP_OLIVE_R = Properties.Resources.topping_Olives_reg_R;
        public static readonly Image TOP_ONION_X = Properties.Resources.topping_Onion_extra;
        public static readonly Image TOP_ONION_X_L = Properties.Resources.topping_Onion_extra_L;
        public static readonly Image TOP_ONION_X_R = Properties.Resources.topping_Onion_extra_R;
        public static readonly Image TOP_ONION = Properties.Resources.topping_Onion_reg;
        public static readonly Image TOP_ONION_L = Properties.Resources.topping_Onion_reg_L;
        public static readonly Image TOP_ONION_R = Properties.Resources.topping_Onion_reg_R;
        public static readonly Image TOP_PEPPERONI_X = Properties.Resources.topping_Pepperoni_extra;
        public static readonly Image TOP_PEPPERONI_X_L = Properties.Resources.topping_Pepperoni_extra_L;
        public static readonly Image TOP_PEPPERONI_X_R = Properties.Resources.topping_Pepperoni_extra_R;
        public static readonly Image TOP_PEPPERONI = Properties.Resources.topping_Pepperoni_reg;
        public static readonly Image TOP_PEPPERONI_L = Properties.Resources.topping_Pepperoni_reg_L;
        public static readonly Image TOP_PEPPERONI_R = Properties.Resources.topping_Pepperoni_reg_R;
        public static readonly Image TOP_PINEAPPLE_X = Properties.Resources.topping_Pineapple_extra;
        public static readonly Image TOP_PINEAPPLE_X_L = Properties.Resources.topping_Pineapple_extra_L;
        public static readonly Image TOP_PINEAPPLE_X_R = Properties.Resources.topping_Pineapple_extra_R;
        public static readonly Image TOP_PINEAPPLE = Properties.Resources.topping_Pineapple_reg;
        public static readonly Image TOP_PINEAPPLE_L = Properties.Resources.topping_Pineapple_reg_L;
        public static readonly Image TOP_PINEAPPLE_R = Properties.Resources.topping_Pineapple_reg_R;
        public static readonly Image TOP_TOMATO_X = Properties.Resources.topping_Tomato_extra;
        public static readonly Image TOP_TOMATO_X_L = Properties.Resources.topping_Tomato_extra_L;
        public static readonly Image TOP_TOMATO_X_R = Properties.Resources.topping_Tomato_extra_R;
        public static readonly Image TOP_TOMATO = Properties.Resources.topping_Tomato_reg;
        public static readonly Image TOP_TOMATO_L = Properties.Resources.topping_Tomato_reg_L;
        public static readonly Image TOP_TOMATO_R = Properties.Resources.topping_Tomato_reg_R;

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

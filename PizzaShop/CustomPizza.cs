/**
 *  Brice Allard
 *  Catterina's Pizza
 *  November 3, 2018
 * 
 *  Description: 
 *      Winforms application that allows the user to choose from preselected menu
 *      items or create their own custom pizza with toppings of their choice.
 *      Images overlayed to display the look of the pizza has been implemented.
 **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    public class CustomPizza
    {
        public List<string> Toppings = new List<string>();
        public string Size { get; set; }
        public string Crust { get; set; }
        public string Sauce { get; set; }
        public bool Pepperoni { get; set; }
        public bool Sausage { get; set; }
        public bool Ham { get; set; }
        public bool Bacon { get; set; }
        public bool Mushrooms { get; set; }
        public bool Onions { get; set; }
        public bool Olives { get; set; }
        public double Price { get; set; }

        public CustomPizza()
        {
            Size = "Large";
            Crust = "Pan";
            Sauce = "Mar";
            Pepperoni = false;
            Sausage = false;
            Ham = false;
            Bacon = false;
            Mushrooms = false;
            Onions = false;
            Olives = false;
            Price = 0.00;
        }

        public void UpdateList()
        {
            if (Pepperoni)
                Toppings.Add("Pepperoni");
            if (Sausage)
                Toppings.Add("Sausage");
            if (Ham)
                Toppings.Add("Ham");
            if (Bacon)
                Toppings.Add("Bacon");
            if (Mushrooms)
                Toppings.Add("Mushrooms");
            if (Onions)
                Toppings.Add("Onions");
            if (Olives)
                Toppings.Add("Olives");
        }

        public string GetListToStrings()
        {
            string CombinedToppings = String.Join(", ", Toppings);

            return CombinedToppings;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class Customer
    {
        public bool ReadyToPlaceOrder(Order anyOrder, Restaurant anyRestaurant)
        {
            if (anyRestaurant.ItemIsOnMenu(anyOrder.Drink) && anyRestaurant.ItemIsOnMenu(anyOrder.Entree) && anyRestaurant.ItemIsOnMenu(anyOrder.Dessert))
            {
                return true;
            }
            else return false;      
        }

        
    }
       
}

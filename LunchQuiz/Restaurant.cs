using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class Restaurant
    {
        public List<MenuItem> MenuItems = new List<MenuItem>();
        public List<Customer> CurrentCustomers = new List<Customer>();
        public int NumberofSeatsAtBar { get; set; }
        public int Numberof4PersonTables { get; set; }
        public int Numberof2PersonTables { get; set; }
     
        public int capacity()
        {
            return NumberofSeatsAtBar + (Numberof4PersonTables * 4) + (Numberof2PersonTables * 2);
        }
        public void AddCustomerToList(Customer person)
        {
            CurrentCustomers.Add(person);
        }  
        
        public bool ItemIsOnMenu(string food)
        {
            bool exists = false;

            foreach (MenuItem food2 in MenuItems)
            {
                if (food2.Name == food)
                {
                    exists = true;
                }
            }

            if (exists == true)
            {
                return true;
            }
            else return false;
        }  
        public bool ItemIsOnMenu(MenuItem food)
        {
            bool exists = false;

            foreach (MenuItem food2 in MenuItems)
            {
                if (food2.Name == food.Name)
                {
                    exists = true;
                }
            }

            if (exists == true)
            {
                return true;
            }
            else return false; 
                   
        }  
            


            public Restaurant()
        {
               
        }        
    }

}

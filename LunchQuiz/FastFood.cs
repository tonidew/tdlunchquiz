using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class FastFood : Restaurant, IProvidesDinner, IProvidesLunch
    {
        //public bool HasDriveThrough = true;

        public bool hasDriveThruWindow
        {
            get
            {
                return hasDriveThruWindow;
            }

            set
            {
                hasDriveThruWindow = true;;
            }
        }

        public bool isOpen24Hours
        {
            get
            {
                return isOpen24Hours;
            }

            set
            {
                isOpen24Hours = true;
          
            }
        }

        public void addMenuItem (string newFood)
        {
            MenuItem greasyfood = new MenuItem();
            greasyfood.Name = newFood;
            this.MenuItems.Add(greasyfood);
        }
        public void addMenuItem(string newFood, double cost)
        {
            MenuItem greasyfood = new MenuItem();
            greasyfood.Name = newFood;
            greasyfood.Price = 1.99;
            this.MenuItems.Add(greasyfood);


        }
             
        }
   }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LunchQuiz
{
    public class Casual : Restaurant, IProvidesDinner, IProvidesLunch
    {
        public bool HasPatio = true;
       

        public Casual()
        {
            this.MenuItems = new List<MenuItem>();
            MenuItem ChickenFingers = new MenuItem();
            MenuItems.Add(ChickenFingers); 
        }

        public bool hasDriveThruWindow
        {
            get
            {
                return hasDriveThruWindow;
            }

            set
            {
                hasDriveThruWindow = true;
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
    }
      
   
}

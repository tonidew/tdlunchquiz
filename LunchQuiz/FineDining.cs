using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class FineDining : Restaurant, IProvidesDinner
    {
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

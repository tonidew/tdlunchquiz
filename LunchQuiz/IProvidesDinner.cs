﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    interface IProvidesDinner
    {
        bool isOpen24Hours { get; set; }
    }
}

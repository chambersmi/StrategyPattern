﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class MuteQuack : IQuackBehavior
    {
        public void MakeQuack()
        {
            Console.WriteLine("<< silence >>");
        }
    }
}

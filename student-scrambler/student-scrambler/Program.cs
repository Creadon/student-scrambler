﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_scrambler
{
    class Program
    {

        public static ObjectManager objectManager = new ObjectManager();
        public static CommandManager commandManager = new CommandManager();

        static void Main(string[] args)
        {

            while(true)
            {
                commandManager.RunCommand(Console.ReadLine());
            }

        }
    }
}

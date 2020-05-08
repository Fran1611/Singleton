﻿using System;

namespace Library
{
    public class Greeter : Singleton<Greeter>
    {
        public Greeter()
        {
            // Intentionally left blank
        }

        public void SayHiToTheWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}

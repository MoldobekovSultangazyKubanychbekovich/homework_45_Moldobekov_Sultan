﻿using System.Net;
using System.Text;

namespace homework_45_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            string currentdir = "../../../site";
            Server server = new Server(currentdir, 8888);
        }
    }
}
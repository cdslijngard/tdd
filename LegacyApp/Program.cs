﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Encryptor encryptor = new Encryptor();

            if (args.Length == 0)
            {
                throw new ArgumentException();
            }
            if (args.Length == 1)
            {
                Console.WriteLine(encryptor.CryptWord(args[0]));
            }
            if (args.Length >= 2)
            {
                if (args[0].Equals("-n"))
                {
                    Console.WriteLine(encryptor.CryptWordToNumbers(args[1]));
                }
                else
                {
                    Console.WriteLine(encryptor.CryptSentence(String.Join(" ", args)));
                }
            }
        }
    }
}
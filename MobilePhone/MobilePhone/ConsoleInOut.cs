using System;
using MobilePhoneLibrary;

namespace MobilePhone {
    class ConsoleInOut : IUserInOut {
        public void Write(string text) {
            Console.Write(text);
        }

        public void WriteLine(string text) {
            Console.WriteLine(text);
        }

        public int ReadChoise(string choiseName, string[] choiseVariants) {
            Console.WriteLine("Select " + choiseName);
            Console.WriteLine("0 - Cancel");
            for (int i = 0; i < choiseVariants.Length; i++) {
                Console.WriteLine($"{i + 1} - {choiseVariants[i]}");
            }
            return Int32.Parse(Console.ReadLine());
        }
    }
}

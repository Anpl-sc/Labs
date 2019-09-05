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

        public int ReadChoice(string choiceName, string[] choiceVariants) {
            Console.WriteLine("Select " + choiceName);
            Console.WriteLine("0 - Cancel");
            for (int i = 0; i < choiceVariants.Length; i++) {
                Console.WriteLine($"{i + 1} - {choiceVariants[i]}");
            }
            bool notValidChoice = true;
            string input;
            do {
                input = Console.ReadLine();
                for (int i = 0; i <= choiceVariants.Length; i++) {
                    if (input == i.ToString()) { notValidChoice = false; }
                }
                if (notValidChoice) { Console.WriteLine("Not proper variant, please select one from list"); }
            } while (notValidChoice);
            return Int32.Parse(input);
        }
    }
}

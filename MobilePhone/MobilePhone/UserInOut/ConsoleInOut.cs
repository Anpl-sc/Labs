using System;

namespace MobilePhone.UserInOut {
    class ConsoleInOut : IUserInOut {
        public void Write(string text) {
            Console.Write(text);
        }

        public void WriteLine(string text) {
            Console.WriteLine(text);
        }

        public string ReadLine() {
            return Console.ReadLine();
        }
    }
}

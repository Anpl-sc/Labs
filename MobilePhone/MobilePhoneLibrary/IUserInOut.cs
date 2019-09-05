namespace MobilePhoneLibrary {
    public interface IUserInOut {
        void Write(string text);
        void WriteLine(string text);
        int ReadChoice(string choiceName, string[] choiceVariants);
    }
}
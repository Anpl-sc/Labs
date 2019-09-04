namespace MobilePhoneLibrary {
    public interface IUserInOut {
        void Write(string text);
        void WriteLine(string text);
        int ReadChoise(string choiseName, string[] choiseVariants);
    }
}
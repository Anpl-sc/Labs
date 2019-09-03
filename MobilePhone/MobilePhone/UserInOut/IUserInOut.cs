namespace MobilePhone.UserInOut {
    public interface IUserInOut {
        void Write(string text);
        void WriteLine(string text);
        string ReadLine();
    }
}
namespace ProductCatalog.WinForms.BindingItem
{
    public class UserModel(string username, string password) : ModelBase
    {
        public string Username
        {
            get => username;
            set => SetField(ref username, value);
        }

        public string Password
        {
            get => password;
            set => SetField(ref password, value);
        }
    }
}

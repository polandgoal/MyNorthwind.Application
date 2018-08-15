namespace MyNorthwind.Domain.Exception
{
    public class AdAccountInvalidException : System.Exception
    {
        public AdAccountInvalidException(string adAccount, System.Exception ex)
            : base($"AD Account \"{adAccount}\" is invalid.", ex)
        {
        }
    }
}

namespace SmtpClient_Library
{
    /// <summary>
    /// Mail_Address
    /// </summary>
    public class Mail_Address
    {
        public Mail_Address(string address, string? displayName = null)
        {
            Address = address;
            DisplayName = displayName;
        }

        /// <summary>
        /// Address 
        /// </summary>
        public string Address { set; get; } = string.Empty;
        /// <summary>
        /// DisplayName
        /// </summary>
        public string? DisplayName { set; get; }
    }
}

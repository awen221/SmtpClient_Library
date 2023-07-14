namespace SmtpClient_Library
{
    public class Smtp_Client
    {
        /// <summary>
        /// Host
        /// </summary>
        public string Host { get; set; } = string.Empty;
        /// <summary>
        /// Port
        /// </summary>
        public int Port { get; set; }
        /// <summary>
        /// EnableSsl
        /// </summary>
        public bool EnableSsl { get; set; }
        /// <summary>
        /// UserName
        /// </summary>
        public string UserName { get; set; } = string.Empty;
        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; } = string.Empty;
    }
}
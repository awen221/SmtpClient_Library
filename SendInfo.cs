namespace SmtpClient_Library
{
    public class SendInfo
    {
        /// <summary>
        /// client
        /// </summary>
        public Smtp_Client client { set; get; } = new();
        /// <summary>
        /// mail
        /// </summary>
        public Mail_Message mail { set; get; } = new();
    }
}

namespace SmtpClient_Library
{
    /// <summary>
    /// Mail_Message
    /// </summary>
    public class Mail_Message
    {
        /// <summary>
        /// Subject
        /// </summary>
        public string Subject { get; set; } = string.Empty;
        /// <summary>
        /// Body 
        /// </summary>
        public string Body { get; set; } = string.Empty;
        /// <summary>
        /// IsBodyHtml
        /// </summary>
        public bool IsBodyHtml { get; set; }

        /// <summary>
        /// From
        /// </summary>
        public Mail_Address? From { set; get; }

        /// <summary>
        /// To
        /// </summary>
        public List<string> To { get; set; } = new();
        /// <summary>
        /// CC
        /// </summary>
        public List<string> CC { get; set; } = new();
        /// <summary>
        /// Bcc
        /// </summary>
        public List<string> Bcc { get; set; } = new();
    }
}

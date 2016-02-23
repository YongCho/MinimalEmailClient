﻿namespace MinimalEmailClient.Models
{
    public class Account
    {
        public string AccountName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public string ImapServerName { get; set; }
        public string ImapLoginName { get; set; }
        public string ImapLoginPassword { get; set; }
        public int ImapLoginPortNumber { get; set; }

        public string SmtpServerName { get; set; }
        public string SmtpLoginName { get; set; }
        public string SmtpLoginPassword { get; set; }
        public int SmtpLoginPortNumber { get; set; }
    }
}

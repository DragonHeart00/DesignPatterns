using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.consepts
{
    interface IEmail
    {
        void SendEmail();
    }


    class OutlookEmail : IEmail
    {
        public void SendEmail()
        {
            Console.WriteLine("Send Outlook Email");
        }
    }



    class GmailEmail : IEmail
    {
        public void SendEmail()
        {
            Console.WriteLine("Send Gmail Email");
        }
    }

}

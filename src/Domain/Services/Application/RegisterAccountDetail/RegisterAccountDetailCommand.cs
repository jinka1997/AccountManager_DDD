using System;
namespace AmDomain.Services.Application.RegisterAccountDetail
{
    public class RegisterAccountDetailCommand
    {
        public RegisterAccountDetailCommand()
        {
           
        }
        public DateTime From { set; get; }
        public DateTime To { set; get; }
        public string Keyword { set; get; }
    }
}

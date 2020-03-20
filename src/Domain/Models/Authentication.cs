using System;
namespace AmDomain.Models
{
    public class Authentication : Entity
    {
        //このModelはInfra行きの気がする
        public string ApiKey { set; get; }
        public long AccessCounter { set; get; }
        public DateTime LastAccessTime { set; get; }

    }
}

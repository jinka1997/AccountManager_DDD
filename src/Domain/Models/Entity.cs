using System;
namespace AmDomain.Models
{
    public class Entity
    {
        public int Id { private set; get; }


        public DateTimeOffset CreatedOn { private set; get; }
        public DateTimeOffset ModifiedAt { private set; get; }

        public long VersionNo { private set; get; }
    }
}

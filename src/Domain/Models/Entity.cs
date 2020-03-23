using System;
namespace AmDomain.Models
{
    public class Entity
    {
        public int Id { private set; get; }


        public DateTimeOffset CreatedOn { private set; get; } = DateTimeOffset.Now;
        public DateTimeOffset ModifiedAt { private set; get; } = DateTimeOffset.Now;

        public long VersionNo { private set; get; } = 1;
    }
}

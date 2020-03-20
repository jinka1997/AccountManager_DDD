using System;
namespace AmDomain.Models
{
    public class Entity
    {
        protected int Id { set; get; }


        protected DateTimeOffset CreatedOn { set; get; }
        protected DateTimeOffset ModifiedAt { set; get; }

        protected long VersionNo { set; get; }
    }
}

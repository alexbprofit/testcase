using System;
namespace VisitorsTracker.Db.Entities
{
    public class Audience : BaseEntity
    {
        public string Name { get; set; }
        public string Desc {get; set;}
        public int limitOfSeet {get; set;}
    }
}

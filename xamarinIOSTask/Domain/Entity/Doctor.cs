
using xamarinIOSTask.ApplicationCore.Core;

namespace xamarinIOSTask.Domain.Entity
{
    public class Doctor : BaseEntity
    {
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public bool IsOnline { get; set; }
        public int ReviewsCount { get; set; }
        public string Field { get; set; }
        public string Level { get; set; }
        public int Rate { get; set; }
    }
}

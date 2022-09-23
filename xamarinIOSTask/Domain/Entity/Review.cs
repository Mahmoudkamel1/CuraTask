using xamarinIOSTask.ApplicationCore.Core;

namespace xamarinIOSTask.Domain.Entity
{
    public class Review :BaseEntity
    {
        public string PatientName { get; set; }
        public string PatientImageURL { get; set; }
        public int PatientAge { get; set; }
        public string PatientComment { get; set; }
        public string SinceTime { get; set; }
        public string DoctorName { get; set; }
        public string DoctorImageURL { get; set; }
        public int DoctorReviewsCount { get; set; }
        public string DoctorField { get; set; }
        public int DoctorRate { get; set; }
    }
}

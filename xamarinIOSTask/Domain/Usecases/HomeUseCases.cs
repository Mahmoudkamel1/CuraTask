using System.Collections.Generic;
using System.Threading.Tasks;
using xamarinIOSTask.ApplicationCore.Core;
using xamarinIOSTask.ApplicationCore.Helper;
using xamarinIOSTask.Domain.Entity;
using xamarinIOSTask.Domain.Interfaces;

namespace xamarinIOSTask.Domain.Usecases
{
    public class HomeUseCases : BaseUseCase, ReviewsServices, DoctorsServices
    {
        string _image1 = Constants.DoctorImageURL1;
        string _image2 = Constants.PatientImageURL;
        string _image3 = Constants.DoctorImageURL2;

        public async Task<List<Doctor>> GetDoctorsAcceptInsurance()
        {
            await Task.Yield();
            return new List<Doctor>
            {
                new Doctor(){ID = 1,Name = "Dr. Barakat Mahmoud 1",Field = "Psyshiarty",ImageURL =_image1 ,IsOnline = true,Level ="Specialist",Rate = 5,ReviewsCount = 20},
                new Doctor(){ID = 2,Name = "Dr. Barakat Mahmoud 2",Field = "Psyshiarty 2",ImageURL =_image1,IsOnline = true,Level ="Not Specialist",Rate = 4,ReviewsCount = 220},
                new Doctor(){ID = 3,Name = "Dr. Barakat Mahmoud 3",Field = "Psyshiarty 3",ImageURL =_image1,IsOnline = true,Level ="Specialist",Rate = 3,ReviewsCount = 2},
                new Doctor(){ID = 4,Name = "Dr. Barakat Mahmoud 4",Field = "Psyshiarty 4",ImageURL =_image1,IsOnline = false,Level ="Specialist",Rate = 4,ReviewsCount = 30},
                new Doctor(){ID = 5,Name = "Dr. Barakat Mahmoud 5",Field = "Psyshiarty 5",ImageURL =_image1,IsOnline = false,Level ="Specialist",Rate = 5,ReviewsCount = 50},
                new Doctor(){ID = 6,Name = "Dr. Barakat Mahmoud 6",Field = "Psyshiarty 6",ImageURL =_image1,IsOnline = false,Level ="Not Specialist",Rate = 4,ReviewsCount = 100},
                new Doctor(){ID = 7,Name = "Dr. Barakat Mahmoud 7",Field = "Psyshiarty 7",ImageURL =_image1,IsOnline = true,Level ="Any text",Rate = 3,ReviewsCount = 205},
                new Doctor(){ID = 8,Name = "Dr. Barakat Mahmoud 8",Field = "Psyshiarty 8",ImageURL =_image1,IsOnline = true,Level ="Any",Rate = 2,ReviewsCount = 206},
                new Doctor(){ID = 9,Name = "Dr. Barakat Mahmoud 9",Field = "Psyshiarty 9",ImageURL =_image1,IsOnline = false,Level ="Text",Rate = 2,ReviewsCount = 207},
                new Doctor(){ID = 10,Name = "Dr. Barakat Mahmoud 10",Field = "Psyshiarty 10",ImageURL =_image1,IsOnline = false,Level ="Specialist",Rate = 1,ReviewsCount = 240},
            };
        }

        public async Task<List<Review>> GetReviews()
        {
            await Task.Yield();
            return new List<Review>()
            {
                new Review(){ID = 1,PatientAge = 20,PatientComment = "any comment happiness",PatientImageURL = _image2,
                PatientName = "Patient 1",SinceTime = "one year ago", DoctorField ="General practice",DoctorImageURL =_image3,
                DoctorName = "Doctor 1",DoctorRate = 5,DoctorReviewsCount = 200},
                new Review(){ID = 2,PatientAge = 20,PatientComment = "any comment express happiness 2",PatientImageURL = _image2,
                PatientName = "Patient 2",SinceTime = "two year ago", DoctorField ="General practice 2",DoctorImageURL =_image3,
                DoctorName = "Doctor 2",DoctorRate = 4,DoctorReviewsCount = 20},
                new Review(){ID = 3,PatientAge = 20,PatientComment = "any comment express happiness 3",PatientImageURL = _image2,
                PatientName = "Patient 3",SinceTime = "three year ago", DoctorField ="General practice 3",DoctorImageURL =_image3,
                DoctorName = "Doctor 3",DoctorRate = 3,DoctorReviewsCount = 10},
                new Review(){ID = 4,PatientAge = 20,PatientComment = "any comment express happiness 4",PatientImageURL = _image2,
                PatientName = "Patient 4",SinceTime = "four year ago", DoctorField ="General practice 4",DoctorImageURL =_image3,
                DoctorName = "Doctor 4",DoctorRate = 2,DoctorReviewsCount = 50},
                new Review(){ID = 5,PatientAge = 20,PatientComment = "any comment express happiness 5",PatientImageURL = _image2,
                PatientName = "Patient 5",SinceTime = "one month ago", DoctorField ="General practice 5",DoctorImageURL =_image3,
                DoctorName = "Doctor 5",DoctorRate = 1,DoctorReviewsCount = 20},
                new Review(){ID = 6,PatientAge = 20,PatientComment = "any comment express happiness 6",PatientImageURL = _image2,
                PatientName = "Patient 6",SinceTime = "two month ago", DoctorField ="General practice 6",DoctorImageURL =_image3,
                DoctorName = "Doctor 6",DoctorRate = 5,DoctorReviewsCount = 22},
                new Review(){ID = 7,PatientAge = 20,PatientComment = "any comment express happiness 7",PatientImageURL = _image2,
                PatientName = "Patient 7",SinceTime = "three month ago", DoctorField ="General practice 7",DoctorImageURL =_image3,
                DoctorName = "Doctor 7",DoctorRate = 4,DoctorReviewsCount = 22},
                new Review(){ID = 8,PatientAge = 20,PatientComment = "any comment express happiness 8",PatientImageURL = _image2,
                PatientName = "Patient 8",SinceTime = "any month ago", DoctorField ="General practice 8",DoctorImageURL =_image3,
                DoctorName = "Doctor 8",DoctorRate = 3,DoctorReviewsCount = 24},
                new Review(){ID = 9,PatientAge = 20,PatientComment = "any comment express happiness 9",PatientImageURL = _image2,
                PatientName = "Patient 9",SinceTime = "any month ago", DoctorField ="General practice 9",DoctorImageURL =_image3,
                DoctorName = "Doctor 9",DoctorRate = 2,DoctorReviewsCount = 28},
            };
        }
    }
}

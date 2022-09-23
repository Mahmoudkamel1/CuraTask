using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using xamarinIOSTask.Domain.Entity;
using xamarinIOSTask.Domain.Interfaces;
using xamarinIOSTask.Domain.Usecases;

namespace xamarinIOSTask.Presentation.Home.ViewModel
{
    public class HomeViewModel
    {
        private DoctorsServices _doctorsServices;
        private ReviewsServices _reviewsServices;
        private List<Review> _reviews = null;
        private List<Doctor> _doctorsAcceptInsurance = null;
        public HomeViewModel()
        {
            _doctorsServices = new HomeUseCases();
            _reviewsServices = new HomeUseCases();
        }
        public async Task<List<Review>> GetHappyCustomerReviews()
        {
            if (_reviews == null || _reviews.Count == 0)
            {
                _reviews = await _reviewsServices.GetReviews();
            }
            return _reviews;
        }
        public async Task<List<Doctor>> GetDoctorAcceptInsurance()
        {
            if (_doctorsAcceptInsurance == null || _doctorsAcceptInsurance.Count == 0)
            {
                _doctorsAcceptInsurance = await _doctorsServices.GetDoctorsAcceptInsurance();
            }
            return _doctorsAcceptInsurance;
        }
    }
}

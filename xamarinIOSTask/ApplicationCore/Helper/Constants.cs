using System;
using System.Collections.Generic;

namespace xamarinIOSTask.ApplicationCore.Helper
{
    public static class Constants
    {
        public static string ReviewCellIdentifier => "happyCustomerCell";
        public static string DoctorCellIdentifier => "doctorCell";
        public static List<string> Reviews = new List<string>
        {
            "one_star.jpg","two_stars.jpg","three_stars.jpg","four_stars.jpg","five_stars.jpg"
        };
        public static string PatientImageURL => "https://acortar.link/logo-acortar-url.png";
        public static string DoctorImageURL1 => "https://acortar.link/logo1.png";
        public static string DoctorImageURL2 => "https://cdn.pixabay.com/photo/2017/06/02/19/12/broken-link-2367103__340.png";
    }
}

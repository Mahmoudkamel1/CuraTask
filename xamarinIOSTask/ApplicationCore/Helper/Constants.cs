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
    }
}

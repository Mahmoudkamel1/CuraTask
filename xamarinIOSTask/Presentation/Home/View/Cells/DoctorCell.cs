// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;
using xamarinIOSTask.ApplicationCore.Helper;
using xamarinIOSTask.Domain.Entity;

namespace xamarinIOSTask.Presentation.Home
{
	public partial class DoctorCell : UICollectionViewCell
	{
		private UIImage _doctorImage;
		public DoctorCell (IntPtr handle) : base (handle)
		{
		}
		public void ConfigureCell(Doctor doctor)
        {
			this.Tag = doctor.ID;
			this.onlineMark.Layer.CornerRadius = 5;
			this.onlineMark.Layer.BorderWidth = 1;
			this.onlineMark.Layer.BorderColor = UIColor.Clear.CGColor;
			this.onlineMark.Hidden = !doctor.IsOnline;
			if(_doctorImage == null)
            {
				_doctorImage = _doctorImage.FromUrl(doctor.ImageURL);
            }
			this.doctorImage.Image = _doctorImage;
			this.doctorImage.Layer.CornerRadius = 8;
			this.doctorImage.Layer.MasksToBounds = true;
			this.doctorName.Text = doctor.Name;
			this.doctorField.Text = doctor.Field;
			this.doctorLevel.Text = doctor.Level;
			this.reviewsCount.Text = doctor.ReviewsCount + " Reviews";
			this.ratingImage.Image = UIImage.FromBundle(Constants.Reviews[doctor.Rate - 1]);

		}
	}
}

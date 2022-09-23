// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace xamarinIOSTask.Presentation.Home
{
	[Register ("DoctorCell")]
	partial class DoctorCell
	{
		[Outlet]
		UIKit.UILabel doctorField { get; set; }

		[Outlet]
		UIKit.UIImageView doctorImage { get; set; }

		[Outlet]
		UIKit.UILabel doctorLevel { get; set; }

		[Outlet]
		UIKit.UILabel doctorName { get; set; }

		[Outlet]
		UIKit.UIView onlineMark { get; set; }

		[Outlet]
		UIKit.UIImageView ratingImage { get; set; }

		[Outlet]
		UIKit.UILabel reviewsCount { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (doctorField != null) {
				doctorField.Dispose ();
				doctorField = null;
			}

			if (doctorImage != null) {
				doctorImage.Dispose ();
				doctorImage = null;
			}

			if (doctorLevel != null) {
				doctorLevel.Dispose ();
				doctorLevel = null;
			}

			if (doctorName != null) {
				doctorName.Dispose ();
				doctorName = null;
			}

			if (onlineMark != null) {
				onlineMark.Dispose ();
				onlineMark = null;
			}

			if (reviewsCount != null) {
				reviewsCount.Dispose ();
				reviewsCount = null;
			}

			if (ratingImage != null) {
				ratingImage.Dispose ();
				ratingImage = null;
			}
		}
	}
}

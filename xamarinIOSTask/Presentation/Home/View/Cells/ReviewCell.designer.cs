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
	[Register ("ReviewCell")]
	partial class ReviewCell
	{
		[Outlet]
		UIKit.UIView bigView { get; set; }

		[Outlet]
		UIKit.UIImageView docotrImage { get; set; }

		[Outlet]
		UIKit.UILabel doctorName { get; set; }

		[Outlet]
		UIKit.UILabel doctorSpecialize { get; set; }

		[Outlet]
		UIKit.UILabel patientAge { get; set; }

		[Outlet]
		UIKit.UILabel patientComment { get; set; }

		[Outlet]
		UIKit.UIImageView patientImage { get; set; }

		[Outlet]
		UIKit.UILabel patientName { get; set; }

		[Outlet]
		UIKit.UIImageView ratingImage { get; set; }

		[Outlet]
		UIKit.UIView ratingsView { get; set; }

		[Outlet]
		UIKit.UILabel reviewsCount { get; set; }

		[Outlet]
		UIKit.UILabel sinceWhen { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (bigView != null) {
				bigView.Dispose ();
				bigView = null;
			}

			if (docotrImage != null) {
				docotrImage.Dispose ();
				docotrImage = null;
			}

			if (doctorName != null) {
				doctorName.Dispose ();
				doctorName = null;
			}

			if (doctorSpecialize != null) {
				doctorSpecialize.Dispose ();
				doctorSpecialize = null;
			}

			if (patientAge != null) {
				patientAge.Dispose ();
				patientAge = null;
			}

			if (patientComment != null) {
				patientComment.Dispose ();
				patientComment = null;
			}

			if (patientImage != null) {
				patientImage.Dispose ();
				patientImage = null;
			}

			if (patientName != null) {
				patientName.Dispose ();
				patientName = null;
			}

			if (ratingsView != null) {
				ratingsView.Dispose ();
				ratingsView = null;
			}

			if (reviewsCount != null) {
				reviewsCount.Dispose ();
				reviewsCount = null;
			}

			if (sinceWhen != null) {
				sinceWhen.Dispose ();
				sinceWhen = null;
			}

			if (ratingImage != null) {
				ratingImage.Dispose ();
				ratingImage = null;
			}
		}
	}
}

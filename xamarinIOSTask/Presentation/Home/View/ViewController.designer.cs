// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace xamarinIOSTask
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UICollectionView doctorsCollectionView { get; set; }

		[Outlet]
		UIKit.UICollectionView happyReviewsCollectionView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (doctorsCollectionView != null) {
				doctorsCollectionView.Dispose ();
				doctorsCollectionView = null;
			}

			if (happyReviewsCollectionView != null) {
				happyReviewsCollectionView.Dispose ();
				happyReviewsCollectionView = null;
			}
		}
	}
}

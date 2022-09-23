using System;
using Foundation;
using UIKit;

namespace xamarinIOSTask.ApplicationCore.Helper
{
    public static class Extensions
    {
		public static UIImage FromUrl(this UIImage image, string uri)
		{
			using (var url = new NSUrl(uri))
			using (var data = NSData.FromUrl(url))
				image = UIImage.LoadFromData(data);

			return image;
		}
	}
}

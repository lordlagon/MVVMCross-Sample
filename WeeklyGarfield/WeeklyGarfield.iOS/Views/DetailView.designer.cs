// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;

namespace DailyGarfield.Touch
{
	[Register ("DetailView")]
	partial class DetailView
	{
		[Outlet]
		UIKit.UIImageView StripImage { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (StripImage != null) {
				StripImage.Dispose ();
				StripImage = null;
			}
		}
	}
}

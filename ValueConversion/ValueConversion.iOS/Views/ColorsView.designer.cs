// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;

namespace ValueConversion.UI.Touch
{
	[Register ("ColorsView")]
	partial class ColorsView
	{
		[Outlet]
		UIKit.UILabel ColorLabel { get; set; }

		[Outlet]
		UIKit.UISlider RedSlider { get; set; }

		[Outlet]
		UIKit.UISlider GreenSlider { get; set; }

		[Outlet]
		UIKit.UISlider BlueSlider { get; set; }

		[Outlet]
		UIKit.UIView ColorView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ColorLabel != null) {
				ColorLabel.Dispose ();
				ColorLabel = null;
			}

			if (RedSlider != null) {
				RedSlider.Dispose ();
				RedSlider = null;
			}

			if (GreenSlider != null) {
				GreenSlider.Dispose ();
				GreenSlider = null;
			}

			if (BlueSlider != null) {
				BlueSlider.Dispose ();
				BlueSlider = null;
			}

			if (ColorView != null) {
				ColorView.Dispose ();
				ColorView = null;
			}
		}
	}
}

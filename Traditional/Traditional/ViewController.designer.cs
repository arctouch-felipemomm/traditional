// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Traditional
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnSum { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblResult { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtNumber1 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtNumber2 { get; set; }

		[Action ("BtnSum_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void BtnSum_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnSum != null) {
				btnSum.Dispose ();
				btnSum = null;
			}
			if (lblResult != null) {
				lblResult.Dispose ();
				lblResult = null;
			}
			if (txtNumber1 != null) {
				txtNumber1.Dispose ();
				txtNumber1 = null;
			}
			if (txtNumber2 != null) {
				txtNumber2.Dispose ();
				txtNumber2 = null;
			}
		}
	}
}

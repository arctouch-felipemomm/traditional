using System;

using UIKit;
using InfColorPickerBinding;

namespace Traditional
{
	public partial class ViewController : UIViewController
	{
		ColorSelectedDelegate selector;

		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			selector = new ColorSelectedDelegate (this);
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void BtnSum_TouchUpInside(UIButton sender)
		{
			long number;

			if (long.TryParse(txtNumber1.Text, out number) && long.TryParse(txtNumber2.Text, out number))
			{
				long result = Traditional.Core.Math.Sum(long.Parse(txtNumber1.Text), long.Parse(txtNumber2.Text));

				this.lblResult.Text = String.Format("Result: {0}", result);
			}
		}

		partial void btnChangeBackground_TouchInside(UIButton sender)
		{
			InfColorPickerController picker = InfColorPickerController.ColorPickerViewController;
			picker.Delegate = selector;
			picker.PresentModallyOverViewController (this);
		}
	}
}


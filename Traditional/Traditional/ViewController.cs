using System;

using UIKit;

namespace Traditional
{
	public partial class ViewController : UIViewController
	{
		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void BtnSum_TouchUpInside(UIButton sender)
		{
			long result = Traditional.Core.Math.Sum(long.Parse(txtNumber1.Text), long.Parse(txtNumber2.Text));

			this.lblResult.Text = String.Format("Result: {0}", result);
		}
	}
}


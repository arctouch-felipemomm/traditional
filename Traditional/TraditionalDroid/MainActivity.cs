using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace TraditionalDroid
{
	[Activity(Label = "TraditionalDroid", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		EditText txtNumber1;
		EditText txtNumber2;
		Button btnSum;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			txtNumber1 = FindViewById<EditText>(Resource.Id.txtNumber1);
			txtNumber2 = FindViewById<EditText>(Resource.Id.txtNumber2);
			btnSum = FindViewById<Button>(Resource.Id.btnSum);

			btnSum.Click += SumClicked;
		}

		private void SumClicked(object sender, System.EventArgs e)
		{
			long result = Traditional.Core.Math.Sum(long.Parse(txtNumber1.Text), long.Parse(txtNumber2.Text));

			Toast.MakeText(this.BaseContext, String.Format("Result: {0}", result), ToastLength.Long).Show();
		}
	}
}



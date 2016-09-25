
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace androidtest
{
	[Activity(Label = "SecondActivity")]
	public class SecondActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Second);
			TextView a = FindViewById<TextView>(Resource.Id.editText1);
			string data = Intent.GetStringExtra("we")??"bu bu";
			a.Text = data;

			// Create your application here
		}
	}
}

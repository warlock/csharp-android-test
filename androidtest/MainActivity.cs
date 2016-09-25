using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace androidtest
{
	[Activity(Label = "androidtest", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button bogbut = FindViewById<Button>(Resource.Id.bogbuton);
			Button button1 = FindViewById<Button>(Resource.Id.button1);

			button1.Click += delegate {
				var activ2 = new Intent(this, typeof(SecondActivity));
				activ2.PutExtra("we", "boh");
				StartActivity(activ2);
				//SetContentView(Resource.Layout.Second);
			};
			Button button = FindViewById<Button>(Resource.Id.myButton);
			bogbut.Click += delegate { bogbut.Text = "holaaa"; };

			button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
		}
	}
}


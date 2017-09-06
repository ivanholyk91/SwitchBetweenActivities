using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace SwitchBetweenActivities
{
    [Activity(Label = "SwitchBetweenActivities", MainLauncher = true, Icon ="@drawable/Icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            var edtName = FindViewById<EditText>(Resource.Id.edtName);
            var edtEmail = FindViewById<EditText>(Resource.Id.edtEmail);
            var btnSend = FindViewById<Button>(Resource.Id.btnSend);

            btnSend.Click += (s, e) =>  {
                Intent nextActivity = new Intent(this, typeof(RecvActivity));
                nextActivity.PutExtra("name", edtName.Text);
                nextActivity.PutExtra("email", edtEmail.Text);
                StartActivity(nextActivity);
             };
        }
    }
}


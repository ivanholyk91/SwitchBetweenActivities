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

namespace SwitchBetweenActivities
{
    [Activity(Label = "RecvActivity")]
    public class RecvActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.RecvActivity);
            string name = Intent.GetStringExtra("name" ?? "Not recv");
            string email = Intent.GetStringExtra("email" ?? "Not recv");

            var txtName = FindViewById<TextView>(Resource.Id.txtName);
            var txtEmail = FindViewById<TextView>(Resource.Id.txtEmail);
            var btnGoBack = FindViewById<Button>(Resource.Id.btnGoBack);

            txtName.Text = name;
            txtEmail.Text = email;
            btnGoBack.Click += delegate {
                this.Finish();
            };
        }
    }
}
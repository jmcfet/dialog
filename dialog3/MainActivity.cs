using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace dialog3
{
    [Activity(Label = "dialog3", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private Button mButtnSignup;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            mButtnSignup = FindViewById<Button>(Resource.Id.sinup);
            mButtnSignup.Click += (object sender, EventArgs args) =>
            {
                FragmentTransaction transcation = FragmentManager.BeginTransaction();
                DialogClass signup = new DialogClass();
                signup.Show(transcation, "Dialog Fragment");
                signup.mOnsignupDone += Signup_mOnsignupDone;
            };
        }

        private void Signup_mOnsignupDone(object sender, OnSignUpEventArgs e)
        {
    //        throw new NotImplementedException();
        }
    }
}


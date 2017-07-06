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

namespace dialog3
{
    public class OnSignUpEventArgs : EventArgs
    {
        string mEmail;
        string mPassword;
        public string EMail
        {
            get { return mEmail; }
            set { mEmail = value; }
        }
        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }
        public OnSignUpEventArgs(string email, string password) : base()
        {
            mEmail = email;
            mPassword = password;
        }
    }
    class DialogClass : DialogFragment
    {
        EditText txtEmail;
        EditText txtPassword;
        Button btnSignup;
        public event EventHandler<OnSignUpEventArgs> mOnsignupDone;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.signup, container, false);
            txtEmail = view.FindViewById<EditText>(Resource.Id.email);
            txtPassword = view.FindViewById<EditText>(Resource.Id.password);
            btnSignup = view.FindViewById<Button>(Resource.Id.signup);
            btnSignup.Click += BtnSignup_Click;
            return view;

        }
        public override void OnActivityCreated(Bundle savedInstanceState)
        {
     //       Dialog.Window.RequestFeature(WindowFeatures.NoTitle);
            base.OnActivityCreated(savedInstanceState);
            //       Dialog.Window.Attributes.WindowAnimations = Resource.
        }

        private void BtnSignup_Click(object sender, EventArgs e)
        {
            mOnsignupDone.Invoke(this, new OnSignUpEventArgs(txtEmail.Text, txtPassword.Text));
            this.Dismiss();
        }
    }
}
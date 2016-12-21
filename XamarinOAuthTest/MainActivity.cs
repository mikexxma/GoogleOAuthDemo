using Android.App;
using Android.Widget;
using Android.OS;
using Xamarin.Auth;
using System;
using Android.Views;

namespace XamarinOAuthTest
{
    [Activity(Label = "XamarinOAuthTest", MainLauncher = true, Icon = "@drawable/icon", Theme = "@android:style/Theme.NoTitleBar")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //Window.RequestFeature(WindowFeatures.NoTitle);
            // Set our view from the "main" layout resource
            //SetContentView (Resource.Layout.Main);

            var auth = new OAuth2Authenticator(
                clientId: "216445815396-dtmqqjf3h6t3g4i4ad0v0qj80gtsljd1.apps.googleusercontent.com",
                clientSecret: "bU7l8svG1q0BRxpXGpOh7QVs",
                scope: "openid",
                authorizeUrl: new Uri("https://accounts.google.com/o/oauth2/auth"),
                redirectUrl: new Uri("https://www.google.com.sg/"),
                accessTokenUrl: new Uri("https://accounts.google.com/o/oauth2/token"),
                getUsernameAsync: null
            );

            StartActivity(auth.GetUI(this));
        }


    }
}


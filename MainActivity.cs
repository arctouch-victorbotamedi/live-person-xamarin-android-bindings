using Android.App;
using Android.Widget;
using Android.OS;
using Com.Liveperson.Infra.Callbacks;
using Com.Liveperson.Infra;

namespace LivePersonXamarinTest
{
    [Activity(Label = "LivePersonTest", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            InitLivePersonProperties properties = new InitLivePersonProperties("brand", "äppid", new LivePersonInit());
            Com.Liveperson.Messaging.Sdk.Api.LivePerson.Initialize(this, properties);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += delegate { button.Text = $"{count++} clicks!"; };
        }

        public class LivePersonInit : Java.Lang.Object, IInitLivePersonCallBack
        {

            public void OnInitFailed(Java.Lang.Exception ex)
            {
                
            }

            public void OnInitSucceed()
            {
                
            }
        }
    }
}


using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.Res;
using Java.Util.Zip;
using Android.Content;

namespace ListViewAndroid
{
    [Activity(Label = "ListView Formas", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
      

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            var button = FindViewById<Button>(Resource.Id.btnSimples);
           
              var button2 = FindViewById<Button>(Resource.Id.btnPersonalizado);

            button.Click += delegate
            {
                
                var itent = new Intent(this, typeof(ListViewSimpleExample));
                StartActivity(itent);

            };
            
             button2.Click += delegate
            {
                
                var itent = new Intent(this, typeof(ListViewCustomizada));
                StartActivity(itent);

            };
        }
    }
}


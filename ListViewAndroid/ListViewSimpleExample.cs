using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Widget;

namespace ListViewAndroid
{
    [Activity(Label = "ListView Simples")]
    public class ListViewSimpleExample : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ListViewSimpleExample);
            var Itens = FindViewById<ListView>(Resource.Id.lvUsers);
            var valores = new List<string> { "Gol", "Celta", "Palio", "Fusca" };
            Itens.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, valores);
            // Create your application here
        }
    }
}

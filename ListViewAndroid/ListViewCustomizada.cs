
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

namespace ListViewAndroid
{
    [Activity(Label = "ListView Customizada")]
    public class ListViewCustomizada : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ListViewCustomizada);
           var Itens = FindViewById<ListView>(Resource.Id.lvUsers);
            var valores = new List<Carro> { 
                                new Carro{ Nome="Gol", Modelo="Volkswagen", Imagem="http://pngimg.com/upload_small/car_logo/car_logo_PNG1667.png"}, 
                                new Carro{ Nome="Celta", Modelo="Chevrolet", Imagem="https://catalogo.webmotors.com.br/assets/img/logos/chevrolet.png?v=201726-198"},
                                new Carro{ Nome="Palio", Modelo="Fiat", Imagem="http://pngimg.com/upload_small/car_logo/car_logo_PNG1637.png"} };
            Itens.Adapter = new CarrosAdapter(this, valores);
            // Create your application here
        }
    }
}

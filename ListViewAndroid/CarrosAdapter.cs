using System;
using Android.Views;
using Android.Widget;
using Java.Lang;
using Android.Content;
using System.Collections.Generic;
using Android.Graphics;
using System.Net;

namespace ListViewAndroid
{
    public class CarrosAdapter: BaseAdapter<Carro>
    {
        private readonly Context pContext;
        private readonly List<Carro> pCarros;
        public CarrosAdapter(Context context, List<Carro> carros)
        {
            pCarros = carros;
            pContext = context;
        }

        public override Carro this[int position]
        {
            get
            {
                return pCarros[position];
            }
        }

        public override int Count
        {
            get
            {
                return pCarros.Count;
            }
        }
        
       

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if(row == null)
                row = LayoutInflater.From(pContext).Inflate(Resource.Layout.item_carros, null);
                
            row.FindViewById<TextView>(Resource.Id.txtNome).Text = pCarros[position].Nome;
            row.FindViewById<TextView>(Resource.Id.txtModelo).Text = pCarros[position].Modelo;
            var bitmap = GetImageBitmapFromUrl(pCarros[position].Imagem);
                row.FindViewById<ImageView>(Resource.Id.imgLogo).SetImageBitmap(bitmap);
            return row;
        }
         private Bitmap GetImageBitmapFromUrl(string url)
    {
        Bitmap imageBitmap = null;
        if(!(url=="null"))
        using (var webClient = new WebClient())
        {
            var imageBytes = webClient.DownloadData(url);
            if (imageBytes != null && imageBytes.Length > 0)
            {
                imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
            }
        }

        return imageBitmap;
    }
      
    }
}

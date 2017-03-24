using System;
using System.Collections.Generic;
using Android.Content;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ListViewAndroid
{
    public class ListViewAdapterCustom<T> : BaseAdapter<T> where T : class
    {
        private Context pcontext;
        private List<T> pitens;
    public ListViewAdapterCustom(Context context, List<T> itens)
        {
            pitens = itens;
            pcontext = context;
        }
        public override T this[int position]
        {
            get
            {
                return pitens[position];
            }
        }

        public override int Count
        {
            get
            {
                return pitens.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if(row ==null)
             
        }
    }
}

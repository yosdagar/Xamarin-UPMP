﻿using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Lab1
{
    [Activity(Label = "Lab1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        Button button;
        TextView textViewDev;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            button = FindViewById<Button>(Resource.Id.MyButton);
            textViewDev = FindViewById<TextView>(Resource.Id.textViewDev);

            button.Click += Button_Click1;
        }

        private void Button_Click1(object sender, EventArgs e)
        {
            textViewDev.Text = "Yosdagar";
            button.Text = "Haz Cambiado el texto";
        }

        
    }
}

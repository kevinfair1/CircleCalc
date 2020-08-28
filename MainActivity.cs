﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace CsharpWeek11CircleCalc
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button button = FindViewById<Button>(Resource.Id.button1);
            TextView tvResult = FindViewById<TextView>(Resource.Id.textView1);
            EditText etRadius = FindViewById<EditText>(Resource.Id.editText1);

            button.Click += delegate
            {
                //button.Text = string.Format("{0} clicks!", count++)
                Circle myCircle = new Circle(Double.Parse(etRadius.Text));
                tvResult.Text = "Area: " + myCircle.getArea() +
                                "\nCircumference: " + myCircle.getCircumference();
            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.OS;
using List.Core.ViewModels;

namespace List.Views
{
    [Activity(Label = "List", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainView : BaseView<MainViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MainView);
        }
    }
}
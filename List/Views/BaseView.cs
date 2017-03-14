
using System;
using Android.OS;
using MvvmCross.Droid.Views;
using MvvmCross.Core.ViewModels;

namespace List.Views
{
    public class BaseView<T> : MvxActivity<T> where T : MvxViewModel
    {
    }
}
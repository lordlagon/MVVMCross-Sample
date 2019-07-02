using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using DailyDilbert.Droid;

namespace DailyGarfield.Droid.Views
{
    [Activity(Label = "View for ListViewModel")]
    public class ListView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.ListView);
        }
    }
}
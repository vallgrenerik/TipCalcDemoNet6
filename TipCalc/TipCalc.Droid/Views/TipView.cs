using Android.App;
using Android.OS;
using MvvmCross;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Views;
using TipCalc.Core.ViewModels;
using TipCalc.Droid;
using Resource = TipCalc.Droid.Resource;

namespace TipCalc.UI.Droid.Views
{
    [Activity(Label = "Tip Calculator", Theme = "@style/AppTheme")]
    public class TipView : MvxActivity<TipViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.TipView);
        }
        protected override void OnDestroy()
        {
	        base.OnDestroy();

	        Mvx.IoCProvider.Resolve<IMvxAndroidActivityLifetimeListener>()
		        .OnDestroy(this);

        }
	}
}
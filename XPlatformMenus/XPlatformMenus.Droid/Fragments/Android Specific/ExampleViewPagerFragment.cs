using System.Collections.Generic;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Views;
using XPlatformMenus.Core.ViewModels;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;

namespace XPlatformMenus.Droid.Fragments
{
	[MvxFragment(typeof(MainViewModel), Resource.Id.content_frame, true)]
    [Register("xplatformmenus.droid.fragments.ExampleViewPagerFragment")]
    public class ExampleViewPagerFragment : BaseFragment<ExampleViewPagerViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            ShowHamburgerMenu = true;
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            var viewPager = view.FindViewById<ViewPager>(Resource.Id.viewpager);
            if (viewPager != null)
            {
                var fragments = new List<MvxCachingFragmentStatePagerAdapter.FragmentInfo>
                {
					new MvxCachingFragmentStatePagerAdapter.FragmentInfo("RecyclerView 1", typeof(RecyclerViewFragment), typeof(RecyclerViewModel)),
					new MvxCachingFragmentStatePagerAdapter.FragmentInfo("RecyclerView 2", typeof(RecyclerViewFragment), typeof(RecyclerViewModel)),
					new MvxCachingFragmentStatePagerAdapter.FragmentInfo("RecyclerView 3", typeof(RecyclerViewFragment), typeof(RecyclerViewModel)),
					new MvxCachingFragmentStatePagerAdapter.FragmentInfo("RecyclerView 4", typeof(RecyclerViewFragment), typeof(RecyclerViewModel)),
					new MvxCachingFragmentStatePagerAdapter.FragmentInfo("RecyclerView 5", typeof(RecyclerViewFragment), typeof(RecyclerViewModel))                };

                viewPager.Adapter = new MvxCachingFragmentStatePagerAdapter(Activity, ChildFragmentManager, fragments);
            }

            var tabLayout = view.FindViewById<TabLayout>(Resource.Id.tabs);
            tabLayout.SetupWithViewPager(viewPager);

            return view;
        }

		protected override int FragmentId => Resource.Layout.fragment_example_viewpager;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;

namespace XPlatformMenus.Mac.Views
{
	public partial class LoginView : BaseView
	{
		#region Constructors

		// Called when created from unmanaged code
		public LoginView(IntPtr handle) : base(handle)
		{
			Initialize();
		}

		// Called when created directly from a XIB file
		[Export("initWithCoder:")]
		public LoginView(NSCoder coder) : base(coder)
		{
			Initialize();
		}

		// Shared initialization code
		void Initialize()
		{
		}

		#endregion
	}
}

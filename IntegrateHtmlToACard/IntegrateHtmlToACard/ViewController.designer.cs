// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace IntegrateHtmlToACard
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton convertTextButton { get; set; }

		[Outlet]
		UIKit.UITextView resultFormatText { get; set; }

		[Outlet]
		UIKit.UITextView textHtml { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (textHtml != null) {
				textHtml.Dispose ();
				textHtml = null;
			}

			if (convertTextButton != null) {
				convertTextButton.Dispose ();
				convertTextButton = null;
			}

			if (resultFormatText != null) {
				resultFormatText.Dispose ();
				resultFormatText = null;
			}
		}
	}
}

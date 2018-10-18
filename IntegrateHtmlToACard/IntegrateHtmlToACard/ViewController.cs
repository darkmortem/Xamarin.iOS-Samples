using System;
using Foundation;
using UIKit;

namespace IntegrateHtmlToACard
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            convertTextButton.TouchUpInside -= ConvertTextButton_TouchUpInside;
            convertTextButton.TouchUpInside += ConvertTextButton_TouchUpInside;

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        void ConvertTextButton_TouchUpInside(object sender, EventArgs e)
        {

            var attr = new NSAttributedStringDocumentAttributes();
            var nsError = new NSError();
            attr.DocumentType = NSDocumentType.HTML;

            var myHtmlData = NSData.FromString(textHtml.Text, NSStringEncoding.Unicode);
            resultFormatText.AttributedText = new NSAttributedString(myHtmlData, attr, ref nsError);
            //resultFormatText.Lines = 0;
            //resultFormatText.SizeToFit();
        }

    }
}

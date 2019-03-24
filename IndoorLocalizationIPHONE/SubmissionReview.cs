using Foundation;
using System;
using UIKit;

namespace IndoorLocalizationIPHONE
{
    public partial class SubmissionReview : UIViewController
    {
       
        public SubmissionReview (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            textFieldReview.Text = "University: " + DataPass.University + "\n" +
                "Campus: " + DataPass.Campus + "\n" +
                 "Building: " + DataPass.Building + "\n" +
                 "Room: " + DataPass.ClassName + "\n";

        }
      

    }
}
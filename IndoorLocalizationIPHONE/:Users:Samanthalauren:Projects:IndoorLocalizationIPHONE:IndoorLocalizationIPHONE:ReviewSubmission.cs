using Foundation;
using System;
using UIKit;

namespace IndoorLocalizationIPHONE
{
    public partial class ReviewSubmission : UIView
    {
        public String university;
        public String Campus;
        public String Building;
        public String Room;
        public String Name;

        public ReviewSubmission (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

    }
}
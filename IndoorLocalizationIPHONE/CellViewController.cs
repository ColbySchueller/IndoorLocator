using Foundation;
using System;
using UIKit;

namespace IndoorLocalizationIPHONE
{
    public partial class CellViewController : UIViewController
    {
        public CellViewController(IntPtr handle) : base(handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Class temp = DataPass.currentClass;
            cellviewTitle.Text = DataPass.currentClass.ClassName;
        }
    }
}
using Foundation;
using System;
using UIKit;

namespace IndoorLocalizationIPHONE
{
    public partial class TableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("TableViewCell");
        public static readonly UINib Nib;

        static TableViewCell()
        {
            Nib = UINib.FromName("TableViewCell", NSBundle.MainBundle);
        }

        protected TableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
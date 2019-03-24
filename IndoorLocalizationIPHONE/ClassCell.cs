using Foundation;
using System;
using UIKit;

namespace IndoorLocalizationIPHONE
{
    public partial class ClassCell : UITableViewCell
    {
        public ClassCell (IntPtr handle) : base (handle)
        {
        }
        internal void UpdateCell(Class obj)
        {
            cellClass.Text = obj.ClassName;
            cellIcon.Image = UIImage.FromFile("148781.png");
        }
    }
}
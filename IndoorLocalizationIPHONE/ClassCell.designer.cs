// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace IndoorLocalizationIPHONE
{
    [Register ("ClassCell")]
    partial class ClassCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UILabel cellClass { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UIImageView cellIcon { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (cellClass != null) {
                cellClass.Dispose ();
                cellClass = null;
            }

            if (cellIcon != null) {
                cellIcon.Dispose ();
                cellIcon = null;
            }
        }
    }
}
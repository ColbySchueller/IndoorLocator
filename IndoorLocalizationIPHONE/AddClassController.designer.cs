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
    [Register ("AddClassController")]
    partial class AddClassController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton nextReview { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textFieldBuilding { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textFieldCampus { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textFieldClass { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textFieldRoom { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textFieldUniversity { get; set; }

        [Action ("NextReview_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void NextReview_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (nextReview != null) {
                nextReview.Dispose ();
                nextReview = null;
            }

            if (textFieldBuilding != null) {
                textFieldBuilding.Dispose ();
                textFieldBuilding = null;
            }

            if (textFieldCampus != null) {
                textFieldCampus.Dispose ();
                textFieldCampus = null;
            }

            if (textFieldClass != null) {
                textFieldClass.Dispose ();
                textFieldClass = null;
            }

            if (textFieldRoom != null) {
                textFieldRoom.Dispose ();
                textFieldRoom = null;
            }

            if (textFieldUniversity != null) {
                textFieldUniversity.Dispose ();
                textFieldUniversity = null;
            }
        }
    }
}
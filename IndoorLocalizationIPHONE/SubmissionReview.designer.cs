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
    [Register ("SubmissionReview")]
    partial class SubmissionReview
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView textFieldReview { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (textFieldReview != null) {
                textFieldReview.Dispose ();
                textFieldReview = null;
            }
        }
    }
}
// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace IndoorLocalizationIPHONE
{
    [Register ("FirstViewController")]
    partial class FirstViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView addClassUIView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAddClass { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView btnRemoveClass { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView removeClassUIView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView tableViewClasses { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (addClassUIView != null) {
                addClassUIView.Dispose ();
                addClassUIView = null;
            }

            if (btnAddClass != null) {
                btnAddClass.Dispose ();
                btnAddClass = null;
            }

            if (btnRemoveClass != null) {
                btnRemoveClass.Dispose ();
                btnRemoveClass = null;
            }

            if (removeClassUIView != null) {
                removeClassUIView.Dispose ();
                removeClassUIView = null;
            }

            if (tableViewClasses != null) {
                tableViewClasses.Dispose ();
                tableViewClasses = null;
            }
        }
    }
}
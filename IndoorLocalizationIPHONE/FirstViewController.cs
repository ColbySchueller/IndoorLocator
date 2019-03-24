using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using CoreGraphics;
using Foundation;
using MapKit;
using UIKit;

namespace IndoorLocalizationIPHONE
{
    public partial class FirstViewController : UIViewController
    {
        protected FirstViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //Background Color
            View.BackgroundColor = UIColor.White;
            Title = "GeoLocator for Kennesaw";

            //Set btn Borders
            addClassUIView.Layer.BorderWidth = 1;
            addClassUIView.Layer.CornerRadius = 15;
            addClassUIView.Layer.BorderColor = UIColor.LightGray.CGColor;
            removeClassUIView.Layer.BorderWidth = 1;
            removeClassUIView.Layer.CornerRadius = 15;
            removeClassUIView.Layer.BorderColor = UIColor.LightGray.CGColor;

            //Setting up ViewTable

            if (DataPass.list != null)
            {
                tableViewClasses.Source = new TableSource(DataPass.list);
                tableViewClasses.RowHeight = UITableView.AutomaticDimension;
                tableViewClasses.EstimatedRowHeight = 40f;
                tableViewClasses.ReloadData();
            }
        }

       

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }


    }
     

    public class TableSource : UITableViewSource
    {
        public List<Class> vList;
        public static Class SelectedRow;
        string CellIdentifier = "TableCell";

       
        public TableSource(List<Class> items)
        {
            vList = items;
            for (int i = 0; i < items.Count; i++)
            {
                Debug.WriteLine("Initialize List: "  + items[i].ClassName);
            }
        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (ClassCell)tableView.DequeueReusableCell("cell_Id", indexPath);
            var temp = vList[indexPath.Row];
            cell.BackgroundColor = UIColor.FromRGB(232, 237, 239);
            cell.UpdateCell(temp);
            
            return cell;
        }
        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return vList.Count;
        }
        //Return Selected Row
        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            SelectedRow = vList[indexPath.Row];
            DataPass.currentClass = vList[indexPath.Row];
            Debug.WriteLine("Selected Row: " + vList[indexPath.Row].ClassName);
        }
        public override void CommitEditingStyle(UITableView tableView, UITableViewCellEditingStyle editingStyle, Foundation.NSIndexPath indexPath)
        {
            switch (editingStyle)
            {
                case UITableViewCellEditingStyle.Delete:
                    // remove the item from the underlying data source
                    vList.RemoveAt(indexPath.Row);
                    // delete the row from the table
                    tableView.DeleteRows(new NSIndexPath[] { indexPath }, UITableViewRowAnimation.Fade);
                    break;
                case UITableViewCellEditingStyle.None:
                    Console.WriteLine("CommitEditingStyle:None called");
                    break;
            }
        }



    }


}

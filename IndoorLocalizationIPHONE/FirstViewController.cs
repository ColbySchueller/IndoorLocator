using System;
using System.Collections.Generic;
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
        public List<Class> vList { get; set; }
        List<bool> expandStatusList; // Maintain a list which keeps track if a section is expanded or not

        string CellIdentifier = "TableCell";


        public TableSource(List<Class> items)
        {
            vList = items;
            expandStatusList = new List<bool>();
            for (int i = 0; i < vList.Count; i++)
            {
                expandStatusList.Add(false); // Initially, no section are expanded
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



    }


}

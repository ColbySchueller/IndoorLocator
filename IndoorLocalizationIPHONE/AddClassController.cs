using Foundation;
using System;
using System.Diagnostics;
using UIKit;

namespace IndoorLocalizationIPHONE 
{
    public partial class AddClassController : UIViewController
    {

        public AddClassController(IntPtr handle) : base(handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

         
            //Change Background Color
            View.BackgroundColor = UIColor.FromRGB(211, 230, 237);

            textFieldRoom.BorderStyle = UITextBorderStyle.None;
            textFieldClass.BorderStyle = UITextBorderStyle.None;
            textFieldBuilding.BorderStyle = UITextBorderStyle.None;
            textFieldUniversity.BorderStyle = UITextBorderStyle.None;


        }

        partial void NextReview_TouchUpInside(UIButton sender)
        {
            //Set Static Variables to class DataPass
            DataPass.University = textFieldUniversity.Text;
            DataPass.Campus = textFieldCampus.Text;
            DataPass.ClassName = textFieldClass.Text;
            DataPass.Building = textFieldBuilding.Text;
            DataPass.Room = textFieldRoom.Text;

            //Add class to table view list
            Class temp = new Class();
            temp.University = DataPass.University;
            temp.Campus = DataPass.Campus;
            temp.ClassName = DataPass.ClassName;
            temp.Building = DataPass.Building;
            temp.Room = DataPass.Room;
            DataPass.list.Add(temp);
            Debug.WriteLine(textFieldUniversity.Text + ":" + textFieldBuilding.Text + ":" + textFieldCampus.Text + ":" + textFieldClass.Text + ":" + textFieldRoom.Text);

        }
    }
   
    
}
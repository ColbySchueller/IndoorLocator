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

            DataPass.University = textFieldUniversity.Text;
            DataPass.Campus = textFieldCampus.Text;
            DataPass.Building = textFieldBuilding.Text;
            DataPass.ClassName = textFieldRoom.Text;
            DataPass.Name = textFieldClass.Text;
            //Add class
            Class temp = new Class();
            temp.ClassName = DataPass.Name;
            DataPass.list.Add(temp);
            Debug.WriteLine(textFieldUniversity.Text + ":" + textFieldBuilding.Text + ":" + textFieldCampus.Text + ":" + textFieldClass.Text + ":" + textFieldRoom.Text);

        }
    }
   
    
}
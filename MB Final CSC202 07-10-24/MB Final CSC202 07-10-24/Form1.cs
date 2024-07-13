using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 Name: Leonardo L. Rapanan
 Class: CSC202
 Date: 07/13/2024
 Assignment: Final Project
 
 */

namespace MB_Final_CSC202_07_10_24
{
    public partial class Form1 : Form
    {
       
        // String array to use default for Start intro, rooms and destription of class area LN 25.
        public string[] RN = new string[4];
        public string[] Dsc = new string[4];

        //String array to use feedback textbox function.
        String[] text = new String[2];
        
        // Class area
        public class area
        {
            private string[] roomName = new string[4];
            private string[] description = new string[4];
           

            public area(string[] RN, string[] Dsc)
            {
                for (int i = 0; i < roomName.Length; i++)
                {
                    roomName[i] = RN[i];
                    description[i] = Dsc[i];
                    
                }
            }
            public string getRoom(int i)
            {
                return roomName[i];
               
            }
            public string getDescription(int i)
            {
                return description[i];
            }
        }

        // Class registration is use in LN266.
        class registration
        {
            private string firstname; // String firstname to be used in firstname textbox East area.
            private string lastname; // String lastname to be used in lastname textbox East area.
            private string email; // String email to be used in email textbox East area.

            public registration(string firstname, string lastname, string email)
            {
                if(firstname.Length == 0) // statement for if user doesnt input, then default name is firstname.
                {
                    MessageBox.Show(" invalid input - Iputing name to firstname");
                    this.firstname = "firstname";
                   
                } else
                {
                    this.firstname = firstname;
                }

                if(lastname.Length == 0)// statement for if user doesnt input, then default name is lastname.
                {
                    MessageBox.Show(" invalid input - Iputing name to lastname");
                    this.lastname = "Laststname";
                }
                else
                {
                    this.lastname = lastname;
                }

                if (email.Length == 0)// statement for if user doesnt input, then default name is doughnut@gmail.com.
                {
                    MessageBox.Show(" invalid input - Iputing email to doughnut@gnmail.com");
                    this.email = "doughnut@gnmail.com";
                }else
                {
                    this.email=email;
                }
            }

            public void display() // function to show in messagebox when user click on Register button East area.
            {
                MessageBox.Show("You're Registered \n" + "Here is the information you inputed: \n" + "Firstname: " + firstname 
                    + "\n"  + "Lastname: " + lastname + "\n" + "Email: " + email + "\n Press Ok button to continue");
            }
        }
        public string[] GetText() // This string of GetText return text of OptionButton when user inputs feed back text box for north and south area.
        {
            return text;
        }

        
        public void OptionButton(string[] text) // Function for feedback user input on  North and south area.
        {
            text[0] = FeedbackTxtbx.Text;
            text[1] = stxBox.Text;
            

            FDBKANSWRTxtbx.Text = text[0];
            STHANSWRtxtbx.Text = text[1];
        }


        // function to make label and textbox appear when pressing (North, East, South, and West) buttons.
        public void RoomDescription()
        {
            Roomtxtbox.Visible = true;
            Descriptiontxtbx.Visible = true;
            RoomLabel.Visible = true;
            DescLabel.Visible = true;

        }
        // North background Image function LN54 button.
        public void NorthImage()
        {
          BackgroundImage = Image.FromFile("Monbase Room.jpg");
        }
        // East background Image function LN59 button.
        public void EastImage()
        {
            BackgroundImage = Image.FromFile("EastRm.jpg");
        }
        // South background Image function LN64 button.
        public void SouthImage()
        {
            BackgroundImage = Image.FromFile("SouthRm.png");
            BackgroundImageLayout = ImageLayout.Stretch;
        }
        // West background Image function LN69 button.
        public void WestImage()
        {
            BackgroundImage = Image.FromFile("WestRm.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
        }
        public Form1()
        {
            InitializeComponent();
            //This will hide navigation button as default
            Navigation.Visible = false;
            // Background Image as default.
            BackgroundImage = Image.FromFile("Moonbase_Cover.png");
            Roomtxtbox.Visible = false;
            Descriptiontxtbx.Visible = false;
            RoomLabel.Visible = false;
            DescLabel.Visible = false;
            FeedbackGrpbx.Visible = false;
            FDBCKSgroupbox.Visible = false;
            Registergrpbox.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RN[0] = "North (New colonial settlers Room)";
            RN[1] = "East (Moonbase Internet Cafe)";
            RN[2] = "South (Moonbase Store)";
            RN[3] = "West (New colonial workplace office)";

            Dsc[0] = "Here is a modern room with cabinets, a sofa, and a bed on top. There is a ladder you can climb to get to your bed and this room also comes with mounted shelves, a rerading light, and also a view to see earth.\r\n\r\nThe second picture is a two story room, 3 beds and a ladder. The room will be loacet inderground of the moonbase.\r\n";
            Dsc[1] = "The east room is for entertainment. This includes internet, a cafe, and also a library, while your stay at the moonbase.";
            Dsc[2] = "Here in the South Area, you will be able shop all of the products as if you were on earth. Products range from food, clothes, electronics, and many more. South room makes you feel like you're back on earth.";
            Dsc[3] = "The West area is the work station where many moonbase colonizers will be working. You will wiva a view of earth, your own high-tech computer and a confy computer seat.";

        }
        // When button clicked North image function should appear with room & description label & textbox..
        private void button1_Click(object sender, EventArgs e)
        {
            NorthImage();
            RoomDescription();
            area Moonbase = new area(RN, Dsc);
            string room = Moonbase.getRoom(0);
            string description = Moonbase.getDescription(0);
            Roomtxtbox.Text = room;
            Descriptiontxtbx.Text = description;
            FeedbackGrpbx.Visible = true;
            FDBCKSgroupbox.Visible = false;
            Registergrpbox.Visible = false;

        }
        // When button clicked East image function should appear with room & description label & textbox..
        private void button2_Click(object sender, EventArgs e)
        {
            EastImage();
            RoomDescription();
            area Moonbase = new area(RN, Dsc);
            string room = Moonbase.getRoom(1);
            string description = Moonbase.getDescription(1);
            Roomtxtbox.Text = room;
            Descriptiontxtbx.Text = description;
            FeedbackGrpbx.Visible = false;
            FDBCKSgroupbox.Visible = false;
            Registergrpbox.Visible = true;

        }
        // When button clicked South image function should appear with room & description label & textbox..
        private void button3_Click(object sender, EventArgs e)
        {
            SouthImage();
            RoomDescription();
            
            area Moonbase = new area(RN, Dsc);
            string room = Moonbase.getRoom(2);
            string description = Moonbase.getDescription(2);
            Roomtxtbox.Text = room;
            Descriptiontxtbx.Text = description;
            FeedbackGrpbx.Visible = false;
            FDBCKSgroupbox.Visible= true;
            Registergrpbox.Visible = false;

        }
        // When button clicked West image function should appear with room & description label & textbox.
        private void button4_Click(object sender, EventArgs e)
        {
            WestImage();
            RoomDescription();
            area Moonbase = new area(RN, Dsc);
            string room = Moonbase.getRoom(3);
            string description = Moonbase.getDescription(3);
            Roomtxtbox.Text = room;
            Descriptiontxtbx.Text = description;
            FeedbackGrpbx.Visible = false;
            FDBCKSgroupbox.Visible = false;
            Registergrpbox.Visible = false;
        }
        /*
         When Start button is clicked. Navigation appears, background Image dissapears, 
         background becomes white, Intro text box, dissapears, and button also dissapears.
         */
        private void STARTbtn_Click(object sender, EventArgs e)
        {
            Navigation.Visible=true;
            BackgroundImage = null;
            BackColor = Color.White;
            INTROtxbx.Visible=false;
            STARTbtn.Visible=false;
        }

        private void FeedbackBtn_Click(object sender, EventArgs e)
        {
            OptionButton(GetText());
            

        }

        private void SOTHBTN_Click(object sender, EventArgs e)
        {
            OptionButton(GetText());
        }

        // Class registration used for register button.
        private void RGSTERbutton_Click(object sender, EventArgs e)
        {
            registration e1 = new registration(Fnametxtbox.Text, Lnametxtbox.Text, Emaltxtbx.Text);
            e1.display();
        }
    }
}

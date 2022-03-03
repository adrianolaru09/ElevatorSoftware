using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorSoftware_Adrian
{
    public partial class Form1 : Form
    {
        private int floorLevel = 0;
        
        private DataSet ds = new DataSet();
        private string dbconnection ;
        private string dbcommand;
        private OleDbConnection conn;
        private OleDbCommand comm;
        private OleDbDataAdapter adapter;
        private OleDbCommandBuilder builder;

        private DateTime localDate;
        private int states = 0;
        private int a = 0;
        private int down = 300;
        private int top = 50;
        private bool btn0Clicked;
        private bool btn1Clicked;
        private bool btnUpClicked;
        private bool btnDownClicked;
        public Form1()
        {
            InitializeComponent();
            //timer for elevator animation
            Timer tmr = new Timer();
            tmr.Interval = 200;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Start();
            //display the current floor
            lbl_Floor0.Text = floorLevel.ToString();
            lbl_Control.Text = floorLevel.ToString();
            lbl_Floor1.Text = floorLevel.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //database connection with dataset
            dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source= ElevatorLog.accdb ";
            dbcommand = " Select Part, ActionMove, DateOfAct from ElevatorLog;";
            try
            {
                conn = new OleDbConnection(dbconnection);
                comm = new OleDbCommand(dbcommand, conn);
                adapter = new OleDbDataAdapter(comm);
                load_db_to_ds();
                builder = new OleDbCommandBuilder(adapter);
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        void load_db_to_ds() //load data into dataset
        {
            try
            {
                adapter.Fill(ds); //fill dataset
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void reload_db_to_ds()   //force reload data into  dataset
        {
            ds.Clear();
            load_db_to_ds();
        }
        public void save_data_db()
        {
            try
            {
                //update db
                DataSet dataSetChanges = ds.GetChanges();
                adapter.Update(dataSetChanges);
                ds.AcceptChanges(); //accept changes
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void DisableButtons() //disable all buttons for elevator
        {
            btn_Down.Enabled = false;
            btn_Up.Enabled = false;
            btn_Floor0_panel.Enabled = false;
            btn_Floor1_panel.Enabled = false;
        }
        private void EnableButtons() // enable all buttons for elevator
        {
            btn_Down.Enabled = true;
            btn_Up.Enabled = true;
            btn_Floor0_panel.Enabled = true;
            btn_Floor1_panel.Enabled = true;
        }
        private void tmr_Tick(object sender , EventArgs e)
        {
            if(p_RightDoor.Top>top && (btn1Clicked == true || btnDownClicked==true) )  
            {          // move elevator to first floor if the call button is pressed        
                       // or if the button on the control panel it s pressed
                p_RightDoor.Top -= 10;
                p_LeftDoor.Top -= 10;
                DisableButtons();
            } else if (btn1Clicked == true || btnDownClicked == true)
            {
                btn1Clicked = false;
                btnDownClicked = false;
                System.Threading.Thread.Sleep(500);  // wait command
                OpenCloseDoors();
                EnableButtons();
            }
            if (p_RightDoor.Top < down && (btn0Clicked == true || btnUpClicked == true)) 
            {   //move elevator to ground floor if the call button is pressed
                //or if the button on the control panel is pressed
                p_RightDoor.Top += 10;
                p_LeftDoor.Top += 10;
                DisableButtons();
            }
            else if (btn0Clicked == true || btnUpClicked == true)
            {
                btn0Clicked = false;
                btnUpClicked = false;
                System.Threading.Thread.Sleep(500); // wait command
                OpenCloseDoors();
                EnableButtons();
            }
        }
        private void lbl_Floor0_Click(object sender, EventArgs e)
        {
        }
        private void lbl_ControlPanel_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void OpenCloseDoors() // open and close the doors
        {
                p_LeftDoor.Left -= 50;
                p_RightDoor.Left += 50;
                System.Threading.Thread.Sleep(1000); // wait command
                p_LeftDoor.Left += 50;
                p_RightDoor.Left -= 50;

        }
        private void btn_Up_Click(object sender, EventArgs e)
        {
            btn0Clicked = false;
            btn1Clicked = false;
            btnUpClicked = true;
            btnDownClicked = false;
            if (floorLevel == 1)
            {   //set the new floor level and display
                floorLevel = 0;
                lbl_Floor0.Text = floorLevel.ToString();
                lbl_Control.Text = floorLevel.ToString();
                lbl_Floor1.Text = floorLevel.ToString();
                System.Threading.Thread.Sleep(500);
            }
            states = 1; //set the action state for the elevator
            Insert_In_Log(); //insert into the database
        }
        private void btn_Down_Click(object sender, EventArgs e)
        {
            btn0Clicked = false;
            btn1Clicked = false;
            btnUpClicked = false;
            btnDownClicked = true;
            if (floorLevel == 0)
            {
                //set the new floor level and display
                floorLevel = 1;
                lbl_Floor0.Text = floorLevel.ToString();
                lbl_Control.Text = floorLevel.ToString();
                lbl_Floor1.Text = floorLevel.ToString();
                System.Threading.Thread.Sleep(500);
            }
            states = 2; //set the action state for the elevator
            Insert_In_Log(); //insert into the database
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void p_RightDoor_Click(object sender, EventArgs e)
        {
        }
        private void lbl_Floor1_Click(object sender, EventArgs e)
        {
        }
        private void btn_Floor0_panel_Click(object sender, EventArgs e)
        {
            btn0Clicked = true;
            btn1Clicked = false;
            btnUpClicked = false;
            btnDownClicked = false;
            //set the new floor level and display
            floorLevel = 0;
            lbl_Floor0.Text = floorLevel.ToString();
            lbl_Control.Text = floorLevel.ToString();
            lbl_Floor1.Text = floorLevel.ToString();
            states = 3; //set the action state for the elevator
            Insert_In_Log(); //insert into the database
        }
        private void btn_Floor1_panel_Click(object sender, EventArgs e)
        {
            btn0Clicked = false;
            btn1Clicked = true;
            btnUpClicked = false;
            btnDownClicked = false;
            //set the new floor level and display
            floorLevel = 1;
            lbl_Floor0.Text = floorLevel.ToString();
            lbl_Control.Text = floorLevel.ToString();
            lbl_Floor1.Text = floorLevel.ToString();
            states = 4; //set the action state for the elevator
            Insert_In_Log(); //insert into the database
        }
        void Insert_In_Log() //insert into the database
        {
            localDate = DateTime.Now; // get the current system date and time
            //defining a new row and placing it into a new data row
            DataRow newRow = ds.Tables[0].NewRow();
            //get the last id (primary key) from the dataset
            object lastID;// key number(primary key) updates each time so it's unique
            if (ds.Tables[0].Rows.Count == 0)
            {
                 lastID = 0;
            }
            else
            {
                 lastID = ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1]["Part"];
            }
            a++; 
            newRow["Part"] = Convert.ToInt32(lastID) + 1;
            //different elevator actions set by the states
            switch(states)
            {
                case 1:
                    newRow["ActionMove"] = " Elevator called at ground floor at: ";
                    break;
                case 2:
                    newRow["ActionMove"] = " Elevator called at first floor at: ";
                    break;
                case 3:
                    newRow["ActionMove"] = " Elevator going to ground floor at: ";
                    break;
                case 4:
                    newRow["ActionMove"] = " Elevator going to first floor at: ";
                    break;
            } 
            newRow["DateOfAct"] = localDate.ToString() ;
            //add the new dataRow to dataTable
            ds.Tables[0].Rows.Add(newRow);
            save_data_db();
            listbox_update();
        }
        public void listbox_update()
        {
            lst_Events.Items.Clear(); // clear listbox before update
            foreach (DataRow row in ds.Tables[0].Rows) //update listbox
            {
                lst_Events.Items.Add(row["Part"] + " " + row["ActionMove"] + " (" + row["DateOfAct"] + ") ");
            }
        }
        private void btn_LoadEvents_Click(object sender, EventArgs e) 
        {   // display database in the listbox
            reload_db_to_ds();
            listbox_update();
        }
        private void btn_ClearLog_Click(object sender, EventArgs e)
        {
            lst_Events.Items.Clear(); // clear listbox
        }
        private void lst_Events_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void Floor1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}

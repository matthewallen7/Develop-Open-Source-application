using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Develop_Open_Source_application
{
    public partial class Dashboard : Form
    {
        int vehicleNo;
        Vehicle[] Vehicles = new Vehicle[6];
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "1234" && txt_Password.Text == "1234")
            {
                MessageBox.Show("You have logged in! :)");
                TabC.SelectTab(1);
                TP_Dashboard.Enabled = true;
                TP_Rental.Enabled = true;
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect! :(");
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Vehicles[0] = new Vehicle("Ford", "Fiesta", 2017, "1ABC777", 100569, "5.8 L/100km", "Red", 10, "Y");
            Vehicles[1] = new Vehicle("Ford", "Focus", 2017, "2DFG987", 94397, "6.4L/100km", "Silver", 9, "N");
            Vehicles[2] = new Vehicle("Ford", "Mondeo", 2018, "3TYH092", 20308, "8.5 L/100km", "Black", 2, "N");
            Vehicles[3] = new Vehicle("Audi", "TTS", 2018, "1BST112", 0, "6.6 L/100km", "Black", 0, "N");
            Vehicles[4] = new Vehicle("Audi", "Q5", 2017, "2BST112", 56195, "5.3 L/100km", "Silver", 5, "Y");
            Vehicles[5] = new Vehicle("Audi", "R8", 2018, "1BST111", 0, "11.42 L/100km", "Black", 0, "N");
            for (int i = 0; i < Vehicles.Length; i++)
            {
                if (Vehicles[i].Manufacturer != null)
                {
                    string Name = Vehicles[i].Manufacturer + " " + Vehicles[i].Model + " " + Vehicles[i].MakeYear;
                    LB_Vehicles.Items.Add(Name);
                }
            }
            TP_Dashboard.Enabled = false;
            TP_Rental.Enabled = false;
        }

        private void LB_Vehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Vehicles.Length; i++)
            {
                string Name = Vehicles[i].Manufacturer + " " + Vehicles[i].Model + " " + Vehicles[i].MakeYear;
                if (LB_Vehicles.SelectedItem.ToString() == Name)
                {
                    txt_Capacity.Text = Vehicles[i].TankCapactiy;
                    txt_Colour.Text = Vehicles[i].Colour;
                    txt_Manufacturer.Text = Vehicles[i].Manufacturer;
                    txt_Model.Text = Vehicles[i].Model;
                    txt_Rego.Text = Vehicles[i].RegoNo;
                    txt_OdometerReading.Text = Convert.ToString(Vehicles[i].TotalKm);
                    txt_Year.Text = Convert.ToString(Vehicles[i].MakeYear);
                    txt_TotalServices.Text = Convert.ToString(Vehicles[i].Services);
                    txt_CheckService.Text = Vehicles[i].Checkservice;
                    lbl_RentalManu.Text = Vehicles[i].Manufacturer;
                    lbl_RentalModel.Text = Vehicles[i].Model;
                    lbl_RentalRego.Text = Vehicles[i].RegoNo;
                    vehicleNo = i;
                }
            }
        }

        private void btn_CalcDifference_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            Cost cost = new Cost();
            double diff = vehicle.addKilometers(Vehicles[vehicleNo].TotalKm, Convert.ToUInt32(txt_TotalOdometer.Text));
            string str = cost.CalcCost(diff);
            txt_Pay.Text = str;
            double checkprice = Convert.ToDouble(diff);
            if (checkprice <= 0)
            {
                MessageBox.Show("Incorrect Details");
                txt_Pay.Text = "";
                txt_TotalOdometer.Text = "";
                txt_NeedService.Text = "";
            }
            else
            {
                Service service = new Service();
                string serv = service.recordService(Vehicles[vehicleNo].Services, Convert.ToDouble(txt_TotalOdometer.Text));
                txt_NeedService.Text = serv;
            }         
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            try
            {
                Vehicle vehicle = new Vehicle();
                Journey journey = new Journey();
                double total = journey.addKilometers(Convert.ToInt32(txt_TotalOdometer.Text));
                Vehicles[vehicleNo].TotalKm = total;
                Vehicles[vehicleNo].Checkservice = txt_NeedService.Text;
                double diff = vehicle.addKilometers(Vehicles[vehicleNo].TotalKm, Convert.ToUInt32(txt_TotalOdometer.Text));
                string output = vehicle.printDetails(Vehicles[vehicleNo].Manufacturer, Vehicles[vehicleNo].Model, Vehicles[vehicleNo].MakeYear, Vehicles[vehicleNo].RegoNo, Vehicles[vehicleNo].TankCapactiy, Vehicles[vehicleNo].Colour, txt_OdometerReading.Text, diff, Vehicles[vehicleNo].Services, txt_Pay.Text, Vehicles[vehicleNo].Checkservice);
                Console.WriteLine(output);
                TabC.SelectTab(1);
                LB_Vehicles.Items.Clear();
                for (int i = 0; i < Vehicles.Length; i++)
                {
                    txt_Capacity.Text = Vehicles[i].TankCapactiy;
                    txt_Colour.Text = Vehicles[i].Colour;
                    txt_Manufacturer.Text = Vehicles[i].Manufacturer;
                    txt_Model.Text = Vehicles[i].Model;
                    txt_Rego.Text = Vehicles[i].RegoNo;
                    txt_OdometerReading.Text = Convert.ToString(Vehicles[i].TotalKm);
                    txt_Year.Text = Convert.ToString(Vehicles[i].MakeYear);
                    txt_TotalServices.Text = Convert.ToString(Vehicles[i].Services);
                    txt_CheckService.Text = Vehicles[i].Checkservice;
                    lbl_RentalManu.Text = Vehicles[i].Manufacturer;
                    lbl_RentalModel.Text = Vehicles[i].Model;
                    lbl_RentalRego.Text = Vehicles[i].RegoNo;
                    string Name = Vehicles[i].Manufacturer + " " + Vehicles[i].Model + " " + Vehicles[i].MakeYear;
                    LB_Vehicles.Items.Add(Name);
                }
                txt_Capacity.Text = "";
                txt_CheckService.Text = "";
                txt_Colour.Text = "";
                txt_Manufacturer.Text = "";
                txt_Model.Text = "";
                txt_NeedService.Text = "";
                txt_OdometerReading.Text = "";
                txt_Pay.Text = "";
                txt_Rego.Text = "";
                txt_TotalOdometer.Text = "";
                txt_TotalServices.Text = "";
                txt_Year.Text = "";
                lbl_RentalManu.Text = "Manufacturer";
                lbl_RentalModel.Text = "Model";
                lbl_RentalRego.Text = "RegoNo";
                vehicleNo = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect Details");
            }        
        }

        private void btn_CheckIn_Click(object sender, EventArgs e)
        {
            TabC.SelectTab(2);
        }

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            if (LB_Vehicles.SelectedItem != null)
            {
                if (txt_CheckService.Text == "N")
                {
                    MessageBox.Show("Enjoy your rental car");
                }
                else
                {
                    MessageBox.Show("This car is due for service");
                }
            }
            else
            {
                MessageBox.Show("Please select are car");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            if (txt_CheckService.Text == "N")
            {
                MessageBox.Show("This car doesn't need a service");
            }
            if (txt_CheckService.Text == "Y")
            {
                int count = Vehicles[vehicleNo].Services;
                int newserv = service.getServiceCount(count);
                Vehicles[vehicleNo].Services = newserv;
                txt_TotalServices.Text = newserv.ToString();
                txt_CheckService.Text = "N";
                Vehicles[vehicleNo].Checkservice = txt_CheckService.Text;
            }
        }
    }
}

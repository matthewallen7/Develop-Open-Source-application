namespace Develop_Open_Source_application
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabC = new System.Windows.Forms.TabControl();
            this.TP_Login = new System.Windows.Forms.TabPage();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.TP_Dashboard = new System.Windows.Forms.TabPage();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_CheckOut = new System.Windows.Forms.Button();
            this.txt_TotalServices = new System.Windows.Forms.TextBox();
            this.txt_CheckService = new System.Windows.Forms.TextBox();
            this.lbl_totalServices = new System.Windows.Forms.Label();
            this.lbl_CheckServices = new System.Windows.Forms.Label();
            this.txt_OdometerReading = new System.Windows.Forms.TextBox();
            this.txt_Capacity = new System.Windows.Forms.TextBox();
            this.txt_Colour = new System.Windows.Forms.TextBox();
            this.txt_Year = new System.Windows.Forms.TextBox();
            this.txt_Rego = new System.Windows.Forms.TextBox();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.txt_Manufacturer = new System.Windows.Forms.TextBox();
            this.lbl_TankCapactiy = new System.Windows.Forms.Label();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.lbl_Manufacturer = new System.Windows.Forms.Label();
            this.lbl_Colour = new System.Windows.Forms.Label();
            this.lbl_Registration = new System.Windows.Forms.Label();
            this.lbl_Odometer = new System.Windows.Forms.Label();
            this.LB_Vehicles = new System.Windows.Forms.ListBox();
            this.btn_CheckIn = new System.Windows.Forms.Button();
            this.TP_Rental = new System.Windows.Forms.TabPage();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.lbl_Pay = new System.Windows.Forms.Label();
            this.txt_Pay = new System.Windows.Forms.TextBox();
            this.lbl_NeedService = new System.Windows.Forms.Label();
            this.txt_NeedService = new System.Windows.Forms.TextBox();
            this.btn_CalcDifference = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TotalOdometer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_RentalTitle = new System.Windows.Forms.Label();
            this.lbl_RentalRego = new System.Windows.Forms.Label();
            this.lbl_RentalModel = new System.Windows.Forms.Label();
            this.lbl_RentalManu = new System.Windows.Forms.Label();
            this.TabC.SuspendLayout();
            this.TP_Login.SuspendLayout();
            this.TP_Dashboard.SuspendLayout();
            this.TP_Rental.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabC
            // 
            this.TabC.Controls.Add(this.TP_Login);
            this.TabC.Controls.Add(this.TP_Dashboard);
            this.TabC.Controls.Add(this.TP_Rental);
            this.TabC.Location = new System.Drawing.Point(1, 1);
            this.TabC.Name = "TabC";
            this.TabC.SelectedIndex = 0;
            this.TabC.Size = new System.Drawing.Size(776, 426);
            this.TabC.TabIndex = 2;
            // 
            // TP_Login
            // 
            this.TP_Login.BackColor = System.Drawing.Color.Aquamarine;
            this.TP_Login.Controls.Add(this.lbl_Password);
            this.TP_Login.Controls.Add(this.lbl_Username);
            this.TP_Login.Controls.Add(this.lbl_Login);
            this.TP_Login.Controls.Add(this.btn_Login);
            this.TP_Login.Controls.Add(this.txt_Password);
            this.TP_Login.Controls.Add(this.txt_Username);
            this.TP_Login.Location = new System.Drawing.Point(4, 25);
            this.TP_Login.Name = "TP_Login";
            this.TP_Login.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Login.Size = new System.Drawing.Size(768, 397);
            this.TP_Login.TabIndex = 0;
            this.TP_Login.Text = "Login";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(82, 181);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(131, 29);
            this.lbl_Password.TabIndex = 5;
            this.lbl_Password.Text = "Password:";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(82, 127);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(137, 29);
            this.lbl_Username.TabIndex = 4;
            this.lbl_Username.Text = "Username:";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.Location = new System.Drawing.Point(322, 18);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(110, 42);
            this.lbl_Login.TabIndex = 3;
            this.lbl_Login.Text = "Login";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Login.FlatAppearance.BorderSize = 2;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Location = new System.Drawing.Point(286, 264);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(173, 33);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(286, 181);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(173, 26);
            this.txt_Password.TabIndex = 1;
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(286, 127);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(173, 26);
            this.txt_Username.TabIndex = 0;
            // 
            // TP_Dashboard
            // 
            this.TP_Dashboard.BackColor = System.Drawing.Color.Cyan;
            this.TP_Dashboard.Controls.Add(this.btn_Update);
            this.TP_Dashboard.Controls.Add(this.btn_CheckOut);
            this.TP_Dashboard.Controls.Add(this.txt_TotalServices);
            this.TP_Dashboard.Controls.Add(this.txt_CheckService);
            this.TP_Dashboard.Controls.Add(this.lbl_totalServices);
            this.TP_Dashboard.Controls.Add(this.lbl_CheckServices);
            this.TP_Dashboard.Controls.Add(this.txt_OdometerReading);
            this.TP_Dashboard.Controls.Add(this.txt_Capacity);
            this.TP_Dashboard.Controls.Add(this.txt_Colour);
            this.TP_Dashboard.Controls.Add(this.txt_Year);
            this.TP_Dashboard.Controls.Add(this.txt_Rego);
            this.TP_Dashboard.Controls.Add(this.txt_Model);
            this.TP_Dashboard.Controls.Add(this.txt_Manufacturer);
            this.TP_Dashboard.Controls.Add(this.lbl_TankCapactiy);
            this.TP_Dashboard.Controls.Add(this.lbl_Year);
            this.TP_Dashboard.Controls.Add(this.lbl_Model);
            this.TP_Dashboard.Controls.Add(this.lbl_Manufacturer);
            this.TP_Dashboard.Controls.Add(this.lbl_Colour);
            this.TP_Dashboard.Controls.Add(this.lbl_Registration);
            this.TP_Dashboard.Controls.Add(this.lbl_Odometer);
            this.TP_Dashboard.Controls.Add(this.LB_Vehicles);
            this.TP_Dashboard.Controls.Add(this.btn_CheckIn);
            this.TP_Dashboard.Location = new System.Drawing.Point(4, 25);
            this.TP_Dashboard.Name = "TP_Dashboard";
            this.TP_Dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Dashboard.Size = new System.Drawing.Size(768, 397);
            this.TP_Dashboard.TabIndex = 1;
            this.TP_Dashboard.Text = "Dashboard";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(655, 351);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(100, 33);
            this.btn_Update.TabIndex = 22;
            this.btn_Update.Text = "Service";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CheckOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_CheckOut.Location = new System.Drawing.Point(17, 313);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.Size = new System.Drawing.Size(241, 30);
            this.btn_CheckOut.TabIndex = 21;
            this.btn_CheckOut.Text = "Check Out";
            this.btn_CheckOut.UseVisualStyleBackColor = false;
            this.btn_CheckOut.Click += new System.EventHandler(this.btn_CheckOut_Click);
            // 
            // txt_TotalServices
            // 
            this.txt_TotalServices.Location = new System.Drawing.Point(475, 323);
            this.txt_TotalServices.Name = "txt_TotalServices";
            this.txt_TotalServices.Size = new System.Drawing.Size(100, 22);
            this.txt_TotalServices.TabIndex = 20;
            // 
            // txt_CheckService
            // 
            this.txt_CheckService.Location = new System.Drawing.Point(475, 361);
            this.txt_CheckService.Name = "txt_CheckService";
            this.txt_CheckService.ReadOnly = true;
            this.txt_CheckService.Size = new System.Drawing.Size(100, 22);
            this.txt_CheckService.TabIndex = 19;
            // 
            // lbl_totalServices
            // 
            this.lbl_totalServices.AutoSize = true;
            this.lbl_totalServices.Location = new System.Drawing.Point(311, 326);
            this.lbl_totalServices.Name = "lbl_totalServices";
            this.lbl_totalServices.Size = new System.Drawing.Size(102, 17);
            this.lbl_totalServices.TabIndex = 18;
            this.lbl_totalServices.Text = "Total Services:";
            // 
            // lbl_CheckServices
            // 
            this.lbl_CheckServices.AutoSize = true;
            this.lbl_CheckServices.Location = new System.Drawing.Point(311, 364);
            this.lbl_CheckServices.Name = "lbl_CheckServices";
            this.lbl_CheckServices.Size = new System.Drawing.Size(118, 17);
            this.lbl_CheckServices.TabIndex = 17;
            this.lbl_CheckServices.Text = "Needs a service?";
            // 
            // txt_OdometerReading
            // 
            this.txt_OdometerReading.Location = new System.Drawing.Point(475, 283);
            this.txt_OdometerReading.Name = "txt_OdometerReading";
            this.txt_OdometerReading.Size = new System.Drawing.Size(100, 22);
            this.txt_OdometerReading.TabIndex = 16;
            // 
            // txt_Capacity
            // 
            this.txt_Capacity.Location = new System.Drawing.Point(475, 242);
            this.txt_Capacity.Name = "txt_Capacity";
            this.txt_Capacity.Size = new System.Drawing.Size(100, 22);
            this.txt_Capacity.TabIndex = 15;
            // 
            // txt_Colour
            // 
            this.txt_Colour.Location = new System.Drawing.Point(475, 196);
            this.txt_Colour.Name = "txt_Colour";
            this.txt_Colour.Size = new System.Drawing.Size(100, 22);
            this.txt_Colour.TabIndex = 14;
            // 
            // txt_Year
            // 
            this.txt_Year.Location = new System.Drawing.Point(475, 152);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(100, 22);
            this.txt_Year.TabIndex = 13;
            // 
            // txt_Rego
            // 
            this.txt_Rego.Location = new System.Drawing.Point(475, 111);
            this.txt_Rego.Name = "txt_Rego";
            this.txt_Rego.Size = new System.Drawing.Size(100, 22);
            this.txt_Rego.TabIndex = 12;
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(475, 69);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(100, 22);
            this.txt_Model.TabIndex = 11;
            // 
            // txt_Manufacturer
            // 
            this.txt_Manufacturer.Location = new System.Drawing.Point(475, 24);
            this.txt_Manufacturer.Name = "txt_Manufacturer";
            this.txt_Manufacturer.Size = new System.Drawing.Size(100, 22);
            this.txt_Manufacturer.TabIndex = 10;
            // 
            // lbl_TankCapactiy
            // 
            this.lbl_TankCapactiy.AutoSize = true;
            this.lbl_TankCapactiy.Location = new System.Drawing.Point(311, 247);
            this.lbl_TankCapactiy.Name = "lbl_TankCapactiy";
            this.lbl_TankCapactiy.Size = new System.Drawing.Size(62, 17);
            this.lbl_TankCapactiy.TabIndex = 9;
            this.lbl_TankCapactiy.Text = "Capactiy";
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Location = new System.Drawing.Point(311, 155);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(38, 17);
            this.lbl_Year.TabIndex = 8;
            this.lbl_Year.Text = "Year";
            // 
            // lbl_Model
            // 
            this.lbl_Model.AutoSize = true;
            this.lbl_Model.Location = new System.Drawing.Point(311, 74);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(46, 17);
            this.lbl_Model.TabIndex = 7;
            this.lbl_Model.Text = "Model";
            // 
            // lbl_Manufacturer
            // 
            this.lbl_Manufacturer.AutoSize = true;
            this.lbl_Manufacturer.Location = new System.Drawing.Point(311, 29);
            this.lbl_Manufacturer.Name = "lbl_Manufacturer";
            this.lbl_Manufacturer.Size = new System.Drawing.Size(92, 17);
            this.lbl_Manufacturer.TabIndex = 6;
            this.lbl_Manufacturer.Text = "Manufacturer";
            // 
            // lbl_Colour
            // 
            this.lbl_Colour.AutoSize = true;
            this.lbl_Colour.Location = new System.Drawing.Point(311, 199);
            this.lbl_Colour.Name = "lbl_Colour";
            this.lbl_Colour.Size = new System.Drawing.Size(49, 17);
            this.lbl_Colour.TabIndex = 5;
            this.lbl_Colour.Text = "Colour";
            // 
            // lbl_Registration
            // 
            this.lbl_Registration.AutoSize = true;
            this.lbl_Registration.Location = new System.Drawing.Point(311, 114);
            this.lbl_Registration.Name = "lbl_Registration";
            this.lbl_Registration.Size = new System.Drawing.Size(84, 17);
            this.lbl_Registration.TabIndex = 4;
            this.lbl_Registration.Text = "Registration";
            // 
            // lbl_Odometer
            // 
            this.lbl_Odometer.AutoSize = true;
            this.lbl_Odometer.Location = new System.Drawing.Point(311, 288);
            this.lbl_Odometer.Name = "lbl_Odometer";
            this.lbl_Odometer.Size = new System.Drawing.Size(75, 17);
            this.lbl_Odometer.TabIndex = 3;
            this.lbl_Odometer.Text = "Odometer:";
            // 
            // LB_Vehicles
            // 
            this.LB_Vehicles.BackColor = System.Drawing.Color.LightCyan;
            this.LB_Vehicles.FormattingEnabled = true;
            this.LB_Vehicles.ItemHeight = 16;
            this.LB_Vehicles.Location = new System.Drawing.Point(17, 29);
            this.LB_Vehicles.Name = "LB_Vehicles";
            this.LB_Vehicles.Size = new System.Drawing.Size(241, 276);
            this.LB_Vehicles.TabIndex = 2;
            this.LB_Vehicles.SelectedIndexChanged += new System.EventHandler(this.LB_Vehicles_SelectedIndexChanged);
            // 
            // btn_CheckIn
            // 
            this.btn_CheckIn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CheckIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_CheckIn.Location = new System.Drawing.Point(17, 351);
            this.btn_CheckIn.Name = "btn_CheckIn";
            this.btn_CheckIn.Size = new System.Drawing.Size(241, 30);
            this.btn_CheckIn.TabIndex = 1;
            this.btn_CheckIn.Text = "Check In";
            this.btn_CheckIn.UseVisualStyleBackColor = false;
            this.btn_CheckIn.Click += new System.EventHandler(this.btn_CheckIn_Click);
            // 
            // TP_Rental
            // 
            this.TP_Rental.BackColor = System.Drawing.Color.Cyan;
            this.TP_Rental.Controls.Add(this.btn_Pay);
            this.TP_Rental.Controls.Add(this.lbl_Pay);
            this.TP_Rental.Controls.Add(this.txt_Pay);
            this.TP_Rental.Controls.Add(this.lbl_NeedService);
            this.TP_Rental.Controls.Add(this.txt_NeedService);
            this.TP_Rental.Controls.Add(this.btn_CalcDifference);
            this.TP_Rental.Controls.Add(this.label2);
            this.TP_Rental.Controls.Add(this.txt_TotalOdometer);
            this.TP_Rental.Controls.Add(this.label1);
            this.TP_Rental.Controls.Add(this.lbl_RentalTitle);
            this.TP_Rental.Controls.Add(this.lbl_RentalRego);
            this.TP_Rental.Controls.Add(this.lbl_RentalModel);
            this.TP_Rental.Controls.Add(this.lbl_RentalManu);
            this.TP_Rental.Location = new System.Drawing.Point(4, 25);
            this.TP_Rental.Name = "TP_Rental";
            this.TP_Rental.Size = new System.Drawing.Size(768, 397);
            this.TP_Rental.TabIndex = 3;
            this.TP_Rental.Text = "Rental";
            // 
            // btn_Pay
            // 
            this.btn_Pay.Location = new System.Drawing.Point(655, 347);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(100, 25);
            this.btn_Pay.TabIndex = 12;
            this.btn_Pay.Text = "Pay";
            this.btn_Pay.UseVisualStyleBackColor = true;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // lbl_Pay
            // 
            this.lbl_Pay.AutoSize = true;
            this.lbl_Pay.Location = new System.Drawing.Point(542, 322);
            this.lbl_Pay.Name = "lbl_Pay";
            this.lbl_Pay.Size = new System.Drawing.Size(60, 17);
            this.lbl_Pay.TabIndex = 11;
            this.lbl_Pay.Text = "Amount:";
            // 
            // txt_Pay
            // 
            this.txt_Pay.Location = new System.Drawing.Point(655, 319);
            this.txt_Pay.Name = "txt_Pay";
            this.txt_Pay.Size = new System.Drawing.Size(100, 22);
            this.txt_Pay.TabIndex = 10;
            // 
            // lbl_NeedService
            // 
            this.lbl_NeedService.AutoSize = true;
            this.lbl_NeedService.Location = new System.Drawing.Point(9, 289);
            this.lbl_NeedService.Name = "lbl_NeedService";
            this.lbl_NeedService.Size = new System.Drawing.Size(101, 17);
            this.lbl_NeedService.TabIndex = 9;
            this.lbl_NeedService.Text = "Need Service?";
            // 
            // txt_NeedService
            // 
            this.txt_NeedService.Location = new System.Drawing.Point(122, 286);
            this.txt_NeedService.Name = "txt_NeedService";
            this.txt_NeedService.Size = new System.Drawing.Size(100, 22);
            this.txt_NeedService.TabIndex = 8;
            // 
            // btn_CalcDifference
            // 
            this.btn_CalcDifference.Location = new System.Drawing.Point(122, 225);
            this.btn_CalcDifference.Name = "btn_CalcDifference";
            this.btn_CalcDifference.Size = new System.Drawing.Size(100, 23);
            this.btn_CalcDifference.TabIndex = 7;
            this.btn_CalcDifference.Text = "Submit";
            this.btn_CalcDifference.UseVisualStyleBackColor = true;
            this.btn_CalcDifference.Click += new System.EventHandler(this.btn_CalcDifference_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rental Information:";
            // 
            // txt_TotalOdometer
            // 
            this.txt_TotalOdometer.Location = new System.Drawing.Point(122, 197);
            this.txt_TotalOdometer.Name = "txt_TotalOdometer";
            this.txt_TotalOdometer.Size = new System.Drawing.Size(100, 22);
            this.txt_TotalOdometer.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Odometer:";
            // 
            // lbl_RentalTitle
            // 
            this.lbl_RentalTitle.AutoSize = true;
            this.lbl_RentalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RentalTitle.Location = new System.Drawing.Point(311, 15);
            this.lbl_RentalTitle.Name = "lbl_RentalTitle";
            this.lbl_RentalTitle.Size = new System.Drawing.Size(126, 42);
            this.lbl_RentalTitle.TabIndex = 3;
            this.lbl_RentalTitle.Text = "Rental";
            // 
            // lbl_RentalRego
            // 
            this.lbl_RentalRego.AutoSize = true;
            this.lbl_RentalRego.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RentalRego.Location = new System.Drawing.Point(7, 105);
            this.lbl_RentalRego.Name = "lbl_RentalRego";
            this.lbl_RentalRego.Size = new System.Drawing.Size(121, 25);
            this.lbl_RentalRego.TabIndex = 2;
            this.lbl_RentalRego.Text = "Regestration";
            // 
            // lbl_RentalModel
            // 
            this.lbl_RentalModel.AutoSize = true;
            this.lbl_RentalModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RentalModel.Location = new System.Drawing.Point(7, 69);
            this.lbl_RentalModel.Name = "lbl_RentalModel";
            this.lbl_RentalModel.Size = new System.Drawing.Size(66, 25);
            this.lbl_RentalModel.TabIndex = 1;
            this.lbl_RentalModel.Text = "Model";
            // 
            // lbl_RentalManu
            // 
            this.lbl_RentalManu.AutoSize = true;
            this.lbl_RentalManu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RentalManu.Location = new System.Drawing.Point(7, 30);
            this.lbl_RentalManu.Name = "lbl_RentalManu";
            this.lbl_RentalManu.Size = new System.Drawing.Size(127, 25);
            this.lbl_RentalManu.TabIndex = 0;
            this.lbl_RentalManu.Text = "Manufacturer";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(772, 421);
            this.Controls.Add(this.TabC);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.TabC.ResumeLayout(false);
            this.TP_Login.ResumeLayout(false);
            this.TP_Login.PerformLayout();
            this.TP_Dashboard.ResumeLayout(false);
            this.TP_Dashboard.PerformLayout();
            this.TP_Rental.ResumeLayout(false);
            this.TP_Rental.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabC;
        private System.Windows.Forms.TabPage TP_Login;
        private System.Windows.Forms.TabPage TP_Dashboard;
        private System.Windows.Forms.Button btn_CheckIn;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.Label lbl_Model;
        private System.Windows.Forms.Label lbl_Manufacturer;
        private System.Windows.Forms.Label lbl_Colour;
        private System.Windows.Forms.Label lbl_Registration;
        private System.Windows.Forms.Label lbl_Odometer;
        private System.Windows.Forms.ListBox LB_Vehicles;
        private System.Windows.Forms.Label lbl_TankCapactiy;
        private System.Windows.Forms.TextBox txt_OdometerReading;
        private System.Windows.Forms.TextBox txt_Capacity;
        private System.Windows.Forms.TextBox txt_Colour;
        private System.Windows.Forms.TextBox txt_Year;
        private System.Windows.Forms.TextBox txt_Rego;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.TextBox txt_Manufacturer;
        private System.Windows.Forms.TabPage TP_Rental;
        private System.Windows.Forms.Label lbl_RentalTitle;
        private System.Windows.Forms.Label lbl_RentalRego;
        private System.Windows.Forms.Label lbl_RentalModel;
        private System.Windows.Forms.Label lbl_RentalManu;
        private System.Windows.Forms.TextBox txt_TotalOdometer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TotalServices;
        private System.Windows.Forms.TextBox txt_CheckService;
        private System.Windows.Forms.Label lbl_totalServices;
        private System.Windows.Forms.Label lbl_CheckServices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_CalcDifference;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.Label lbl_Pay;
        private System.Windows.Forms.TextBox txt_Pay;
        private System.Windows.Forms.Label lbl_NeedService;
        private System.Windows.Forms.TextBox txt_NeedService;
        private System.Windows.Forms.Button btn_CheckOut;
        private System.Windows.Forms.Button btn_Update;
    }
}


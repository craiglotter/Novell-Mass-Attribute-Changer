using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Novell.Directory.Ldap;
using vbAccelerator.Components.Shell;



namespace Novell_Mass_Attribute_Changer
{
	/// <summary>
	/// Summary description for Main_Screen.
	/// </summary>
	public class Main_Screen : System.Windows.Forms.Form
	{
		private SysTray sysTray;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox SearchContext;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox SearchParameter;
		private System.Windows.Forms.Label resultsreturned;
		private System.Windows.Forms.ImageList ilsIcons;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox Password;
		private System.Windows.Forms.ComboBox Context;
		private System.Windows.Forms.TextBox Username;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox ModifyAction;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox savefilename;
		private System.Windows.Forms.TextBox attributevalue;
		private System.Windows.Forms.TextBox attributetoalter;
		private System.Windows.Forms.CheckBox showerror;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label Statusbar;
		private System.Windows.Forms.RichTextBox label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label19;
		private System.ComponentModel.IContainer components;

		public Main_Screen()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Screen));
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchContext = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SearchParameter = new System.Windows.Forms.TextBox();
            this.resultsreturned = new System.Windows.Forms.Label();
            this.ilsIcons = new System.Windows.Forms.ImageList(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Context = new System.Windows.Forms.ComboBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.attributevalue = new System.Windows.Forms.TextBox();
            this.attributetoalter = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ModifyAction = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.savefilename = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.showerror = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Statusbar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(592, 44);
            this.label5.TabIndex = 7;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(112, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "PROCESS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchContext
            // 
            this.SearchContext.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchContext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchContext.ForeColor = System.Drawing.Color.Black;
            this.SearchContext.Location = new System.Drawing.Point(16, 24);
            this.SearchContext.Name = "SearchContext";
            this.SearchContext.Size = new System.Drawing.Size(200, 20);
            this.SearchContext.TabIndex = 15;
            this.SearchContext.Text = "Students.com.main.uct";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(224, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "SEARCH CONTEXT";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(224, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "SEARCH PARAMETER";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchParameter
            // 
            this.SearchParameter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchParameter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchParameter.ForeColor = System.Drawing.Color.Black;
            this.SearchParameter.Location = new System.Drawing.Point(16, 48);
            this.SearchParameter.Name = "SearchParameter";
            this.SearchParameter.Size = new System.Drawing.Size(200, 20);
            this.SearchParameter.TabIndex = 17;
            this.SearchParameter.Text = "CN=*";
            // 
            // resultsreturned
            // 
            this.resultsreturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsreturned.ForeColor = System.Drawing.Color.Firebrick;
            this.resultsreturned.Location = new System.Drawing.Point(376, 344);
            this.resultsreturned.Name = "resultsreturned";
            this.resultsreturned.Size = new System.Drawing.Size(200, 16);
            this.resultsreturned.TabIndex = 19;
            this.resultsreturned.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ilsIcons
            // 
            this.ilsIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsIcons.ImageStream")));
            this.ilsIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsIcons.Images.SetKeyName(0, "");
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox1.Items.AddRange(new object[] {
            "Students.com.main.uct",
            "Staff.com.main.uct",
            "com.main.uct"});
            this.comboBox1.Location = new System.Drawing.Point(24, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.Text = "Students.com.main.uct";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "CONTEXT QUICK SELECTOR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(16, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 56);
            this.panel1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(224, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "USER CONTEXT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(224, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "NETWORK PASSWORD";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(224, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "LOGIN NAME";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.ForeColor = System.Drawing.Color.Black;
            this.Password.Location = new System.Drawing.Point(16, 48);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(200, 20);
            this.Password.TabIndex = 24;
            // 
            // Context
            // 
            this.Context.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Context.ForeColor = System.Drawing.Color.Black;
            this.Context.Items.AddRange(new object[] {
            "com.main.uct",
            "Staff.com.main.uct",
            "Students.com.main.uct"});
            this.Context.Location = new System.Drawing.Point(16, 72);
            this.Context.Name = "Context";
            this.Context.Size = new System.Drawing.Size(200, 21);
            this.Context.Sorted = true;
            this.Context.TabIndex = 25;
            this.Context.SelectedIndexChanged += new System.EventHandler(this.Context_SelectedIndexChanged);
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username.ForeColor = System.Drawing.Color.Black;
            this.Username.Location = new System.Drawing.Point(16, 24);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(200, 20);
            this.Username.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(16, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 23);
            this.panel3.TabIndex = 29;
            // 
            // attributevalue
            // 
            this.attributevalue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.attributevalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attributevalue.ForeColor = System.Drawing.Color.Black;
            this.attributevalue.Location = new System.Drawing.Point(16, 48);
            this.attributevalue.Name = "attributevalue";
            this.attributevalue.Size = new System.Drawing.Size(136, 20);
            this.attributevalue.TabIndex = 31;
            this.attributevalue.Text = "0";
            // 
            // attributetoalter
            // 
            this.attributetoalter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.attributetoalter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attributetoalter.ForeColor = System.Drawing.Color.Black;
            this.attributetoalter.Location = new System.Drawing.Point(16, 24);
            this.attributetoalter.Name = "attributetoalter";
            this.attributetoalter.Size = new System.Drawing.Size(136, 20);
            this.attributetoalter.TabIndex = 30;
            this.attributetoalter.Text = "accountBalance";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(160, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "ATTRIBUTE VALUE";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(160, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 16);
            this.label13.TabIndex = 32;
            this.label13.Text = "ATTRIBUTE NAME";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(160, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 16);
            this.label14.TabIndex = 35;
            this.label14.Text = "MODIFY ACTION";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModifyAction
            // 
            this.ModifyAction.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ModifyAction.ForeColor = System.Drawing.Color.Black;
            this.ModifyAction.Items.AddRange(new object[] {
            "ADD",
            "DELETE",
            "REPLACE"});
            this.ModifyAction.Location = new System.Drawing.Point(16, 72);
            this.ModifyAction.Name = "ModifyAction";
            this.ModifyAction.Size = new System.Drawing.Size(136, 21);
            this.ModifyAction.Sorted = true;
            this.ModifyAction.TabIndex = 34;
            this.ModifyAction.SelectedIndexChanged += new System.EventHandler(this.ModifyAction_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Firebrick;
            this.label15.Location = new System.Drawing.Point(16, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(264, 16);
            this.label15.TabIndex = 36;
            this.label15.Text = "Add - Adds value to existing value";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Firebrick;
            this.label16.Location = new System.Drawing.Point(16, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(264, 16);
            this.label16.TabIndex = 37;
            this.label16.Text = "Delete - Subtracts value from existing value";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Firebrick;
            this.label17.Location = new System.Drawing.Point(16, 136);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(304, 16);
            this.label17.TabIndex = 38;
            this.label17.Text = "Replace - Replaces existing value with new value";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(16, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 16);
            this.label18.TabIndex = 40;
            this.label18.Text = "ACTIVITY LOG FILE";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // savefilename
            // 
            this.savefilename.BackColor = System.Drawing.Color.WhiteSmoke;
            this.savefilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.savefilename.ForeColor = System.Drawing.Color.Black;
            this.savefilename.Location = new System.Drawing.Point(16, 40);
            this.savefilename.Name = "savefilename";
            this.savefilename.ReadOnly = true;
            this.savefilename.Size = new System.Drawing.Size(248, 20);
            this.savefilename.TabIndex = 39;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "ActivityLog.txt";
            this.saveFileDialog1.Filter = "Text files|*.txt";
            this.saveFileDialog1.Title = "Activity Log File ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(272, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 20);
            this.button2.TabIndex = 41;
            this.button2.Text = "BROWSE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // showerror
            // 
            this.showerror.BackColor = System.Drawing.Color.Transparent;
            this.showerror.Checked = true;
            this.showerror.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showerror.Location = new System.Drawing.Point(608, 320);
            this.showerror.Name = "showerror";
            this.showerror.Size = new System.Drawing.Size(120, 24);
            this.showerror.TabIndex = 42;
            this.showerror.Text = "SHOW ERRORS";
            this.showerror.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Context);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Username);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(24, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 112);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrator Account to use";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.ModifyAction);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.attributetoalter);
            this.groupBox2.Controls.Add(this.attributevalue);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(376, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 160);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attribute Modifications to be made";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.savefilename);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(376, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 72);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Activity Log";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.SearchContext);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.SearchParameter);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(24, 184);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(336, 168);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Object Search";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Firebrick;
            this.label19.Location = new System.Drawing.Point(192, 88);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(128, 36);
            this.label19.TabIndex = 37;
            this.label19.Text = "Note: * acts as a wildcard character";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.Statusbar);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(320, 368);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 136);
            this.panel4.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(9, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(400, 9);
            this.label8.TabIndex = 20;
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(9, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(400, 9);
            this.label7.TabIndex = 19;
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(9, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(400, 9);
            this.label6.TabIndex = 18;
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Statusbar
            // 
            this.Statusbar.BackColor = System.Drawing.Color.White;
            this.Statusbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statusbar.ForeColor = System.Drawing.Color.Firebrick;
            this.Statusbar.Location = new System.Drawing.Point(9, 115);
            this.Statusbar.Name = "Statusbar";
            this.Statusbar.Size = new System.Drawing.Size(400, 9);
            this.Statusbar.TabIndex = 17;
            this.Statusbar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.ReadOnly = true;
            this.label1.Size = new System.Drawing.Size(392, 72);
            this.label1.TabIndex = 15;
            this.label1.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(9, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 74);
            this.panel2.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(664, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 176);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // Main_Screen
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 502);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showerror);
            this.Controls.Add(this.resultsreturned);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(752, 536);
            this.MinimumSize = new System.Drawing.Size(752, 536);
            this.Name = "Main_Screen";
            this.Text = "Novell Mass Attribute Changer 20060316.2";
            this.Load += new System.EventHandler(this.Main_Screen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Main_Screen());
		}

		protected override void OnHandleCreated(EventArgs e)
		{
			if (null != sysTray)
			{
				sysTray.AssignHandle(this.Handle);	
				sysTray.ShowInSysTray = true;
			}
			base.OnHandleCreated(e);
		}

		private void sysTray_DoubleClick(object sender, EventArgs e)
		{
			RestoreMe();
		}

		/// <summary>
		/// Performs the following steps as necessary:
		/// unhides, unmiminizes, brings to foreground and
		/// sets as active application.
		/// </summary>
		private void RestoreMe()
		{
			if (!this.Visible)
			{
				this.Visible = true;
			}
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.WindowState = FormWindowState.Normal;
			}
			this.BringToFront();
		}

		private void Main_Screen_Load(object sender, System.EventArgs e)
		{
			try
			{
				Context.SelectedIndex = 1;
//				if (Context.SelectedIndex > -1)
//				{
//					SearchContext.Text = Context.Items[Context.SelectedIndex].ToString();
//					SearchContext.Refresh();
//				}
ModifyAction.SelectedIndex = 0;



				// Assign the SysTray object to this form
				sysTray = new SysTray(this);
				// Set the Icon:
				sysTray.IconImageList = ilsIcons;
				sysTray.IconIndex = 0;
				// Set the default context menu:
				//sysTray.Menu = mnuContext;
				// Set the tooltip text:
				sysTray.ToolTipText = "Novell Mass Attribute Changer";
			
				// events:
				/*sysTray.MouseDown += new MouseEventHandler(sysTray_MouseDown);
				sysTray.MouseUp += new MouseEventHandler(sysTray_MouseUp);
				sysTray.MouseMove += new MouseEventHandler(sysTray_MouseMove);*/
				sysTray.Click += new EventHandler(sysTray_DoubleClick);
				sysTray.DoubleClick += new EventHandler(sysTray_DoubleClick);
				/*sysTray.KeySelect += new EventHandler(sysTray_KeySelect);
				sysTray.EnterSelect += new EventHandler(sysTray_EnterSelect);
				sysTray.BalloonClicked += new EventHandler(sysTray_BalloonClicked);
				sysTray.BalloonHide += new EventHandler(sysTray_BalloonHide);
				sysTray.BalloonShow += new EventHandler(sysTray_BalloonShow);
				sysTray.BalloonTimeOut += new EventHandler(sysTray_BalloonTimeOut);
*/
				// Show:
				sysTray.ShowInSysTray = true;


			}
			catch(System.Exception except)
			{
				Error_Handler(except);
			}
		}

		private void Error_Handler(System.Exception except)
		{
			if (showerror.Checked == true)
			{

				label1_Message("--------------\nError Encountered:\n" + except.ToString());
			}			
		
			
					Statusbar_Message("Error Encountered");
			
		}

		private void Error_Handler(string except)
		{
			if (showerror.Checked == true)
			{
				label1_Message("--------------\nError Encountered:\n" + except);
			}
			Statusbar_Message("Error Encountered");
		}

		private void Statusbar_Message(string message)
		{
			label8.Text = label7.Text;
			label8.Refresh();
			label7.Text = label6.Text;
			label7.Refresh();
			label6.Text = Statusbar.Text;
			label6.Refresh();
			message = message.ToUpper();
			Statusbar.Text = message;
			Statusbar.Refresh();
		}
	
		private void label1_Message(string message)
		{
			if (label1.TextLength > 0)
				label1.Text = label1.Text + "\n" + message;
			else
				label1.Text = label1.Text  + message;
			label1.Refresh();
		}
		
		private int ldap_check(int serveruse)
		{
			try
			{
				if (serveruse == 1)
					Statusbar_Message("Retrieving username input");
				if (Username.Text.Equals("") == true)
				{
					Error_Handler("Input Error: Username field has been left blank.");
					Statusbar_Message("Operation failed");
					return 0;
				}
				if (serveruse == 1)
					Statusbar_Message("Retrieving password input");
				string userPasswd = Password.Text;
				
				if (Password.Text.Equals("") == true)
				{
					Error_Handler("Input Error: Password field has been left blank.");
					Statusbar_Message("Operation failed");
					return 0;
				}	

                //if (Context.SelectedIndex < 0)
                //{
                //    Error_Handler("Invalid Context selected from the list.");
                //    Statusbar_Message("Operation failed");
                //    return 0;
                //}	

				string tdn = "";
				//string[] tempdn = Context.Items[Context.SelectedIndex].ToString().Split('.');
                string[] tempdn = Context.Text.Split('.');
				System.Collections.IEnumerator runner = tempdn.GetEnumerator();
				while(runner.MoveNext())
				{
					if (runner.Current.Equals("uct") == false)
						tdn = tdn + "OU="+ runner.Current + ",";
					else
						tdn = tdn + "O="+ runner.Current + ",";
				}
				tdn = tdn.Remove(tdn.Length-1,1);
				string userDN = "CN=" + Username.Text.ToUpper() + "," + tdn;
				if (serveruse == 1)
					Statusbar_Message("Setting DN string as " + userDN);

			
				
				string ldapHost;
				int ldapPort;
				int ldapVersion = LdapConnection.Ldap_V3;
				if (serveruse == 1)
				{
					ldapHost = "rep1.uct.ac.za";
					ldapPort = LdapConnection.DEFAULT_PORT;
				}
				else
				{
					ldapHost = "rep2.uct.ac.za";
					ldapPort = LdapConnection.DEFAULT_PORT;
				}
				Statusbar_Message("Setting LDAP server as " + ldapHost + ":" + ldapPort);

				Statusbar_Message("Attempting to bind " + Username.Text + " to " + ldapHost + ":" + ldapPort);
				// Creating an LdapConnection instance
				LdapConnection ldapConn= new LdapConnection();
				try				
				{
					//Connect function will create a socket
					//ldapConn.SecureSocketLayer = true;
					ldapConn.Connect(ldapHost,ldapPort);
					//Bind function will Bind the user
					//ldapConn.startTLS();
					ldapConn.Bind(ldapVersion,userDN,userPasswd);
					//ldapConn.stopTLS();
				}
				catch(System.Exception except)
				{
					Error_Handler(except);
					if (serveruse == 1)
					{
						Statusbar_Message("Contacting Secondary LDAP server");
						ldap_check(2);
						return 0;
					}
					else
					{
						Statusbar_Message("Operation failed");
						return 0;
						
					}
				}
				
				//LdapAttribute attr = new LdapAttribute("userPassword", userPasswd);
				//bool correct = ldapConn.Compare(userDN, attr);
				//label1_Message("Password Verify: " + correct);

				string stdn = "";
				string[] stempdn = SearchContext.Text.Split('.');
				System.Collections.IEnumerator srunner = stempdn.GetEnumerator();
				while(srunner.MoveNext())
				{
					if (srunner.Current.Equals("uct") == false)
						stdn = stdn + "OU="+ srunner.Current + ",";
					else
						stdn = stdn + "O="+ srunner.Current + ",";
				}
				stdn = stdn.Remove(stdn.Length-1,1);
				Statusbar_Message("Search DN string set as " + stdn);
				if (stdn.Equals("") == true)
				{
					Error_Handler("Input Error: Search DN field has been left blank.");
					Statusbar_Message("Operation failed");
					return 0;
				}

				Statusbar_Message("Search Parameter string set as " + SearchParameter.Text);
				if (SearchParameter.Text.Equals("") == true)
				{
					Error_Handler("Input Error: Search Parameter field has been left blank.");
					Statusbar_Message("Operation failed");
					return 0;
				}

				Statusbar_Message("Retrieving Object Details");
				resultsreturned.Text = "0";
				resultsreturned.Text = resultsreturned.Text + " RESULTS RETURNED";
				resultsreturned.Refresh();
				bool LoopsOn;
				LoopsOn = false;
				if (SearchParameter.Text.ToUpper() == "CN=*")
				{
					LoopsOn = true;
				}
				else
				{
					LoopsOn = false;
				}
				

				string[] searchparams;
				if (LoopsOn == false)
				{
					searchparams = new string[1]{SearchParameter.Text};
				}
				else
				{
					//searchparams = new string[702];
					//string[] outerloop = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
					//string[] innerloop = {"-","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
					searchparams = new string[676];
					string[] outerloop = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
					string[] innerloop = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};

int current = 0;
					foreach(string outer in outerloop)
					{
						string c = outer;
						foreach(string inner in innerloop)
						{
							c = "CN=" + outer +  inner + "*";
							searchparams[current] = c;
							//label1_Message(current + ": " + c);
							current = current + 1;
						}
						
					}
				}
				//MessageBox.Show(searchparams.Length.ToString());

				foreach(string arrsearchterm in searchparams)
				{

					// Searches in the Marketing container and return all child entries just below this
					//container i.e Single level search
					LdapSearchQueue queue=ldapConn.Search(stdn,LdapConnection.SCOPE_SUB,
						//"objectClass=*",
						//"CN=" + Username.Text.ToUpper(),				
						arrsearchterm,
						null,		
						false,
						(LdapSearchQueue) null,
						(LdapSearchConstraints) null );

					LdapMessage message;
				
					while ((message = queue.getResponse()) != null)
				
					{
						if (message is LdapSearchResult)
						{
							double doh = (Double.Parse(resultsreturned.Text.Replace(" RESULTS RETURNED","")) + 1);
							resultsreturned.Text = doh.ToString();
							resultsreturned.Text = resultsreturned.Text + " RESULTS RETURNED";
							resultsreturned.Refresh();
							LdapEntry entry = ((LdapSearchResult) message).Entry;
							//label1_Message("------------------------------------------------\n ENTRY:\n------------------------------------------------");
						////	label1_Message(" " + entry.DN );
						ActivityLogger("DN: " + entry.DN);

//------------
							ArrayList modList = new ArrayList();
														LdapAttribute setattribute = new LdapAttribute(attributetoalter.Text, attributevalue.Text);
							
							if (ModifyAction.SelectedIndex ==0)
							{
								modList.Add( new LdapModification(LdapModification.ADD, setattribute));
							}

							if (ModifyAction.SelectedIndex ==1)
							{
								modList.Add( new LdapModification(LdapModification.DELETE, setattribute));
							}

							if (ModifyAction.SelectedIndex ==2)
							{
								modList.Add( new LdapModification(LdapModification.REPLACE, setattribute));
							}

							LdapModification[] mods = new LdapModification[modList.Count]; 	
							Type mtype=Type.GetType("Novell.Directory.LdapModification");
							mods = (LdapModification[])modList.ToArray(typeof(LdapModification));
                        
							//conn.Connect(ldapHost,ldapPort);
							//conn.Bind(loginDN,password);
						
							try
							{
								ldapConn.Modify(entry.DN,mods);
							}
							catch(System.Exception except)
							{
								Error_Handler("Altering " + entry.DN + ": " + except);
							ActivityLogger("Altering Attribute Failed");
							}
//------------


							//label1_Message("------------------------------------------------\n ATTRIBUTES:\n------------------------------------------------");
							LdapAttributeSet attributeSet =  entry.getAttributeSet();
						
							System.Collections.IEnumerator ienum = attributeSet.GetEnumerator();
							while(ienum.MoveNext())
							{
								LdapAttribute attribute=(LdapAttribute)ienum.Current;
								string attributeName = attribute.Name;
								if (attributeName.Equals(attributetoalter.Text) == true)
								{
									System.Collections.IEnumerator ienum2 = attribute.StringValues;
								
									while(ienum2.MoveNext())
									{
										//string gr =(string)ienum.Current;
										//label1.Text = label1.Text + " \n " +  attributeName + " value:" + gr;
						////				label1_Message(" Attribute: " + attributeName + "   Value: " + ienum2.Current.ToString() + "");
										if (ModifyAction.SelectedIndex ==0)
										{
											ActivityLogger("Attribute: " + attributeName + "   Old Value: " + ienum2.Current.ToString() + "");
										}

										if (ModifyAction.SelectedIndex ==1)
										{
											ActivityLogger("Attribute: " + attributeName + "   Old Value: " + ienum2.Current.ToString() + "");
										}

										if (ModifyAction.SelectedIndex ==2)
										{
											ActivityLogger("Attribute: " + attributeName + "   Old Value: " + ienum2.Current.ToString()  + "   New Value: " + attributevalue.Text + "");
										}
						

									}
									break;
								}
							
							}
						}
					}
				}
Statusbar_Message("Disconnecting from LDAP server");

				ldapConn.Disconnect();
				Statusbar_Message("Operation successfully completed");
				sysTray.ShowBalloonTip("Operation successfully completed. " + resultsreturned.Text.ToLower() + ".", NotifyIconBalloonIconFlags.NIIF_INFO, "Novell Mass Attribute Changer");
			
				return 1;
			}
			catch(System.Exception except)
			{
								Error_Handler(except);
				Statusbar_Message("Operation failed");
			}
			return 0;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if (savefilename.Text.Length > 0)
			{
				label8.Text = "";
				label8.Refresh();
				label7.Text = "";
				label7.Refresh();
				label6.Text = "";
				label6.Refresh();
				Statusbar.Text = "";
				Statusbar.Refresh();
				label1.Text = "";
				label1.Refresh();
				ldap_check(1);
			}
			else
			{
				MessageBox.Show("Please ensure you have a valid save file name entered into the Results File textbox.");
			}
		}

		private void ActivityLogger(string Message)
		{
			try
			{
				if (savefilename.Text.Length > 0)
				{

					System.IO.StreamWriter filewriter;
					filewriter = new System.IO.StreamWriter(savefilename.Text,true);
					filewriter.WriteLine(String.Format("{0:yyyyMMdd HH:mm:ss}", DateTime.Now) + ": " + Message);
					filewriter.Flush();
					filewriter.Close();
				}
			}
			catch(System.Exception except)
			{
				Error_Handler("ActivityLogger: " + except);
							Statusbar_Message("Activity Logging failed");
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e) 
		{
			SearchContext.Text = comboBox1.SelectedItem.ToString();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			saveFileDialog1.FileName = "ActivityLog_" + String.Format("{0:yyyyMMdd}", DateTime.Now) + ".txt";
			DialogResult result = saveFileDialog1.ShowDialog();
			if (result == DialogResult.OK)
			{
				savefilename.Text = saveFileDialog1.FileName;
			}
		}

		private void Context_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		private void ModifyAction_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

	


	




//		private void Context_SelectedIndexChanged(object sender, System.EventArgs e)
//		{
//			try
//			{
//				if (Context.SelectedIndex > -1)
//				{
//					SearchContext.Text = Context.Items[Context.SelectedIndex].ToString();
//					SearchContext.Refresh();
//				}
//			}
//			catch(System.Exception except)
//			{
//				Error_Handler(except);
//				Statusbar_Message("Operation failed");
//			}
//			
//		}


	}
}

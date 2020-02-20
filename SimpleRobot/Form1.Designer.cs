namespace SimpleRobot
{
    partial class Form1
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
            this.panel_map = new System.Windows.Forms.Panel();
            this.lbl_robot = new System.Windows.Forms.Label();
            this.btn_north = new System.Windows.Forms.Button();
            this.btn_west = new System.Windows.Forms.Button();
            this.btn_south = new System.Windows.Forms.Button();
            this.btn_east = new System.Windows.Forms.Button();
            this.btn_go1 = new System.Windows.Forms.Button();
            this.btn_go10 = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_coords = new System.Windows.Forms.Label();
            this.lbl_distance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel_map
            // 
            this.panel_map.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel_map.Location = new System.Drawing.Point(24, 12);
            this.panel_map.Name = "panel_map";
            this.panel_map.Size = new System.Drawing.Size(200, 200);
            this.panel_map.TabIndex = 0;
            // 
            // lbl_robot
            // 
            this.lbl_robot.AutoSize = true;
            this.lbl_robot.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbl_robot.Location = new System.Drawing.Point(209, 200);
            this.lbl_robot.Name = "lbl_robot";
            this.lbl_robot.Size = new System.Drawing.Size(15, 12);
            this.lbl_robot.TabIndex = 0;
            this.lbl_robot.Text = "3";
            // 
            // btn_north
            // 
            this.btn_north.Location = new System.Drawing.Point(105, 218);
            this.btn_north.Name = "btn_north";
            this.btn_north.Size = new System.Drawing.Size(31, 31);
            this.btn_north.TabIndex = 1;
            this.btn_north.Text = "N";
            this.btn_north.UseVisualStyleBackColor = true;
            this.btn_north.Click += new System.EventHandler(this.btn_north_Click);
            // 
            // btn_west
            // 
            this.btn_west.Location = new System.Drawing.Point(68, 247);
            this.btn_west.Name = "btn_west";
            this.btn_west.Size = new System.Drawing.Size(31, 31);
            this.btn_west.TabIndex = 2;
            this.btn_west.Text = "W";
            this.btn_west.UseVisualStyleBackColor = true;
            this.btn_west.Click += new System.EventHandler(this.btn_west_Click);
            // 
            // btn_south
            // 
            this.btn_south.Location = new System.Drawing.Point(105, 274);
            this.btn_south.Name = "btn_south";
            this.btn_south.Size = new System.Drawing.Size(31, 31);
            this.btn_south.TabIndex = 3;
            this.btn_south.Text = "S";
            this.btn_south.UseVisualStyleBackColor = true;
            this.btn_south.Click += new System.EventHandler(this.btn_south_Click);
            // 
            // btn_east
            // 
            this.btn_east.Location = new System.Drawing.Point(142, 247);
            this.btn_east.Name = "btn_east";
            this.btn_east.Size = new System.Drawing.Size(31, 31);
            this.btn_east.TabIndex = 4;
            this.btn_east.Text = "E";
            this.btn_east.UseVisualStyleBackColor = true;
            this.btn_east.Click += new System.EventHandler(this.btn_east_Click);
            // 
            // btn_go1
            // 
            this.btn_go1.Location = new System.Drawing.Point(12, 250);
            this.btn_go1.Name = "btn_go1";
            this.btn_go1.Size = new System.Drawing.Size(47, 25);
            this.btn_go1.TabIndex = 5;
            this.btn_go1.Text = "Go 1";
            this.btn_go1.UseVisualStyleBackColor = true;
            this.btn_go1.Click += new System.EventHandler(this.btn_go1_Click);
            // 
            // btn_go10
            // 
            this.btn_go10.Location = new System.Drawing.Point(192, 250);
            this.btn_go10.Name = "btn_go10";
            this.btn_go10.Size = new System.Drawing.Size(47, 25);
            this.btn_go10.TabIndex = 6;
            this.btn_go10.Text = "Go 10";
            this.btn_go10.UseVisualStyleBackColor = true;
            this.btn_go10.Click += new System.EventHandler(this.btn_go10_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(154, 297);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(84, 26);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.button7_Click);
            // 
            // lbl_coords
            // 
            this.lbl_coords.AutoSize = true;
            this.lbl_coords.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lbl_coords.Location = new System.Drawing.Point(82, 0);
            this.lbl_coords.Name = "lbl_coords";
            this.lbl_coords.Size = new System.Drawing.Size(78, 13);
            this.lbl_coords.TabIndex = 8;
            this.lbl_coords.Text = "{ X = 1 , Y = 1 }";
            // 
            // lbl_distance
            // 
            this.lbl_distance.AutoSize = true;
            this.lbl_distance.Location = new System.Drawing.Point(4, 297);
            this.lbl_distance.Name = "lbl_distance";
            this.lbl_distance.Size = new System.Drawing.Size(55, 13);
            this.lbl_distance.TabIndex = 9;
            this.lbl_distance.Text = "Distance: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 328);
            this.Controls.Add(this.lbl_distance);
            this.Controls.Add(this.lbl_robot);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_coords);
            this.Controls.Add(this.btn_go10);
            this.Controls.Add(this.btn_go1);
            this.Controls.Add(this.btn_east);
            this.Controls.Add(this.btn_south);
            this.Controls.Add(this.btn_west);
            this.Controls.Add(this.btn_north);
            this.Controls.Add(this.panel_map);
            this.Name = "Form1";
            this.Text = "Simple Robot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_map;
        private System.Windows.Forms.Button btn_north;
        private System.Windows.Forms.Button btn_west;
        private System.Windows.Forms.Button btn_south;
        private System.Windows.Forms.Button btn_east;
        private System.Windows.Forms.Button btn_go1;
        private System.Windows.Forms.Button btn_go10;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_robot;
        private System.Windows.Forms.Label lbl_coords;
        private System.Windows.Forms.Label lbl_distance;
    }
}


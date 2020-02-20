using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SimpleRobot
{
    public partial class Form1 : Form
    {
        private Robot robot = new Robot(); //Instantiates new Robot object.
        private RobotTracker rt = new RobotTracker();

        public Form1()
        {
            InitializeComponent();
            lbl_robot.Location = robot.GetPosition(); //Moves the label to starting position.
            lbl_robot.Text = "5";
            lbl_coords.Text = "{ X = " + robot.GetXCoord() + " Y = " + robot.GetYCoord() + " }";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_north_Click(object sender, EventArgs e)
        {
            robot.FaceNorth();
            lbl_robot.Text = "5";
        }

        private void btn_south_Click(object sender, EventArgs e)
        {
            robot.FaceSouth();
            lbl_robot.Text = "6";
        }

        private void btn_east_Click(object sender, EventArgs e)
        {
            robot.FaceEast();
            lbl_robot.Text = "4";
        }

        private void btn_west_Click(object sender, EventArgs e)
        {
            robot.FaceWest();
            lbl_robot.Text = "3";
        }

        private void btn_go1_Click(object sender, EventArgs e) //Moves robot 1 tile, updates labels.
        {
            robot.GoOne();
            lbl_robot.Location = robot.GetPosition();
            lbl_distance.Text = "Distance: " +RobotTracker.distance.ToString();
            lbl_coords.Text = "{ X = " + robot.GetXCoord() + " Y = " + robot.GetYCoord() + " }";
        }

        private void btn_go10_Click(object sender, EventArgs e) //Moves robot 10 tiles, updates labels.
        {
            robot.GoTen();
            lbl_robot.Location = robot.GetPosition();
            lbl_distance.Text = "Distance: " +RobotTracker.distance.ToString();
            lbl_coords.Text = "{ X = " + robot.GetXCoord() + " Y = " + robot.GetYCoord() + " }";
        }
    }
}

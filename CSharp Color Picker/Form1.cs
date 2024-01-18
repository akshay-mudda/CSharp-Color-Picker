using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Color_Picker
{
    public partial class Form1 : Form
    {
        String Hex;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Dark mode is selected
                ApplyDarkMode();
            }
            else
            {
                // Light mode is selected
                ApplyLightMode();
            }
        }

        private void ApplyDarkMode()
        {
            // Set dark mode colors
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.ForeColor = Color.White;
            
        }

        private void ApplyLightMode()
        {
            // Set light mode colors
            this.BackColor = SystemColors.Control;
            this.ForeColor = SystemColors.ControlText;
            // Add other light mode styling as needed
        }

        private void UpdateRGBTextBox()
        {
            textBox4.Text = $"rgb({trackBar1.Value}, {trackBar2.Value}, {trackBar3.Value})";
        }

        private void UpdateRGBATextBox()
        {
            
            int rValue = trackBar1.Value;
            int gValue = trackBar2.Value;
            int bValue = trackBar3.Value;
            int alphaValue = (rValue + gValue + bValue) / 3;
            textBox6.Text = $"rgba({rValue}, {gValue}, {bValue}, {alphaValue / 255.0:F2})";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
            UpdateRGBTextBox();
            UpdateRGBATextBox();
            panel1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            Hex = string.Format("{0:X2}{1:X2}{2:X2}", trackBar1.Value, trackBar2.Value, trackBar3.Value);
            textBox5.Text = "#" + Hex;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = trackBar2.Value.ToString();
            UpdateRGBTextBox();
            UpdateRGBATextBox();
            panel1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            Hex = string.Format("{0:X2}{1:X2}{2:X2}", trackBar1.Value, trackBar2.Value, trackBar3.Value);
            textBox5.Text = "#" + Hex;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = trackBar3.Value.ToString();
            UpdateRGBTextBox();
            UpdateRGBATextBox();
            panel1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            Hex = string.Format("{0:X2}{1:X2}{2:X2}", trackBar1.Value, trackBar2.Value, trackBar3.Value);
            textBox5.Text = "#" + Hex;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "rgb(0, 0, 0)";
            textBox6.Text = "rgba(0, 0, 0, 0.00)";
            panel1.BackColor = Color.Black;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            string githubProfileLink = "https://github.com/akshay-mudda";

            // Open the link in the default web browser
            Process.Start(githubProfileLink);
        }

        private void InitializeFormComponents()
        {
            // You can call this method in the Form constructor or Load event
            // to set up the link label and other components.

            linkLabel1.LinkArea = new LinkArea(0, linkLabel1.Text.Length);
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        }
    }
}

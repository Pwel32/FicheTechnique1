using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using Microsoft.VisualBasic.Devices;
using System.IO;

namespace FicheTechnique
{
    public partial class Form1 : Form
    {
        public static ulong Ram;
       
       
        public Form1()
        {
            InitializeComponent();
        }

      
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure", "Exiting software", MessageBoxButtons.OKCancel);
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace listeDeProduit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string chemin = @"C:\Users\jgaman\Documents\GitHub\listeDeProduit\";
            //IO
            DirectoryInfo dossier = new DirectoryInfo(chemin);
            FileInfo[] fichiers = dossier.GetFiles("*.*", SearchOption.AllDirectories);
            ListBox1.DataSource = fichiers;
            
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileInfo fichier = (FileInfo)listBox1.SelectedItem;
            lblDateCreation.Text = fichier.CreationTime.ToString();
        }
    }
}

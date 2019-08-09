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

namespace Polymorphism6percent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_submit_Click(object sender, EventArgs e)
        {
            double cowMilkPrice, goatMilkPrice, cowVaccination, jerseyCowVaccination, goatVaccination;            //Collection of user input data
            cowMilkPrice = Int32.Parse(txt_cowmilk.Text);
            goatMilkPrice = Int32.Parse(txt_goatmilk.Text);
            cowVaccination = Int32.Parse(txt_cow.Text);
            jerseyCowVaccination = Int32.Parse(txt_jersey.Text);
            goatVaccination = Int32.Parse(txt_goat.Text);
        }

        private void Btn_browse_Click(object sender, EventArgs e)                   //browse for text file
        {
            using (OpenFileDialog fileBrowse = new OpenFileDialog() { Filter = "Text Files (*.txt)|*.txt" })
            {
                if (fileBrowse.ShowDialog() == DialogResult.OK)
                {
                    lbl_browse.Text = fileBrowse.FileName;
                    String filePath = fileBrowse.FileName;
                    createObjectArray(filePath);

                }
            } 
        }

        private void Txt_cowmilk_TextChanged(object sender, EventArgs e)                //disabling submit button until all fields are filled
        {
            submitVisibility();
        }

        private void Txt_goatmilk_TextChanged(object sender, EventArgs e)
        {
            submitVisibility();
        }

        private void Txt_cow_TextChanged(object sender, EventArgs e)
        {
            submitVisibility();
        }

        private void Txt_jersey_TextChanged(object sender, EventArgs e)
        {
            submitVisibility();
        }

        private void Txt_goat_TextChanged(object sender, EventArgs e)
        {
            submitVisibility();
        }
         private void Lbl_browse_TextChanged(object sender, EventArgs e)
        {
            submitVisibility();
        }

        private void submitVisibility()
        {
            if((txt_cowmilk.Text != String.Empty) && (txt_goatmilk.Text != String.Empty) && (txt_cow.Text != String.Empty) && (txt_jersey.Text != String.Empty) && (txt_goat.Text != String.Empty) && (lbl_browse.Text != "No file"))
            {
                btn_submit.Enabled = true;
            }
            else
            {
                btn_submit.Enabled = false;
            }
        }

        private void createObjectArray(String filePath)
        {

        }
        
    }
}

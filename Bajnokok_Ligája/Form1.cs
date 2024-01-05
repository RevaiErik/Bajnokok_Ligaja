using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bajnokok_Ligája
{
    public partial class Form1 : Form
    {
        string bldata = "Bajnokok_Ligaja.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(bldata))
            {
                Bajnokok_Ligaja_dataset.ReadXml(bldata);
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Bajnokok_Ligaja_dataset.WriteXml(bldata);
            Close();
        }

        private void csapatok_filter_bindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (filter_comboBox.SelectedValue != null)
            {
                if ((int)filter_comboBox.SelectedValue != 0)
                {
                    Csapatok_bindingSource.Filter = $"Csoport_id = {filter_comboBox.SelectedValue}";
                }
                else
                {
                    Csapatok_bindingSource.RemoveFilter();
                }
            }
        }
    }
}

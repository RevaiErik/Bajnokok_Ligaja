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
        string bldata = "../../src/Bajnokok_Ligaja.xml";
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
           Tabella();
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
                    Csapatok_bindingSource.Filter = "csapat_id > 0";
                }
            }
        }

        private void filter2_comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (filter2_comboBox.SelectedValue != null)
            {
                if ((int)filter2_comboBox.SelectedValue != 0)
                {
                    Tabella_bindingSource.Filter = $"Csoport_id = {filter2_comboBox.SelectedValue}";
                }
                else
                {
                    Tabella_bindingSource.Filter = "csapat_id > 0";
                }
            }
        }


        private void Tabella() {

            foreach (DataRow csapatok_item in Bajnokok_Ligaja_dataset.Tables["Csapatok"].Rows)
            { 
                int LM = 0;
                int GY = 0;
                int V = 0;
                int D = 0;
                int P = 0;
                foreach (DataRow meccs_item in Bajnokok_Ligaja_dataset.Tables["Meccsek"].Rows)
                {
                    if ((int)meccs_item["Csapat1_id"]  == (int)csapatok_item["Csapat_id"]
                        || (int)meccs_item["Csapat2_id"] == (int)csapatok_item["Csapat_id"])
                    {
                        LM ++;
                        if ((int)meccs_item["Gol1"] == (int)meccs_item["Gol2"])
                        {
                            D++;
                            P++;
                        }

                        if ((int)meccs_item["Csapat1_id"] == (int)csapatok_item["Csapat_id"])
                        {
                            if ((int)meccs_item["Gol1"] > (int)meccs_item["Gol2"])
                            {
                                GY++;
                                P += 3;
                            }
                            else if ((int)meccs_item["Gol1"] < (int)meccs_item["Gol2"])
                            {
                                V++;
                            }

                        }

                        if ((int)meccs_item["Csapat2_id"] == (int)csapatok_item["Csapat_id"])
                        {
                            if ((int)meccs_item["Gol1"] < (int)meccs_item["Gol2"])
                            {
                                GY++;
                                P += 3;
                            }
                            else if ((int)meccs_item["Gol1"] > (int)meccs_item["Gol2"])
                            {
                                V++;
                            }

                        }
                    }
                }

                csapatok_item["LM"] = LM;
                csapatok_item["GY"] = GY;
                csapatok_item["V"] = V;
                csapatok_item["D"] = D;
                csapatok_item["P"] = P;
            }

        }

        private void novekvo_button_Click(object sender, EventArgs e)
        {
            Tabella_dataGridView.Sort(Tabella_dataGridView.Columns["P"], ListSortDirection.Descending);
        }
        private void updatebutton_Click(object sender, EventArgs e)
        {
            Tabella_bindingSource.EndEdit();
            Tabella();
        }

        private void ABC_button_Click(object sender, EventArgs e)
        {
            Tabella_dataGridView.Sort(Tabella_dataGridView.Columns[0], ListSortDirection.Ascending);
        }
    }
}

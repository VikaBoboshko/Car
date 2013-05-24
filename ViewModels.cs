using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LumenWorks.Framework.IO.Csv;
using System.IO;

namespace car
{
    public partial class ViewModels : Form
    {
        public ViewModels()
        {
            InitializeComponent();
        }
        List<data> Brandlist = new List<data>();
        string IdBrand = "";
        string IdModels = "";
        string IdBaseProperties = "";
        string IdColor = "";
        string IdType = "";
        string IdDelete = "";
        string IdAddress = "";
        int selectIndex = -1;
        int selectId = -1;    
        CSV car = new CSV(CarFile.Path);
        CSV baseProperties = new CSV(BasePropertiesFile.Path);
        struct data
        {
            public string n;
            public string name;
        };


        private void ViewModels_Load(object sender, EventArgs e)
        {            
            using (CsvReader csv = new CsvReader(new StreamReader("Brand.csv"), true, ';'))
            {
                data dataModels = new data();
                int j = 0;
                while (csv.ReadNextRecord())
                {                    
                    dataModels.name = csv[1];
                    dataModels.n = csv[0];
                    comboBoxBrand.Items.Add(csv[1]);
                    Brandlist.Add(dataModels);
                    j++;
                }
            }        
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxComplex.Enabled = true;
            dataGridViewModels.Rows.Clear();
            string brand = "";           
            brand = comboBoxBrand.SelectedItem.ToString();
            for (int i = 0; i < Brandlist.Count; i++)
            {
                if (brand.CompareTo(Brandlist[i].name) == 0)
                {
                    IdBrand = Brandlist[i].n;
                    break;
                }
            }
            CsvReader csvBaseProperties = new CsvReader(new StreamReader("baseProperties.csv"), true, ';');            
            string model = "";
            using (CsvReader csv = new CsvReader(new StreamReader("Car.csv"), true, ';'))
            {
                int i = 0;
                int k_b = 0;
                int k_m = 0;
                int jj = 0;
                           
                while (csv.ReadNextRecord())
                {
                    if (csv[1] == IdBrand && IdBrand != "")
                    {
                        csvBaseProperties.MoveTo(k_b);

                        IdBaseProperties = csv[6];
                        IdModels = csv[2];
                        IdType = csv[4];
                        IdColor = csv[5];
                        while (csvBaseProperties.ReadNextRecord())
                        {
                            if (csvBaseProperties[0] == IdBaseProperties && IdBaseProperties != "")
                            {
                                dataGridViewModels.Rows.Add();
                                dataGridViewModels.Rows[i].Cells[0].Value = i + 1;
                                for (int j = 0; j < csvBaseProperties.FieldCount; j++)
                                {
                                    dataGridViewModels.Rows[i].Cells[j + 5].Value = csvBaseProperties[j].ToString();
                                }                                   
                                i++;
                                break;
                            }
                            k_b++;
                        }
                        CsvReader csvModels = new CsvReader(new StreamReader("Models.csv"), true, ';');                       
                        while (csvModels.ReadNextRecord())
                        {                           
                            if (csvModels[0] == IdModels && IdModels != "")
                            {                                
                                model = csvModels[2];                                                          
                                break;
                            }
                        }
                        dataGridViewModels.Rows[i - 1].Cells[4].Value = model;                        
                        dataGridViewModels.Rows[i - 1].Cells[2].Value = IdType;
                        dataGridViewModels.Rows[i - 1].Cells[3].Value = IdColor;
                        dataGridViewModels.Rows[i - 1].Cells[1].Value = IdModels;

                    }
                }
            }            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewModels_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //IdBrand=
            IdModels = dataGridViewModels.Rows[e.RowIndex].Cells[1].Value.ToString();
            IdBaseProperties = dataGridViewModels.Rows[e.RowIndex].Cells[5].Value.ToString();
            IdType = dataGridViewModels.Rows[e.RowIndex].Cells[2].Value.ToString();
            IdColor = dataGridViewModels.Rows[e.RowIndex].Cells[3].Value.ToString();
            using (CsvReader csv = new CsvReader(new StreamReader(CarFile.Path), true, ';'))
            {                
                while (csv.ReadNextRecord())
                {
                    try
                    {
                        selectIndex = e.RowIndex;
                        selectId = int.Parse(dataGridViewModels.Rows[selectIndex].Cells[1].Value.ToString());
                    }
                    catch
                    {
                    }
                    if (IdModels == csv[CarFile.id_ModelId] && IdBrand == csv[CarFile.id_BrandId] && IdBaseProperties == csv[CarFile.id_PropertiesId] && IdType == csv[CarFile.id_TypeId] && IdColor == csv[CarFile.id_ColorId])
                    {
                        IdDelete = csv[CarFile.id_Id];
                        IdAddress = csv[CarFile.id_AddressId];
                        textBoxPP.Text = csv[CarFile.id_PeredPid].ToString();
                        textBoxZP.Text = csv[CarFile.id_ZadPid].ToString();
                        textBoxPT.Text = csv[CarFile.id_PeredStop].ToString();
                        textBoxZT.Text = csv[CarFile.id_ZadStop].ToString();
                        textBoxGasCity.Text = csv[CarFile.id_GasCity].ToString();
                        textBoxGasRoad.Text = csv[CarFile.id_GasRoad].ToString();
                        textBoxGasCombi.Text = csv[CarFile.id_GasRoad].ToString();
                        textBoxMaxSpeed.Text = csv[CarFile.id_MaxSpeed].ToString();
                        textBoxSizeCar.Text = csv[CarFile.id_SizeCar].ToString();
                        textBoxKliners.Text = csv[CarFile.id_Kliners].ToString();
                        textBoxVB.Text = csv[CarFile.id_Vbak].ToString();
                        textBoxVBag.Text = csv[CarFile.id_Vbag].ToString();
                        textBoxSizeS.Text = csv[CarFile.id_SizeS].ToString();
                        textBoxYears.Text = csv[CarFile.id_Years].ToString();
                        textBoxPrice.Text = csv[CarFile.id_Price].ToString();

                        if (csv[22] == "True")
                            checkBoxCZ.Checked = true;
                        else
                            checkBoxCZ.Checked = false;

                        if (csv[23] == "True")
                            checkBoxSP.Checked = true;
                        else
                            checkBoxSP.Checked = false;

                        if (csv[24] == "True")
                            checkBoxPF.Checked = true;
                        else
                            checkBoxPF.Checked = false;

                        if (csv[25] == "True")
                            checkBoxC.Checked = true;
                        else
                            checkBoxC.Checked = false;

                        if (csv[26] == "True")
                            checkBoxE.Checked = true;
                        else
                            checkBoxE.Checked = false;

                        if (csv[27] == "True")
                            checkBoxPZS.Checked = true;
                        else
                            checkBoxPZS.Checked = false;

                        if (csv[28] == "True")
                            checkBoxPPS.Checked = true;
                        else
                            checkBoxPPS.Checked = false;

                        if (csv[29] == "True")
                            checkBoxPC.Checked = true;
                        else
                            checkBoxPC.Checked = false;

                        if (csv[30] == "True")
                            checkBoxDZ.Checked = true;
                        else
                            checkBoxDZ.Checked = false;
                    }
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (IdDelete != "")
            {                
                DialogResult resut = MessageBox.Show("Видалити модель " + dataGridViewModels.Rows[selectIndex].Cells[4].Value + "?", "Увага!", MessageBoxButtons.YesNo);
                if (resut == DialogResult.Yes)
                {
                    car.Remove(int.Parse(IdDelete));
                    dataGridViewModels.Rows.RemoveAt(selectIndex);
                }
            }
        }

        private void EditToolStripButton_Click(object sender, EventArgs e)
        {
            textBoxPP.ReadOnly = false;
            textBoxZP.ReadOnly = false;
            textBoxPT.ReadOnly = false;
            textBoxZT.ReadOnly = false;
            textBoxGasCity.ReadOnly = false;
            textBoxGasRoad.ReadOnly = false;
            textBoxGasCombi.ReadOnly = false;
            textBoxMaxSpeed.ReadOnly = false;
            textBoxSizeCar.ReadOnly = false;
            textBoxKliners.ReadOnly = false;
            textBoxVB.ReadOnly = false;
            textBoxVBag.ReadOnly = false;
            textBoxSizeS.ReadOnly = false;
            textBoxYears.ReadOnly = false;
            textBoxPrice.ReadOnly = false;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {                      
            //string id = "";
            //string name = "";
            //string address_st = "";
            string st = "";
            //id = dataGridViewModels.Rows[selectIndex].Cells[1].Value.ToString();
            //name = dataGridViewModels.Rows[selectIndex].Cells[2].Value.ToString();
            //address_st = dataGridViewModels.Rows[selectIndex].Cells[3].Value.ToString();
            //tel = dataGridViewModels.Rows[selectIndex].Cells[4].Value.ToString();

            st += IdDelete + ";" + IdBrand + ";" + IdModels + ";" + IdAddress + ";" + IdType + ";" + IdColor + ";" + IdBaseProperties + ";" + textBoxPP.Text + ";" + textBoxZP.Text +
                ";" + textBoxPT.Text + ";" + textBoxZT.Text + ";" + textBoxGasCity.Text +
                ";" + textBoxGasRoad.Text + ";" + textBoxGasCombi.Text + ";" + textBoxMaxSpeed.Text + ";" + textBoxSizeCar.Text +
                ";" + textBoxKliners.Text + ";" + textBoxVB.Text + ";" + textBoxVBag.Text + ";" + textBoxSizeS.Text +
                ";" + textBoxYears.Text + ";" + textBoxPrice.Text + ";" + checkBoxCZ.Checked + ";" + checkBoxSP.Checked + ";" + checkBoxPF.Checked +
                ";" + checkBoxC.Checked + ";" + checkBoxE.Checked + ";" + checkBoxPZS.Checked + ";" + checkBoxPPS.Checked + ";" + checkBoxPC.Checked + ";" + checkBoxDZ.Checked + ";";
            car.Edit(int.Parse(IdDelete), st);                                  
                       
        }
    }
}

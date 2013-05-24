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
    public partial class NewCar : Form
    {
        public NewCar()
        {
            InitializeComponent();
        }

        List<data> Brandlist = new List<data>();
        List<data> Modelslist = new List<data>();
        List<data> Typelist = new List<data>();
        List<data> Colorlist = new List<data>();
        List<data> Addresslist = new List<data>();
        public List<string> rowProperties = new List<string>();
        CSV baseProperties = new CSV("baseProperties.csv");
        CSV Car = new CSV("Car.csv");
        string[,] str;
        string IdBrand = "";
        string IdModel = "";
        string IdColor = "";
        string IdType = "";
        string IdProperties = "";
        string IdAddress = "";
       // Other other;
        Other other = new Other();
        struct data
        {
            public string n;
            public string name;
        };

        private void groupBoxTrans_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void NewCar_Load(object sender, EventArgs e)
        {
           // other = new Other();
            data data = new data();
            // Load brand in comboBox
            using (CsvReader csv = new CsvReader(new StreamReader("Brand.csv"), true, ';'))
            {

                int j = 0;
                while (csv.ReadNextRecord())
                {                   
                    data.name = csv[1];
                    data.n = csv[0];
                    comboBoxBrand.Items.Add(csv[1]);
                    Brandlist.Add(data);                 
                    j++;
                }
            }
            // Load type in comboBox
            using (CsvReader csv = new CsvReader(new StreamReader("Type.csv"), true, ';'))
            {
                int j = 0;
                while (csv.ReadNextRecord())
                {
                    data.name = csv[1];
                    data.n = csv[0];
                    comboBoxType.Items.Add(csv[1]);
                    Typelist.Add(data);
                    j++;
                }
            }
            // Load color in comboBox
            using (CsvReader csv = new CsvReader(new StreamReader("Color.csv"), true, ';'))
            {
                int j = 0;
                while (csv.ReadNextRecord())
                {
                    data.name = csv[1];
                    data.n = csv[0];
                    comboBoxColor.Items.Add(csv[1]);
                    Colorlist.Add(data);
                    j++;
                }
            }

            // Load address in comboBox
            using (CsvReader csv = new CsvReader(new StreamReader("Address.csv"), true, ';'))
            {
                int j = 0;
                while (csv.ReadNextRecord())
                {
                    data.name = csv[1];
                    data.n = csv[0];
                    comboBoxAddress.Items.Add(csv[1]);
                    Addresslist.Add(data);
                    //j++;
                }
            }

        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            string brand = "";
            data dataModels = new data();
            brand = comboBoxBrand.SelectedItem.ToString();
            for (int i = 0; i < Brandlist.Count; i++)
            {
                if (brand.CompareTo(Brandlist[i].name) == 0)
                {
                    IdBrand = Brandlist[i].n;
                    break;
                }
            }
         //   MessageBox.Show(IdBrand);
            comboBoxModels.Items.Clear();
           // comboBoxModels.Text = "Будь-яка";
            using (CsvReader csv = new CsvReader(new StreamReader("Models.csv"), true, ';'))
            {
                while (csv.ReadNextRecord())
                {
                    if (csv[1] == IdBrand && IdBrand != "")
                    {
                        comboBoxModels.Items.Add(csv[2]);
                        dataModels.n = csv[0];
                        dataModels.name = csv[2];
                        Modelslist.Add(dataModels);
                    }
                    //   else
                    // comboBoxModels.Items.Add(csv[2]);

                }
            }

            //}  
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
       //     bool f = other.checkBoxCZ.Checked;
        //    MessageBox.Show(f.ToString());
            try
            {
                //add base properties
                
                int k_properties = int.Parse(baseProperties.lastId());
               // MessageBox.Show(k_properties.ToString());
                IdProperties = (k_properties + 1).ToString();
                rowProperties.Add(IdProperties);
                rowProperties.Add(comboBoxGas.SelectedItem.ToString());
                rowProperties.Add(textBoxVMotor.Text);
                rowProperties.Add(textBoxZul.Text);
                rowProperties.Add(textBoxNorma.Text);
                rowProperties.Add(textBoxBox.Text);
                rowProperties.Add(textBoxPrivid.Text);

                bool isRecord = false;                
                using (CsvReader csv = new CsvReader(new StreamReader("baseProperties.csv"), true, ';'))
                {
                    bool a = true;
                    while (csv.ReadNextRecord())
                    {
                       // MessageBox.Show(csv.FieldCount.ToString());
                        int k = 0;
                        for (int i = 1; i < csv.FieldCount; i++)
                        {
                           // MessageBox.Show("i " + i + " " + csv[i] + " " + rowProperties[i]);
                            if (csv[i].CompareTo(rowProperties[i]) == 0)
                            {
                                k++;
                            }                            
                        }
                       // j++;
                        if (k == 6)
                        {
                            IdProperties = csv[0];
                            isRecord = true;
                            break;
                        }
                        //if (csv[1] == IdBrand && IdBrand != "")
                        //{
                        //    comboBoxModels.Items.Add(csv[2]);
                        //    dataModels.n = csv[0];
                        //    dataModels.name = csv[2];
                        //    Modelslist.Add(dataModels);
                        //}
                        //   else
                        // comboBoxModels.Items.Add(csv[2]);

                    }
                }

                if (!isRecord)
                    baseProperties.Add(rowProperties);

                //add  properties
                List<string> rowNewCar = new List<string>();
                int k_newCar = int.Parse(Car.lastId());
                string id_newCar = (k_newCar + 1).ToString();
              // MessageBox.Show(id_newCar);
                rowNewCar.Add(id_newCar);
                rowNewCar.Add(IdBrand);//1
                rowNewCar.Add(IdModel);//2
                rowNewCar.Add(IdAddress);
                rowNewCar.Add(IdType); //4
                rowNewCar.Add(IdColor);
                rowNewCar.Add(IdProperties);
                rowNewCar.Add(textBoxPeredPidvisk.Text);//7
                rowNewCar.Add(textBoxZadPidvisk.Text);
                rowNewCar.Add(textBoxPeredStop.Text);
                rowNewCar.Add(textBoxZadStop.Text);
                //rowNewCar.Add(textBoxPeredStop.Text);
                rowNewCar.Add(textBoxGasCity.Text);
                rowNewCar.Add(textBoxGasRoad.Text);
                rowNewCar.Add(textBoxGasCombo.Text);
                rowNewCar.Add(textBoxMaxSpeed.Text);
                rowNewCar.Add(textBoxSizeCar.Text);
                rowNewCar.Add(textBoxKlirens.Text);
                rowNewCar.Add(textBoxVBak.Text);
                rowNewCar.Add(textBoxVBag.Text);
                rowNewCar.Add(textBoxSizeS.Text);
                rowNewCar.Add(textBoxYear.Text);
                rowNewCar.Add(textBoxPrice.Text); //21
                rowNewCar.Add(other.checkBoxCZ.Checked.ToString());
                rowNewCar.Add(other.checkBoxSP.Checked.ToString());
                rowNewCar.Add(other.checkBoxPF.Checked.ToString());
                rowNewCar.Add(other.checkBoxK.Checked.ToString());
                rowNewCar.Add(other.checkBoxE.Checked.ToString());
                rowNewCar.Add(other.checkBoxPZS.Checked.ToString());
                rowNewCar.Add(other.checkBoxPPS.Checked.ToString());
                rowNewCar.Add(other.checkBoxPC.Checked.ToString());
                rowNewCar.Add(other.checkBoxDZ.Checked.ToString());   
                Car.Add(rowNewCar);
                MessageBox.Show("Успішно додано!");
                Close();
            }
            catch (Exception t)
            {
                MessageBox.Show("Помилка додавання запусу в таблицю. Вибачте за незручності. Детальніше: " + t.Message);
            }
        }

        private void buttonOther_Click(object sender, EventArgs e)
        {
           
            other.Show();
        }

        private void comboBoxModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            string model = "";
            model = comboBoxModels.SelectedItem.ToString();
            for (int i = 0; i < Modelslist.Count; i++)
            {
                if (model.CompareTo(Modelslist[i].name) == 0)
                {
                    IdModel = Modelslist[i].n;
                    break;
                }
            }
           // MessageBox.Show(IdModel);
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = "";
            type = comboBoxType.SelectedItem.ToString();
            for (int i = 0; i < Typelist.Count; i++)
            {
                if (type.CompareTo(Typelist[i].name) == 0)
                {
                    IdType = Typelist[i].n;
                    break;
                }
            }
          //  MessageBox.Show(IdType);
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = "";
            color = comboBoxColor.SelectedItem.ToString();
            for (int i = 0; i < Colorlist.Count; i++)
            {
                if (color.CompareTo(Colorlist[i].name) == 0)
                {
                    IdColor = Colorlist[i].n;
                    break;
                }
            }
           // MessageBox.Show(IdColor);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            string address = "";
            address = comboBoxAddress.SelectedItem.ToString();
            for (int i = 0; i < Addresslist.Count; i++)
            {
                if (address.CompareTo(Addresslist[i].name) == 0)
                {
                    IdAddress = Addresslist[i].n;
                    break;
                }
            }
         //   MessageBox.Show(IdAddress);
        }

       
       
    }
}

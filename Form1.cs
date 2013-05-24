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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        
        List<data> Brandlist = new List<data>();
        List<data> Modelslist = new List<data>();
        List<data> Typelist = new List<data>();
        List<data> Colorlist = new List<data>();
        List<string> Pricelist = new List<string>();
        string IdBrand = "";
        string IdModels = "";
        string IdType = "";
        string IdColor = "";
        string IdbaseProperties = "";
        string brand1 = "";
        string model1 = "";
        string[,] str;
        int id_NT = 5;
        int id_PT = 10;
        int id_ZT = 11;
        int id_Combi = 14;
        int id_SizeCar = 16;
        int id_Kliners = 17;
        int id_Vb = 18;
        int id_SizeS = 20;
        int id_Year = 21;
        int idGrid_CZ = 25;
        int idGrid_SP = 26;
        int idGrid_PF = 27;
        int idGrid_C = 28;
        int idGrid_E = 29;
        int idGrid_PZS = 30;
        int idGrid_PPS = 31;
        int idGrid_PC = 32;
        int idGrid_DZ = 33;
        struct data
        {
            public string n;
            public string name;
        };

        private void button1_Click(object sender, EventArgs e)
        {
           // ReadCsv();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {//d:\Навчання\ІІ курс\car\car
            data data = new data();
            using (CsvReader csv = new CsvReader(new StreamReader("Brand.csv"), true, ';'))
            {

                int j = 0;
                while (csv.ReadNextRecord())
                {
                    //for (int i = 0; i < 2; i++)
                    //{
                    //    str[i, j] = csv[i].ToString();
                    //}
                    data.name = csv[1];
                    data.n = csv[0];
                    comboBoxBrand.Items.Add(csv[1]);
                    Brandlist.Add(data);                    
                    j++;
                }
            }
            comboBoxModels.Items.Add("Будь-яка");
            comboBoxModels.SelectedIndex = 0;           
            comboBoxType.SelectedIndex = 0;
            comboBoxColor.SelectedIndex = 0;
            comboBoxGas.SelectedIndex = 0;
            comboBoxYear.SelectedIndex = 0;
           
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


            // Load year

            for (int i = 0; i < 3; ++i)
            {
                comboBoxYear.Items.Add(DateTime.Now.Year - i);
            }

            dataGridViewFind.Width = Width - 250;
            dataGridViewFind.Height = Height - 130;
           // textBoxFind.Location = new System.Drawing.Point(261,Height - 90);            
            
        }

        
        private void ToolStripMenuItemAddress_Click(object sender, EventArgs e)
        {
            Address address = new Address();
            address.Show();
        }       
       

        private void ToolStripMenuItemColor_Click(object sender, EventArgs e)
        {
            myColor color = new myColor();
            color.Show();
        }

        private void ToolStripMenuItemModels_Click(object sender, EventArgs e)
        {
            ViewModels viewModels = new ViewModels();
            viewModels.Show();
        }

        private void ToolStripMenuItemNewCar_Click(object sender, EventArgs e)
        {
            NewCar newCar = new NewCar();
            newCar.Show();
        }

        private void ToolStripMenuItemDynamicProp_Click(object sender, EventArgs e)
        {
            DynamicProper dynamic = new DynamicProper();
            dynamic.Show();
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            data dataModel = new data();
           
           // string n = "";
            brand1 = comboBoxBrand.SelectedItem.ToString();
            for (int i = 0; i < Brandlist.Count; i++)
            {
                if (brand1.CompareTo(Brandlist[i].name) == 0)
                {
                    IdBrand = Brandlist[i].n;
                    break;
                }
            }
            
            comboBoxModels.Items.Clear();
            comboBoxModels.Items.Add("Будь-яка");

            using (CsvReader csv = new CsvReader(new StreamReader("Models.csv"), true, ';'))
            {
                while (csv.ReadNextRecord())
                {
                    if (csv[1] == IdBrand && IdBrand != "")
                    {
                        dataModel.name = csv[2];
                        dataModel.n = csv[0];
                        comboBoxModels.Items.Add(csv[2]);
                        Modelslist.Add(dataModel);                        
                    }

                }
            }
            comboBoxModels.SelectedIndex = 0;

            Pricelist.Clear();
            using (CsvReader csv = new CsvReader(new StreamReader("Car.csv"), true, ';'))
            {
                while (csv.ReadNextRecord())
                {
                    if (csv[1] == IdBrand && IdBrand != "")
                    {                                               
                       Pricelist.Add(csv[21]);
                    }

                }
            }
            if (Pricelist.Count != 0)
            {
                Pricelist.Sort();
                comboBoxPriceFrom.Items.Clear();
                comboBoxPriceFrom.Items.Add("Будь-яка");

                comboBoxPriceTo.Items.Clear();
                comboBoxPriceTo.Items.Add("Будь-яка");

                comboBoxPriceFrom.Items.Add(Pricelist[0].ToString());
                comboBoxPriceTo.Items.Add(Pricelist[Pricelist.Count - 1].ToString());
            }
           // MessageBox.Show(Pricelist[0].ToString() + " " + Pricelist[Pricelist.Count - 1].ToString());
            //}            
            
        }

        private void comboBoxBrand_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
        }

        private void comboBoxBrand_Click(object sender, EventArgs e)
        {
            //comboBoxBrand.Items.Clear();
            //data data = new data();
            //using (CsvReader csv = new CsvReader(new StreamReader(@"D:\Student\Дипломна\car\car\data\Brand.csv"), true, ';'))
            //{

            //    int j = 0;
            //    while (csv.ReadNextRecord())
            //    {                    
            //        data.name = csv[1];
            //        data.n = csv[0];
            //        comboBoxBrand.Items.Add(csv[1]);
            //        Brandlist.Add(data);                    
            //        j++;
            //    }
            //}                
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItemBrand_Click_1(object sender, EventArgs e)
        {
         //   Maker maker = new Maker();
           // maker.Show();
        }

        private void ToolStripMenuItemModel_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            model.Show();
        }

        private void ToolStripMenuItemType_Click(object sender, EventArgs e)
        {
            Type type = new Type();
            type.Show();
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
        }

        private void textBoxFind_MouseClick(object sender, MouseEventArgs e)
        {
           // textBoxFind.Text = "";
        }

        private void ToolStripMenuItemCar_Click(object sender, EventArgs e)
        {

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {

         //   MessageBox.Show(comboBoxModels.SelectedItem.ToString());
            dataGridViewFind.Rows.Clear();
            if (IdBrand == "")
                MessageBox.Show("Виберіть будь ласка марку автомобіля");
            else
                Find(int.Parse(IdBrand.ToString()));           
           
            int k = 1;
            for (int j = 0; j < dataGridViewFind.Rows.Count; j++)
            {
                if (dataGridViewFind.Rows[j].Visible)
                {
                    dataGridViewFind.Rows[j].Cells[0].Value = k;
                    k++;
                }
            }
           
           // tabControl1.Enabled = true;
        }

        public void Find(int id_brand)//, int id_model, int id_type, int id_color)
        {
            string model = "";
            string id_model = "";

            string color = "";
            string id_color = "";

            string type = "";
            string id_type = "";

                                 
            using (CsvReader csv = new CsvReader(new StreamReader("Car.csv"), true, ';'))
            {
                int i = 0;
                int k = 0;
                int k_m = 0;
                int jj = 0;
                
                while (csv.ReadNextRecord())
                {

                    if (csv[1] == id_brand.ToString()) //|| id_model.ToString() == csv[2] || id_type.ToString() == csv[4] || id_color.ToString() == csv[5])
                    {

                        CsvReader csvBaseProperties = new CsvReader(new StreamReader("baseProperties.csv"), true, ';'); 
                        IdbaseProperties = csv[6];
                        id_model = csv[IdColumn.id_ModelId];
                        id_type = csv[IdColumn.id_TypeId];
                        id_color = csv[IdColumn.id_ColorId];

                        while (csvBaseProperties.ReadNextRecord())
                        {
                            if (csvBaseProperties[0] == IdbaseProperties && IdbaseProperties != "")
                            {
                                dataGridViewFind.Rows.Add();
                              //  dataGridViewFind.Rows[i].Cells[0].Value = i + 1;
                                for (int j = 1; j < csvBaseProperties.FieldCount; j++)
                                {                                   
                                        dataGridViewFind.Rows[i].Cells[j + 1].Value = csvBaseProperties[j].ToString();
                                    // dataGridViewFind.Rows[i].Cells[1].Value = brand1.ToString();
                                    // dataGridViewFind.Rows[i].Cells[1].Value = "---";//model1.ToString();
                                }
                                i++;
                                break;
                            }
                            //k_b++;
                        }

                        // models
                        CsvReader csvModels = new CsvReader(new StreamReader("Models.csv"), true, ';');
                        while (csvModels.ReadNextRecord())
                        {
                            if (csvModels[0] == id_model && id_model != "")
                            {
                                model = csvModels[2];
                                break;
                            }
                        }
                        dataGridViewFind.Rows[k].Cells[1].Value = model;

                        dataGridViewFind.Rows[k].Cells[34].Value = csv[IdColumn.id_AddressId];

                      //type                        
                        CsvReader csvType = new CsvReader(new StreamReader("Type.csv"), true, ';');
                        while (csvType.ReadNextRecord())
                        {
                            if (csvType[0] == id_type && id_type != "")
                            {
                                type = csvType[1];
                                break;
                            }
                        }
                        dataGridViewFind.Rows[k].Cells[22].Value = type;

                        // color
                        CsvReader csvColor = new CsvReader(new StreamReader("Color.csv"), true, ';');
                        while (csvColor.ReadNextRecord())
                        {
                            if (csvColor[0] == id_color && id_color != "")
                            {
                                color = csvColor[1];
                                break;
                            }
                        }
                        dataGridViewFind.Rows[k].Cells[23].Value = color;


                       // MessageBox.Show(csv.FieldCount.ToString());
                        for (int j = 7; j <= csv.FieldCount + 1; j++)
                        {
                            if (j <= 20)
                                dataGridViewFind.Rows[k].Cells[j + 1].Value = csv[j];
                            if (j > 23)
                                dataGridViewFind.Rows[k].Cells[j].Value = csv[j - 3];

                        }
                          k++;                          
                    }                    
                }

                // фільтрація моделей
                if (comboBoxModels.SelectedIndex != 0)
                    for (int j = 0; j < dataGridViewFind.Rows.Count; j++)
                    {
                        if (comboBoxModels.SelectedItem.ToString() != dataGridViewFind.Rows[j].Cells[1].Value.ToString())// && comboBoxModels.SelectedItem.ToString() != "Будь-яка")
                        {
                            dataGridViewFind.Rows[j].Visible = false;
                        }
                    }

                // фільтрація по типу кузова
                if (comboBoxType.SelectedItem.ToString() != "Будь-який")
                    for (int j = 0; j < dataGridViewFind.Rows.Count; j++)
                    {
                        if (comboBoxType.SelectedItem.ToString() != dataGridViewFind.Rows[j].Cells[22].Value.ToString())// && comboBoxModels.SelectedItem.ToString() != "Будь-яка")
                        {
                            dataGridViewFind.Rows[j].Visible = false;
                        }
                    }  

                // фільтрація по кольору                
                if (comboBoxColor.SelectedItem.ToString() != "Будь-який")
                    for (int j = 0; j < dataGridViewFind.Rows.Count; j++)
                    {
                        if (comboBoxColor.SelectedItem.ToString() != dataGridViewFind.Rows[j].Cells[2].Value.ToString())// && comboBoxModels.SelectedItem.ToString() != "Будь-яка")
                        {
                            dataGridViewFind.Rows[j].Visible = false;
                        }
                    }

               
                // фільтрація по ціні
             //   MessageBox.Show(comboBoxPriceFrom.Text.ToString());
                if (comboBoxPriceFrom.Text.ToString() != "Будь-яка" && comboBoxPriceTo.Text.ToString() != "Будь-яка")
                    for (int j = 0; j < dataGridViewFind.Rows.Count; j++)
                    {
                        if (int.Parse(comboBoxPriceFrom.Text.ToString()) <= int.Parse(dataGridViewFind.Rows[j].Cells[24].Value.ToString()) && int.Parse(comboBoxPriceTo.Text.ToString()) >= int.Parse(dataGridViewFind.Rows[j].Cells[24].Value.ToString()))// && comboBoxModels.SelectedItem.ToString() != "Будь-яка")
                        {
                           
                           // MessageBox.Show("true");
                        }
                        else
                            dataGridViewFind.Rows[j].Visible = false;
                    }


                if (comboBoxPriceFrom.Text.ToString() != "Будь-яка" && comboBoxPriceTo.Text.ToString() == "Будь-яка")
                    for (int j = 0; j < dataGridViewFind.Rows.Count; j++)
                    {
                        if (int.Parse(comboBoxPriceFrom.Text.ToString()) <= int.Parse(dataGridViewFind.Rows[j].Cells[24].Value.ToString()))// && comboBoxModels.SelectedItem.ToString() != "Будь-яка")
                        {

                          //  MessageBox.Show("true");
                        }
                        else
                            dataGridViewFind.Rows[j].Visible = false;
                    }

                if (comboBoxPriceFrom.Text.ToString() == "Будь-яка" && comboBoxPriceTo.Text.ToString() != "Будь-яка")
                    for (int j = 0; j < dataGridViewFind.Rows.Count; j++)
                    {
                        if (int.Parse(comboBoxPriceTo.Text.ToString()) >= int.Parse(dataGridViewFind.Rows[j].Cells[24].Value.ToString()))// && comboBoxModels.SelectedItem.ToString() != "Будь-яка")
                        {

                          //  MessageBox.Show("true");
                        }
                        else
                            dataGridViewFind.Rows[j].Visible = false;
                    }

                // фільтрація по році випуску
                if (comboBoxYear.SelectedItem.ToString() != "Будь-який")
                    for (int j = 0; j < dataGridViewFind.Rows.Count; j++)
                    {
                        if (comboBoxYear.SelectedItem.ToString() != dataGridViewFind.Rows[j].Cells[21].Value.ToString())// && comboBoxModels.SelectedItem.ToString() != "Будь-яка")
                        {
                            dataGridViewFind.Rows[j].Visible = false;
                        }
                    }

                // фільтрація по типу двигуна 
                if (comboBoxGas.SelectedItem.ToString() != "Будь-який")
                    for (int j = 0; j < dataGridViewFind.Rows.Count; j++)
                    {
                        if (comboBoxGas.SelectedItem.ToString() != dataGridViewFind.Rows[j].Cells[2].Value.ToString())// && comboBoxModels.SelectedItem.ToString() != "Будь-яка")
                        {
                            dataGridViewFind.Rows[j].Visible = false;
                        }
                    }

                if (textBoxVMotor.Text != "")
                    for (int j = 0; j < dataGridViewFind.Rows.Count; j++)
                    {
                        if (textBoxVMotor.Text != dataGridViewFind.Rows[j].Cells[3].Value.ToString())// && comboBoxModels.SelectedItem.ToString() != "Будь-яка")
                        {
                            dataGridViewFind.Rows[j].Visible = false;
                        }
                    }

                if (textBoxZul.Text != "")
                    for (int j = 0; j < dataGridViewFind.Rows.Count; j++)
                    {
                        if (textBoxZul.Text != dataGridViewFind.Rows[j].Cells[4].Value.ToString())// && comboBoxModels.SelectedItem.ToString() != "Будь-яка")
                        {
                            dataGridViewFind.Rows[j].Visible = false;
                        }
                    }

                if (textBoxNorma.Text != "")
                    for (int j = 0; j < dataGridViewFind.Rows.Count; j++)
                    {
                        if (textBoxNorma.Text != dataGridViewFind.Rows[j].Cells[5].Value.ToString())// && comboBoxModels.SelectedItem.ToString() != "Будь-яка")
                        {
                            dataGridViewFind.Rows[j].Visible = false;
                        }
                    }

                if (textBoxBox.Text != "")
                    for (int j = 0; j < dataGridViewFind.Rows.Count; j++)
                    {
                        if (textBoxBox.Text != dataGridViewFind.Rows[j].Cells[6].Value.ToString())// && comboBoxModels.SelectedItem.ToString() != "Будь-яка")
                        {
                            dataGridViewFind.Rows[j].Visible = false;
                        }
                    }

                if (textBoxPrivid.Text != "")
                    for (int j = 0; j < dataGridViewFind.Rows.Count; j++)
                    {
                        if (textBoxPrivid.Text != dataGridViewFind.Rows[j].Cells[7].Value.ToString())// && comboBoxModels.SelectedItem.ToString() != "Будь-яка")
                        {
                            dataGridViewFind.Rows[j].Visible = false;
                        }
                    }

                if (textBoxPeredPidvisk.Text != "")
                    for (int j = 0; j < dataGridViewFind.Rows.Count; j++)
                    {
                        if (textBoxPeredPidvisk.Text != dataGridViewFind.Rows[j].Cells[8].Value.ToString())// && comboBoxModels.SelectedItem.ToString() != "Будь-яка")
                        {
                            dataGridViewFind.Rows[j].Visible = false;
                        }
                    }

                if (textBoxZadPidvisk.Text != "")
                    for (int j = 0; j < dataGridViewFind.Rows.Count; j++)
                    {
                        if (textBoxZadPidvisk.Text != dataGridViewFind.Rows[j].Cells[9].Value.ToString())// && comboBoxModels.SelectedItem.ToString() != "Будь-яка")
                        {
                            dataGridViewFind.Rows[j].Visible = false;
                        }
                    }

                // Комплектація
                if (checkBoxCZ.CheckState != CheckState.Indeterminate)
                    for (int j = 0; j < dataGridViewFind.Rows.Count; j++)
                    {
                        if (checkBoxCZ.Checked.ToString() != dataGridViewFind.Rows[j].Cells[25].Value.ToString())// && comboBoxModels.SelectedItem.ToString() != "Будь-яка")
                        {
                            dataGridViewFind.Rows[j].Visible = false;
                        }
                    }

                if (checkBoxSP.CheckState != CheckState.Indeterminate)
                    for (int j = 0; j < dataGridViewFind.Rows.Count; j++)
                    {
                        if (checkBoxSP.Checked.ToString() != dataGridViewFind.Rows[j].Cells[26].Value.ToString())// && comboBoxModels.SelectedItem.ToString() != "Будь-яка")
                        {
                            dataGridViewFind.Rows[j].Visible = false;
                        }
                    }

                if (checkBoxPF.CheckState != CheckState.Indeterminate)
                    for (int j = 0; j < dataGridViewFind.Rows.Count; j++)
                    {
                        if (checkBoxPF.Checked.ToString() != dataGridViewFind.Rows[j].Cells[27].Value.ToString())// && comboBoxModels.SelectedItem.ToString() != "Будь-яка")
                        {
                            dataGridViewFind.Rows[j].Visible = false;
                        }
                    }

                if (checkBoxC.CheckState != CheckState.Indeterminate)
                    for (int j = 0; j < dataGridViewFind.Rows.Count; j++)
                    {
                        if (checkBoxC.Checked.ToString() != dataGridViewFind.Rows[j].Cells[28].Value.ToString())// && comboBoxModels.SelectedItem.ToString() != "Будь-яка")
                        {
                            dataGridViewFind.Rows[j].Visible = false;
                        }
                    }

                if (checkBoxE.CheckState != CheckState.Indeterminate)
                    for (int j = 0; j < dataGridViewFind.Rows.Count; j++)
                    {
                        if (checkBoxE.Checked.ToString() != dataGridViewFind.Rows[j].Cells[29].Value.ToString())// && comboBoxModels.SelectedItem.ToString() != "Будь-яка")
                        {
                            dataGridViewFind.Rows[j].Visible = false;
                        }
                    }

                if (checkBoxPZS.CheckState != CheckState.Indeterminate)
                    for (int j = 0; j < dataGridViewFind.Rows.Count; j++)
                    {
                        if (checkBoxPZS.Checked.ToString() != dataGridViewFind.Rows[j].Cells[30].Value.ToString())// && comboBoxModels.SelectedItem.ToString() != "Будь-яка")
                        {
                            dataGridViewFind.Rows[j].Visible = false;
                        }
                    }

                if (checkBoxPPS.CheckState != CheckState.Indeterminate)
                    for (int j = 0; j < dataGridViewFind.Rows.Count; j++)
                    {
                        if (checkBoxPPS.Checked.ToString() != dataGridViewFind.Rows[j].Cells[31].Value.ToString())// && comboBoxModels.SelectedItem.ToString() != "Будь-яка")
                        {
                            dataGridViewFind.Rows[j].Visible = false;
                        }
                    }

                if (checkBoxPC.CheckState != CheckState.Indeterminate)
                    for (int j = 0; j < dataGridViewFind.Rows.Count; j++)
                    {
                        if (checkBoxPC.Checked.ToString() != dataGridViewFind.Rows[j].Cells[32].Value.ToString())// && comboBoxModels.SelectedItem.ToString() != "Будь-яка")
                        {
                            dataGridViewFind.Rows[j].Visible = false;
                        }
                    }

                if (checkBoxDZ.CheckState != CheckState.Indeterminate)
                    for (int j = 0; j < dataGridViewFind.Rows.Count; j++)
                    {
                        if (checkBoxDZ.Checked.ToString() != dataGridViewFind.Rows[j].Cells[33].Value.ToString())// && comboBoxModels.SelectedItem.ToString() != "Будь-яка")
                        {
                            dataGridViewFind.Rows[j].Visible = false;
                        }
                    }                
                
            }
           // MessageBox.Show((id_brand + id_model + id_type + id_color).ToString());
        }

        private void comboBoxModels_SelectedIndexChanged(object sender, EventArgs e)
        {                       
            // string n = "";
            model1 = comboBoxModels.SelectedItem.ToString();
            for (int i = 0; i < Modelslist.Count; i++)
            {
                if (model1.CompareTo(Modelslist[i].name) == 0)
                {
                    IdModels = Modelslist[i].n;
                    break;
                }
            }
          //  MessageBox.Show(IdModel);
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
        }
        

        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboBoxGas.SelectedIndex = 0;
            textBoxNorma.Text = "";
            textBoxVMotor.Text = "";
            textBoxZul.Text = "";
        }

        private void buttonReset_MouseMove(object sender, MouseEventArgs e)
        {            
        }

        private void buttonReset2_Click(object sender, EventArgs e)
        {           
            textBoxBox.Text = "";
            textBoxZadPidvisk.Text = "";
            textBoxPeredPidvisk.Text = "";
            textBoxPrivid.Text = "";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            checkBoxCZ.CheckState = CheckState.Indeterminate;
        }

        private void buttonReset3_Click(object sender, EventArgs e)
        {
            checkBoxCZ.CheckState = CheckState.Indeterminate;
            checkBoxSP.CheckState = CheckState.Indeterminate;
            checkBoxPF.CheckState = CheckState.Indeterminate;
            checkBoxC.CheckState = CheckState.Indeterminate;
            checkBoxE.CheckState = CheckState.Indeterminate;
            checkBoxPZS.CheckState = CheckState.Indeterminate;
            checkBoxPPS.CheckState = CheckState.Indeterminate;
            checkBoxPC.CheckState = CheckState.Indeterminate;
            checkBoxDZ.CheckState = CheckState.Indeterminate;
        }

        private void dataGridViewFind_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedItem selectetdItem = new SelectedItem();
            selectetdItem.textBoxNT.Text = dataGridViewFind.Rows[e.RowIndex].Cells[id_NT].Value.ToString();
            selectetdItem.textBoxPT.Text = dataGridViewFind.Rows[e.RowIndex].Cells[id_PT].Value.ToString();
            selectetdItem.textBoxZT.Text = dataGridViewFind.Rows[e.RowIndex].Cells[id_ZT].Value.ToString();
            selectetdItem.textBoxCombi.Text = dataGridViewFind.Rows[e.RowIndex].Cells[id_Combi].Value.ToString();
            selectetdItem.textBoxSizeCar.Text = dataGridViewFind.Rows[e.RowIndex].Cells[id_SizeCar].Value.ToString();
            selectetdItem.textBoxKliners.Text = dataGridViewFind.Rows[e.RowIndex].Cells[id_Kliners].Value.ToString();
            selectetdItem.textBoxVB.Text = dataGridViewFind.Rows[e.RowIndex].Cells[id_Vb].Value.ToString();
            selectetdItem.textBoxSizeS.Text = dataGridViewFind.Rows[e.RowIndex].Cells[id_SizeS].Value.ToString();
            selectetdItem.textBoxYear.Text = dataGridViewFind.Rows[e.RowIndex].Cells[id_Year].Value.ToString();
            using (CsvReader csv = new CsvReader(new StreamReader("Address.csv"), true, ';'))
            {                
                int n = csv.FieldCount;
                int i = 0;
                while (csv.ReadNextRecord())
                {
                    if (csv[0] == dataGridViewFind.Rows[e.RowIndex].Cells[34].Value.ToString())
                    {
                        // for (int j = 1; j < n; j++)
                        // {
                        selectetdItem.textBoxAddress.Text = csv[1] + "\r\n" + "адреса:" + csv[2] + " телефон:" + csv[3];
                        
                        
                        //
                        // }
                    }
                    i++;
                }
            }
            //selectetdItem.textBoxAddress.Text = dataGridViewFind.Rows[e.RowIndex].Cells[id_Year].Value.ToString();

            if (dataGridViewFind.Rows[e.RowIndex].Cells[idGrid_CZ].Value.ToString() == "True")
                selectetdItem.checkBoxCZ.Checked = true;
            else
                selectetdItem.checkBoxCZ.Checked = false;

            if (dataGridViewFind.Rows[e.RowIndex].Cells[idGrid_SP].Value.ToString() == "True")
                selectetdItem.checkBoxSP.Checked = true;
            else
                selectetdItem.checkBoxSP.Checked = false;

            if (dataGridViewFind.Rows[e.RowIndex].Cells[idGrid_PF].Value.ToString() == "True")
                selectetdItem.checkBoxPF.Checked = true;
            else
                selectetdItem.checkBoxPF.Checked = false;

            if (dataGridViewFind.Rows[e.RowIndex].Cells[idGrid_C].Value.ToString() == "True")
                selectetdItem.checkBoxC.Checked = true;
            else
                selectetdItem.checkBoxC.Checked = false;

            if (dataGridViewFind.Rows[e.RowIndex].Cells[idGrid_E].Value.ToString() == "True")
                selectetdItem.checkBoxE.Checked = true;
            else
                selectetdItem.checkBoxE.Checked = false;

            if (dataGridViewFind.Rows[e.RowIndex].Cells[idGrid_PZS].Value.ToString() == "True")
                selectetdItem.checkBoxPZS.Checked = true;
            else
                selectetdItem.checkBoxPZS.Checked = false;

            if (dataGridViewFind.Rows[e.RowIndex].Cells[idGrid_PPS].Value.ToString() == "True")
                selectetdItem.checkBoxPPS.Checked = true;
            else
                selectetdItem.checkBoxPPS.Checked = false;

            if (dataGridViewFind.Rows[e.RowIndex].Cells[idGrid_PC].Value.ToString() == "True")
                selectetdItem.checkBoxPC.Checked = true;
            else
                selectetdItem.checkBoxPC.Checked = false;

            if (dataGridViewFind.Rows[e.RowIndex].Cells[idGrid_DZ].Value.ToString() == "True")
                selectetdItem.checkBoxDZ.Checked = true;
            else
                selectetdItem.checkBoxDZ.Checked = false;

            selectetdItem.Show();

        }
       
        
    }
}

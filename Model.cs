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
    public partial class Model : Form
    {
        public Model()
        {
            InitializeComponent();
        }
        static string filePathMoels = "Models.csv";
        static string filePathBrand = "Brand.csv";
        string selectRow = "";
        int selectIndex = -1;
        int selectIdBrand = -1;
        int selectIdModel = -1;
        CSV models = new CSV(filePathMoels);
        CSV brand = new CSV(filePathBrand);

        private void Model_Shown(object sender, EventArgs e)
        {
            // Load in brand table
            dataGridViewModel.ReadOnly = true;
            dataGridViewMaker.ReadOnly = true;
            using (CsvReader csv = new CsvReader(new StreamReader(filePathBrand), true, ';'))
            {
                int n = csv.FieldCount;
                int i = 0;
                while (csv.ReadNextRecord())
                {
                    dataGridViewMaker.Rows.Add();
                    dataGridViewMaker.Rows[i].Cells[0].Value = i + 1;
                    for (int j = 0; j < n; j++)
                    {
                        dataGridViewMaker.Rows[i].Cells[j + 1].Value = csv[j];
                    }
                    i++;
                }
            }

            // first id brand in table
            int k = int.Parse(dataGridViewMaker.Rows[0].Cells[1].Value.ToString());

            // Load in model table
            using (CsvReader csv = new CsvReader(new StreamReader(filePathMoels), true, ';'))
            {
                int n = csv.FieldCount;
                int i = 0;
                if (k != 0)
                {
                    csv.MoveTo(n - 1);                    
                    while (csv.ReadNextRecord())
                    {
                        if (int.Parse(csv[1]) == k)
                        {
                            dataGridViewModel.Rows.Add();
                            dataGridViewModel.Rows[i].Cells[0].Value = i + 1;
                            dataGridViewModel.Rows[i].Cells[2].Value = csv[2];
                            i++;
                        }
                    }
                }
                else
                {
                    dataGridViewModel.Rows.Add();
                    dataGridViewModel.Rows[0].Cells[0].Value = "-";
                    dataGridViewModel.Rows[0].Cells[0].Value = "Нема записів";
                }

            }           
        }
        
        // save new brand in csv-file
        private void saveBrandtoolStripButton_Click(object sender, EventArgs e)
        {
            dataGridViewMaker.ReadOnly = true;
            int n = dataGridViewMaker.RowCount - 1;
            int k = int.Parse(brand.lastId());
            string id = (k + 1).ToString();
            string name = dataGridViewMaker.Rows[n].Cells[2].Value.ToString();                     
            List<string> rowMaker = new List<string>();
            rowMaker.Add(id);
            rowMaker.Add(name);           
            brand.Add(rowMaker);
        }

        // save new model in csv-file
        private void saveModelsToolStripButton_Click(object sender, EventArgs e)
        {
            dataGridViewModel.ReadOnly = true;
            int n = dataGridViewModel.RowCount - 1;
            int k_model = int.Parse(models.lastId());           
            string id = (k_model + 1).ToString();
            string id_brand = selectIdBrand.ToString();
            string name = dataGridViewModel.Rows[n].Cells[2].Value.ToString();            
            List<string> rowModel = new List<string>();
            rowModel.Add(id);
            rowModel.Add(id_brand);
            rowModel.Add(name);
            models.Add(rowModel);
        }

        // add new row for brand
        private void addBrandToolStripButton_Click(object sender, EventArgs e)
        {
            dataGridViewMaker.ReadOnly = false;
            dataGridViewMaker.Rows.Add();
            int n = dataGridViewMaker.RowCount;
            dataGridViewMaker.Rows[n - 1].Cells[0].Value = n;
        }

        // add new row for model
        private void addToolStripButton_Click(object sender, EventArgs e)
        {
            dataGridViewModel.ReadOnly = false;
            dataGridViewModel.Rows.Add();
            int n = dataGridViewModel.RowCount;
            dataGridViewModel.Rows[n - 1].Cells[0].Value = n;
        }

        private void dataGridViewMaker_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {             
                selectIndex = e.RowIndex;
              //  selectRow = dataGridViewMaker.Rows[selectIndex].Cells[2].Value.ToString();
                selectIdBrand = int.Parse(dataGridViewMaker.Rows[selectIndex].Cells[1].Value.ToString());             

                using (CsvReader csv = new CsvReader(new StreamReader(filePathMoels), true, ';'))
                {
                    int i = 0;
                    dataGridViewModel.Rows.Clear();
                    while (csv.ReadNextRecord())
                    {                        
                        if (int.Parse(csv[1]) == selectIdBrand)
                        {
                            dataGridViewModel.Rows.Add();
                            dataGridViewModel.Rows[i].Cells[0].Value = i + 1;
                            dataGridViewModel.Rows[i].Cells[1].Value = csv[0];
                            dataGridViewModel.Rows[i].Cells[2].Value = csv[2];
                            i++;
                        }
                    }
                }              
            }
            catch
            {

            }

        }
       

        private void deleteBrandToolStripButton_Click(object sender, EventArgs e)
        {
            CSV car = new CSV("Car.csv");
            List<string> listNumber = new List<string>();
            if (selectIndex != -1)
            {
                DialogResult resut = MessageBox.Show("Якщо виробник " + dataGridViewMaker.Rows[selectIndex].Cells[2].Value + " використовується в записах, то всі записи з даним виробником будуть видалені!\nПродовжити?", "Увага!", MessageBoxButtons.YesNo);
                if (resut == DialogResult.Yes)
                {
                    using (CsvReader csv = new CsvReader(new StreamReader("Car.csv"), true, ';'))
                    {
                        while (csv.ReadNextRecord())
                        {
                            if (selectIdBrand.ToString() == csv[IdColumn.id_BrandId])
                            {
                                listNumber.Add(csv[0]);                               
                            }
                        }
                    }                
                    brand.Remove(selectIdBrand);
                    dataGridViewMaker.Rows.RemoveAt(selectIndex);
                    for (int i = 0; i < listNumber.Count; i++)
                    {
                        car.Remove(int.Parse(listNumber[i]));
                    }
                }
            }                
        }

        private void nextBrandtoolStripButton_Click(object sender, EventArgs e)
        {
            //frefre
        }

        private void Model_Load(object sender, EventArgs e)
        {
           // models = new CSV(filePathMoels);
           // brand = new CSV(filePathBrand);
        }

        private void dataGridViewModel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteModelToolStripButton_Click(object sender, EventArgs e)
        {
            if (selectIndex != -1)
            {
                CSV car = new CSV("Car.csv");
                List<string> listNumber = new List<string>();
               // MessageBox.Show(selectIdModel.ToString() + " " + selectIdBrand.ToString());
                DialogResult resut = MessageBox.Show("Якщо модель " + dataGridViewModel.Rows[selectIndex].Cells[2].Value + " використовується в записах, то всі записи з даною моделлю будуть видалені!\nПродовжити?", "Увага!", MessageBoxButtons.YesNo);
                if (resut == DialogResult.Yes)
                {
                    using (CsvReader csv = new CsvReader(new StreamReader("Car.csv"), true, ';'))
                    {
                        while (csv.ReadNextRecord())
                        {
                            if (selectIdBrand.ToString() == csv[IdColumn.id_BrandId] && selectIdModel.ToString() == csv[IdColumn.id_ModelId])
                            {
                                listNumber.Add(csv[0]);
                            }
                        }
                    }
                    models.Remove(selectIdModel);
                    dataGridViewModel.Rows.RemoveAt(selectIndex);
                    for (int i = 0; i < listNumber.Count; i++)
                    {
                        car.Remove(int.Parse(listNumber[i]));
                    }
                }
               // models.Remove(selectId);
                //dataGridViewModel.Rows.RemoveAt(selectIndex);
            }
        }

        private void dataGridViewModel_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                selectIndex = e.RowIndex;
                selectIdModel = int.Parse(dataGridViewModel.Rows[selectIndex].Cells[1].Value.ToString());

            }
            catch
            {

            }
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using LumenWorks.Framework.IO.Csv;

namespace car
{
    public partial class Address : Form
    {
        public Address()
        {
            InitializeComponent();
        }

        int selectIndex = -1;
        int selectId = -1;
       // static string filePathAddress = "Address.csv";
        CSV address = new CSV(AddressFile.Path);
        CSV car = new CSV(CarFile.Path);
        bool edit = false;       
       // CsvReader csvAddress = new CsvReader(new StreamReader(@"D:\Student\Дипломна\car\car\data\Address.csv"), true, ';');

        private void Address_Shown(object sender, EventArgs e)
        {
            dataGridViewAddress.ReadOnly = true;
            using (CsvReader csv = address.connect())
            {
            
                dataGridViewAddress.ReadOnly = true;
                int n = csv.FieldCount;              
                int i = 0;                                           
                while (csv.ReadNextRecord())
                {
                    dataGridViewAddress.Rows.Add();
                    dataGridViewAddress.Rows[i].Cells[0].Value = i + 1;
                    for (int j = 0; j < n; j++)
                    {
                        dataGridViewAddress.Rows[i].Cells[j + 1].Value = csv[j].ToString();
                    }
                    i++;
                }
            }
        }

        
        
        

        private void dataGridViewAddress_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                selectIndex = e.RowIndex;
                selectId = int.Parse(dataGridViewAddress.Rows[selectIndex].Cells[1].Value.ToString());
               // MessageBox.Show(selectId.ToString());
            }
            catch (Exception r)
            {
               // MessageBox.Show(r.Message);
               // MessageBox.Show(selectIndex.ToString());
            }
        }
       

        private void DeletetoolStripButton4_Click(object sender, EventArgs e)
        {
            bool a = false;
            if (selectIndex != -1)
            {
                using (CsvReader csvCar = car.connect())
                {
                    while (csvCar.ReadNextRecord())
                    {
                        if (selectId.ToString() == csvCar[IdColumn.id_AddressId])
                        {
                            MessageBox.Show("Неможливо видалити, даний автосалон використовується!");
                            a = true;
                            break;
                        }
                    }
                }

                if (!a)
                {
                    DialogResult resut = MessageBox.Show("Автосалон " + dataGridViewAddress.Rows[selectIndex].Cells[2].Value + " не використовується.\nВидалити?", "Увага!", MessageBoxButtons.YesNo);
                    if (resut == DialogResult.Yes)
                    {
                        address.Remove(selectId);
                        dataGridViewAddress.Rows.RemoveAt(selectIndex);
                    }
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "";
                string name = "";
                string address_st = "";
                string tel = "";
                if (edit)
                {
                    id = dataGridViewAddress.Rows[selectIndex].Cells[1].Value.ToString();
                    name = dataGridViewAddress.Rows[selectIndex].Cells[2].Value.ToString();
                    address_st = dataGridViewAddress.Rows[selectIndex].Cells[3].Value.ToString();
                    tel = dataGridViewAddress.Rows[selectIndex].Cells[4].Value.ToString();
                    address.Edit(selectId, id + ";" + name + ";" + address_st + ";" + tel + ";");
                }
                else
                {
                    int n = dataGridViewAddress.RowCount - 1;
                    int k = int.Parse(address.lastId());
                    id = (k + 1).ToString();
                    name = dataGridViewAddress.Rows[n].Cells[2].Value.ToString();
                    address_st = dataGridViewAddress.Rows[n].Cells[3].Value.ToString();
                    tel = dataGridViewAddress.Rows[n].Cells[4].Value.ToString();
                    List<string> rowAddress = new List<string>();
                    rowAddress.Add(id);
                    rowAddress.Add(name);
                    rowAddress.Add(address_st);
                    rowAddress.Add(tel);
                    address.Add(rowAddress);
                }
                dataGridViewAddress.ReadOnly = true;
            }
            catch
            {
            }
        }

        private void EdittoolStripButton2_Click(object sender, EventArgs e)
        {
            dataGridViewAddress.ReadOnly = false;
            edit = true;
        }

        private void addToolStripButton1_Click(object sender, EventArgs e)
        {
            dataGridViewAddress.ReadOnly = false;
            dataGridViewAddress.Rows.Add();
            int n = dataGridViewAddress.RowCount;
            dataGridViewAddress.Rows[n - 1].Cells[0].Value = n;
        }

       
    }
}

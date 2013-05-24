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
    public partial class myColor : Form
    {
        public myColor()
        {
            InitializeComponent();
        }
        int selectIndex = -1;
        int selectId = -1;
        static string filePathColor = "Color.csv";
        CSV color = new CSV(filePathColor);

        // Load data in color table
        private void Color_Shown(object sender, EventArgs e)
        {
            using (CsvReader csv = new CsvReader(new StreamReader(filePathColor), true, ';'))
            {
                int n = csv.FieldCount;
                int i = 0;
                while (csv.ReadNextRecord())
                {
                    dataGridViewColor.Rows.Add();                    
                    dataGridViewColor.Rows[i].Cells[0].Value = i + 1;
                    for (int j = 0; j < n; j++)
                    {
                        dataGridViewColor.Rows[i].Cells[j + 1].Value = csv[j];                        
                    }
                    
                    i++;
                }
                dataGridViewColor.ReadOnly = true;
            }
        }                

        // add new row for color
        private void addToolStripButton_Click(object sender, EventArgs e)
        {
            dataGridViewColor.ReadOnly = false;
            dataGridViewColor.Rows.Add();
            int n = dataGridViewColor.RowCount;
            dataGridViewColor.Rows[n - 1].Cells[0].Value = n;
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            bool a = false;
            if (selectIndex != -1)
            {
                using (CsvReader csv = new CsvReader(new StreamReader("Car.csv"), true, ';'))
                {
                    while (csv.ReadNextRecord())
                    {
                        if (selectId.ToString() == csv[IdColumn.id_ColorId])
                        {
                            MessageBox.Show("Неможливо видалити, даний колір використовується!");
                            a = true;
                            break;
                        }
                    }
                }

                if (!a)
                {
                    DialogResult resut = MessageBox.Show("Колір " + dataGridViewColor.Rows[selectIndex].Cells[2].Value + " не використовується.\nВидалити?", "Увага!", MessageBoxButtons.YesNo);
                    if (resut == DialogResult.Yes)
                    {
                        color.Remove(selectId);
                        dataGridViewColor.Rows.RemoveAt(selectIndex);
                    }
                }
            }
        }
        
        private void dataGridViewColor_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                selectIndex = e.RowIndex;
                selectId = int.Parse(dataGridViewColor.Rows[selectIndex].Cells[1].Value.ToString());
            }
            catch
            {
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            
            int n = dataGridViewColor.RowCount - 1;
            int k = int.Parse(color.lastId());
            string id = (k + 1).ToString();
            string name = dataGridViewColor.Rows[n].Cells[2].Value.ToString();           
            List<string> rowColor = new List<string>();
            rowColor.Add(id);
            rowColor.Add(name);
            color.Add(rowColor);
            dataGridViewColor.ReadOnly = true;
         

        }

            

        

        
        
    }
}

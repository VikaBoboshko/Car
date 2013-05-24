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
    public partial class Type : Form
    {
        int selectIndex = -1;
        int selectId = -1;
        static string filePathType = "Type.csv";
        CSV color = new CSV(filePathType);
        public Type()
        {
            InitializeComponent();
        }

        private void Type_Shown(object sender, EventArgs e)
        {
            dataGridViewType.ReadOnly = true;
            using (CsvReader csv = new CsvReader(new StreamReader(filePathType), true, ';'))
            {
                int n = csv.FieldCount;
                int i = 0;
                while (csv.ReadNextRecord())
                {
                    dataGridViewType.Rows.Add();
                    dataGridViewType.Rows[i].Cells[0].Value = i + 1;
                    for (int j = 0; j < n; j++)
                    {
                        dataGridViewType.Rows[i].Cells[j + 1].Value = csv[j];
                    }

                    i++;
                }
            }
        }

        private void addTypeToolStripButton_Click(object sender, EventArgs e)
        {
            dataGridViewType.ReadOnly = false;
            dataGridViewType.Rows.Add();
            int n = dataGridViewType.RowCount;
            dataGridViewType.Rows[n - 1].Cells[0].Value = n;
        }

        private void deleteTypeToolStripButton_Click(object sender, EventArgs e)
        {
            bool a = false;
            if (selectIndex != -1)
            {
                using (CsvReader csv = new CsvReader(new StreamReader("Car.csv"), true, ';'))
                {
                    while (csv.ReadNextRecord())
                    {
                        if (selectId.ToString() == csv[IdColumn.id_TypeId])
                        {
                            MessageBox.Show("Неможливо видалити, даний тип кузова використовується!");
                            a = true;
                            break;
                        }
                    }
                }

                if (!a)
                {
                    DialogResult resut = MessageBox.Show("Тип кузова " + dataGridViewType.Rows[selectIndex].Cells[2].Value + " не використовується.\nВидалити?", "Увага!", MessageBoxButtons.YesNo);
                    if (resut == DialogResult.Yes)
                    {
                        color.Remove(selectId);
                        dataGridViewType.Rows.RemoveAt(selectIndex);
                    }
                }
            }
        }

        private void dataGridViewType_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                selectIndex = e.RowIndex;
                selectId = int.Parse(dataGridViewType.Rows[selectIndex].Cells[1].Value.ToString());
            }
            catch
            {
            }
        }

        private void saveBrandtoolStripButton_Click(object sender, EventArgs e)
        {
            int n = dataGridViewType.RowCount - 1;
            int k = int.Parse(color.lastId());
            string id = (k + 1).ToString();
            string name = dataGridViewType.Rows[n].Cells[2].Value.ToString();
            List<string> rowColor = new List<string>();
            rowColor.Add(id);
            rowColor.Add(name);
            color.Add(rowColor);
            dataGridViewType.ReadOnly = true;
        }                
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoParts.Controls
{
    public partial class TableControl : UserControl
    {
        public TableControl()
        {
            InitializeComponent();
            this.Load += DataTable;
        }

        private void DataTable(object? sender, EventArgs e)
        {
            var data = DataTableGetDatas();
            dtgv.DataSource = data;

            dtgv.Columns[nameof(Data.Id)].HeaderText = "Идентификатор";
            dtgv.Columns[nameof(Data.Name)].HeaderText = "Наименование";
        }
        private IEnumerable<Data> GetDatas()
        {


            for (var i = 0; i < 10; i++)
            {
                yield return new Data(
                    Id: i,
                    Name: i.ToString());

            }


        }
        private DataTable DataTableGetDatas()
        {
            var data = new DataTable();

            data.Columns.Add("id", typeof(int));
            data.Columns.Add("name", typeof(string));

            data.Columns["id"].Unique = true;
            data.PrimaryKey = new DataColumn[] { data.Columns["id"] };

            for (var i = 0; i < 10; i++)
            {
                var row = data.NewRow();
                row["id"] = i;
                row["name"] = "s";

                data.Rows.Add(row);
            }


            return data;
        }
    }
}

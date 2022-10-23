using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Music__Player.Properties;
namespace Music__Player.sources.View
{
    public partial class History : UserControl
    {
        //Icon icon_favorite = new Icon(Resources.favorite);
        Bitmap icon_search = new Bitmap(Resources.icon_search_blue);
        Bitmap draft = new Bitmap(Resources.draft);
        Bitmap icon_leftArrow = new Bitmap(Resources.leftArrow);
        Image icon = new Bitmap(Resources.icon_favorite_blue);

        public History()
        {
            
            InitializeComponent();

            datagridviewHistory.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagridviewHistory.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            datagridviewHistory.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            datagridviewHistory.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            datagridviewHistory.Columns[5].HeaderCell.Style.Padding = new Padding(0, 0, 20, 0);
            datagridviewHistory.Columns[5].DefaultCellStyle.Padding = new Padding(0, 0, 40, 0);

        }

        private void datagridviewHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 0)
            //    e
        }

        private void datagridviewHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (e.RowIndex < 0)
            //    return;
            //if (e.ColumnIndex == 0)
            //    e.Value = icon_favorite;
            
        }

        private void datagridviewHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
               
                int rowIndex = e.RowIndex;
                int colIndex = e.ColumnIndex;
                MessageBox.Show(datagridviewHistory.Columns[0].DefaultCellStyle.BackColor.ToString());
                datagridviewHistory.Rows[rowIndex].Cells[colIndex].Value = icon_search;
                
            }
        }

        private void datagridviewHistory_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.CellStyle.BackColor = Color.White;
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            datagridviewHistory.Rows.Add(
                new object[]
                {
                    icon_search,
                    "Tran Tuan Vu",
                    "Author",
                    "Tuan Vu Author Tran",
                    "03:14",
                    "18 October, 2021"
                }
                );
            int number = datagridviewHistory.Columns[5].HeaderCell.Style.Padding.Right;
            MessageBox.Show(number.ToString());
        }
    }
}

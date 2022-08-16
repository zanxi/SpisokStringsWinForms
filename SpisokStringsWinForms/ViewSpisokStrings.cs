using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpisokStringsWinForms
{
    public partial class ViewSpisokStrings : UserControl
    {
        public string id;
        public string valstr;

        //public event string dgGetString;
        delegate void dgGetString();

        public ViewSpisokStrings()
        {
            InitializeComponent();
                        
            dataGridView1.CellContentClick += _CellContentClick;
        }

        #region отрисовка и поиск в таблице
        public void Redraw(List<StringId> strings)
        {
            if (strings == null) return;
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(strings.Count()+1);

            try
            {

                int i = 0;
                foreach (var strId in strings)
                {
                    i++;
                    dataGridView1.Rows[i].Cells["Ind"].Value = strId.Id.ToString();
                    dataGridView1.Rows[i].Cells["Strings"].Value = strId.ValStr;
                }
            }
            catch (Exception err)
            {

            }
        }
        List<StringId> SearchInParam(List<StringId> strings, string seek)
        {
            if (seek.Length > 0)
            {
                List<StringId> stringsTemp = new List<StringId>();
                foreach (StringId var in strings)
                {
                    if (var.ValStr.ToLower().Contains(seek.ToLower()))
                    {
                        stringsTemp.Add(var);
                    }

                }
                return stringsTemp;
            }
            else return strings;
        }

        public void Redraw(List<StringId> strings, string searchText)
        {
            if (strings == null) return;
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(strings.Count());

            List<StringId> stringsTemp = SearchInParam(strings, searchText);

            try
            {

                int i = 0;
                foreach (var strId in stringsTemp)
                {
                    i++;
                    dataGridView1.Rows[i].Cells["Ind"].Value = strId.Id.ToString();
                    dataGridView1.Rows[i].Cells["Strings"].Value = strId.ValStr;
                }
            }
            catch (Exception err)
            {

            }
        }
        #endregion

        #region создание механизма взаимдействия с главной формой события нажатия на клетку в таблице
        private void _CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 1) return;
            id = dataGridView1.Rows[e.RowIndex].Cells["Ind"].Value.ToString();
            valstr = dataGridView1.Rows[e.RowIndex].Cells["Strings"].Value.ToString();
            //var cell = dataGridView[e.ColumnIndex, e.RowIndex];
            OnValueChanged(EventArgs.Empty);
        }
              

        private EventHandler onValueChanged;
        
        public event EventHandler ValueChanged
        {
            add
            {
                onValueChanged += value;
            }
            remove
            {
                onValueChanged -= value;
            }
        }
        
        protected virtual void OnValueChanged(EventArgs e)
        {
            if (onValueChanged != null)
            {
                onValueChanged.Invoke(this, e);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells["Ind"].Value.ToString();
            valstr = dataGridView1.Rows[e.RowIndex].Cells["Strings"].Value.ToString();
            OnValueChanged(EventArgs.Empty);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OnValueChanged(EventArgs.Empty);
        }
        #endregion
    }
}

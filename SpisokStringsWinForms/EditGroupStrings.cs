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
    public partial class EditGroupStrings : Form
    {
        List<StringId> strings;

        public List<StringId> newGroupStrings;
        public EditGroupStrings()
        {
            InitializeComponent();
        }

        // зарузить группу строк в окно редактирования
        public void Add(List<StringId> strings)
        {
            this.strings = strings;
            textBox_GroupName.Text = strings[0].GroupName;
            foreach(var strID in strings)
            {
                richTextBox_NewGroupStrings.AppendText(strID.ValStr+"\n");
            }
        }

        // применить изменения
        private void button2_Click(object sender, EventArgs e)
        {
            newGroupStrings = new List<StringId>();
            //richTextBox_NewGroupStrings.AppendText; 

            string[] lines = richTextBox_NewGroupStrings.Text.Split(new char[] { '\r', '\n', }, StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[lines.Length];
            for (int i = 0; i < array.Length; i++)
            {
                //array[i] = int.Parse(lines[i]);
                newGroupStrings.Add(new StringId() {  ValStr = lines[i], GroupName = textBox_GroupName.Text });
                
            }

             this.Close();
        }

        // отмена изменений
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

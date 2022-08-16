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
    public partial class Form2 : Form
    {
        SpisokStrings spisokStrings; // генерация  строк
        SpisokStrings spisokStringsId; // генерация групп строк
        SpisokStringsDB stringsDB; // инстанс БД
        
        public Form2()
        {
            InitializeComponent();

            // события перехвата нажатия на клетки в контролах просмотра таблиц
            this.viewSpisokStrings1.ValueChanged += ViewSpisokStrings1_ValueChanged;
            this.viewSpisokStringsGroup1.ValueChanged += ViewSpisokStringsGroup1_ValueChanged; ;
            Load += Form1_Load;

        }

        private void ViewSpisokStringsGroup1_ValueChanged(object sender, EventArgs e)
        {
            textBox_IDGroup.Text = viewSpisokStringsGroup1.groupname;
            textBox_GroupStrings.Text = viewSpisokStringsGroup1.valstr;

            if (textBox_IDGroup.Text != "")
            {
                List<StringId> listStrId = stringsDB.GetSpisokStringsGroup(textBox_IDGroup.Text);
                comboBox_spisokStrings.Items.Clear();
                foreach (StringId strID in listStrId)
                {
                    comboBox_spisokStrings.Items.Add(strID.ValStr);
                };
                label_CheckSpisokStrings.Text = "Группа содержит "+listStrId.Count + " строк";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Проверка подключения к БД
            // --------Проверка подключения к БД------------------------------------

            AutorizationDBServer DBCon = new AutorizationDBServer();
            DBCon.ShowDialog();

            // создаем инстанс для связи с БД
            stringsDB = new SpisokStringsDB(
                DBCon.textBox_IPSQLServer.Text,
                DBCon.textBox_NameDB.Text,
                DBCon.textBox_loginDB.Text,
                DBCon.textBox_passwordDB.Text);

            try
            {
                stringsDB.TestOpen();
            }
            catch
            {
                MessageBox.Show("Не удается подключиться. проверте учетную запись.");
                this.Close();                
            }

            #endregion

            #region Работа с 1-й вкладкой - работа с строками
            // -----Работа с строками --------------------
            // создаем списко строк
            spisokStrings = new SpisokStrings();

            

            // читаем список строк из БД
            List<StringId> listStrId = stringsDB.GetSpisokStrings();
            if(listStrId.Count ==0)
            {
                stringsDB.Create(spisokStrings.Strings);
                listStrId = stringsDB.GetSpisokStrings();
            }

            //MessageBox.Show(spisokStrings.Strings[0]);
            //viewSpisokStrings1.Redraw(spisokStrings.Strings);
            if(listStrId!=null) viewSpisokStrings1.Redraw(listStrId);
            #endregion

            #region Работа с 2-й вкладкой - работа с группами строк
            // -----------Работа со списком групп слов --------------------------------------

            // создаем списко строк
            // генератор случайных чисел
            spisokStringsId = new SpisokStrings("GroupName");

            // читаем список строк из БД
            List<StringId> listStrId2 = stringsDB.GetSpisokStringsGroup();
            if (listStrId2.Count == 0)
            {
                stringsDB.Create(spisokStringsId.StringsId);
                listStrId2 = stringsDB.GetSpisokStringsGroup();
            }

            //MessageBox.Show(spisokStrings.Strings[0]);
            //viewSpisokStrings1.Redraw(spisokStrings.Strings);
            if (listStrId2 != null) viewSpisokStringsGroup1.Redraw(listStrId2);

            #endregion
        }

        #region поиск по таблице
        private void searchText_TextChanged(object sender, EventArgs e)
        {
            //vtBuf = ((ViewTable)ctrl);

            //читаем БД
            List<StringId> listStrId = stringsDB.GetSpisokStrings();
            //перерисовываем таблицу
            viewSpisokStrings1.Redraw(listStrId, searchText.Text);

            //viewSpisokStrings1.Redraw(spisokStrings.Strings, searchText.Text.ToLower());            
        }
        #endregion

        private void searchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //viewSpisokStrings1.Redraw(spisokStrings.Strings, searchText.Text.ToLower());
                //viewSpisokStrings1.Redraw(spisokStrings.Strings, searchText.Text.ToLower());

                //читаем БД
                //List<StringId> listStrId = stringsDB.GetSpisokStrings();
                //перерисовываем таблицу
                //viewSpisokStrings1.Redraw(listStrId, searchText.Text);
            }
        }

        private void ViewSpisokStrings1_ValueChanged(object sender, EventArgs e)
        {
            textBox_Id.Text = viewSpisokStrings1.id;
            textBox_ValueStr.Text = viewSpisokStrings1.valstr;

        }

        private void viewSpisokStrings1_Load(object sender, EventArgs e)
        {

        }

        #region кнопки - сохранения, добавления, удаления, очистки таблицы строк
        private void button_SaveIDString_Click(object sender, EventArgs e)
        {
            //stringsDB.Update(spisokStrings);
            if (textBox_Id.Text == "")
            {
                MessageBox.Show("Ошибка: не указан номер записи");
                return;
            }
            stringsDB.Update(int.Parse(textBox_Id.Text), textBox_ValueStr.Text);
            MessageBox.Show("Запись изменена.");

            //читаем БД
            List<StringId> listStrId = stringsDB.GetSpisokStrings();
            //перерисовываем таблицу
            viewSpisokStrings1.Redraw(listStrId);

        }

        private void button_AddIDString_Click(object sender, EventArgs e)
        {
            if (textBox_ValueStr.Text == "")
            {
                MessageBox.Show("Ошибка: введена пустая строка");
                return;
            }
            stringsDB.Add(textBox_ValueStr.Text);
            MessageBox.Show("Строка добавлена в конец таблицы.");

            //читаем БД
            List<StringId> listStrId = stringsDB.GetSpisokStrings();
            //перерисовываем таблицу
            viewSpisokStrings1.Redraw(listStrId);
        }

        private void button_DeleteIDString_Click(object sender, EventArgs e)
        {
            if (textBox_Id.Text == "")
            {
                MessageBox.Show("Ошибка: не указан номер записи");
                return;
            }
            stringsDB.Delete(int.Parse(textBox_Id.Text));
            MessageBox.Show("Запись удалена.");
            textBox_Id.Text = "";
            textBox_ValueStr.Text = "";

            //читаем БД
            List<StringId> listStrId = stringsDB.GetSpisokStrings();
            //перерисовываем таблицу
            viewSpisokStrings1.Redraw(listStrId);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            stringsDB.DeleteAll(Datas.TableSpisokStrings);
            MessageBox.Show("Все данные удалены");
            textBox_Id.Text = "";
            textBox_ValueStr.Text = "";

            //читаем БД
            List<StringId> listStrId = stringsDB.GetSpisokStrings();
            //перерисовываем таблицу
            viewSpisokStrings1.Redraw(listStrId);
        }
        #endregion

        #region редактирование групп строк
        //редактирование групп строк
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox_IDGroup.Text == "")
            {
                MessageBox.Show("Группа не выбрана");
                return;
            }
            List<StringId> listStrId = stringsDB.GetSpisokStringsGroup(textBox_IDGroup.Text);
            EditGroupStrings editGS = new EditGroupStrings();
            editGS.Add(listStrId);
            editGS.ShowDialog();

            if (editGS.newGroupStrings != null)
            {
                stringsDB.Delete(textBox_IDGroup.Text);
                stringsDB.Add(editGS.newGroupStrings);
                MessageBox.Show("Изменения группы обновлены в таблице.");

                //читаем БД
                List<StringId> listStrId2 = stringsDB.GetSpisokStringsGroup();
                //перерисовываем таблицу
                viewSpisokStringsGroup1.Redraw(listStrId2);

            }

            comboBox_spisokStrings.Items.Clear();
            textBox_IDGroup.Text = "";
            textBox_GroupStrings.Text = "";
        }

        #endregion

        #region поиск по группам строк
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //читаем БД
            List<StringId> listStrId = stringsDB.GetSpisokStringsGroup();
            //перерисовываем таблицу
            viewSpisokStringsGroup1.Redraw(listStrId, textBox_SearchGroup.Text);
        }
        #endregion
        
        #region поиск по словам в группах
        private void textBox_SearchTextGroup_TextChanged(object sender, EventArgs e)
        {
            //читаем БД
            List<StringId> listStrId = stringsDB.GetSpisokStringsGroup();
            //перерисовываем таблицу
            viewSpisokStringsGroup1.Redraw(listStrId, textBox_SearchTextGroup.Text,false);
        }
        #endregion

        #region кнопки - добавления, редактирования, удаления, очистки таблицы групп строк
        private void button2_Click(object sender, EventArgs e)
        {
            EditGroupStrings editNewGS = new EditGroupStrings();
            editNewGS.ShowDialog();
            if(editNewGS.textBox_GroupName.Text=="")
            {
                MessageBox.Show("не задано имя группы.Изменений не было внесено в БД");
                return;
            }
            if(editNewGS.newGroupStrings!=null)
            {
                stringsDB.Add(editNewGS.newGroupStrings);
                MessageBox.Show("Новая группа добавлена в конец таблицы.");

                //читаем БД
                List<StringId> listStrId = stringsDB.GetSpisokStringsGroup();
                //перерисовываем таблицу
                viewSpisokStringsGroup1.Redraw(listStrId);

            }
            comboBox_spisokStrings.Items.Clear();
            textBox_IDGroup.Text = "";
            textBox_GroupStrings.Text = "";
            //stringsDB.   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_IDGroup.Text == "")
            {
                MessageBox.Show("Ошибка: не указан группа строк для удаления");
                return;
            }
            stringsDB.Delete(textBox_IDGroup.Text);
            MessageBox.Show("Группа строк удалена.");
            textBox_IDGroup.Text = "";
            textBox_GroupStrings.Text = "";
            comboBox_spisokStrings.Items.Clear();

            //читаем БД
            List<StringId> listStrId = stringsDB.GetSpisokStringsGroup();
            //перерисовываем таблицу
            viewSpisokStringsGroup1.Redraw(listStrId);

            comboBox_spisokStrings.Items.Clear();
            textBox_IDGroup.Text = "";
            textBox_GroupStrings.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stringsDB.DeleteAll(Datas.TableSpisokStringsGroup);
            MessageBox.Show("Все данные удалены");
            textBox_IDGroup.Text = "";
            textBox_GroupStrings.Text = "";
            comboBox_spisokStrings.Items.Clear();

            //читаем БД
            List<StringId> listStrId = stringsDB.GetSpisokStringsGroup();
            //перерисовываем таблицу
            viewSpisokStringsGroup1.Redraw(listStrId);
            
        }
        #endregion

    }
}

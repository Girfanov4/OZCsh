using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oz31_32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //////////////////////////////////////////////////////////////////////////////////////
        //обработка нажатия кнопки 1
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы нажали на кнопку " + ((Button)sender).Text);
        }
        //обработка нажатия кнопки 2
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы нажали на кнопку " + ((Button)sender).Text);
        }
        //////////////////////////////////////////////////////////////////////////////////////
        //обработка нажатия чекбокса 1
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            MessageBox.Show("Новое значение " + checkBox.Name + " равно " + checkBox.Checked.ToString());
        }
        //обработка нажатия чекбокса 2
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            MessageBox.Show("Новое значение " + checkBox.Name + " равно " + checkBox.Checked.ToString());
        }
        //обработка нажатия чекбокса 3
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            MessageBox.Show("Новое значение " + checkBox.Name + " равно " + checkBox.Checked.ToString());
        }
        //////////////////////////////////////////////////////////////////////////////////////
        /// //Обработка переключателя 1
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                tabPage3.BackColor = Color.Red;
            }
        }
        //Обработка переключателя 2
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                tabPage3.BackColor = Color.Green;
            }
        }
        //Обработка переключателя 3
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                tabPage3.BackColor = Color.Blue;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////
        //Заполнение ListView данными при запуске
        private void Form1_Load(object sender, EventArgs e)
        {
            
            listView1.Items.Add(new CountryItem("United States", "US", "Dollar")); listView1.Items[0].ImageIndex = 0;

            listView1.Items.Add(new CountryItem("Great Britain", "GB", "Pound")); listView1.Items[1].ImageIndex = 1;

            listView1.Items.Add(new CountryItem("Canada", "CA", "Dollar")); listView1.Items[2].ImageIndex = 2;

            listView1.Items.Add(new CountryItem("Japan", "JP", "Yen")); listView1.Items[3].ImageIndex = 3;

            listView1.Items.Add(new CountryItem("Germany", "GM", "Euro")); listView1.Items[4].ImageIndex = 4;

        }
        public class CountryItem : System.Windows.Forms.ListViewItem
        {
            string _cntryName = ""; string _cntryAbbrev = ""; string _currency = "";
            public CountryItem(string countryName, string countryAbbreviation, string currency)
            {
                _cntryName = countryName;
                _cntryAbbrev = countryAbbreviation;
                _currency = currency;
                base.Text = _cntryName + "\n" + _cntryAbbrev + "\n" + _currency;
                base.SubItems.Add(currency);
            }

            public string CountryName
            {
                get { return _cntryName; }
            }

            public string CountryAbbreviation
            {
                get { return _cntryAbbrev; }
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////
        //Обработка поля ввода на пустоту
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                //Добавление элемента в ListBox
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = null;
            }
            else
            {
                MessageBox.Show("Заполните поле ввода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Обработка удаления элемента ListBox 
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
            }
            catch
            {
                MessageBox.Show("Выберите элемент", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      
    }
}

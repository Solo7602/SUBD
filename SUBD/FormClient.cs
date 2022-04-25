using DATABASE.Implements;
using DATABASE.TABLES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUBD
{
    public partial class FormClient : Form
    {
        ClientStorage _Storage;
        HotelStorage HotelStorage;
        public FormClient()
        {
            InitializeComponent();
            _Storage = new ClientStorage();
            HotelStorage = new HotelStorage(); 
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            int IdHotel = (int)comboBoxHotel.SelectedValue;
            try
            {
                _Storage.Insert(new Client()
                {
                    Name = name,
                    Surname = surname,
                    idHotel = IdHotel
                });
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            int id = (int)comboBoxId.SelectedValue;
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            int IdHotel = (int)comboBoxHotel.SelectedValue;
            try
            {
                _Storage.Update(new Client()
                {
                    Id = id,
                    Name = name,
                    Surname= surname,
                    idHotel= IdHotel 
                });
            }
            catch
            {
                MessageBox.Show("Отсутствует запись с данным индексом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                _Storage.Delete(new Client() { Id = (int)comboBoxId.SelectedValue });
            }
            catch
            {
                MessageBox.Show("Отсутствует запись с данным индексом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                List<Client> list;
                list = _Storage.GetFullList();
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
                    foreach (var component in list)
                    {
                        comboBoxId.DisplayMember = "Id";
                        comboBoxId.ValueMember = "Id";
                        comboBoxId.DataSource = list;
                        comboBoxId.SelectedItem = null;
                    }
                }
                var Hotel = HotelStorage.GetFullList();
                if (Hotel != null)
                {
                    foreach (var component in Hotel)
                    {
                        comboBoxHotel.DisplayMember = "Id";
                        comboBoxHotel.ValueMember = "Id";
                        comboBoxHotel.DataSource = Hotel;
                        comboBoxHotel.SelectedItem = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

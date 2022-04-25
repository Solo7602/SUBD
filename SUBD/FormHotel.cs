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
    public partial class FormHotel : Form
    {
        HotelStorage _Storage;
        public FormHotel()
        {
            InitializeComponent();
            _Storage = new HotelStorage();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            int star = Convert.ToInt32(textBoxStars.Text);
            int place = Convert.ToInt32(textBoxPlaces.Text);
            try
            {
                _Storage.Insert(new Hotel()
                {
                    Name = name,
                    Stars = star,
                    Places = place
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
            int star = Convert.ToInt32(textBoxStars.Text);
            int place = Convert.ToInt32(textBoxPlaces.Text);
            try
            {
                _Storage.Update(new Hotel()
                {
                    Id = id,
                    Name = name,
                    Stars = star,
                    Places = place
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
                _Storage.Delete(new Hotel() { Id = (int)comboBoxId.SelectedValue });
            }
            catch
            {
                MessageBox.Show("Отсутствует запись с данным индексом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                List<Hotel> list;
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormHotel_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

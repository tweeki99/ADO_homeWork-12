using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityPhones
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            using (var context = new PhoneAppContext())
            {
                foreach (var city in context.Cities.ToList())
                {
                    ComboBoxCities.Items.Add(city.Name);
                }
            }
        }

        private void ComboBoxCitiesSelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGridViewNumbers();

            using (var context = new PhoneAppContext())
            {
                TextBoxCode.Text = context.Cities.Where(c => c.Name == ComboBoxCities.SelectedItem.ToString()).FirstOrDefault().Code.ToString();
            }
        }

        private void ButtonAddNumberClick(object sender, EventArgs e)
        {
            string number = MaskedTextBoxNumber.Text;

            if (TextBoxCode.Text == "XXXX")
            {
                MessageBox.Show("Выберете город");
                return;
            }

            number = number.Replace("-", string.Empty);
            if (number.Length != 6)
            {
                MessageBox.Show("Неверный формат телефона");
                return;
            }

            using (var context = new PhoneAppContext())
            {
                City selectedCity = context.Cities.Where(c => c.Name == ComboBoxCities.SelectedItem.ToString()).FirstOrDefault();

                if (selectedCity != null)
                {
                    context.Numbers.Add(
                        new Number
                        {
                            CityId = selectedCity.Id,
                            City = selectedCity,
                            PhoneNumber = Convert.ToInt32(number)
                        });
                    context.SaveChanges();
                    MaskedTextBoxNumber.Text = "";
                    LoadDataGridViewNumbers();
                }
            }
        }

        private void LoadDataGridViewNumbers()
        {
            DataGridViewNumbers.Rows.Clear();
            DataGridViewNumbers.Columns.Clear();

            DataGridViewNumbers.Columns.Add("Code", "Код города");
            DataGridViewNumbers.Columns.Add("Number", "Номер");

            using (var context = new PhoneAppContext())
            {
                var numbers = context.Numbers.Where(n => n.City.Name == ComboBoxCities.SelectedItem.ToString()).ToList();

                for (int i = 0; i < numbers.Count(); i++)
                {
                    List<string> data = new List<string>();

                    data.Add(numbers[i].City.Code.ToString());
                    data.Add(numbers[i].PhoneNumber.ToString());

                    DataGridViewNumbers.Rows.Add(data.ToArray());
                }
            }
        }
    }
}

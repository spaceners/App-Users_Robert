using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Users
{
    public partial class Form2 : Form
    {
        DateTime birthDate;
        public Form2()
        {
            InitializeComponent();
        }

        internal void receiveDetails(dynamic item)
        {
            textID.Text = item.id.value;  
            textFirstname.Text = item.name.first;
            textLastName.Text = item.name.last;
            textAddress.Text = item.location.street.number+" "+item.location.street.name;
            textCity.Text = item.location.city;
            textState.Text = item.location.state;
            textCountry.Text = item.location.country;
            textZipCode.Text = item.location.postcode;
            textEmail.Text = item.email;
            textDOB.Text = string.Format("{0:dd/MMMM/yyyy}", item.dob.date);
            textPhoneNumber.Text = item.phone;
            DateTime.TryParse(string.Format("{0:dd/MMMM/yyyy}", item.dob.date), out birthDate);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime nextBirthday = birthDate.AddYears(CalculateAge() + 1);

            TimeSpan difference = nextBirthday - DateTime.Today;

            label1.Text = difference.TotalDays + " days to birthday";
            if (difference.TotalDays <= 100)
            {
                label1.Text = difference.TotalHours + " Hours to birthdat";
            }
            if (difference.TotalHours <= 1500)
            {
                label1.Text = difference.TotalHours + " Minutes to birthdat";
            }
            if (difference.TotalMinutes <= 1)
            {
                label1.Text = difference.TotalSeconds + " Seconds to birthdat";
            }
        }

        public int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (today < birthDate.AddYears(age))
                age--;
            return age;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

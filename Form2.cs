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
        double totalSeconds;
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
            if (DateTime.TryParse(string.Format("{0:dd/MMMM/yyyy}", item.dob.date), out birthDate))
            {
                TimeSpan timeDiff = DateTime.Now - birthDate;
                totalSeconds = timeDiff.TotalSeconds;
            }

            TimeSpan month = TimeSpan.FromSeconds(totalSeconds);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;
                TimeSpan month = TimeSpan.FromSeconds(totalSeconds);


            }
        }
    }
}

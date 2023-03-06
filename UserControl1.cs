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
    public partial class ucDashboardPage : UserControl
    {
        List<String> userInfo = new List<String>();

        public ucDashboardPage()
        {
            InitializeComponent();
        }

        internal void receiveData(string response)
        {
            throw new NotImplementedException();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Windows.Forms;

namespace App_Users
{
    public partial class frmAppUsers : Form
    {
        Form2 userDetails = new Form2();
        private static string userList;
        private BindingSource userListBindingSouce = new BindingSource();
        static List<String> userNames = new List<String>();
        private int page = 1;
        private int limit = 100;
        private dynamic recentlyViewed;


        public frmAppUsers()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (recentlyViewed == null)
            {
                btnRecentlyViewed.Enabled = false;
            }
       
            ucUserProfile1.Show();
        }
        
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ucUserProfile1.Hide();
            string endpoint = "https://randomuser.me/api/?page=" + page + "&results="+ limit+"&seed=abc";
            displayUsers(formatResponse(endpoint));
        }

        private dynamic formatResponse(string endpoint)
        {
            
            string response = get(endpoint);
            userList = response;
            dynamic reader = JsonConvert.DeserializeObject<dynamic>(response);

            return reader;
        }

        private void displayUsers(dynamic reader)
        {
            userNames.Clear();
            foreach (var user in reader["results"])
            {
                string name = user["name"]["first"] + " " + user["name"]["last"];
                userNames.Add(name);
            }
            if (userNames.Count < limit)
            {
                btnNext.Enabled = false;  
            }
            else
            {
                btnNext.Enabled = true;
            }

            processDataBinding();
        }

        public string get(string endpoint)
        {
            HttpRequest httpRequest = new HttpRequest();
            httpRequest.endPoint = endpoint;
            httpRequest.method = "GET";

            string response = httpRequest.makeRequest();

            return response;
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            ucUserProfile1.Show();
            ucUserProfile1.BringToFront();
        }


        /*
         Search button Function
        */
        private void button3_Click(object sender, EventArgs e)
        {
            userNames.Clear();
            
            string input = textSearch.Text.ToString();
            dynamic userDDearchList = JsonConvert.DeserializeObject<dynamic>(userList);
            if (input.Length >= 1)
            {
                foreach (var item in userDDearchList["results"])
                {
                    string name = item["name"]["first"] + " " + item["name"]["last"];
                    name = name.ToLower();

                    if (name.Contains(input.ToLower()))
                    {
                        userNames.Add(name);
                    }
                }

                processDataBinding();
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            dynamic users = JsonConvert.DeserializeObject<dynamic>(userList);
            if (users["results"].Count >= 1)
            {
                foreach (var item in users["results"])
                {
                    string name = item["name"]["first"] + " " + item["name"]["last"];
                    if (name.ToLower() == userNames[index].ToLower())
                    {
                        recentlyViewed = item;
                        userDetails.receiveDetails(item);
                        userDetails.ShowDialog(); 
                    }
                }
            }
            if (recentlyViewed != null)
            {
                btnRecentlyViewed.Enabled = true; 
            }
        }

        private void ucUserProfile1_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            userNames.Clear();
            page++;
            string endpoint = "https://randomuser.me/api/?page=" + page + "&results="+ limit +"& seed=abc";
            displayUsers(formatResponse(endpoint));
            if (page == 2)
            {
                btnPrevious.Enabled = true;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            userNames.Clear();
            page--;
            string endpoint = "https://randomuser.me/api/?page=" + page + "&results="+ limit +"& seed=abc";
            displayUsers(formatResponse(endpoint));
            if(page <= 1)
            {
                btnPrevious.Enabled = false;
            }
           
        }

        private void btnRecentlyViewed_Click(object sender, EventArgs e)
        {        
            userDetails.receiveDetails(recentlyViewed);
            userDetails.ShowDialog();
        }

        private void processDataBinding()
        {
            userListBindingSouce.DataSource = userNames;

            listBox1.DataSource = userListBindingSouce;
            userListBindingSouce.ResetBindings(false);
        }
    }
}

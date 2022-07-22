using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordScamStopper2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private string Compare(ComboBox cb)
        {
            if (cb.Text == "Discord")
            {
                return "https://discord";
            }
            if (cb.Text == "Apple")
            {
                return "https://apple.com";
            }
            if (cb.Text == "Roblox")
            {
                return "https://roblox.com";
            }
            if (cb.Text == "Steam")
            {
                return "steampowered.com";
            }
            if (cb.Text == "Github")
            {
                return "https://github.com";
            }
            if (cb.Text == "Instagram")
            {
                return "https://instagram.com";
            }
            if (cb.Text == "Twitter")
            {
                return "https://twitter.com";
            }
            if (cb.Text == "Facebook")
            {
                return "https://facebook.com";
            }


            return "idk";


        }
        private bool CompareBothURLs(RichTextBox box, string outsite)
        {
            return box.Text.Contains(outsite);
        }

               //  private void PostData(bool isreal, CheckBox check)
               //{
               // if(check.Checked == true)
               //   {
               //    if(isreal == false)
               // {
                   // var values = new Dictionary<string, string>
                   // {
                   //   { "NotImplemtmented" }
                   // };

                   // var content = new FormUrlEncodedContent(values);

                   // var response =  client.PostAsync("awiresoftware.xyz:6900/postscam", content);

                    // var responseString = response.Content.ReadAsStringAsync();
                // }
               // else
                //{
                    //return;
               /// }
            //}
         //else
            //{
              //  return;
           // }
       // }
    }
}

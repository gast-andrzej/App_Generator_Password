using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generator_Password
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GENERATOR_Click(object sender, EventArgs e)
        {
            int z;
            Int32.TryParse(TextBox.Text, out z);
            
            List<string> asciiCharacters = new List<string>();

            // ASCII Letters (Uppercase)
            for (int i = 65; i <= 90; i++)
            {
                char c = Convert.ToChar(i);
                asciiCharacters.Add(c.ToString());
            }

            // ASCII Letters (Lowercase)
            for (int i = 97; i <= 122; i++)
            {
                char c = Convert.ToChar(i);
                asciiCharacters.Add(c.ToString());
            }

            // ASCII Digits
            for (int i = 48; i <= 57; i++)
            {
                char c = Convert.ToChar(i);
                asciiCharacters.Add(c.ToString());
            }

            // ASCII Punctuation
            for (int i = 33; i <= 47; i++)
            {
                if (i == 34 || i == 39 || i == 92)
                    continue;

                char c = Convert.ToChar(i);
                asciiCharacters.Add(c.ToString());
            }
            var random = new Random();
            int index = 0;
            List<string> listex = new List<string>();
            for (; index < z; index++)
            {
                int ind = random.Next(asciiCharacters.Count);
                listex.Add(asciiCharacters[ind]);
            }
            var build = new StringBuilder();
            for (int i = 0; i < listex.Count; i++)
            {
                build.Append(listex[i]);
            }
            string resul = build.ToString();
            Password.Text = resul;
        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Password.Text);
            MessageBox.Show("Your Password is copied");
        }
    }
}

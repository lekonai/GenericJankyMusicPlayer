using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // create global variables of a string array to save titles of tracks
        String[] paths, files;

        private void btnSltSong_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); // selects songs
            // code to select multiple files:
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; // saves the names of the tracks 
                paths = ofd.FileNames; // saves the paths of the tracks
                // display music titles in listbox
                for(int i = 0; i <= files.Length; i++)
                {
                    listBoxSong.Items.Add(files[i]); //display songs in list box
                }
            }
        }

        private void logo1_Click(object sender, EventArgs e)
        {
            // gonna make this open a funny cat gif just you watch :)
            kittyBox.Visible = true;
        }

        private void listBoxSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this will play songs.
            wmpMusic1.URL = paths[listBoxSong.SelectedIndex];
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxSong.Items.Clear();
        }

        private void kittyBox_Click(object sender, EventArgs e)
        { 
            kittyBox.Visible = false;
        }

        private void picCross_Click(object sender, EventArgs e)
        {
            this.Close(); // it's a bit obvious this does doesn't it?
        }
    }
}

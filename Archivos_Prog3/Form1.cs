using System.IO;
using System.Diagnostics;

namespace Archivos_Prog3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void searchDirectories(string direc)
        {
            try
            {

                DirectoryInfo d = new DirectoryInfo(@direc);

                DirectoryInfo[] d2 = d.GetDirectories("*");
                FileInfo[] fileInfo = d.GetFiles("*");

                cmbxDirectories.Items.Clear();
                cmbxDirectories.Text = "";

                foreach (FileInfo files in fileInfo)
                {

                    cmbxDirectories.Items.Add(direc + files.Name);
                }

                foreach (DirectoryInfo directoryInfo in d2)
                {
                    cmbxDirectories.Items.Add(direc+directoryInfo.Name);
                } 

            }catch(SystemException ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);    
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(cmbxDirectories.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a directory or it not exist that file.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            string direc = cmbxDirectories.SelectedItem.ToString();

            if (!direc.EndsWith("\\"))
            {
                direc += "\\";
            }

            txtTitle.Clear();

            txtTitle.Text = direc;  

            searchDirectories(direc);
        }

        private void cmbxDirectories_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbxDirectories.Text.Contains(".txt") || cmbxDirectories.Text.Contains("."))
            {
                btnRead.Visible = true;
                btnSearch.Visible = false;
            }
            else
            {
                btnSearch.Visible = true;
                btnRead.Visible = false;
                return;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                string text = File.ReadAllText(cmbxDirectories.Text);

                txtbxResults.Text = text;
            }catch(SystemException ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);  
            }
        }

    }
}
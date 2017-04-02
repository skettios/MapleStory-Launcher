using System.Windows.Forms;

namespace MSLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            
            exeBrowseDialog.Multiselect = false;
            exeBrowseDialog.CheckFileExists = true;
            exeBrowseDialog.Filter = @"MapleStory (*.exe)|MapleStory.exe";
            methodComboBox.SelectedIndex = 0;
            if (Application.UserAppDataRegistry.GetValue("MaplePath") != null)
                mapleLocationTextbox.Text = Application.UserAppDataRegistry.GetValue("MaplePath").ToString();
        }

        private void exeBrowseButton_Click(object sender, System.EventArgs e)
        {
            if (exeBrowseDialog.ShowDialog() == DialogResult.OK)
            {
                Application.UserAppDataRegistry.SetValue("MaplePath", mapleLocationTextbox.Text);
            }
        }

        private void exeBrowseDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mapleLocationTextbox.Text = exeBrowseDialog.FileName;
        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            if (idTextBox.Text == "" || passwordTextbox.Text == "")
            {
                MessageBox.Show(this, @"Email/ID or Password is incomplete!", @"Account Information");
                return;
            }

            if (MapleStoryLauncher.LaunchMaple(idTextBox.Text, passwordTextbox.Text, mapleLocationTextbox.Text, methodComboBox.Text))
                Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.UserAppDataRegistry.SetValue("MaplePath", mapleLocationTextbox.Text);
        }
    }
}

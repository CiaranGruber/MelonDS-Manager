using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDSMForms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MDSMMainMenu_Load(object sender, EventArgs e)
        {
            FormNav.SelectNextForm(Forms.Close);
        }

        private void Btn_Installer_Click(object sender, EventArgs e)
        {
            FormNav.SelectNextForm(Forms.Close);
            Close();
        }

        private void Btn_RomManager_Click(object sender, EventArgs e)
        {

        }
    }
}

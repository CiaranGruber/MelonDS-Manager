using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDSMBaseApplication;


namespace MDSMForms
{
    /// <summary>
    /// The Form Navigation that acts as a base form between all screens
    /// </summary>
    public partial class FormNav : Form
    {
        /// <summary>The application that is currently running</summary>
        private MDSMBaseApp RunningApp;
        private static Forms NextForm;
        private static object[] NextFormData;

        /// <summary>
        /// Initialises a new Form Navigation instance specifying the initial form to load
        /// </summary>
        /// <param name="startingForm">The initial form that will be loading upon the beginning of the program</param>
        public FormNav(Forms startingForm) : this(startingForm, new object[0])
        {

        }

        /// <summary>
        /// Initialises a new Form Navigation instance specifying the initial form to load and additional data to begin the program
        /// </summary>
        /// <param name="startingForm">The initial form that will be loading upon the beginning of the program</param>
        /// <param name="startingFormData">The data to be sent to the starting form</param>
        public FormNav(Forms startingForm, object[] startingFormData)
        {
            InitializeComponent();
            SelectNextForm(startingForm, startingFormData);
        }

        private void FormNav_Load(object sender, EventArgs e)
        {
            Form nextForm;
            while (NextForm != Forms.Close)
            {
                // Create next instance of form to be loaded
                if (NextForm == Forms.StartingForm)
                    nextForm = new MainMenu();
                else
                    throw new NotImplementedException("Form does not exist");

                // Hide loading screen until the form is closed
                Hide();
                nextForm.ShowDialog();
                if (NextForm != Forms.Close) Show();
            }

            // Close form navigation when complete
            Close();
        }

        /// <summary>
        /// Selects the next form to be opened
        /// </summary>
        /// <param name="nextForm">The next form to open</param>
        public static void SelectNextForm(Forms nextForm)
        {
            SelectNextForm(nextForm, new object[0]);
        }

        /// <summary>
        /// Selects the next form to be opened with additional data
        /// </summary>
        /// <param name="nextForm">The next form to open</param>
        /// <param name="additionalData">Additional data to be carried to the next form</param>
        public static void SelectNextForm(Forms nextForm, object[] additionalData)
        {
            NextForm = nextForm;
            NextFormData = additionalData;
        }
    }
}

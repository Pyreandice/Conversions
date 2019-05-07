using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversions_Homework_9_GraysonBeam
{
    public partial class MainForm : Form
    {
        public List<Conversions> ConversionsList { get; set; } = new List<Conversions>();

        public MainForm()
        {
            InitializeComponent();
        }

        public void BindRichTextBox()
        {

        }

        public void BindComboBox()
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            
        }

        private void AddEditButton_Click(object sender, EventArgs e)
        {
            var openForm = new ConversionForm();
            var result = openForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.ConversionsList.Add(openForm.ToConversions);
            }
            // else, the user has clicked cancel, DoNothing();
        }
    }
}

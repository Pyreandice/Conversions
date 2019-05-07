using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversions_Homework_9_GraysonBeam
{
    public partial class ConversionForm : Form
    {
        public Conversions ToConversions { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversionForm"/> class.
        /// </summary>
        public ConversionForm()
        {
            InitializeComponent();
            const double MilesToKilos = 1.6093;
            const double KilosToMiles = 0.6214;
            const double InchToCenti = 2.54;
            const double CentiToInch = 0.3937;
        }


    }
}

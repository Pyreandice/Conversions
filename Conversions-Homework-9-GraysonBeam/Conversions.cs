using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace Conversions_Homework_9_GraysonBeam
{
    public class Conversions
    {
        /// <summary>
        /// Gets or sets from unit.
        /// </summary>
        /// <value>
        /// From unit.
        /// </value>
        public double FromUnit { get; set; }

        /// <summary>
        /// Gets or sets from value.
        /// </summary>
        /// <value>
        /// From value.
        /// </value>
        public double FromValue { get; set; }

        /// <summary>
        /// Converts to unit.
        /// </summary>
        /// <value>
        /// To unit.
        /// </value>
        public double ToUnit { get; set; }

        /// <summary>
        /// Converts to value.
        /// </summary>
        /// <value>
        /// To value.
        /// </value>
        public double ToValue { get; set; }

        /// <summary>
        /// Gets or sets the conversion ratio.
        /// </summary>
        /// <value>
        /// The conversion ratio.
        /// </value>
        public double ConversionRatio { get; set; }

    }
}

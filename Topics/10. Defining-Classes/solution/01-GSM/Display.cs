using System;
using System.Text;

namespace MobilePhone
{
    public class Display
    {
        // Private Constans
        private const double MinSizeInches = 0.5;
        private const double MaxSizeInches = 100;
        private const ulong MaxNumberOfColors = ulong.MaxValue;

        // Private Fields
        private double? sizeInches = null;
        private ulong? numberOfColors = null;

        // Constructors
        public Display(double? sizeInches = null, ulong? numberOfColors = null)
        {
            this.SizeInches = sizeInches;
            this.NumberOfColors = numberOfColors;
        }

        // Properties
        public double? SizeInches
        {
            get { return this.sizeInches; }
            set
            {
                if (value.HasValue && (value < MinSizeInches || value > MaxSizeInches))
                    throw new ArgumentOutOfRangeException("Display size's value is not in range!");

                this.sizeInches = value;
            }
        }

        public ulong? NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if (value.HasValue && value > MaxNumberOfColors)
                    throw new ArgumentOutOfRangeException("Number of colors has too big value!");
                
                this.numberOfColors = value;
            }
        }

        // Override method
        public override string ToString()
        {
            StringBuilder displayInfo = new StringBuilder();

            displayInfo.AppendLine("--> DISPLAY <--");

            if (this.sizeInches.HasValue)
                displayInfo.AppendLine(string.Format("Size: {0}-inch", sizeInches));

            if (this.numberOfColors.HasValue)
                displayInfo.AppendLine("Number of colors: " + numberOfColors);

            return displayInfo.ToString();
        }
    }
}
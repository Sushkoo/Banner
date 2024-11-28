using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    internal interface IBannerOperations
    {
        // Feketere szinezi a teljes kijelzot
        public void Clear();


        // 1 pixellel balra forgatja a kepet
        public void RotateToLeft();

        public void RotateToRight();

        // 1 pixellel balra tolja a kepet
        public void ShiftToLeft(Color fillColor);
        public void ShiftToRight(Color fillColor);
        public void DrawLine(int rowIndex, Color drawingColor);
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    public class Banner : ABanner, IBannerOperations
    {
        public void Clear()
        {
            for (int row = 0; row < RowNum; row++)
            {
                for (int column = 0; column < ColumnNum; column++)
                {
                    this[row, column] = Color.Black;
                }
            }
        }

        public void DrawLine(int rowIndex, Color drawingColor)
        {
            if (rowIndex < 0 || rowIndex >= RowNum)
                throw new ArgumentException("Invalid row index.");

            for (int column = 0; column < ColumnNum; column++)
            {
                this[rowIndex, column] = drawingColor;
            }
        }

        public void RotateToLeft()
        {
            for (int row = 0; row < RowNum; row++)
            {
                Color firstPixel = this[row, 0];
                for (int column = 0; column < ColumnNum - 1; column++)
                {
                    this[row, column] = this[row, column + 1];
                }
                this[row, ColumnNum - 1] = firstPixel;
            }
        }

        public void RotateToRight()
        {
            for (int row = 0; row < RowNum; row++)
            {
                Color lastPixel = this[row, ColumnNum - 1];
                for (int column = ColumnNum - 1; column > 0; column--)
                {
                    this[row, column] = this[row, column - 1];
                }
                this[row, 0] = lastPixel;
            }
        }

        public void ShiftToLeft(Color fillColor)
        {
            for (int row = 0; row < RowNum; row++)
            {
                for (int column = 0; column < ColumnNum - 1; column++)
                {
                    this[row, column] = this[row, column + 1];
                }
                this[row, ColumnNum - 1] = fillColor;
            }
        }

        public void ShiftToRight(Color fillColor)
        {
            for (int row = 0; row < RowNum; row++)
            {
                for (int column = ColumnNum - 1; column > 0; column--)
                {
                    this[row, column] = this[row, column - 1];
                }
                this[row, 0] = fillColor;
            }
        }
    }
}

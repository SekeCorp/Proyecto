using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public class DataGridViewPrinter
    {
        private DataGridView dataGridView;
        private Graphics graphics;
        private Rectangle printArea;
        private Color textColor;
        private bool useDefaultPrintDialog;

        public DataGridViewPrinter(DataGridView dataGridView, Graphics graphics, Rectangle printArea, Color textColor, bool useDefaultPrintDialog)
        {
            this.dataGridView = dataGridView;
            this.graphics = graphics;
            this.printArea = printArea;
            this.textColor = textColor;
            this.useDefaultPrintDialog = useDefaultPrintDialog;
        }

        public bool DrawDataGridView()
        {
            if (dataGridView.Rows.Count == 0)
                return false;

            int rowHeight = dataGridView.Rows[0].Height;
            int headerHeight = dataGridView.ColumnHeadersVisible ? dataGridView.ColumnHeadersHeight : 0;

            int totalHeight = headerHeight;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                totalHeight += rowHeight;
                if (totalHeight > printArea.Height)
                    return true;
            }

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            Rectangle cellBounds = new Rectangle(printArea.Left, printArea.Top + headerHeight, printArea.Width, rowHeight);

            using (Pen pen = new Pen(textColor))
            using (SolidBrush brush = new SolidBrush(textColor))
            using (Font font = new Font(dataGridView.Font, FontStyle.Bold))
            {
                if (dataGridView.ColumnHeadersVisible)
                {
                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        graphics.FillRectangle(brush, cellBounds);
                        graphics.DrawRectangle(pen, cellBounds);
                        graphics.DrawString(column.HeaderText, font, Brushes.Black, cellBounds, stringFormat);

                        cellBounds.X += cellBounds.Width;
                    }

                    cellBounds.Y += rowHeight;
                    cellBounds.X = printArea.Left;
                }

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        graphics.FillRectangle(brush, cellBounds);
                        graphics.DrawRectangle(pen, cellBounds);
                        graphics.DrawString(cell.Value?.ToString(), dataGridView.Font, Brushes.Black, cellBounds, stringFormat);

                        cellBounds.X += cellBounds.Width;
                    }

                    cellBounds.Y += rowHeight;
                    cellBounds.X = printArea.Left;
                }
            }

            return false;
        }
    }
}

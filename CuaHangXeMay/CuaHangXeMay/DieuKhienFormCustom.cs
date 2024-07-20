using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoAnQuanLyCuaHangXeMay
{
    public class DieuKhienFormCustom
    {


        public void frmCustom_MouseMove(bool drag, Point dragCursor, Point dragForm, int widthForm, int heightForm, Point thisLocation)
        {
            int wid = SystemInformation.VirtualScreen.Width;
            int hei = SystemInformation.VirtualScreen.Height;
            if (drag)
            {
                // Phải using System.Drawing;
                Point change = Point.Subtract(Cursor.Position, new Size(dragCursor));
                Point newpos = Point.Add(dragForm, new Size(change));
                // QUyết định có cho form chui ra ngoài màn hình không
                if (newpos.X < 0) newpos.X = 0;
                if (newpos.Y < 0) newpos.Y = 0;
                if (newpos.X + widthForm > wid) newpos.X = wid - widthForm;
                if (newpos.Y + heightForm > hei) newpos.Y = hei - heightForm;
                thisLocation = newpos;
            }
        }

        public void frmCustom_MouseDown(bool drag, Point dragCursor, Point dragForm, Point thisLocation)
        {
            drag = true;
            dragCursor = Cursor.Position;
            dragForm = thisLocation;
        }

        public void frmCustom_MouseUp(bool drag)
        {
            drag = false;
        }

        public DieuKhienFormCustom()
        {
        }



    }
}

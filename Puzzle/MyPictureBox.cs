using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    class MyPictureBox : PictureBox
    {
        int index = 0;

        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        int imageIndex = 0;

        public int ImageIndex
        {
            get
            {
                return imageIndex;
            }
            set
            {
                imageIndex = value;
            }
        }
        public bool isMatch()
        {
            return (index == imageIndex);
        }

    }
}

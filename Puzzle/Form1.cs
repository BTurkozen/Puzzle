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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog openFileDialog = null;
        Image image;
        Image Imag;
        PictureBox picBoxWhole = null;
        PictureBox Ipucu = null;
        private void buttonImageBrowse_Click(object sender, EventArgs e)
        {

            if (openFileDialog == null)
            {
                openFileDialog = new OpenFileDialog();
            }

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                while(groupBoxPuzzle.Controls.Count>0)
                {
                    groupBoxPuzzle.Controls.RemoveAt(0);
                }
                image = CreateBitmapImage(Image.FromFile(openFileDialog.FileName));
                if (picBoxWhole == null)
                {
                    picBoxWhole = new PictureBox();
                    picBoxWhole.Height = groupBoxPuzzle.Height;
                    picBoxWhole.Width = groupBoxPuzzle.Width;
                    groupBoxPuzzle.Controls.Add(picBoxWhole);     
                }
                picBoxWhole.Image = image;

                Imag = CrateBitmapImag(Image.FromFile(openFileDialog.FileName));
                if(Ipucu==null)
                {
                    Ipucu = new PictureBox();
                    Ipucu.Height = groupBoxIpucu.Height;
                    Ipucu.Width = groupBoxIpucu.Width;
                    groupBoxIpucu.Controls.Add(Ipucu);
                }
                Ipucu.Image = Imag;

  
            }
        }
        private Bitmap CreateBitmapImage(Image image)
        {
            Bitmap objBmpImage = new Bitmap(groupBoxPuzzle.Width, groupBoxPuzzle.Height);
            Graphics objGraphics = Graphics.FromImage(objBmpImage);
            objGraphics.Clear(Color.White);
            objGraphics.DrawImage(image, new Rectangle(0, 0, groupBoxPuzzle.Width, groupBoxPuzzle.Height));
            objGraphics.Flush();
            return objBmpImage;
              }
        private Bitmap CrateBitmapImag(Image imag)
        {
            Bitmap objBmpIpucu = new Bitmap(groupBoxIpucu.Width, groupBoxIpucu.Height);
            Graphics objGraphicsIpucu = Graphics.FromImage(objBmpIpucu);
            objGraphicsIpucu.Clear(Color.White);
            objGraphicsIpucu.DrawImage(image, new Rectangle(0, 0, groupBoxIpucu.Width, groupBoxIpucu.Height));
            objGraphicsIpucu.Flush();
            return objBmpIpucu;
        }

        PictureBox[] picBoxes = null;
        Image[] images = null;
        const int LEVEL_1_NUM = 4;
        const int LEVEL_2_NUM = 9;
        const int LEVEL_3_NUM = 16;
        const int LEVEL_4_NUM = 25;
        int currentLevel = 0;


        private void buttonLevel1_Click(object sender, EventArgs e)
        {
            currentLevel = LEVEL_1_NUM;
            labelStatus.Text = "PUZZLE HENÜZ TAMAMLANMADI";
            PlayLevel();

        }

        private void PlayLevel()
        {
            if (picBoxWhole != null)
            {
                groupBoxPuzzle.Controls.Remove(picBoxWhole);
                picBoxWhole.Dispose();
                picBoxWhole = null;
            }

            if (picBoxes == null)
            {
                images = new Image[currentLevel];
                picBoxes = new PictureBox[currentLevel];
            }

            int numRow = (int)Math.Sqrt(currentLevel);
            int numCol = numRow;
            int unitX = groupBoxPuzzle.Width / numRow;
            int unitY = groupBoxPuzzle.Height / numCol;
            int[] indice = new int[currentLevel];

            for (int i = 0; i < currentLevel; i++)
            {
                indice[i] = i;
                if (picBoxes[i] == null)
                {
                    picBoxes[i] = new MyPictureBox();
                    picBoxes[i].Click += new EventHandler(OnPuzzleClick);
                    picBoxes[i].BorderStyle = BorderStyle.Fixed3D;
                }
                picBoxes[i].Width = unitX;
                picBoxes[i].Height = unitY;
                ((MyPictureBox)picBoxes[i]).Index = i;

                CreateBitmapImage(image, images, i, numRow, numCol, unitX, unitY);

                picBoxes[i].Location = new Point(unitX * (i % numCol), unitY * (i / numCol));

                if (!groupBoxPuzzle.Controls.Contains(picBoxes[i]))
                {
                    groupBoxPuzzle.Controls.Add(picBoxes[i]);
                }

            }

            shuffle(ref indice);
            for (int i = 0; i < currentLevel; i++)
            {
                picBoxes[i].Image = images[indice[i]];
                ((MyPictureBox)picBoxes[i]).ImageIndex = indice[i];

            }
        }

        private void CreateBitmapImage(Image image, Image[] images, int index, int numRow, int numCol, int unitX, int unitY)
        {
            images[index] = new Bitmap(unitX, unitY);
            Graphics objGraphics = Graphics.FromImage(images[index]);
            objGraphics.Clear(Color.White);

            objGraphics.DrawImage(image, new Rectangle(0, 0, unitX, unitY), new Rectangle(unitX * (index % numCol),
                unitY * (index / numCol), unitX, unitY), GraphicsUnit.Pixel);
            objGraphics.Flush();
            
        }

        private void shuffle(ref int[] array)
        {
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n);
                n--;
                int temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }

        MyPictureBox firstBox = null;
        MyPictureBox secondBox = null;


        public void OnPuzzleClick(object sender, EventArgs e)
        {
            if (firstBox == null)
            {
                firstBox = (MyPictureBox)sender;
                ((MyPictureBox)sender).BorderStyle = BorderStyle.FixedSingle;
            }
            else if (secondBox == null)
            {
                secondBox = (MyPictureBox)sender;
                firstBox.BorderStyle = BorderStyle.Fixed3D;
                secondBox.BorderStyle = BorderStyle.FixedSingle;
                SwitchImages(firstBox, secondBox);
                firstBox = null;
                secondBox = null;
            }
            
        }

        private void SwitchImages(MyPictureBox box1, MyPictureBox box2)
        {
            int tmp = box2.ImageIndex;
            box2.Image = images[box1.ImageIndex];
            box2.ImageIndex = box1.ImageIndex;
            box1.Image = images[tmp];
            box1.ImageIndex = tmp;

            if (isSuccessful())
            {
                labelStatus.Text = "TEBRİKLER";
            }
        }

        private bool isSuccessful()
        {
            for (int i = 0; i < currentLevel; i++)
            {
                if (((MyPictureBox)picBoxes[i]).ImageIndex != ((MyPictureBox)picBoxes[i]).Index)
                {
                    return false;
                }

            }
            return true;
        }

        private void buttonLevel2_Click(object sender, EventArgs e)
        {
            currentLevel = LEVEL_2_NUM;
            labelStatus.Text = "PUZZLE HENÜZ TAMAMLANMADI";
            PlayLevel();
        }
         

        private void buttonLevel3_Click(object sender, EventArgs e)
        {
            currentLevel = LEVEL_3_NUM;
            labelStatus.Text = "PUZZLE HENÜZ TAMAMLANMADI";
            PlayLevel();
        }

        private void buttonLevel4_Click(object sender, EventArgs e)
        {
            currentLevel = LEVEL_4_NUM;
            labelStatus.Text = "PUZZLE HENÜZ TAMAMLANMADI";
            PlayLevel();
        }
        }

        }
    

    


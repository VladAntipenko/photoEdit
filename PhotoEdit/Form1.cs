using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
//using System.Drawing.Bitmap;


namespace PhotoEdit
{
    public partial class frmMain : Form
    {

       

        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolMenu_Click(object sender, EventArgs e)
        {
            // variable, which kept value our answer from window, after click on the ExitToolStrip           
            DialogResult rsl = MessageBox.Show("Вы действительно хотите выйти из приложения?",
                "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rsl == DialogResult.Yes)
                Application.Exit();
        }

        private void openToolMenu_Click(object sender, EventArgs e)
        {
            loadImage();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            loadImage();
        }

        //================= LOAD IMAGE ======================================
        Image MemForImage;

        private void loadImage()
        {
            //select initial directory
            openFile.InitialDirectory = "f:";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // try load file with name openFile.FileName
                    MemForImage = Image.FromFile(openFile.FileName);
                    this.Text = openFile.FileName;
                    ScaleImage(MemForImage, pBMain.Width, pBMain.Height);
                    pBMain.Left = (this.ClientRectangle.Width - pBMain.Width) / 2;
                    pBMain.Top = (this.ClientRectangle.Height - pBMain.Height) / 2;
                    pBMain.Image = MemForImage;

                }

                catch (Exception ex) // если попытка загрузки не удалась 
                {
                    // выводим сообщение с причиной ошибки 
                    MessageBox.Show("Не удалось загрузить файл: " + ex.Message);
                }
            }
        }
        // =====================================================================================
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form formImg = new frmImage(MemForImage);
            formImg.ShowDialog();

        }

        private void closeToolpMenu_Click(object sender, EventArgs e)
        {
            pBMain.Image = null;
        }

        public Image newMemForImage { get; set; }

        //======= сжимает фото пропроционально если оно превышает размеры pictureBox ===========
        static Image ScaleImage(Image source, int width, int height)
        {

            Image dest = new Bitmap(width, height);
            using (Graphics gr = Graphics.FromImage(dest))
            {
                gr.FillRectangle(Brushes.White, 0, 0, width, height);  // Очищаем экран
                gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                float srcwidth = source.Width;
                float srcheight = source.Height;
                float dstwidth = width;
                float dstheight = height;

                if (srcwidth <= dstwidth && srcheight <= dstheight)  // Исходное изображение меньше целевого
                {
                    int left = (width - source.Width) / 2;
                    int top = (height - source.Height) / 2;
                    gr.DrawImage(source, left, top, source.Width, source.Height);
                }
                else if (srcwidth / srcheight > dstwidth / dstheight)  // Пропорции исходного изображения более широкие
                {
                    float cy = srcheight / srcwidth * dstwidth;
                    float top = ((float)dstheight - cy) / 2.0f;
                    if (top < 1.0f) top = 0;
                    gr.DrawImage(source, 0, top, dstwidth, cy);
                }
                else  // Пропорции исходного изображения более узкие
                {
                    float cx = srcwidth / srcheight * dstheight;
                    float left = ((float)dstwidth - cx) / 2.0f;
                    if (left < 1.0f) left = 0;
                    gr.DrawImage(source, left, 0, cx, dstheight);
                }

                return dest;
            }
        }
        // ======================= обрезание фото ==============================================
       

        private void saveToolMenu_Click(object sender, EventArgs e)
        {
            string name = "f:/new.jpeg";
            pBMain.Image.Save(name, ImageFormat.Jpeg);
        }

        private void inverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            darker();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            darker();
        }

        void darker()
        {
            var image = new Bitmap(pBMain.Image);

            ImageAttributes imageAttributes = new ImageAttributes();
            int width = image.Width;
            int height = image.Height;
            float brightness = 0.5F;

            float[][] colorMatrixElements = {
                                                new float[] {brightness, 0, 0, 0, 0},
                                                new float[] {0, brightness, 0, 0, 0},
                                                new float[] {0, 0, brightness, 0, 0},
                                                new float[] {0, 0, 0, 1, 0},
                                                new float[] {0, 0, 0, 0, 1}
                                            };

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

            imageAttributes.SetColorMatrix(
                colorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);
            Graphics graphics = Graphics.FromImage(image);
            graphics.DrawImage(image, new Rectangle(0, 0, width, height), 0, 0, width,
                               height,
                               GraphicsUnit.Pixel,
                               imageAttributes);

            pBMain.Image = image;
        }

    }
    }


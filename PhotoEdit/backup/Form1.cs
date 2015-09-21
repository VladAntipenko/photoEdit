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

           // openFile.Filter = "image (JPEG) files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if(openFile.ShowDialog() == DialogResult.OK ) 
            {
                try
                {
                    // try load file with name openFile.FileName
                    MemForImage = Image.FromFile(openFile.FileName);

                    if (MemForImage.Size.Width > pBMain.Size.Width)
                    {
                        
                        int propW = MemForImage.Width / pBMain.Width;                          

                        Bitmap newMemForImage = new Bitmap(MemForImage.Width, MemForImage.Height);
                        using (Graphics gr = Graphics.FromImage(newMemForImage))
                        {
                            gr.SmoothingMode = SmoothingMode.HighQuality;
                            gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                            gr.DrawImage(MemForImage, new Rectangle(0, 0, MemForImage.Width / propW, MemForImage.Height));
                        }
                        newMemForImage.Save("f:/new.jpeg");
                        pBMain.Image = newMemForImage;
                        MessageBox.Show("ok");
                    }

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
            Form formImg = new frmImage(MemForImage );
            formImg.ShowDialog();

        }

        private void closeToolpMenu_Click(object sender, EventArgs e)
        {
            pBMain.Image = null;
        }

        public Image newMemForImage { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*    if (MemForImage.Size.Width > pBMain.Size.Width || MemForImage.Size.Height > pBMain.Size.Height)
                    {

                        int propW = MemForImage.Width / pBMain.Width;
                        int propH = MemForImage.Height / pBMain.Height;

                        Bitmap newMemForImage = new Bitmap(MemForImage.Width, MemForImage.Height);
                        using (Graphics gr = Graphics.FromImage(newMemForImage))
                        {
                            gr.SmoothingMode = SmoothingMode.HighQuality;
                            gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                            gr.DrawImage(MemForImage, new Rectangle(0, 0, MemForImage.Width / propW, MemForImage.Height/propH));
                        }
                        newMemForImage.Save("f:/new.jpeg");
                        pBMain.Image = newMemForImage;
                        MessageBox.Show("ok");
                    } */

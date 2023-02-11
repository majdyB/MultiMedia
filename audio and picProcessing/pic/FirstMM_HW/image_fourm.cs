using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FirstMM_HW
{

    public partial class image_fourm : Form
    {
        
        Stack<Bitmap> undo = new Stack<Bitmap>();

        Stack<Bitmap> redo = new Stack<Bitmap>();

        // class var to use it in all the code
        Bitmap bm;

        byte[] data;
        private int start_y;
        private int start_x;
        private void Bmap2Arra() {
            //converting into 32 bit photo
            bm = new Bitmap(bm);
            // saving in the data array
            data = new byte[bm.Width * bm.Height * 4];

            //locking the image
            var imglock = bm.LockBits(new Rectangle(0, 0, bm.Width, bm.Height),
                System.Drawing.Imaging.ImageLockMode.ReadOnly,
                bm.PixelFormat);

            //to find the fisrt pixel in the data array
            var first_indx = imglock.Scan0;

            //coping all the bytes 
            Marshal.Copy(first_indx, data, 0, data.Length);

            //unlocking the image
            bm.UnlockBits(imglock);

            ShowPic.Image = bm;
        }
        public image_fourm() { InitializeComponent(); }

        //puuhing elements into undo stack
        private void Add2Stack() {
            if(bm==null)
            {
                return;
            }
            else
            {
                undo.Push(bm);
                bm = new Bitmap(bm);
            }

            undo.Push(new Bitmap(bm)); }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void brighterToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void editToolStripMenuItem_Click(object sender, EventArgs e) {  }

        private void doToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenFile = new OpenFileDialog();

            OpenFile.Filter = "image file | *jpg";

            if (OpenFile.ShowDialog() == DialogResult.Cancel) return;

            else
            {
                bm = new Bitmap(OpenFile.FileName);

                Bmap2Arra();
                MessageBox.Show("Your Photo Path is : " + OpenFile.FileName);

                W.Text = "    Width : " + bm.Width.ToString() + "  ,  " +
                        "Hight : " + bm.Height.ToString() + "  ,  " +
                        "Pixel Format : " + bm.PixelFormat + "  ,  " +
                        "HorizontalResolution : " + bm.HorizontalResolution + "  ,  " +
                        "Vertical Resolution : " + bm.VerticalResolution + "  .  "
                    ;
            }
        }

        //coverting the photo to red color





        private void inverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bm == null) { MessageBox.Show("You didn't pick a photo"); return; }
            else
            {
                Add2Stack();
                for (int i = 0; i < bm.Width; i++)
                {
                    for (int j = 0; j < bm.Height; j++)
                    {
                        var c = bm.GetPixel(i, j);
                        var newcolor = Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
                        bm.SetPixel(i, j, newcolor);

                    }//end height

                }//end width

                ShowPic.Image = bm;
            }//end else
        }

        private void toGrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bm == null) { MessageBox.Show("You didn't pick a photo"); return; }
            else
            {

                //locking the image
                var imglock2 = bm.LockBits(new Rectangle(0, 0, bm.Width, bm.Height),
                    System.Drawing.Imaging.ImageLockMode.WriteOnly,
                    bm.PixelFormat);

                //to find the fisrt pixel in the data array
                var first_indx = imglock2.Scan0;

                //coping all the bytes 
                Marshal.Copy(data, 0, first_indx, data.Length);

                //unlocking the image
                bm.UnlockBits(imglock2);
                Add2Stack();
                for (int i = 0; i < data.Length; i += 4)
                {

                    var y = (Byte)(data[i + 2] * (.29900)+  (data[i + 1] * .58700)+ (data[i] * .114000));
                   
                    data[i] =  (y);


                }

                //locking the image
                var imglock = bm.LockBits(new Rectangle(0, 0, bm.Width, bm.Height),
                    System.Drawing.Imaging.ImageLockMode.WriteOnly,
                    bm.PixelFormat);

                //to find the fisrt pixel in the data array
                var first_indx1 = imglock.Scan0;

                //coping all the bytes 
                Marshal.Copy(data, 0, first_indx, data.Length);

                //unlocking the image
                bm.UnlockBits(imglock);

                ShowPic.Image = bm;
            }
        }//end else


        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (redo.Count == 0) { MessageBox.Show("You didn't pick a photo"); return; }
            else
            {
                undo.Push(bm);
                bm = redo.Pop();
                ShowPic.Image = bm;
            }

        }

        private void undoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            if (undo.Count == 0) { MessageBox.Show("You didn't pick a photo"); return; }
            else
            {
                redo.Push(bm);
                bm = undo.Pop();
                ShowPic.Image = bm;
            }

        }

        private void increaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bm == null) { MessageBox.Show("You didn't pick a photo"); return; }
             else {
              
                Add2Stack();
      
                for (int i = 0; i < data.Length; i += 4)
                {
                 
                    var newR = (byte)((data[i+2]-255) * 0.5);
                    var newG = (byte)((data[i + 2] - 255)* 0.5);
                    var newB = (byte)((data[i + 2] - 255)* 0.5);
                    //blue
                    data[i] = newB;
                    //green
                    data[i + 1] = newG;
                    //red
                   data[i+2]= newR;
                    //alpha
                    //data[i+3]

                }//end for

  
            //end else
        }
            }

        private void decreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bm == null) { MessageBox.Show("You didn't pick a photo"); return; } 
            else
            {
                Add2Stack();
                for (int i = 0; i < data.Length; i += 4)
                {
                     
                    var newR = (byte)(data[i + 2] * 0.7);
                    var newG = (byte)(data[i + 1] * 0.7);
                    var newB = (byte)(data[i] * 0.7);

                    //blue
                    data[i] = newB;
                    //green
                    data[i + 1] = newG;
                    //red
                    data[i + 2] = newR;
                    //alpha
                    //data[i+3]


                }//end width

                ShowPic.Image = bm;
            }//end else
        }

        private void toRed2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bm == null) { MessageBox.Show("You didn't pick a photo"); return; }
            else
            {
                Add2Stack();
                for (int i = 0; i < data.Length; i += 4)
                {
                    //blue
                    data[i] = 0;
                    //green
                    data[i + 1] = 0;
                    //red
                    //data[i+2];
                    //alpha
                    //data[i+3]

                }//end for

                //locking the image
                var imglock = bm.LockBits(new Rectangle(0, 0, bm.Width, bm.Height),
                    System.Drawing.Imaging.ImageLockMode.WriteOnly,
                    bm.PixelFormat);

                //to find the fisrt pixel in the data array
                var first_indx = imglock.Scan0;

                //coping all the bytes 
                Marshal.Copy(data, 0, first_indx, data.Length);

                //unlocking the image
                bm.UnlockBits(imglock);

                ShowPic.Image = bm;
            }
        }

        private void toBlue2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bm == null) { MessageBox.Show("You didn't pick a photo"); return; }
            else
            {
                Add2Stack();
                for (int i = 0; i < data.Length; i += 4)
                {
                    //blue
                    // data[i] = 0;
                    //green
                    data[i + 1] = 0;
                    //red
                    data[i + 2] = 0;
                    //alpha
                    //data[i+3]

                }//end for

                //locking the image
                var imglock = bm.LockBits(new Rectangle(0, 0, bm.Width, bm.Height),
                    System.Drawing.Imaging.ImageLockMode.WriteOnly,
                    bm.PixelFormat);

                //to find the fisrt pixel in the data array
                var first_indx = imglock.Scan0;

                //coping all the bytes 
                Marshal.Copy(data, 0, first_indx, data.Length);

                //unlocking the image
                bm.UnlockBits(imglock);

                ShowPic.Image = bm;
            }
        }

        private void toGreen2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bm == null) { MessageBox.Show("You didn't pick a photo"); return; }
            else
            {
                Add2Stack();
                for (int i = 0; i < data.Length; i += 4)
                {
                    //blue
                    data[i] = 0;
                    //green
                    //data[i + 1] = 0;
                    //red
                    data[i + 2] = 0;
                    //alpha
                    //data[i+3]

                }//end for

                //locking the image
                var imglock = bm.LockBits(new Rectangle(0, 0, bm.Width, bm.Height),
                    System.Drawing.Imaging.ImageLockMode.WriteOnly,
                    bm.PixelFormat);

                //to find the fisrt pixel in the data array
                var first_indx = imglock.Scan0;

                //coping all the bytes 
                Marshal.Copy(data, 0, first_indx, data.Length);

                //unlocking the image
                bm.UnlockBits(imglock);

                ShowPic.Image = bm;
            }
        }

        private void ScrolPanel_MouseMove(object sender, MouseEventArgs e)
        {   

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void ShowPic_MouseMove(object sender, MouseEventArgs e)
        {
            if (bm == null) return;
            var c = bm.GetPixel(e.X, e.Y);
            //  label2.BackColor = c;
            // lblColor.Text = string.Format("R:{0}, G:{1}, B:{2}", c.R, c.G, c.B);
          


            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                var nb = new Bitmap(bm);
                using (Graphics g = Graphics.FromImage(nb))
                {
                    g.DrawRectangle(new Pen(Color.Blue),
                       Math.Min(start_x, e.X),
                       Math.Min(start_y, e.Y),
                        Math.Abs(e.X - start_x),
                        Math.Abs(e.Y - start_y));
                }
              
                ShowPic.Image = nb;
            }

        }

        private void ScrolPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
            //once leaving block using will dispose the object
        {
            using (Graphics g = Graphics.FromImage(bm))
            {
                g.DrawString("OLA mate", DefaultFont, new SolidBrush(Color.Red), 0, 0);
            }
            ShowPic.Image = bm;
            ShowPic.Refresh();
        }

        private void logoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add2Stack();
            using (Graphics g = Graphics.FromImage(bm))
            {
                var logo = new Bitmap("C: \\Users\\pc\\Pictures\\Untitled.png");

                var logo1= new Bitmap("C: \\Users\\pc\\Pictures\\Untitled.png");
                g.TranslateTransform(200, 200);
                g.DrawImage(logo, new Rectangle(200, 200, logo.Width, logo.Height));

                g.RotateTransform(10);
                g.DrawImage(logo1, new Rectangle(200, 200, logo.Width, logo.Height));
            }
            ShowPic.Image = bm;
            ShowPic.Refresh();
            ShowPic.Update(); 
            
        }

        private void rotateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add2Stack();
             

                                        ///// attempt 1 ///////
                // g.TranslateTransform((float)bm.Width / 2, (float)bm.Height / 2);
                // g.RotateTransform(45);
                //g.TranslateTransform(-(float)bm.Width / 2, -(float)bm.Height / 2);
                //g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                // g.DrawImage(newBitmap, new Point(0, 0));

                                       ////doc's code //////
                // g.Clear(Color.White);
                //g.TranslateTransform(bm.Width / 2, bm.Height / 2);

                // g.RotateTransform(45);

                //g.DrawImage(newBitmap, -newBitmap.Width / 2, -newBitmap.Height / 2);

                                       ////// flip ////
               // bm.RotateFlip(RotateFlipType.Rotate90FlipY);
               //ShowPic.Image = bm;

            double angle = 90; // rotating angle
            int Width = bm.Width; //getting the cordination of current pic so it can be dinamic
            int height = bm.Height;
            double ANG = angle * Math.PI / 180; //applyig the standard cordination on pic
            double COS = Math.Abs(Math.Cos(ANG)); //getting the rotation cordination of the angle
            double SIN = Math.Abs(Math.Sin(ANG));
            int newLength = (int)(Width * COS + height * SIN);// standarizing the cordinations of current pic
            int newHeight = (int)(Width * SIN + height * COS);

            Bitmap newB = new Bitmap(newLength, newHeight);
            using (Graphics g = Graphics.FromImage(newB))
            {

                g.Clear(Color.White);
                g.TranslateTransform((float)(newLength - Width)/2 , (float)(newHeight - height) /2);
                g.TranslateTransform((float)bm.Width/2 , (float)bm.Height/2 );

                g.RotateTransform(90);

                g.TranslateTransform((float)-bm.Width / 2, (float)-bm.Height / 2);
                g.DrawImage(bm, new System.Drawing.Point(0, 0));

            }

            bm = newB;

            ShowPic.Image = bm; 
 
            

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "Image File |.jpg*";
            f.Title = "Save the image";
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            bm.Save(f.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void ShowPic_clickup(object sender, EventArgs e)
        {

        }

        private void ShowPic_MouseDown(object sender, MouseEventArgs e)
        {
            start_x = e.X;
            start_y = e.Y;

        }

        private void ShowPic_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void drowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(bm))
            {
                g.DrawRectangle(new Pen(Color.Blue), 200, 100, bm.Width / 4, bm.Height / 4);
            }
            ShowPic.Image = bm;
        }

        private void selectColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
 
            selectColorToolStripMenuItem.BackColor = c.Color;
            float r = 0.2F;
            Add2Stack();
            for (int i = 0; i < data.Length; i += 4)
            {
                data[i + 0] = (byte)(data[i + 0] * (1 - r) + c.Color.B * r); // Blue
                data[i + 1] = (byte)(data[i + 1] * (1 - r) + c.Color.G * r); // Green
                data[i + 2] = (byte)(data[i + 2] * (1 - r) + c.Color.R * r); // Red
                //data[i + 3]; // Alpha
            }

            var imageLock = bm.LockBits(
                new Rectangle(0, 0, bm.Width, bm.Height)
                , System.Drawing.Imaging.ImageLockMode.WriteOnly
                , bm.PixelFormat);

            var ptr = imageLock.Scan0;

            Marshal.Copy(data, 0, ptr, data.Length);

            bm.UnlockBits(imageLock);

         ShowPic.Image = bm;
        }

        private void W_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var OpenFile = new OpenFileDialog();

            OpenFile.Filter = "image file | *jpg";

            if (OpenFile.ShowDialog() == DialogResult.Cancel) return;

            else
            {
                bm = new Bitmap(OpenFile.FileName);

                Bmap2Arra();
                MessageBox.Show("Your Photo Path is : " + OpenFile.FileName);

                W.Text = "    Width : " + bm.Width.ToString() + "  ,  " +
                        "Hight : " + bm.Height.ToString() + "  ,  " +
                        "Pixel Format : " + bm.PixelFormat + "  ,  " +
                        "HorizontalResolution : " + bm.HorizontalResolution + "  ,  " +
                        "Vertical Resolution : " + bm.VerticalResolution + "  .  "
                    ;
            }
        }

        private void add_logo_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(bm)) { 
                var logo = new Bitmap("C: \\Users\\pc\\Pictures\\Untitled.png");
            g.TranslateTransform(200, 200);
            g.DrawImage(logo, new Rectangle(200, 200, logo.Width, logo.Height));
 
        }
        ShowPic.Image = bm;
            ShowPic.Refresh();
            ShowPic.Update(); 
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            double angle = 90; // rotating angle
            int Width = bm.Width; //getting the cordination of current pic so it can be dinamic
            int height = bm.Height;
            double ANG = angle * Math.PI / 180; //applyig the standard cordination on pic
            double COS = Math.Abs(Math.Cos(ANG)); //getting the rotation cordination of the angle
            double SIN = Math.Abs(Math.Sin(ANG));
            int newLength = (int)(Width * COS + height * SIN);// standarizing the cordinations of current pic
            int newHeight = (int)(Width * SIN + height * COS);

            Bitmap newB = new Bitmap(newLength, newHeight);
            using (Graphics g = Graphics.FromImage(newB))
            {

                g.Clear(Color.White);
                g.TranslateTransform((float)(newLength - Width) / 2, (float)(newHeight - height) / 2);
                g.TranslateTransform((float)bm.Width / 2, (float)bm.Height / 2);

                g.RotateTransform(90);

                g.TranslateTransform((float)-bm.Width / 2, (float)-bm.Height / 2);
                g.DrawImage(bm, new System.Drawing.Point(0, 0));

            }

            bm = newB;

            ShowPic.Image = bm;


        }

        private void OpenToolstrip_Click(object sender, EventArgs e)
        {

            if (undo.Count == 0) { MessageBox.Show("You didn't pick a photo"); return; }
            else
            {
                redo.Push(bm);
                bm = undo.Pop();
                ShowPic.Image = bm;
            }
        }

        private void add_logo_Click_1(object sender, EventArgs e)
        {
            if (redo.Count == 0) { MessageBox.Show("You didn't pick a photo"); return; }
            else
            {
                undo.Push(bm);
                bm = redo.Pop();
                ShowPic.Image = bm;
            }

        }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using NAudio.Wave;
using System.Runtime.InteropServices;
 
using System.Drawing.Imaging;

namespace Audio_Processing

{
    public partial class FrmAudio : Form
    {
        WaveOut waveout = new WaveOut();
        WaveStream reader ;


        short[] sata;

        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        public FrmAudio()
        {
            InitializeComponent();
            
            // By the default set the volume to 0
            uint CurrVol = 0;
            // At this point, CurrVol gets assigned the volume
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            // Calculate the volume
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            // Get the volume on a scale of 1 to 10 (to fit the trackbar)
            trackBar1.Value = CalcVol / (ushort.MaxValue / 10);
        }
        //from reader =>short
        //something missing?
        private short[] ReadData()
        {
            return ReadData(reader);

        }
        private short[] ReadData(WaveStream reader)
        {
            reader.Seek(0, System.IO.SeekOrigin.Begin);
            byte[] Byte = new byte[reader.Length];
            reader.Read(Byte, 0, Byte.Length);
            short[] data = new short[Byte.Length / 2];
            for(int i = 0; i<sata.Length;i++)
            {
                data[i] = (short)(Byte[i * 2] + Byte[i * 2 + 1] * 256);
            }
            return data;
        }
        private void WriteData(short [] data)
        {
            byte[] Byte = new byte[data.Length * 2];
            for(int i = 0; i < data.Length; i++)
            {
                Byte[i * 2] = (byte)(data[i] % 256);
                Byte[i * 2 + 1] = (byte)(data[i] / 256);
            }
               RawSourceWaveStream WaveStream = new RawSourceWaveStream(Byte
                   , 0,Byte.Length,
                   reader.WaveFormat);
                reader = WaveStream;

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Open = new OpenFileDialog();
            Open.Filter = "MP3 Files | *.mp3";
            Open.Title = "Select Audio mate!!!!";
            if (Open.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;

            }
            else
            {
                // MessageBox.Show(Open.FileName);
                reader = new Mp3FileReader(Open.FileName);
                MessageBox.Show(reader.WaveFormat.SampleRate.ToString());
                LstProp.Items.Add(
                    new ListViewItem(new string[] { "sample rate", reader.WaveFormat.SampleRate.ToString() })

                      );
                LstProp.Items.Add(
                   new ListViewItem(new string[] { "Channai", reader.WaveFormat.Channels.ToString() })

                     );
                LstProp.Items.Add(
                  new ListViewItem(new string[] { "BitSample", reader.WaveFormat.BitsPerSample.ToString() })


                    );
                LstProp.Items.Add(
                  new ListViewItem(new string[] { "Total time", reader.TotalTime.ToString() })

                    );
                LstProp.Items.Add(
                  new ListViewItem(new string[] { "Encoding", reader.WaveFormat.Encoding.ToString() })

                    );
                Byte[] B = new byte[reader.Length];
                sata = new short[B.Length / 2];
                reader.Read(B, 0, B.Length);

                for (int i = 0; i < sata.Length; i++)
                {
                    sata[i] = (short)(B[i * 2] + B[i * 2 + 1] * 256);
                }
                byte[] audioBytes = new byte[reader.Length];
                reader.Read(audioBytes, 0, (int)(reader.Length));
                short[] sampleArray = new short[audioBytes.Length / 2];
                Buffer.BlockCopy(audioBytes, 0, sampleArray, 0, audioBytes.Length);
                var picGen = GenerateImageOfSound(sampleArray, 647, 137 );
                Buffer.BlockCopy(sampleArray, 0, audioBytes, 0, audioBytes.Length);
                reader = new RawSourceWaveStream(audioBytes, 0, audioBytes.Length, reader.WaveFormat);
                pictureBox1.Image = (Bitmap)picGen;
                waveout.Init(reader);
                timer1.Enabled = true;
                

            }
        }
        Bitmap GenerateImageOfSound(short[] data, int width, int height)
        {
            Bitmap picGen = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            using (Graphics g = Graphics.FromImage(picGen))
            {
                g.Clear(Color.Black);
                int spp = data.Length / width;
                int px = 0, py = 0;
                for (int i = 0; i < data.Length; i += spp)
                {
                    int max = data[i], min = data[i];
                    for (int j = i + 1; j < Math.Min(i + spp, data.Length); j++)
                    {
                        if (data[j] > max)
                            max = data[j];
                        if (data[j] < min)
                            min = data[j];
                    }
                    int x = i / spp;
                    int y1 = (height / 2) - max * (height / 2) / short.MaxValue;
                    int y2 = (height / 2) - min * (height / 2) / short.MaxValue;
                    g.DrawLine(Pens.White, px, py, x, y1);
                    g.DrawLine(Pens.White, x, y1, x, y2);
                    px = x;
                    py = y2;
                }
            }
            return picGen;
        }
        //private object GenerateImageOfSound(short[] sampleArray, int v1, int v2)
        //{
        // throw new NotImplementedException();
        //}

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (waveout.PlaybackState == PlaybackState.Playing)
            {
                waveout.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           hScrollBar1.Value= (int)(reader.Position * hScrollBar1.Maximum / reader.Length);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            reader.Position = hScrollBar1.Value * reader.Length / hScrollBar1.Maximum;

        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            waveout.Init(reader);
            reader.Seek(0, System.IO.SeekOrigin.Begin);


            waveout.Play();

        }

        private void continueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reader == null) return;
            else
            {
                waveout.Resume();
            }
        }

        private void stopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (reader == null) { MessageBox.Show("no audio exist"); return; }
            else
            {
                if (waveout.PlaybackState == PlaybackState.Playing) { waveout.Stop(); timer1.Enabled = false; }

                else { MessageBox.Show("i mean u can't stop an audio without playing it in  the first place"); return; }
            }
        }

        private void fasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reader == null) { MessageBox.Show("skip time !"); return; }

            short[] data = ReadData();
            short[] NewData = new short[data.Length / 2];


            for (int i = 0; i < NewData.Length; i += reader.WaveFormat.Channels)
            {
                int j = i * 2;
                for (int c = 0; c < reader.WaveFormat.Channels; c++)
                    NewData[i + c] = data[j + c];
            }
            
            WriteData(NewData);
        }

        private void FrmAudio_Load(object sender, EventArgs e)
        {

        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reader == null) { MessageBox.Show("pause the time!"); return; }
            else
            {
                waveout.Pause();
            }
        }

        private void reverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
              if (reader == null) { MessageBox.Show("reverse what?"); return; }

            //  short[] readD = ReadData();
            // short[] NewData = new short[readD.Length];

            // var channels = reader.WaveFormat.Channels;

            // for (int i = 0; i < readD.Length; i += channels)
            // {
            // NewData[i] = readD[i];
            //readD.Reverse();
            //  NewData[i + 1] = readD[i + 1];
            // }
            short[] data = ReadData();
            short[] newData = new short[data.Length];
            var channels = reader.WaveFormat.Channels;
            for (int i = 0; i < newData.Length; i += channels)
            {
                int j = newData.Length - channels - 1 - i;
                for(int c = 0; c < channels; c++)
                {
                    newData[i + c] = data[j + c];
                }
            }

            WriteData(newData);
        }

        private void increasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reader == null)
                return;

            short[] readD = ReadData();
            short[] NewData = new short[readD.Length];

             NewData = new short[NewData.Length];
            for (int i = 0; i < NewData.Length; i++)
            {
                NewData[i] = (short)(NewData[i] * 2);
                if (NewData[i] > short.MaxValue)
                    NewData[i] = short.MaxValue;
                else if (NewData[i] < short.MinValue)
                    NewData[i] = short.MinValue;
            }
            

            WriteData(NewData);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // Calculate the volume that's being set. BTW: this is a trackbar!
            int NewVolume = ((ushort.MaxValue / 10) * trackBar1.Value);
            // Set the same volume for both the left and the right channels
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            // Set the volume
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
        }

        private void decreasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            short[] readD = ReadData();
            short[] NewData = new short[readD.Length];


            
            for (int i = 0; i < NewData.Length; i++)
            {
                NewData[i] = (short)(NewData[i] / 2);
                if (NewData[i] > short.MaxValue)
                    NewData[i] = short.MaxValue;
                else if (NewData[i] < short.MinValue)
                    NewData[i] = short.MinValue;
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {


              var Sam = int.Parse(speed.Text);
            // var Cha = int.Parse(zoomiez.Text);
            //short[] readD = ReadData();
            //short[] NewData = new short[readD.Length / 2];

            //  var c = reader.WaveFormat.Channels;

            // for (int i = 0; i < NewData.Length; i += c)
            // {
            // NewData[i] = readD[i * t];
            //NewData[i + 1] = readD[i * t + 1];
            //}
            //  WaveFormat format = new WaveFormat(Sam, Cha);
            //  reader = new RawSourceWaveStream(waveout, format);

            if (reader == null) { MessageBox.Show("skip time !"); return; }

            short[] data = ReadData();
            short[] NewData = new short[data.Length / 2];


            for (int i = 0; i < NewData.Length; i += reader.WaveFormat.Channels)
            {
                int j = (((i / 2) / 2) * 2)*Sam;
                for (int c = 0; c < reader.WaveFormat.Channels; c++)
                    NewData[i + c] = data[j + c];
            }

            WriteData(NewData);
      

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        { 
            if(reader== null) { MessageBox.Show("what save????????????????????//"); return; }
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "WAV File|*.wav";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            WaveFileWriter writer = new WaveFileWriter(dialog.FileName, reader.WaveFormat);
            byte[] buffer = new byte[60000000];
            reader.Seek(0, System.IO.SeekOrigin.Begin);
            while (true)
            {
                int extraBytes = reader.Read(buffer, 0, buffer.Length);
                if (extraBytes == 0) break;
                else writer.Write(buffer, 0, extraBytes);
            }
            writer.Close();
        }

        private void slowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            short[] data = ReadData();
            short[] NewData = new short[data.Length * 2];

            for (int i = 0; i < NewData.Length; i += reader.WaveFormat.Channels)
            {
                int j = ((i / 2) / 2) * 2;
                for (int c = 0; c < reader.WaveFormat.Channels; c++)
                    NewData[i + c] = data[j + c];
            }
           WriteData(NewData);
        }

        private void speed_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {

        }

        private void speedChangerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float ChangePercintage = float.Parse(toolStripTextBox2.Text);
            short[] data = ReadData();
            int channels = reader.WaveFormat.Channels;
            int oldLen = data.Length / channels;
            int newLen = (int)(oldLen / ChangePercintage);
            short[] NewData = new short[newLen * channels];
            for (int i = 0; i < newLen; i++)
            {
                int j = (int)(i * ChangePercintage);
                if (j > oldLen - 1) j = oldLen-1;
                for(int w = 0; w < channels; w++)
                {
                    NewData[i * channels + w] = data[j * channels + w];
                }
            }
        }

        private void mergeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "MP3 Files | *.mp3";
            f.Title = "press F to pey respect";
            if (f.ShowDialog()== DialogResult.Cancel) { return; }
            Mp3FileReader RD = new Mp3FileReader(f.FileName);
            if (RD.WaveFormat.Channels != reader.WaveFormat.Channels)
            {
                MessageBox.Show("sorry channels mismatch");
                return;
            };
            if (RD.WaveFormat.SampleRate != reader.WaveFormat.SampleRate)
            {
                MessageBox.Show("sorry SampleRate mismatch");
                return;

            };
            if (RD.WaveFormat.BitsPerSample != reader.WaveFormat.BitsPerSample)
            {
                MessageBox.Show("sorry BitsPerSample mismatch");
                return;
            };
            short[] Dat1 = ReadData(reader);
            short[] Dat2 = ReadData(RD);

            short[] data = new short[Math.Max(Dat1.Length, Dat2.Length)];

            float mRatio = float.Parse(toolStripTextBox1.Text);
            for(int i = 0; i < data.Length; i++)
            {
                if (i >= Dat1.Length)
                    data[i] = Dat2[i];
                else if (i >= Dat2.Length)
                    data[i] = Dat1[i];
                else
                    data[i] = (short)(Dat1[i] * (1 - mRatio) + Dat2[i] * mRatio);
            }

            WriteData(data);

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

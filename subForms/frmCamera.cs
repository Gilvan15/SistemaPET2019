using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using AForge.Video;


namespace SistemaPet.subForms
{
    public partial class frmCamera : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private bool DeviceExist = false;
        

        public frmCamera()
        {
            InitializeComponent();
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = img;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilterInfoCollection videosources = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videosources != null)
            {
                videoSource = new VideoCaptureDevice(videosources[0].MonikerString);
                videoSource.NewFrame += (s, i) => pictureBox1.Image = (Bitmap)i.Frame.Clone();
                videoSource.Start();
            }

        }

        private void frmCamera_Load(object sender, EventArgs e)
        {


        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (btnCapturar.Text == "Capturar")
            {
                if (DeviceExist == true)
                {
                    videoSource = new VideoCaptureDevice(videoDevices[comboCamera.SelectedIndex].MonikerString);
                    videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);

                    //Encerra o sinal da camera.
                    if (!(videoSource == null))
                        if (videoSource.IsRunning)
                        {
                            videoSource.SignalToStop();
                            videoSource = null;
                        }
                    videoSource.DesiredFrameSize = new Size(160, 120);
                    videoSource.DesiredFrameRate = 10;
                    videoSource.Start();

                    btnCapturar.Text = "Gravar";
                }
                else
                {
                    MessageBox.Show("Nenhum dispositivo encontrado!");
                }
            }
            else
            {
                if (videoSource.IsRunning)
                {
                    //Encerra o sinal da camera.
                    // Note que este bloco de código se repetiu, você pode cirar um método para ele.
                    if (!(videoSource == null))
                        if (videoSource.IsRunning)
                        {
                            videoSource.SignalToStop();
                            videoSource = null;

                            // salva a imagem;
                            saveFileDialog1.Filter = "JPEG (*.jpg;*.jpeg;*jpeg;*.jfif)|*.jpg;*.jpeg;*jpeg;*.jfif";
                            DialogResult res = saveFileDialog1.ShowDialog();
                            if (res == DialogResult.OK)
                            {
                                pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                            }
                        }
                }
            }
        }



    
    }
    
}

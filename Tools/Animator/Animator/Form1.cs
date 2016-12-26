using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Animator
{
  public partial class Form1 : Form
  {
    private bool _initialized = false;
    private Bitmap[] _frames = null;
    private int _currentFrame = 0;

    public Form1()
    {
      InitializeComponent();
      picSourceImage.AllowDrop = true;
    }

    private void Initialize()
    {
      txtMessage.Text = "";
      txtWidth.Text = "0";
      txtHeight.Text = "0";
      txtFrames.Text = "0";
      _initialized = false;
      try
      {
        if (picSourceImage.Image == null) throw new Exception("Source image not loaded");
        if (numFrameWidth.Value > picSourceImage.Image.Width) throw new Exception("Frame width may not be larger than source image width");
        if (picSourceImage.Image.Width % numFrameWidth.Value != 0) throw new Exception("Source image width is not divisible by frame width");

        List<Bitmap> frames = new List<Bitmap>();

        for (int x = 0; x < picSourceImage.Image.Width; x += Convert.ToInt32(numFrameWidth.Value))
        {
          Bitmap b = new Bitmap(Convert.ToInt32(numFrameWidth.Value), picSourceImage.Image.Height, PixelFormat.Format32bppArgb);
          Graphics g = Graphics.FromImage(b);

          Rectangle destination = new Rectangle(0, 0, b.Width, b.Height);
          Rectangle source = new Rectangle(x,0,Convert.ToInt32(numFrameWidth.Value), picSourceImage.Image.Height);

          g.DrawImage(picSourceImage.Image, destination, source, GraphicsUnit.Pixel);
          frames.Add(b);
        }

        if (frames.Count == 0) return;
        _frames = frames.ToArray();
        _currentFrame = 0;
        _initialized = true;

        txtWidth.Text = picSourceImage.Image.Width.ToString();
        txtHeight.Text = picSourceImage.Image.Height.ToString();
        txtFrames.Text = _frames.Length.ToString();
      }
      catch (Exception ex)
      {
        txtMessage.Text = ex.Message;
      }
    }

    private void trackInterval_Scroll(object sender, EventArgs e)
    {
      timerAnimator.Interval = trackInterval.Value;
      txtInterval.Text = trackInterval.Value.ToString();
    }

    private void timerAnimator_Tick(object sender, EventArgs e)
    {
      try
      {
        if (!_initialized) return;
        Bitmap frame = _frames[_currentFrame];
        picAnimation.Image = frame;
        _currentFrame++;
        if (_currentFrame > _frames.Length -1) _currentFrame = 0;
      }
      catch (Exception ex)
      {
        txtMessage.Text = ex.Message;
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void picSourceImage_DragEnter(object sender, DragEventArgs e)
    {
      try
      {
        e.Effect = DragDropEffects.None;
        if (e.Data.GetDataPresent(DataFormats.FileDrop))
        {
          string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
          if (files.Length == 1 && files[0].EndsWith(".png")) e.Effect = DragDropEffects.Copy;
        }
      }
      catch (Exception ex)
      {
        txtMessage.Text = ex.Message;
      }
    }

    private void picSourceImage_DragDrop(object sender, DragEventArgs e)
    {
      try
      {
        if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Copy)
        {
          string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
          picSourceImage.Image = Bitmap.FromFile(files[0]);

          Initialize();
        }
      }
      catch (Exception ex)
      {
        txtMessage.Text = ex.Message;
      }
    }

    private void numFrameWidth_ValueChanged(object sender, EventArgs e)
    {
      Initialize();
    }

    private void numFrameHeight_ValueChanged(object sender, EventArgs e)
    {
      Initialize();
    }

    private void radCenter_CheckedChanged(object sender, EventArgs e)
    {
      if (radCenter.Checked) picAnimation.SizeMode = PictureBoxSizeMode.CenterImage;
    }

    private void radZoom_CheckedChanged(object sender, EventArgs e)
    {
      if (radZoom.Checked) picAnimation.SizeMode = PictureBoxSizeMode.Zoom;
    }

    private void radStretch_CheckedChanged(object sender, EventArgs e)
    {
      if (radStretch.Checked) picAnimation.SizeMode = PictureBoxSizeMode.StretchImage;
    }
  }
}

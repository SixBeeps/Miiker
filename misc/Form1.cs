using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miiker
{
    public partial class Form1 : Form
    {
        public bool isMale = true; //Use bool to save space
        public Image fBody = assignImage("C:/Program Files/Miiker/Assets/Female_Body.png");
        public Image mBody = assignImage("C:/Program Files/Miiker/Assets/Male_Body.png");
        public Form1()
        {
            InitializeComponent();
            Setup();
        }

        public void Setup()
        {
            fBody = resizeImage(fBody, new Size(100, 117));
            mBody = resizeImage(mBody, new Size(100, 117));
            miiHead.Image = resizeImage(miiHead.Image, new Size(100, 97));
            foreach (PictureBox pbox in Form1.ActiveForm.Controls)
            {
                pbox.ErrorImage = Image.FromFile("C:/Program Files/Miiker/Assets/errornoimage.png");
            }
            GC.Collect();
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void femaleRButton_CheckedChanged(object sender, EventArgs e)
        {
            isMale = false;
            miiBody.Image = fBody;
        }

        private void maleRButton_CheckedChanged(object sender, EventArgs e)
        {
            isMale = true;
            miiBody.Image = mBody;
        }

        public static Image assignImage(string FilePath)
        {
            try
            {
                return Image.FromFile(FilePath);
            } catch
            {
                return Image.FromFile("C:/Program Files/Miiker/Assets/errornoimage.png");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isMale = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Open Mii...";
            openDialog.Filter = "Mii File (*.mii)|*.mii";
            openDialog.DefaultExt = ".mii";
            openDialog.AddExtension = true;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader stream = new StreamReader(openDialog.FileName);
                MessageBox.Show(stream.ReadToEnd());
                stream.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Open Mii...";
            saveDialog.Filter = "Mii File (*.mii)|*.mii";
            saveDialog.DefaultExt = ".mii";
            saveDialog.AddExtension = true;
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter stream = new StreamWriter(saveDialog.FileName);
                string data = "";
                if (isMale) { data = data + "1"; } else { data = data + "0"; }
                stream.Write();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ExerciseNo8
{
    public partial class Form1 : Form
    {
        private List<string> imageFiles;
        private int currentImageIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;
                textBox1.Text = folderPath;
                imageFiles = Directory.GetFiles(folderPath, "*.*")
                    .Where(f => f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                f.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                f.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase))
                    .ToList();

                if (imageFiles.Count > 0)
                {
                    currentImageIndex = 0; 
                    LoadImage();           
                    label2.Text = $"Total Photos: {imageFiles.Count}";
                }
                else
                {
                    MessageBox.Show("No images found in the selected folder.", "No Images", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void LoadImage()
        {
            if (imageFiles != null && imageFiles.Count > 0)
            {
                pictureBox1.Image?.Dispose(); 
                pictureBox1.Image = Image.FromFile(imageFiles[currentImageIndex]);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (imageFiles != null && imageFiles.Count > 0)
            {
                currentImageIndex = (currentImageIndex + 1) % imageFiles.Count; // Loop to the next image
                LoadImage();
            }
        }
    }
}

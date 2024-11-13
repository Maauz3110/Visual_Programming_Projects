using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_8
{
    public partial class Photo_Viewer : Form
    {
        private string[] imageFiles;       // Array to hold paths of images in the folder
        private int currentImageIndex = 0; // Index to track the current image being displayed
        private bool isPlaying = false;    // To track if the slideshow is playing

        public Photo_Viewer()
        {
            InitializeComponent();
        }

        private void btnSetFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFolderPath.Text = folderDialog.SelectedPath; // Display the selected folder path
                    LoadImagesFromFolder(folderDialog.SelectedPath);
                }
            }
        }

        private void LoadImagesFromFolder(string folderPath)
        {
            // Get all image files in the selected folder with common image extensions
            imageFiles = Directory.GetFiles(folderPath, "*.*")
                                  .Where(f => f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                              f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                                              f.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                              f.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) ||
                                              f.EndsWith(".gif", StringComparison.OrdinalIgnoreCase))
                                  .ToArray();

            lblTotalPhotos.Text = "Total Photos: " + imageFiles.Length; // Update total photos count

            if (imageFiles.Length > 0)
            {
                currentImageIndex = 0; // Start from the first image
                DisplayImage(); // Display the first image
                btnPlayPause.Enabled = true; // Enable Play/Pause button
                isPlaying = true;
                timerSlideshow.Start(); // Start the slideshow timer
            }
            else
            {
                MessageBox.Show("No images found in the selected folder.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnPlayPause.Enabled = false; // Disable Play/Pause button if no images are found
            }
        }

        private void DisplayImage()
        {
            if (imageFiles != null && imageFiles.Length > 0)
            {
                pictureBoxPhoto.ImageLocation = imageFiles[currentImageIndex];
            }
        }

        private void timerSlideshow_Tick(object sender, EventArgs e)
        {
            if (imageFiles != null && imageFiles.Length > 0)
            {
                currentImageIndex = (currentImageIndex + 1) % imageFiles.Length; // Move to the next image
                DisplayImage();
            }
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                timerSlideshow.Stop();
                btnPlayPause.Text = "Play";
                isPlaying = false;
            }
            else
            {
                timerSlideshow.Start();
                btnPlayPause.Text = "Pause";
                isPlaying = true;
            }
        }

        private void Photo_Viewer_Load(object sender, EventArgs e)
        {
            timerSlideshow.Interval = 3000;
        }
    }
}

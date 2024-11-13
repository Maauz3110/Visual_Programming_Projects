namespace Exercise_8
{
    partial class Photo_Viewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.btnSetFolder = new System.Windows.Forms.Button();
            this.timerSlideshow = new System.Windows.Forms.Timer(this.components);
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblTotalPhotos = new System.Windows.Forms.Label();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnPlayPause = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Location = new System.Drawing.Point(1, -1);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(798, 291);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 0;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // btnSetFolder
            // 
            this.btnSetFolder.Location = new System.Drawing.Point(713, 300);
            this.btnSetFolder.Name = "btnSetFolder";
            this.btnSetFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSetFolder.TabIndex = 2;
            this.btnSetFolder.Text = "Set";
            this.btnSetFolder.UseVisualStyleBackColor = true;
            // 
            // timerSlideshow
            // 
            this.timerSlideshow.Enabled = true;
            this.timerSlideshow.Interval = 3000;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(-4, 296);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(86, 25);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "Location";
            // 
            // lblTotalPhotos
            // 
            this.lblTotalPhotos.AutoSize = true;
            this.lblTotalPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPhotos.Location = new System.Drawing.Point(12, 357);
            this.lblTotalPhotos.Name = "lblTotalPhotos";
            this.lblTotalPhotos.Size = new System.Drawing.Size(144, 25);
            this.lblTotalPhotos.TabIndex = 5;
            this.lblTotalPhotos.Text = "Total Photos: 0";
            this.lblTotalPhotos.Click += new System.EventHandler(this.timerSlideshow_Tick);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(116, 300);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.ReadOnly = true;
            this.txtFolderPath.Size = new System.Drawing.Size(569, 22);
            this.txtFolderPath.TabIndex = 6;
            this.txtFolderPath.Click += new System.EventHandler(this.btnSetFolder_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Location = new System.Drawing.Point(692, 357);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(96, 56);
            this.btnPlayPause.TabIndex = 7;
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // Photo_Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.lblTotalPhotos);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnSetFolder);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Name = "Photo_Viewer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Photo_Viewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button btnSetFolder;
        private System.Windows.Forms.Timer timerSlideshow;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblTotalPhotos;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnPlayPause;
    }
}


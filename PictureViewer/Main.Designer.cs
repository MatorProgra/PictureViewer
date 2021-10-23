
namespace PictureViewer
{
	partial class Main
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.PBPicture = new System.Windows.Forms.PictureBox();
			this.BtnOpenPicture = new System.Windows.Forms.Button();
			this.OFDOpenFile = new System.Windows.Forms.OpenFileDialog();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.BtnDeletePicture = new System.Windows.Forms.Button();
			this.BtnSaveOrginal = new System.Windows.Forms.Button();
			this.BtnSaveCopy = new System.Windows.Forms.Button();
			this.BtnRotateLeft = new System.Windows.Forms.Button();
			this.BtnRotateRight = new System.Windows.Forms.Button();
			this.BtnFlipHorizontal = new System.Windows.Forms.Button();
			this.BtnFlipVertical = new System.Windows.Forms.Button();
			this.FBDOpenFolder = new System.Windows.Forms.FolderBrowserDialog();
			((System.ComponentModel.ISupportInitialize)(this.PBPicture)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// PBPicture
			// 
			this.PBPicture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PBPicture.Location = new System.Drawing.Point(0, 0);
			this.PBPicture.Name = "PBPicture";
			this.PBPicture.Size = new System.Drawing.Size(1131, 618);
			this.PBPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.PBPicture.TabIndex = 0;
			this.PBPicture.TabStop = false;
			// 
			// BtnOpenPicture
			// 
			this.BtnOpenPicture.Location = new System.Drawing.Point(3, 3);
			this.BtnOpenPicture.Name = "BtnOpenPicture";
			this.BtnOpenPicture.Size = new System.Drawing.Size(110, 42);
			this.BtnOpenPicture.TabIndex = 1;
			this.BtnOpenPicture.Text = "Otwórz zdjęcie";
			this.BtnOpenPicture.UseVisualStyleBackColor = true;
			this.BtnOpenPicture.Click += new System.EventHandler(this.BtnOpenPicture_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.BtnOpenPicture);
			this.flowLayoutPanel1.Controls.Add(this.BtnDeletePicture);
			this.flowLayoutPanel1.Controls.Add(this.BtnSaveOrginal);
			this.flowLayoutPanel1.Controls.Add(this.BtnSaveCopy);
			this.flowLayoutPanel1.Controls.Add(this.BtnRotateLeft);
			this.flowLayoutPanel1.Controls.Add(this.BtnRotateRight);
			this.flowLayoutPanel1.Controls.Add(this.BtnFlipHorizontal);
			this.flowLayoutPanel1.Controls.Add(this.BtnFlipVertical);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 568);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1131, 50);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// BtnDeletePicture
			// 
			this.BtnDeletePicture.Enabled = false;
			this.BtnDeletePicture.Location = new System.Drawing.Point(119, 3);
			this.BtnDeletePicture.Name = "BtnDeletePicture";
			this.BtnDeletePicture.Size = new System.Drawing.Size(110, 42);
			this.BtnDeletePicture.TabIndex = 2;
			this.BtnDeletePicture.Text = "Usuń zdjęcie";
			this.BtnDeletePicture.UseVisualStyleBackColor = true;
			this.BtnDeletePicture.Click += new System.EventHandler(this.BtnDeletePicture_Click);
			// 
			// BtnSaveOrginal
			// 
			this.BtnSaveOrginal.Enabled = false;
			this.BtnSaveOrginal.Location = new System.Drawing.Point(235, 3);
			this.BtnSaveOrginal.Name = "BtnSaveOrginal";
			this.BtnSaveOrginal.Size = new System.Drawing.Size(110, 42);
			this.BtnSaveOrginal.TabIndex = 7;
			this.BtnSaveOrginal.Text = "Zapisz zmiany";
			this.BtnSaveOrginal.UseVisualStyleBackColor = true;
			this.BtnSaveOrginal.Click += new System.EventHandler(this.OnSave_Click);
			// 
			// BtnSaveCopy
			// 
			this.BtnSaveCopy.Enabled = false;
			this.BtnSaveCopy.Location = new System.Drawing.Point(351, 3);
			this.BtnSaveCopy.Name = "BtnSaveCopy";
			this.BtnSaveCopy.Size = new System.Drawing.Size(110, 42);
			this.BtnSaveCopy.TabIndex = 10;
			this.BtnSaveCopy.Text = "Zapisz kopię";
			this.BtnSaveCopy.UseVisualStyleBackColor = true;
			this.BtnSaveCopy.Click += new System.EventHandler(this.OnSave_Click);
			// 
			// BtnRotateLeft
			// 
			this.BtnRotateLeft.Enabled = false;
			this.BtnRotateLeft.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BtnRotateLeft.ForeColor = System.Drawing.SystemColors.ControlText;
			this.BtnRotateLeft.Image = global::PictureViewer.Properties.Resources.RotateLeft;
			this.BtnRotateLeft.Location = new System.Drawing.Point(467, 3);
			this.BtnRotateLeft.Name = "BtnRotateLeft";
			this.BtnRotateLeft.Size = new System.Drawing.Size(42, 42);
			this.BtnRotateLeft.TabIndex = 5;
			this.BtnRotateLeft.UseVisualStyleBackColor = true;
			this.BtnRotateLeft.Click += new System.EventHandler(this.OnRotation_Click);
			// 
			// BtnRotateRight
			// 
			this.BtnRotateRight.Enabled = false;
			this.BtnRotateRight.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BtnRotateRight.Image = global::PictureViewer.Properties.Resources.RotateRight;
			this.BtnRotateRight.Location = new System.Drawing.Point(515, 3);
			this.BtnRotateRight.Name = "BtnRotateRight";
			this.BtnRotateRight.Size = new System.Drawing.Size(42, 42);
			this.BtnRotateRight.TabIndex = 6;
			this.BtnRotateRight.UseVisualStyleBackColor = true;
			this.BtnRotateRight.Click += new System.EventHandler(this.OnRotation_Click);
			// 
			// BtnFlipHorizontal
			// 
			this.BtnFlipHorizontal.Enabled = false;
			this.BtnFlipHorizontal.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BtnFlipHorizontal.Image = global::PictureViewer.Properties.Resources.Horizontal;
			this.BtnFlipHorizontal.Location = new System.Drawing.Point(563, 3);
			this.BtnFlipHorizontal.Name = "BtnFlipHorizontal";
			this.BtnFlipHorizontal.Size = new System.Drawing.Size(42, 42);
			this.BtnFlipHorizontal.TabIndex = 8;
			this.BtnFlipHorizontal.UseVisualStyleBackColor = true;
			this.BtnFlipHorizontal.Click += new System.EventHandler(this.OnRotation_Click);
			// 
			// BtnFlipVertical
			// 
			this.BtnFlipVertical.Enabled = false;
			this.BtnFlipVertical.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BtnFlipVertical.Image = global::PictureViewer.Properties.Resources.Vertical;
			this.BtnFlipVertical.Location = new System.Drawing.Point(611, 3);
			this.BtnFlipVertical.Name = "BtnFlipVertical";
			this.BtnFlipVertical.Size = new System.Drawing.Size(42, 42);
			this.BtnFlipVertical.TabIndex = 9;
			this.BtnFlipVertical.UseVisualStyleBackColor = true;
			this.BtnFlipVertical.Click += new System.EventHandler(this.OnRotation_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1131, 618);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.PBPicture);
			this.Name = "Main";
			this.Text = "Przeglądarka zdjęć";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
			this.Shown += new System.EventHandler(this.Main_Shown);
			((System.ComponentModel.ISupportInitialize)(this.PBPicture)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox PBPicture;
		private System.Windows.Forms.Button BtnOpenPicture;
		private System.Windows.Forms.OpenFileDialog OFDOpenFile;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button BtnDeletePicture;
		private System.Windows.Forms.Button BtnRotateLeft;
		private System.Windows.Forms.Button BtnRotateRight;
		private System.Windows.Forms.Button BtnSaveOrginal;
		private System.Windows.Forms.Button BtnFlipHorizontal;
		private System.Windows.Forms.Button BtnFlipVertical;
		private System.Windows.Forms.Button BtnSaveCopy;
		private System.Windows.Forms.FolderBrowserDialog FBDOpenFolder;
	}
}


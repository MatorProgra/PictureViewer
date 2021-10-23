using PictureViewer.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PictureViewer
{
	enum RotateDirection
	{
		None, Left, Right, Horizontal, Vertical
	}

	public partial class Main : Form
	{
		private string _filePath;

		public Main()
		{
			InitializeComponent();
			SetApplicationSettings();
			SetOpenPictureBoxSettings();
		}

		private void SetApplicationSettings()
		{
			_filePath = Settings.Default.FilePath;

			WindowState = Settings.Default.IsMaximize ? FormWindowState.Maximized : FormWindowState.Normal;
			if (!(WindowState == FormWindowState.Maximized))
			{
				Width = Settings.Default.MainWindowWidth;
				Height = Settings.Default.MainWindowHeight;
			}
		}

		private void SetOpenPictureBoxSettings()
			=> OFDOpenFile.Filter = "Pliki jpg|*.jpg|" + "Pliki gif|*.gif|" + "Pliki png|*.png|" + "Wszystkie pliki|*.*";

		private void LoadLastOpenedPicture()
			=> SetPicture(_filePath);

		private void SetPicture(string filePath)
		{
			if (!string.IsNullOrWhiteSpace(filePath) && File.Exists(filePath))
			{
				Image image = Image.FromFile(filePath);
				SetPictureBoxSizeMode(image);
				PBPicture.Image = image;
				SetButtonsEnabled(true);
			}
		}

		private void SetButtonsEnabled(bool enabled)
			=> BtnDeletePicture.Enabled = BtnRotateLeft.Enabled = BtnRotateRight.Enabled = BtnFlipHorizontal.Enabled = BtnFlipVertical.Enabled = enabled;

		private void SetPictureBoxSizeMode(Image image)
			=> PBPicture.SizeMode = image.Height < PBPicture.Height ? PictureBoxSizeMode.CenterImage : PictureBoxSizeMode.Zoom;

		private void RotateImage(RotateDirection direction)
		{
			BtnSaveOrginal.Enabled = BtnSaveCopy.Enabled = true;
			Image image = PBPicture.Image;
			switch (direction)
			{
				case RotateDirection.Left:
					image.RotateFlip(RotateFlipType.Rotate270FlipNone);
					break;
				case RotateDirection.Right:
					image.RotateFlip(RotateFlipType.Rotate90FlipNone);
					break;
				case RotateDirection.Horizontal:
					image.RotateFlip(RotateFlipType.RotateNoneFlipY);
					break;
				case RotateDirection.Vertical:
					image.RotateFlip(RotateFlipType.RotateNoneFlipX);
					break;
			}
			SetPictureBoxSizeMode(image);
			PBPicture.Image = image;
		}

		private void BtnOpenPicture_Click(object sender, EventArgs e)
		{
			if (OFDOpenFile.ShowDialog() == DialogResult.OK)
			{
				_filePath = OFDOpenFile.FileName;
				SetPicture(_filePath);
			}
		}

		private void BtnDeletePicture_Click(object sender, EventArgs e)
		{
			PBPicture.Image = null;
			_filePath = string.Empty;
			BtnSaveOrginal.Enabled = BtnSaveCopy.Enabled = false;
			SetButtonsEnabled(false);
		}

		private void OnRotation_Click(object sender, EventArgs e)
		{
			string btnName = (sender as Button).Name;
			RotateDirection direction = btnName switch
			{
				"BtnRotateLeft" => RotateDirection.Left,
				"BtnRotateRight" => RotateDirection.Right,
				"BtnFlipHorizontal" => RotateDirection.Horizontal,
				"BtnFlipVertical" => RotateDirection.Vertical,
				_ => RotateDirection.None
			};
			RotateImage(direction);
		}

		private void OnSave_Click(object sender, EventArgs e)
		{
			string btnName = (sender as Button).Name;

			string path = btnName == BtnSaveCopy.Name ?
				Path.Combine(
					Path.GetDirectoryName(_filePath), 
					$"{Path.GetFileNameWithoutExtension(_filePath)}_edited_{DateTime.Now:dd-MM-yyyy}_{DateTime.Now:HH_mm}{Path.GetExtension(_filePath)}") :
				_filePath;

			PBPicture.Image.Save(path);
			MessageBox.Show("Zmiany zostały zapisane", "Zapis pliku", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void Main_Shown(object sender, EventArgs e)
			=> LoadLastOpenedPicture();

		private void Main_FormClosed(object sender, FormClosedEventArgs e)
		{
			Settings.Default.FilePath = _filePath;

			Settings.Default.IsMaximize = WindowState == FormWindowState.Maximized;
			if (!(WindowState == FormWindowState.Maximized))
			{
				Settings.Default.MainWindowWidth = Width;
				Settings.Default.MainWindowHeight = Height;
			}

			Settings.Default.Save();
		}
	}
}

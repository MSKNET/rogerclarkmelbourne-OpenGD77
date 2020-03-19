﻿using System.ComponentModel.Design;
using System.Windows.Forms;
using System;
namespace GD77_FirmwareLoader
{
	partial class MainForm
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
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.btnDownload = new System.Windows.Forms.Button();
			this.btnOpenFile = new System.Windows.Forms.Button();
			this.SuspendLayout();

			//
			// Model selector
			//
			this.grpboxModel = new System.Windows.Forms.GroupBox();
			this.grpboxModel.Text = " Select your radio type ";
			this.grpboxModel.Location = new System.Drawing.Point(5, 5);
			this.grpboxModel.Size = new System.Drawing.Size(220, 85);
			this.rbModels = new System.Windows.Forms.RadioButton[3];

			this.rbModels[0] = new System.Windows.Forms.RadioButton();
			this.rbModels[0].Text = "Radioddity GD-77 / TYT MD-760";
			this.rbModels[0].Location = new System.Drawing.Point(5, 15);
			this.rbModels[0].UseVisualStyleBackColor = true;
			this.rbModels[0].Tag = (int)FirmwareLoader.OutputType.OutputType_GD77;
			this.rbModels[0].AutoSize = true;
			this.rbModels[0].CheckedChanged += new System.EventHandler(this.rbModel_CheckedChanged);

			this.rbModels[1] = new System.Windows.Forms.RadioButton();
			this.rbModels[1].Text = "Radioddity GD-77S";
			this.rbModels[1].Location = new System.Drawing.Point(5, 35);
			this.rbModels[1].UseVisualStyleBackColor = true;
			this.rbModels[1].Tag = (int)FirmwareLoader.OutputType.OutputType_GD77S;
			this.rbModels[1].AutoSize = true;
			this.rbModels[1].CheckedChanged += new System.EventHandler(this.rbModel_CheckedChanged);

			this.rbModels[2] = new System.Windows.Forms.RadioButton();
			this.rbModels[2].Text = "Baofeng MD-1801 / DM-860";
			this.rbModels[2].Location = new System.Drawing.Point(5, 55);
			this.rbModels[2].UseVisualStyleBackColor = true;
			this.rbModels[2].Tag = (int)FirmwareLoader.OutputType.OutputType_DM1801;
			this.rbModels[2].AutoSize = true;
			this.rbModels[2].CheckedChanged += new System.EventHandler(this.rbModel_CheckedChanged);

			this.rbModels[(int)FirmwareLoader.outputType].Checked = true;

			this.grpboxModel.Controls.Add(this.rbModels[0]);
			this.grpboxModel.Controls.Add(this.rbModels[1]);
			this.grpboxModel.Controls.Add(this.rbModels[2]);
			this.Controls.Add(this.grpboxModel);

			//
			// progressBar
			//
			this.progressBar.Location = new System.Drawing.Point(240, 33);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(130, 8);
			this.progressBar.TabIndex = 0;
			this.progressBar.Visible = false;
			this.progressBar.Minimum = 0;
			this.progressBar.Maximum = 100;
			this.progressBar.Value = 0;

			// 
			// btnDownload
			// 
			this.btnDownload.Location = new System.Drawing.Point(240, 42);
			this.btnDownload.Name = "btnDownload";
			this.btnDownload.Size = new System.Drawing.Size(130, 24);
			this.btnDownload.TabIndex = 1;
			this.btnDownload.Text = "Download && Update";
			this.btnDownload.UseVisualStyleBackColor = true;
			this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);

			// 
			// btnOpenFile
			// 
			this.btnOpenFile.Location = new System.Drawing.Point(240, 67);
			this.btnOpenFile.Name = "btnOpenFile";
			this.btnOpenFile.Size = new System.Drawing.Size(130, 24);
			this.btnOpenFile.TabIndex = 2;
			this.btnOpenFile.Text = "Select a File && Update";
			this.btnOpenFile.UseVisualStyleBackColor = true;
			this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);

			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 100);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.btnDownload);
			this.Controls.Add(this.btnOpenFile);
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.Text = "Open(GD77/GD77S/MD1801) Firmware loader";
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.ResumeLayout(false);
		}

		#endregion

		private ProgressBar progressBar;
		private Button btnDownload;
		private Button btnOpenFile;
		private GroupBox grpboxModel;
		private RadioButton[] rbModels;

	}
}

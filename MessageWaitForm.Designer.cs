
namespace ChecktxtName
{
    partial class MessageWaitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageWaitForm));
            this.tblWait = new System.Windows.Forms.TableLayoutPanel();
            this.tblProg = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar = new XanderUI.XUIFlatProgressBar();
            this.lbProg = new System.Windows.Forms.Label();
            this.pbGif = new System.Windows.Forms.PictureBox();
            this.tblWait.SuspendLayout();
            this.tblProg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGif)).BeginInit();
            this.SuspendLayout();
            // 
            // tblWait
            // 
            this.tblWait.ColumnCount = 2;
            this.tblWait.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tblWait.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblWait.Controls.Add(this.tblProg, 1, 0);
            this.tblWait.Controls.Add(this.pbGif, 0, 0);
            this.tblWait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblWait.Location = new System.Drawing.Point(0, 0);
            this.tblWait.Margin = new System.Windows.Forms.Padding(0);
            this.tblWait.Name = "tblWait";
            this.tblWait.RowCount = 1;
            this.tblWait.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblWait.Size = new System.Drawing.Size(600, 150);
            this.tblWait.TabIndex = 0;
            // 
            // tblProg
            // 
            this.tblProg.ColumnCount = 1;
            this.tblProg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblProg.Controls.Add(this.progressBar, 0, 0);
            this.tblProg.Controls.Add(this.lbProg, 0, 1);
            this.tblProg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblProg.Location = new System.Drawing.Point(150, 0);
            this.tblProg.Margin = new System.Windows.Forms.Padding(0);
            this.tblProg.Name = "tblProg";
            this.tblProg.RowCount = 2;
            this.tblProg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblProg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblProg.Size = new System.Drawing.Size(450, 150);
            this.tblProg.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.BarStyle = XanderUI.XUIFlatProgressBar.Style.Material;
            this.progressBar.BarThickness = 5;
            this.progressBar.CompleteColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.progressBar.InocmpletedColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(15, 44);
            this.progressBar.Margin = new System.Windows.Forms.Padding(15, 3, 15, 0);
            this.progressBar.MaxValue = 100;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(420, 31);
            this.progressBar.TabIndex = 1;
            this.progressBar.Text = "xuiFlatProgressBar1";
            this.progressBar.Value = 0;
            // 
            // lbProg
            // 
            this.lbProg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbProg.AutoSize = true;
            this.lbProg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProg.Location = new System.Drawing.Point(189, 90);
            this.lbProg.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.lbProg.Name = "lbProg";
            this.lbProg.Size = new System.Drawing.Size(71, 21);
            this.lbProg.TabIndex = 0;
            this.lbProg.Text = "Loading";
            this.lbProg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbGif
            // 
            this.pbGif.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGif.Image = global::ChecktxtName.Properties.Resources.load;
            this.pbGif.InitialImage = null;
            this.pbGif.Location = new System.Drawing.Point(0, 0);
            this.pbGif.Margin = new System.Windows.Forms.Padding(0);
            this.pbGif.Name = "pbGif";
            this.pbGif.Size = new System.Drawing.Size(150, 150);
            this.pbGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGif.TabIndex = 0;
            this.pbGif.TabStop = false;
            // 
            // MessageWaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(600, 150);
            this.Controls.Add(this.tblWait);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageWaitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageWaitForm";
            this.tblWait.ResumeLayout(false);
            this.tblProg.ResumeLayout(false);
            this.tblProg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblWait;
        private System.Windows.Forms.PictureBox pbGif;
        private System.Windows.Forms.TableLayoutPanel tblProg;
        private System.Windows.Forms.Label lbProg;
        private XanderUI.XUIFlatProgressBar progressBar;
    }
}
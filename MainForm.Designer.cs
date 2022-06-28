
namespace ChecktxtName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tbButton = new System.Windows.Forms.TableLayoutPanel();
            this.btLoadFile = new XanderUI.XUIButton();
            this.btLoadName = new XanderUI.XUIButton();
            this.btFind = new XanderUI.XUIButton();
            this.btSave = new XanderUI.XUIButton();
            this.tbText = new System.Windows.Forms.TableLayoutPanel();
            this.txtSaveName = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.RichTextBox();
            this.txtNovel = new System.Windows.Forms.RichTextBox();
            this.bgwSearch = new System.ComponentModel.BackgroundWorker();
            this.bgwLoadFile = new System.ComponentModel.BackgroundWorker();
            this.MainTPanel.SuspendLayout();
            this.tbButton.SuspendLayout();
            this.tbText.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTPanel
            // 
            this.MainTPanel.ColumnCount = 2;
            this.MainTPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.MainTPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTPanel.Controls.Add(this.tbButton, 1, 0);
            this.MainTPanel.Controls.Add(this.tbText, 0, 0);
            this.MainTPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainTPanel.Name = "MainTPanel";
            this.MainTPanel.RowCount = 1;
            this.MainTPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTPanel.Size = new System.Drawing.Size(1179, 567);
            this.MainTPanel.TabIndex = 0;
            // 
            // tbButton
            // 
            this.tbButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbButton.ColumnCount = 1;
            this.tbButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbButton.Controls.Add(this.btLoadFile, 0, 1);
            this.tbButton.Controls.Add(this.btLoadName, 0, 3);
            this.tbButton.Controls.Add(this.btFind, 0, 5);
            this.tbButton.Controls.Add(this.btSave, 0, 7);
            this.tbButton.Location = new System.Drawing.Point(947, 4);
            this.tbButton.Margin = new System.Windows.Forms.Padding(4);
            this.tbButton.Name = "tbButton";
            this.tbButton.RowCount = 9;
            this.tbButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.58741F));
            this.tbButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.98601F));
            this.tbButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.293706F));
            this.tbButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.98601F));
            this.tbButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.293706F));
            this.tbButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.98601F));
            this.tbButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.293706F));
            this.tbButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.98601F));
            this.tbButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.58741F));
            this.tbButton.Size = new System.Drawing.Size(228, 559);
            this.tbButton.TabIndex = 0;
            // 
            // btLoadFile
            // 
            this.btLoadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btLoadFile.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btLoadFile.ButtonImage = global::ChecktxtName.Properties.Resources.file_storage;
            this.btLoadFile.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btLoadFile.ButtonText = "Load File";
            this.btLoadFile.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btLoadFile.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btLoadFile.CornerRadius = 5;
            this.btLoadFile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btLoadFile.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btLoadFile.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btLoadFile.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btLoadFile.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btLoadFile.Location = new System.Drawing.Point(4, 74);
            this.btLoadFile.Margin = new System.Windows.Forms.Padding(4);
            this.btLoadFile.Name = "btLoadFile";
            this.btLoadFile.Size = new System.Drawing.Size(220, 70);
            this.btLoadFile.TabIndex = 1;
            this.btLoadFile.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btLoadFile.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btLoadFile.Click += new System.EventHandler(this.btLoadFile_Click);
            // 
            // btLoadName
            // 
            this.btLoadName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btLoadName.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btLoadName.ButtonImage = global::ChecktxtName.Properties.Resources.txt;
            this.btLoadName.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btLoadName.ButtonText = "Load Name";
            this.btLoadName.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btLoadName.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btLoadName.CornerRadius = 5;
            this.btLoadName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadName.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btLoadName.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btLoadName.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btLoadName.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btLoadName.Location = new System.Drawing.Point(4, 187);
            this.btLoadName.Margin = new System.Windows.Forms.Padding(4);
            this.btLoadName.Name = "btLoadName";
            this.btLoadName.Size = new System.Drawing.Size(220, 70);
            this.btLoadName.TabIndex = 2;
            this.btLoadName.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btLoadName.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btLoadName.Click += new System.EventHandler(this.btLoadName_Click);
            // 
            // btFind
            // 
            this.btFind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btFind.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btFind.ButtonImage = global::ChecktxtName.Properties.Resources.finding;
            this.btFind.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btFind.ButtonText = "Find Name";
            this.btFind.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btFind.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btFind.CornerRadius = 5;
            this.btFind.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFind.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btFind.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btFind.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btFind.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btFind.Location = new System.Drawing.Point(4, 300);
            this.btFind.Margin = new System.Windows.Forms.Padding(4);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(220, 70);
            this.btFind.TabIndex = 3;
            this.btFind.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btFind.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btSave.ButtonImage = global::ChecktxtName.Properties.Resources.download;
            this.btSave.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btSave.ButtonText = "Save";
            this.btSave.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btSave.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btSave.CornerRadius = 5;
            this.btSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btSave.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btSave.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btSave.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btSave.Location = new System.Drawing.Point(4, 413);
            this.btSave.Margin = new System.Windows.Forms.Padding(4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(220, 70);
            this.btSave.TabIndex = 4;
            this.btSave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btSave.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.ColumnCount = 1;
            this.tbText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbText.Controls.Add(this.txtSaveName, 0, 2);
            this.tbText.Controls.Add(this.txtName, 0, 1);
            this.tbText.Controls.Add(this.txtNovel, 0, 0);
            this.tbText.Location = new System.Drawing.Point(4, 4);
            this.tbText.Margin = new System.Windows.Forms.Padding(4);
            this.tbText.Name = "tbText";
            this.tbText.RowCount = 3;
            this.tbText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbText.Size = new System.Drawing.Size(935, 559);
            this.tbText.TabIndex = 1;
            // 
            // txtSaveName
            // 
            this.txtSaveName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaveName.BackColor = System.Drawing.Color.White;
            this.txtSaveName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaveName.Location = new System.Drawing.Point(4, 376);
            this.txtSaveName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaveName.Name = "txtSaveName";
            this.txtSaveName.Size = new System.Drawing.Size(927, 179);
            this.txtSaveName.TabIndex = 2;
            this.txtSaveName.Text = "";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(4, 190);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(927, 178);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "";
            // 
            // txtNovel
            // 
            this.txtNovel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNovel.BackColor = System.Drawing.Color.White;
            this.txtNovel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNovel.Location = new System.Drawing.Point(4, 4);
            this.txtNovel.Margin = new System.Windows.Forms.Padding(4);
            this.txtNovel.Name = "txtNovel";
            this.txtNovel.Size = new System.Drawing.Size(927, 178);
            this.txtNovel.TabIndex = 0;
            this.txtNovel.Text = "";
            // 
            // bgwSearch
            // 
            this.bgwSearch.WorkerReportsProgress = true;
            this.bgwSearch.WorkerSupportsCancellation = true;
            this.bgwSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSearch_DoWork);
            this.bgwSearch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSearch_RunWorkerCompleted);
            // 
            // bgwLoadFile
            // 
            this.bgwLoadFile.WorkerReportsProgress = true;
            this.bgwLoadFile.WorkerSupportsCancellation = true;
            this.bgwLoadFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLoadFile_DoWork);
            this.bgwLoadFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLoadFile_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 567);
            this.Controls.Add(this.MainTPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Name";
            this.MainTPanel.ResumeLayout(false);
            this.tbButton.ResumeLayout(false);
            this.tbText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTPanel;
        private System.Windows.Forms.TableLayoutPanel tbButton;
        private XanderUI.XUIButton btLoadFile;
        private XanderUI.XUIButton btLoadName;
        private XanderUI.XUIButton btFind;
        private XanderUI.XUIButton btSave;
        private System.Windows.Forms.TableLayoutPanel tbText;
        private System.Windows.Forms.RichTextBox txtSaveName;
        private System.Windows.Forms.RichTextBox txtName;
        private System.Windows.Forms.RichTextBox txtNovel;
        public System.ComponentModel.BackgroundWorker bgwSearch;
        public System.ComponentModel.BackgroundWorker bgwLoadFile;
    }
}


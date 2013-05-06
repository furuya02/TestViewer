namespace TestView {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MainMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MainMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuView = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MainMenuViewStyle1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuViewStyle2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuViewStyle3 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listBox = new System.Windows.Forms.ListBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuFile,
            this.MainMenuView});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(843, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // MainMenuFile
            // 
            this.MainMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuOpen,
            this.toolStripMenuItem1,
            this.MainMenuExit});
            this.MainMenuFile.Name = "MainMenuFile";
            this.MainMenuFile.Size = new System.Drawing.Size(39, 20);
            this.MainMenuFile.Text = "&File";
            // 
            // MainMenuOpen
            // 
            this.MainMenuOpen.Name = "MainMenuOpen";
            this.MainMenuOpen.Size = new System.Drawing.Size(104, 22);
            this.MainMenuOpen.Text = "&Open";
            this.MainMenuOpen.Click += new System.EventHandler(this.MainMenuOpen_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(101, 6);
            // 
            // MainMenuExit
            // 
            this.MainMenuExit.Name = "MainMenuExit";
            this.MainMenuExit.Size = new System.Drawing.Size(104, 22);
            this.MainMenuExit.Text = "E&xit";
            this.MainMenuExit.Click += new System.EventHandler(this.MainMenuExit_Click);
            // 
            // MainMenuView
            // 
            this.MainMenuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuFont,
            this.toolStripMenuItem2,
            this.MainMenuViewStyle1,
            this.MainMenuViewStyle2,
            this.MainMenuViewStyle3});
            this.MainMenuView.Name = "MainMenuView";
            this.MainMenuView.Size = new System.Drawing.Size(47, 20);
            this.MainMenuView.Text = "&View";
            // 
            // MainMenuFont
            // 
            this.MainMenuFont.Name = "MainMenuFont";
            this.MainMenuFont.Size = new System.Drawing.Size(139, 22);
            this.MainMenuFont.Text = "&Font";
            this.MainMenuFont.Click += new System.EventHandler(this.MainMenuFont_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(136, 6);
            // 
            // MainMenuViewStyle1
            // 
            this.MainMenuViewStyle1.Checked = true;
            this.MainMenuViewStyle1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MainMenuViewStyle1.Name = "MainMenuViewStyle1";
            this.MainMenuViewStyle1.Size = new System.Drawing.Size(139, 22);
            this.MainMenuViewStyle1.Text = "ViewStyle1";
            this.MainMenuViewStyle1.Click += new System.EventHandler(this.MainMenuViewStyle1_Click);
            // 
            // MainMenuViewStyle2
            // 
            this.MainMenuViewStyle2.Name = "MainMenuViewStyle2";
            this.MainMenuViewStyle2.Size = new System.Drawing.Size(139, 22);
            this.MainMenuViewStyle2.Text = "ViewStyle2";
            this.MainMenuViewStyle2.Click += new System.EventHandler(this.MainMenuViewStyle1_Click);
            // 
            // MainMenuViewStyle3
            // 
            this.MainMenuViewStyle3.Name = "MainMenuViewStyle3";
            this.MainMenuViewStyle3.Size = new System.Drawing.Size(139, 22);
            this.MainMenuViewStyle3.Text = "ViewStyle3";
            this.MainMenuViewStyle3.Click += new System.EventHandler(this.MainMenuViewStyle1_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 629);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(843, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(843, 605);
            this.splitContainer1.SplitterDistance = 279;
            this.splitContainer1.TabIndex = 2;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(279, 605);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.richTextBox);
            this.splitContainer2.Size = new System.Drawing.Size(560, 605);
            this.splitContainer2.SplitterDistance = 287;
            this.splitContainer2.TabIndex = 0;
            // 
            // listBox
            // 
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(0, 0);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(560, 287);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(560, 314);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            this.richTextBox.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 651);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFile;
        private System.Windows.Forms.ToolStripMenuItem MainMenuExit;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ToolStripMenuItem MainMenuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MainMenuView;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFont;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MainMenuViewStyle1;
        private System.Windows.Forms.ToolStripMenuItem MainMenuViewStyle2;
        private System.Windows.Forms.ToolStripMenuItem MainMenuViewStyle3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}


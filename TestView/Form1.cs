using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestView {
    public partial class Form1 : Form{
        private String _projectDirectory="c:\\tmp2";
        private LeftView _leftView;
        private RightView _rightView;
        
        public Form1() {
            InitializeComponent();
            _leftView = new LeftView(treeView);
            _rightView = new RightView(listView);
        }

        private void MainMenuExit_Click(object sender, EventArgs e){
            Close();
        }

        private void MainMenuOpen_Click(object sender, EventArgs e) {
            var dlg = new FolderBrowserDialog();
            dlg.SelectedPath = _projectDirectory;
            dlg.RootFolder = Environment.SpecialFolder.Desktop;
            if (dlg.ShowDialog(this) == DialogResult.OK){
                Text = _projectDirectory;
                _projectDirectory = dlg.SelectedPath;
                _leftView.Refresh(_projectDirectory);

            }
        }

        private void treeView_Click(object sender, EventArgs e){
            
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e) {
            var node = treeView.SelectedNode;
            if (node == null) {
                return;
            }
            var fileName = (string)node.Tag;
            if (fileName == null) {
                return;
            }
            _rightView.Refresh(_projectDirectory + "\\" + fileName);

        }

        private void MainMenuFont_Click(object sender, EventArgs e) {
            FontDialog dlg = new FontDialog();
            if (DialogResult.OK == dlg.ShowDialog()){
                treeView.Font = dlg.Font;
                listView.Font = dlg.Font;
            }
        }

    }
}

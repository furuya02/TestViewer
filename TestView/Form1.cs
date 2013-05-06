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

        private ViewStyle _viewStyle = ViewStyle.ViewStyle1;

        
        public Form1() {
            InitializeComponent();
            _leftView = new LeftView(treeView);
            _rightView = new RightView(listBox);
            SetFont(new Font("メイリオ",9));

            //DEBUG
            _projectDirectory = @"C:\tmp2\bjd5\BJDTest";
            _leftView.Refresh(_projectDirectory);
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

        private void MainMenuFont_Click(object sender, EventArgs e) {
            FontDialog dlg = new FontDialog();
            if (DialogResult.OK == dlg.ShowDialog()){
                SetFont(dlg.Font);
            }
        }

        void SetFont(Font font){
            treeView.Font = font;
            listBox.Font = font;
            richTextBox.Font = font;
        }

        private void MainMenuViewStyle1_Click(object sender, EventArgs e) {
            if (sender == MainMenuViewStyle1){
                _viewStyle = ViewStyle.ViewStyle1;
            }else if (sender == MainMenuViewStyle2) {
                _viewStyle = ViewStyle.ViewStyle2;
            } else if (sender == MainMenuViewStyle3) {
                _viewStyle = ViewStyle.ViewStyle3;
            }

            MainMenuViewStyle1.Checked = _viewStyle == ViewStyle.ViewStyle1;
            MainMenuViewStyle2.Checked = _viewStyle == ViewStyle.ViewStyle2;
            MainMenuViewStyle3.Checked = _viewStyle == ViewStyle.ViewStyle3;

            _rightView.SetViewStyle(_viewStyle);

        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e) {
            var node = treeView.SelectedNode;
            if (node == null) {
                return;
            }
            var fileName = (string)node.Tag;
            if (fileName == null){
                _rightView.SetFileName(null);
            } else{
                _rightView.SetFileName(_projectDirectory + "\\" + fileName);
            }
            if (0 < listBox.Items.Count){
                listBox.SelectedIndex = 0;
            }
            listBox_SelectedIndexChanged(null, null);
        }


        private void listBox_SelectedIndexChanged(object sender, EventArgs e){
            OneMethod oneMethod = null;
            var index = listBox.SelectedIndex;
            if (index != -1){
                oneMethod = _rightView.GetOneMethod(index);
            }
            
            richTextBox.Clear();


            if (oneMethod != null){
                oneMethod.Code.Disp(richTextBox);
            }
        }
    }
}

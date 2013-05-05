using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestView {
    class LeftView{
        private TreeView _treeView;
        public LeftView(TreeView treeView){
            _treeView = treeView;
        }

        public void Refresh(string path){
            _treeView.Nodes.Clear();
            var ar = new List<string>();
            Search(ref ar,path);
            foreach (var f in ar){
                var s = f.Substring(path.Length+1);
                AddNode(s);
            }

        }

        private void AddNode(string path){
            var tmp = path.Split('\\');
            TreeNodeCollection nodes = _treeView.Nodes;
            TreeNode node = null;
            for (int i = 0; i < tmp.Length - 1; i++) {
                var dir = tmp[i];
                node = null;
                foreach (var n in nodes){
                    if (((TreeNode)n).Text == dir){
                        node = (TreeNode) n;
                        break;
                    }
                }
                if (node==null){
                    nodes.Add(dir);
                    node = nodes[nodes.Count - 1];
                }
                nodes = node.Nodes;
            }
            TreeNode treeNode = node.Nodes.Add(tmp[tmp.Length - 1]);
            treeNode.Tag = path;
        }


        void Search(ref List<string> ar,string path){
            var dirs = Directory.GetDirectories(path);
            foreach (var dir in dirs) {
                Search(ref ar,dir); //再帰
            }
            var files = Directory.GetFiles(path);
            foreach (var file in files){
                if (IsTestCode(file)){
                    ar.Add(file);
                }
            }
        }

//        //bool target=true の場合は、フォルダ名にTestが付いていなくても対象とする
//        public void Append(TreeNodeCollection nodes, string path, bool target) {
//            var dirs = Directory.GetDirectories(path);
//            foreach (var dir in dirs){
//                var name = Path.GetFileName(dir);
//                //最後がTestになっているものだけが対象
//                if (target || IsTestDir(name)){
//                    var node = nodes.Add(name);
//                    Append(node.Nodes, dir,true); //再帰
//                }
//            }
//            var files = Directory.GetFiles(path);
//            foreach (var file in files) {
//                var name = Path.GetFileName(file);
//                //最後がTestになっているものだけが対象
//                if (IsTestFile(name)){
//                    TreeNode node = nodes.Add(Path.GetFileName(file));
//                }
//            }
//
//            
//        }

        //テストコードかどうか判定
        bool IsTestCode(string fileName){
            var lines = File.ReadAllLines(fileName);
            foreach(var s in lines){
                if (s.IndexOf("using NUnit.Framework;") == 0) {
                    return true;
                }
            }
            return false;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestView{
    internal class Code{
        private readonly int _indent = 0;
        private readonly List<string> _ar = new List<string>();

        private int _count = 0;

        public Code(String str){
            _indent = str.IndexOf("public");
            Add(str);
        }

        public bool Append(string str){
            return Add(str);
        }

        //メソッドが終了した場合 return true
        private bool Add(string str){
            if (str == ""){
                return false; //空白行は追加しない
            }
            //{のカウント
            int st = str.Length - str.Replace("{", "").Length;
            //}のカウント
            int en = str.Length - str.Replace("}", "").Length;
            //{}の増減をインクリメント
            _count += st - en;

            str = str.Replace("\t", "    ");//タブ処理
            
            //インデント処理
            if (str.Length < _indent){
                _ar.Add(str);
            } else{
                _ar.Add(" "+str.Substring(_indent));
            }

            //初めの{が終了した場合
            if (_count <= 0){
                return true;
            }
            return false;
        }

        public void Disp(RichTextBox richTextBox){
            var sb = new StringBuilder();
            foreach (var l in _ar) {
                sb.Append(l);
                sb.Append("\r\n");
            }
            richTextBox.Text = sb.ToString();

            //カラー処理

            richTextBox.Find("expected",RichTextBoxFinds.Reverse);
            richTextBox.SelectionColor = Color.Red;
        }
    }
}

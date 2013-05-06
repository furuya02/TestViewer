using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestView {
    enum ViewStyle{
        ViewStyle1,
        ViewStyle2,
        ViewStyle3
    }
    class RightView{
        readonly List<OneMethod> _ar = new List<OneMethod>();
        private ViewStyle _viewStyle = ViewStyle.ViewStyle1;
        
        private readonly ListBox _listBox;

        public RightView(ListBox listBox){
            _listBox = listBox;
        }

        public void SetViewStyle(ViewStyle viewStyle){
            _viewStyle = viewStyle;

            Refresh();
        }

        public void SetFileName(string fileName){
            _ar.Clear();

            if (fileName != null){
                var lines = File.ReadAllLines(fileName);
                OneMethod oneMethod = null;

                foreach (var l in lines){
                    if (oneMethod == null){
                        if (l.IndexOf("[Test]") != -1){
                            oneMethod = new OneMethod(MethodType.Normal);
                        }
                        if (l.IndexOf("[TestCase") != -1){
                            oneMethod = new OneMethod(MethodType.Parameter);
                            oneMethod.Append(l);
                        }
                    } else{
                        if (oneMethod.Append(l)){
                            //クラス終了
                            _ar.Add(oneMethod);
                            oneMethod = null;
                        }
                    }
                }
            }

            Refresh();

        }

        void Refresh(){
            _listBox.Items.Clear();
            foreach (var a in _ar){
                foreach (var s in a.GetLines(_viewStyle)) {
                    _listBox.Items.Add(s);
                    //var item = (ListViewItem) _listBox.Items[_listBox.Items.Count];
                    //item.Tag = this;
                }
            }

        }

        public OneMethod GetOneMethod(int index){
            if (_ar != null){
                return _ar[index];
            }
            return null;
        }
    
    }
}

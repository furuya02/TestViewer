using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestView {
    class RightView{
        private ListView _listView;
        public RightView(ListView listView){
            _listView = listView;
        }

        public void Refresh(string fileName){
            _listView.Items.Clear();

            var lines = File.ReadAllLines(fileName);

            List<string> ar = new List<string>();
            //0 Unknown
            //1 = [Test]
            //2 = {TestCase
            int flg = 0;


            foreach (string l in lines){
                if (flg == 1){
                    ar.Add(l);
                    flg = 0;
                    continue;
                }

                if (l.IndexOf("[Test]") != -1){
                    flg = 1;
                    continue;
                }
                if (l.IndexOf("[TestCase") != -1){
                    ar.Add(l);
                    flg = 2;
                    continue;
                } else{
                    if (flg == 2){
                        ar.Add(l);
                        flg = 0;
                        continue;
                    }
                }
            }
            foreach (var a in ar){
                _listView.Items.Add(a);
            }
        }
    }
}

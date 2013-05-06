using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestView {
    internal enum MethodType{
        Normal,
        Parameter
    }

    class OneMethod{
        private MethodType _clasType;
        private string _name = "";
        private Code _code = null;
        List<string[]> _params = new List<string[]>();


        public OneMethod(MethodType methodType){
            _clasType = methodType;
        }

        public Code Code{
            get{
                return _code;
            }
        } 


        //クラスが終了したとき　return true
        public bool Append(string str){
            if (_code != null){
                if (_code.Append(str)){
                    return true;
                }
            } else{
                int index = str.IndexOf("[TestCase");
                if (index != -1){
                    str = str.Substring(index);
                    str = str.Replace("[TestCase", "");
                    str = str.Replace("]", "");
                    var param = str.Split(new[] { ',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                    _params.Add(param);
                }
            }
            //メソッド宣言の開始
            if (str.IndexOf("public")!=-1){
                var tmp = str.Split(new []{' '},3,StringSplitOptions.RemoveEmptyEntries);
                _name = tmp[2];
                //最後の{を削除
                int index = tmp[2].IndexOf("{");
                if (index != -1){
                    _name = tmp[2].Substring(0,index);
                }
                //パラメータ間の空白を削除
                _name = _name.Replace(", ", ",");
                _code=new Code(str);

            }
            return false;
        }
        public List<string> GetLines(ViewStyle viewStyled){
            var lines = new List<string>();
            if (viewStyled == ViewStyle.ViewStyle1){
                lines.Add(_name);
            } else if (viewStyled == ViewStyle.ViewStyle2){
                foreach (var param in _params){
                    StringBuilder sb = new StringBuilder();
                    foreach (var p in param){
                        if (sb.Length != 0){
                            sb.Append(",");
                        }
                        sb.Append(p);
                    }
                    lines.Add(string.Format("{0} {1}",_name,sb.ToString()));
                }
            } else{
                lines.Add("test");
                
            }
            return lines;
        }

        public string ToString(ViewStyle viewStyled){
            return _name;
        }

    }
}

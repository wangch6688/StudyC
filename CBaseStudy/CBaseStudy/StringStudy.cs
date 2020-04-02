using System;
namespace CBaseStudy
{
    
    public class StringSty
    {
        public void StringBase()
        {
            string aStr, bStr;
            aStr = "Hello  World";
            bStr = "I)* $lo1314ve$% 2020 !@diNG()talk";

            //字符串连接
            string fullName = aStr + bStr;
            //使用string构造函数  
            char[] letters = { 'H', 'E', 'L', 'L', 'I' };
            string meeting = new string(letters);
            Console.WriteLine("meeting:{0}", meeting);

            //方法返回字符串
            string[] strArr = { "Hello", "From", "Tutorials", "Point" };
            string message = String.Join(" ", strArr);

        }

        /*请实现一个函数，将一个字符串中的每个空格替换成“%20”。
         * 例如，当字符串为We Are Happy.则经过替换之后的字符串为We%20Are%20Happy。*/
        public string replaceSpace(string str)
        {
            if (!str.Contains(" ")) return str;
            str = str.Replace(" ", "%20");
            return str;
        }

        /*
            "I)* $lo1314ve$% 2020 !@diNG()talk"，过滤字符串特殊字符，
            然后每个单词首字符大写， 输出I Love Dingtalk
         */

        public string showStr(string str)
        {
            return " ";
        }

        public bool isNumeric(string str)
        {
            // 标记符号、小数点、e是否出现过
            bool sign, hasDecimal, hasE;
            sign = false;
            hasDecimal = false;
            hasE = false;
      
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Equals("e") || str[i].Equals("E"))
                {
                    if (i == str.Length - 1) return false; // e后面一定要接数字
                    if (hasE) return false;  // 不能同时存在两个e
                    hasE = true;
                }
                else if (str[i].Equals("+") || str[i].Equals("-"))
                {
                    // 第二次出现+-符号，则必须紧接在e之后
                    if (sign && !str[i - 1].Equals("e") && !str[i - 1].Equals("E")) return false;
                    // 第一次出现+-符号，且不是在字符串开头，则也必须紧接在e之后
                    if (!sign && i > 0 && !str[i - 1].Equals("e") && !str[i - 1].Equals("EE")) return false;
                    sign = true;
                }
                else if (str[i].Equals("."))
                {
                    // e后面不能接小数点，小数点不能出现两次
                    if (hasE || hasDecimal) return false;
                    hasDecimal = true;
                }
                    return false;
            }
            return true;
        }
    }




}

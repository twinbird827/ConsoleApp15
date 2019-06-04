using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static Dictionary<string, string> ValuePairs;

        static void Main(string[] args)
        {
            Init();

            Test("b");
            Test("l");
            Test("r");
            Test("bbb");
            Test("rrr");
            Test("blll");
            Test("llll");
            Test("rbrl");
            Test("brrrr");
            Test("llrrr");
            Test("lrlll");
            Test("lrrrr");
            Test("rllll");
            Test("blrrrr");
            Test("brllll");
            Test("bbbrrlrl");
            Test("rbllrrrr");
            Test("lbrlrrblr");
            Test("rlbrrrrbl");
            Test("bllrlrbrrb");
            Test("rllrllllbb");
            Test("blblrlrrlbr");
            Test("lrlrrrrrbrb");
            Test("rblllrlrrlrr");
            Test("rbrrlrblrllb");
            Test("lrrrlrllrrllr");
            Test("rrlblllrrlrrb");
            Test("brbllrrbbrlrll");
            Test("rrrbbrlbrlblrb");
            Test("lllllllllllblrr");
            Test("llllllrllrlbrrr");

            Console.ReadLine();
        }

        static void Init()
        {
            ValuePairs = new Dictionary<string, string>();
            ValuePairs["ABl"] = "C";
            ValuePairs["ABr"] = "E";
            ValuePairs["ABb"] = "A";
            ValuePairs["ADl"] = "E";
            ValuePairs["ADr"] = "F";
            ValuePairs["ADb"] = "A";
            ValuePairs["ACl"] = "F";
            ValuePairs["ACr"] = "B";
            ValuePairs["ACb"] = "A";
            ValuePairs["BAl"] = "D";
            ValuePairs["BAr"] = "C";
            ValuePairs["BAb"] = "B";
            ValuePairs["BCl"] = "A";
            ValuePairs["BCr"] = "F";
            ValuePairs["BCb"] = "B";
            ValuePairs["BEl"] = "F";
            ValuePairs["BEr"] = "D";
            ValuePairs["BEb"] = "B";
            ValuePairs["CAl"] = "B";
            ValuePairs["CAr"] = "D";
            ValuePairs["CAb"] = "C";
            ValuePairs["CBl"] = "E";
            ValuePairs["CBr"] = "A";
            ValuePairs["CBb"] = "C";
            ValuePairs["CFl"] = "D";
            ValuePairs["CFr"] = "E";
            ValuePairs["CFb"] = "C";
            ValuePairs["DAl"] = "C";
            ValuePairs["DAr"] = "B";
            ValuePairs["DAb"] = "D";
            ValuePairs["DEl"] = "B";
            ValuePairs["DEr"] = "F";
            ValuePairs["DEb"] = "D";
            ValuePairs["DFl"] = "E";
            ValuePairs["DFr"] = "C";
            ValuePairs["DFb"] = "D";
            ValuePairs["EBl"] = "A";
            ValuePairs["EBr"] = "C";
            ValuePairs["EBb"] = "E";
            ValuePairs["EDl"] = "F";
            ValuePairs["EDr"] = "A";
            ValuePairs["EDb"] = "E";
            ValuePairs["EFl"] = "C";
            ValuePairs["EFr"] = "D";
            ValuePairs["EFb"] = "E";
            ValuePairs["FCl"] = "B";
            ValuePairs["FCr"] = "A";
            ValuePairs["FCb"] = "F";
            ValuePairs["FDl"] = "A";
            ValuePairs["FDr"] = "E";
            ValuePairs["FDb"] = "F";
            ValuePairs["FEl"] = "D";
            ValuePairs["FEr"] = "B";
            ValuePairs["FEb"] = "F";
        }

        static void Test(string target)
        {
            Console.WriteLine($"{target.PadRight(15)}:{Proc(target)}");
        }

        static string Proc(string target)
        {
            var sb = new StringBuilder("BA");

            foreach (var c in target)
            {
                sb.Append(ValuePairs[$"{sb.ToString(sb.Length - 2, 2)}{c}"]);
            }

            return sb.ToString(1, sb.Length - 1);
        }

    }

}

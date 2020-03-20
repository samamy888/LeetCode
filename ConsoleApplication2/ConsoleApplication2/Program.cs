using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexTest
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    class Program
    {
        static int[] TestArray = { 12, 345, 2, 6, 7896 };
        static int TestNumber = 234;
        static string TestStr = "RLRRRLLRLL";
        static ListNode TestNode = GetTestNode();
        static public ListNode GetTestNode()
        {
            ListNode node = new ListNode(1);
            ListNode node2 = new ListNode(0);
            node2.next = new ListNode(1);
            node.next = node2;
            return node;
        }
        static void Main(string[] args)
        {
            int ans = GetDecimalValue(TestNode);
            Console.WriteLine("ans = " + ans);
            Console.ReadLine();
        }
        static public int GetDecimalValue(ListNode head)
        {
            List<int> list = new List<int>();
            int ans = 0;
            while (true)
            {

                list.Add(head.val);
                if (head.next == null)
                    break;
                head = head.next;
            }
            for(int i = 0; i < list.Count; i++)
            {
                ans += Convert.ToInt32(list[list.Count-i-1] *Math.Pow(2,i));
            }
            return ans;
        }
    }

}





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
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    class Program
    {
        static int[] TestArray = { 0,1,2,3,4};
        static int[] TestArray2 = { 0,1,2,2,1};
        static int TestNumber = 234;
        static string TestStr1 = "aA";
        static string TestStr2 = "aAAbbbb";
        static ListNode TestNode = GetTestNode();
        static TreeNode TestTreeNode = GetTestTreeNode();
        static public ListNode GetTestNode()
        {
            ListNode node = new ListNode(1);
            ListNode node2 = new ListNode(0);
            node2.next = new ListNode(1);
            node.next = node2;
            return node;
        }
        static public TreeNode GetTestTreeNode()
        {
            TreeNode node = new TreeNode(10);
            node.left = new TreeNode(5);
            node.right = new TreeNode(15);
            node.left.left = new TreeNode(3);
            node.left.right = new TreeNode(7);
            node.right.right = new TreeNode(18);
            return node;
        }
        static public string ArrayAnstoString(int[] ans)
        {
            string str= "[";
            for(int i = 0; i < ans.Length; i++)
            {
                str += ans[i] + ",";
            }
            str = str.Substring(0,str.Length-1)+"]";
            return str;
        }
        static void Main(string[] args)
        {
            //int ans = RangeSumBST(TestTreeNode, 7, 15 );
            //Console.WriteLine("ans = " + ans);
            int[] ans = CreateTargetArray(TestArray, TestArray2);
            Console.WriteLine(ArrayAnstoString(ans));
            Console.ReadLine();
        }
        static public int[] CreateTargetArray(int[] nums, int[] index)
        {
            int?[] tmp = new int?[nums.Length];
            int[] ans = new int[nums.Length];
            int cnt;
            for(int i = nums.Length-1; i >= 0; i--)
            {
                cnt = i;
                while (tmp[cnt] !=null)
                {
                    cnt++;
                }
                tmp[index[i]] = nums[cnt];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = tmp[i].GetValueOrDefault();
            }
            return ans;
        }
    }

}





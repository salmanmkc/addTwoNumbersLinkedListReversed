
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;


// Definition for singly-linked list.
public class ListNode
{
     public int val;
     public ListNode next;
     public ListNode(int x) { val = x; }

    public ListNode(long v)
    {
    }
}

public class Solution
{
    List<decimal> l1List = new List<decimal>();
    List<decimal> l2List = new List<decimal>();
    //int i = 0;
    int count = 0;
    string currentNodeString = "";
    string prevNodeString = "";

    public static void Main()
    {
        ListNode l1 = new ListNode(1);
        ListNode l12 = new ListNode(1);
        ListNode l13 = new ListNode(1);
        ListNode l14 = new ListNode(1);
        ListNode l15 = new ListNode(1);
        ListNode l16 = new ListNode(1);
        ListNode l17 = new ListNode(1);
        ListNode l18 = new ListNode(1);
        ListNode l19 = new ListNode(1);
        ListNode l110 = new ListNode(1);
        ListNode l111 = new ListNode(1);
        ListNode l112 = new ListNode(1);
        ListNode l113 = new ListNode(1);
        ListNode l114 = new ListNode(1);
        ListNode l115 = new ListNode(1);
        ListNode l116 = new ListNode(1);
        ListNode l117 = new ListNode(1);
        ListNode l118 = new ListNode(1);
        ListNode l119 = new ListNode(1);
        ListNode l120 = new ListNode(1);
        ListNode l121 = new ListNode(1);
        ListNode l122 = new ListNode(1);
        ListNode l123 = new ListNode(1);
        ListNode l124 = new ListNode(1);





        l1.next = l12;
        l12.next = l13;
        l13.next = l14;
        l14.next = l15;
        l15.next = l16;
        l16.next = l17;
        l17.next = l18;
        l18.next = l19;
        l19.next = l110;
        l110.next = l111;
        l111.next = l112;
        l112.next = l113;
        l113.next = l114;
        l114.next = l115;
        l115.next = l116;
        l116.next = l117;
        l117.next = l118;
        l118.next = l119;
        l119.next = l120;
        l120.next = l121;
        l121.next = l122;
        l122.next = l123;
        l123.next = l124;





        //ListNode l1 = new ListNode(9);
        //int[] firstSet = new int[] { 1, 2 };
        //ListNode l2 = new ListNode(9);
        //int[] secondSet = new int[] { 4, 2, 9 };
        //Solution s = new Solution();
        //s.arrayToList(firstSet, l1);
        //s.arrayToList(secondSet, l2);
        //s.AddTwoNumbers(l1, l2);





        ListNode l2 = new ListNode(1);
        ListNode l22 = new ListNode(1);
        ListNode l23 = new ListNode(1);
        ListNode l24 = new ListNode(1);
        ListNode l25 = new ListNode(1);
        ListNode l26 = new ListNode(1);
        ListNode l27 = new ListNode(1);
        ListNode l28 = new ListNode(1);
        ListNode l29 = new ListNode(1);
        ListNode l210 = new ListNode(1);
        ListNode l211 = new ListNode(1);




        l2.next = l22;
        l22.next = l23;
        l23.next = l24;
        l24.next = l25;
        l25.next = l26;
        l26.next = l27;
        l27.next = l28;
        l28.next = l29;
        l29.next = l210;
        l210.next = l211;


        Solution s = new Solution();
        s.AddTwoNumbers(l1, l2);
    }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        convertToArray(l1, l1List);
        convertToArray(l2, l2List);
        List<decimal> reversedL1 = new List<decimal>();
        reverseList(l1List, reversedL1);
        List<decimal> reversedL2 = new List<decimal>();
        reverseList(l2List, reversedL2);
        BigInteger l1Val = new BigInteger(convertToInt(reversedL1));
        BigInteger l2Val = new BigInteger(convertToInt(reversedL2));
        BigInteger sum = BigInteger.Add(l1Val, l2Val);
        string[] ArrayAnswer = sum.ToString().Select(o => (o.ToString())).ToArray();
        int lastNode = Convert.ToInt32(ArrayAnswer[ArrayAnswer.Length - 1]);
        ListNode newNode = new ListNode(Convert.ToInt32((ArrayAnswer[ArrayAnswer.Length - 1])));
        return arrayToList(ArrayAnswer, newNode);
        //return l1;

    }

    private void reverseList(List<decimal> List, List<decimal> reversedList)
    {
        for (int i = List.Count() - 1; i > -1; i--)
        {
            reversedList.Add(List[i]);
        }
    }

    public ListNode arrayToList(string[] array, ListNode newNode)
    {
        var dictionary = new Dictionary<string, ListNode>();
        for (int i = array.Length - 2; i > -1; i--)
        {
            //ListNode addNode = new ListNode(array[i]);
            dictionary.Add("addNode" + i, new ListNode(Convert.ToInt32((array[i]))));
            currentNodeString = "addNode" + i;
            if (count == 0)
            {
                newNode.next = dictionary[currentNodeString];
            }
            else
            {
                dictionary[prevNodeString].next = dictionary[currentNodeString];

            }
            prevNodeString = currentNodeString;
            //arrayToList(array, addNode);
            count++;
        }

        return newNode;
    }

    public decimal convertToInt(List<decimal> list)
    {
        decimal converted = 0;
        for (int i = 0; i < list.Count(); i++)
        {
            converted += list[i] * (decimal)Convert.ToUInt64(Math.Pow(10, list.Count() - i - 1));
        }
        return converted;
    }

    public void convertToArray(ListNode list, List<decimal> array)
    {
        array.Add((decimal)list.val);
        if (list.next != null)
        {
            //array.Add(list.next.val);
            convertToArray(list.next, array);
        }
        else
        {
            return;
        }
    }
}
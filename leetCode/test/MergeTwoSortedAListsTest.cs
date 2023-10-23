using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode;

namespace test
{
    [TestClass]
    public class MergeTwoSortedAListsTest
    {
        [DataTestMethod]
        [DataRow(new int[] { 1, 3, 5 }, new int[] { 2, 4, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        [DataRow(new int[] { 1 }, new int[] { 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        [DataRow(new int[] { }, new int[] { 1, 2 }, new int[] { 1, 2 })]
        public void MergeTwoListsTest(int[] list1Values, int[] list2Values, int[] expectedMergedValues)
        {
            ListNode list1 = CreateLinkedList(list1Values);
            ListNode list2 = CreateLinkedList(list2Values);

            ListNode mergedList = MergeTwoSortedLists.MergeTwoLists(list1, list2);
            
            int[] mergedListValues = ConvertLinkedListToArray(mergedList);
            CollectionAssert.AreEqual(expectedMergedValues, mergedListValues);
        }

        private ListNode CreateLinkedList(int[] values)
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;

            foreach (int value in values)
            {
                current.next = new ListNode(value);
                current = current.next;
            }

            return dummy.next;
        }

        private int[] ConvertLinkedListToArray(ListNode head)
        {
            List<int> values = new List<int>();
            while(head != null)
            {
                values.Add(head.val);
                head = head.next;
            }
            return values.ToArray();
        }


    }
}

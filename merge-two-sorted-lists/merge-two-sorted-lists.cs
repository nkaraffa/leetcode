/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        //Check if entries are null, then return other node
            if(l1 == null)
            {
                return l2;
            }
            else if (l2 == null)
            {
                return l1;
            }

            //Instaniate ListNode 'ans' and 'temp'
            ListNode ans = new ListNode(), temp = ans;

            //Keeping looping until one ListNode is null
            while(l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)       //Check if current value of SortedList is greater than
                {
                    temp.next = l1;         //Save in temp
                    l1 = l1.next;           //Then increment ListNode for while loop
                }
                else
                {
                    temp.next = l2;         //Save in temp
                    l2 = l2.next;           //Then increment ListNode for while loop
                }

                temp = temp.next;           
            }

            //Boolean check for null ListNode (l1 or l2)
            //Set temp.next equal to whichever value is null
            temp.next = l1 == null ? l2 : l1;

            //Return ans.next for your combined and sorted list
            return ans.next;
    }
}
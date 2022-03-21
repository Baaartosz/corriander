/*
Sum Lists

You have two lits represented by a linked list, where each node contains a single digit.
Digits are stored in reverse order.

E.g (6 -> 5 -> 1) = 156

Not allowed to cheat and convert linked list into an integer.

baaart.dev
*/

// Will return to this question later down the line, I know how to solve it but at the time
// I became ill and found it very hard to focus.
//
// int sumLists(ListNode a,ListNode b){ // TODO - need to change from int to return listnode.  
//     int sum; 
//     int n = 1;
//     while( a != null || b != null){
//         x = a.value;
//         y = b.value;

//         // Allows for values to be not the same size E.g (4 -> 6 -> 3) + (1 -> 3 -> 3 -> 7)
//         if(x != null) x = x * n;
//         else x = 0;
//         if(y != null) y = y * n;
//         else y = 0;

//         sum += x + y; // Sum together a , b nodes and add them to sum;
//         n *= 10; // 1 10 100 ... 100,000

//         // Move down LinkedList
//         a = a.next;
//         b = b.next;
//     }
//     return sum;
// }

// // Adjusted code for giving back ListNode of result.
// ListNode sumLists(ListNode a, ListNode b, bool isForwardOrder){  
//     ListNode sum = new ListNode(0, null);
//     ListNode head = null;
//     if(isForwardOrder) head = sum;

//     while (a != null || b != null){
//         int c = sum.value + a + b;
//         int value = c % 10;
//         if(c > 9){
//             // ( Carry 1 )
//             if(isForwardOrder){
//                 sum.value += 1;
//                 sum.next = new ListNode(value);
//                 sum = sum.next;
//             }else{
//                 sum.value = value;
//                 sum = new ListNode(1, sum); // +=
//             }
//         }else{
//             // Generate a new Node.

//             if (isForawrdOrder) sum = new ListNode(value, sum);
//             else sum = new ListNode(0, sum); // needs changing
//         }

//         a = a.next;
//         b = b.next;
//     }
//     return sum;
// }

// /*
// FOLLOW UP
// ---------

// What if the linked list is in forward order?
// */

// int sumLists(ListNode a, ListNode b, bool isForwardOrder){
//     int sum;
//     int n = 1;
//     while( a != null || b != null){
//         x = a.value;
//         y = b.value;

//         // Allows for values to be not the same size E.g (4 -> 6 -> 3) + (1 -> 3 -> 3 -> 7)
//         if(x != null) x = x * n;
//         else x = 0;
//         if(y != null) y = y * n;
//         else y = 0;

//         sum += x + y; // Sum together a , b nodes and add them to sum;
//         n = (isForwardOrder) ? n /= 10 : n *= 10; 
//         // ^^ BUG - cannot run forwards as n has to be set before hand to max number of nodes.

//         // Move down LinkedList
//         a = a.next;
//         b = b.next;
//     }
//     return sum;
// }
class ListNode{} // For Code Highlighting
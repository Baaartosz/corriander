/*
Remove Duplicates 

Write code to remove duplicates from an unsorted linked list.

Follow up with; How would you solve this problem without using a temporary buffer?

baaart.dev
*/

// Assuming a LinkedList of integers.

//RemoveDuplicates(LinkedList.head);

void RemoveDuplicates(ListNode node){
    HastSet<int> ints = new HastSet<int>();
    ListNode prev = null;

    while(node != null) { // While list is not empty.
        if(ints.contains(node.vaule)){
            prev.next = node.next;
        }else{
            ints.add(node.value);
            prev = node;
        }
        node = node.next;
    }
}

// use current and runner pointers
void RemoveDuplicates_NoBuffer(ListNode node){
    
}
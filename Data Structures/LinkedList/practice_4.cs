/*
Partition

Write code to partition a linked list around a value 'x', such that all nodes less than 'x' come 
before all nodes greater than or equal to 'x'.

IMPORTANT! {
    The partition element 'x' can appear anywhere in the 'right partition'; 
    it does not need to appear between the left and right partitions.
}

Example:

INPUT: 3 -> 5 -> 8 -> 5 -> 10 -> 2 -> 1 [Partition = 5]
OUTPUT 3 -> 1 -> 2   ->   10 -> 5 -> 5 -> 8 (One of many possible outputs)
*/

ListNode partition(ListNode head, int p){
    ListNode lowHead, highHead = null;
    ListNode currentLow, currentHigh = null;
    ListNode runner = head;
    while(runner != null){ // O(n)
        if(runner.value < p){ // Check numbers lower then partition int.
            
            // Set the head of the lower number nodes.
            if(lowHead == null){
                lowHead = runner;
                currentLow = lowHead;
            }else{ // Add to end of node.
                currentLow.next = runner;
                currentLow = currentLow.next;
            }
        }else if(runner.value >= p){ // Check numbers greater than or equal to partition int.
            
            // Set the head of the higher number nodes.
            if(highHead == null){
                highHead = runner;
                currentHigh = highHead;
            }else{ // Add to end of node.
                currentHigh.next = runner;
                currentHigh = currentHigh.next;
            }
        }
        runner = runner.next;
    }

    // Combined the two list nodes back into one.
    currentHigh.next = null;
    currentLow.next = highHead;
    return lowHead;
}


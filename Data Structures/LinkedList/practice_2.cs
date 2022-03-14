/*
Return Kth to Last

Implement an algorithm to find the Kth to last element of a singly linked list.

baaart.dev
*/

// k = 2, 2nd last element

int findKthToLast(ListNode node, int k){ // Asumming List size is not known. Non-recursive.
    // O(1) Space
    ListNode runner = node;
    ListNode lagger = node;
    int nodesAhead = 0;

    while(runner != null){ // O(n) Time
        if(nodesAhead > k) {
            nodesAhead++;
        }else{
            lagger = lagger.next;
        }
        runner = runner.next;
    }
    return lagger.value;
}
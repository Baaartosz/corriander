/*
Delete Middle Node

Implement an algorithm to delete a node in the middle 
(i.e any node but he first and last node, not necessarily the exact middle ) 
of a singly linked list, give only access to that node.

Example:

INPUT: <node C> from linked list a -> b -> c -> d -> e -> f
OUTPUT: a -> b -> d -> e -> f

baaart.dev
*/

boolean delete(ListNode n) {
    if(n == null || n.next == null){
        return false; // Cannot delete;
    }
    ListNode node = n.next;
    n.item = node.item;
    n.next = node.next;
    return true; // Successful Deletion
}
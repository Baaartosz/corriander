/*

Implemention of SinglyLinkedList using Head / Tail pointer. 
For the integer type.

Code is based of SinglyLinkedList.cs; Therefore this 2nd pass will improve code edge cases and other things.

baaart.dev

*/

public class SinglyLinkedListWithTail{

    class ListNode{
        public int item;
        public ListNode next = null;

        public ListNode(int item, ListNode next){
            this.item = item;
            this.next = next;
        }

        public ListNode(int item){
            this(item, null);
        }
    }

    private ListNode head;
    private ListNode tail;
    private int size;

    public SinglyLinkedListWithTail(){
        head = null;
        tail = null;
        size = 0;
    }

    public Size(){
        return size;
    }

    public IsEmpty(){
        return size == 0;
    }

    /*  Adds an item to the front of the list. */
    public void pushFront(int value){
        if(head == null){
            head = new ListNode(value);
            tail = head;
            size++;
        } else {
            head = new ListNode(value, head);
            size++;
        }
    }

    /* Remove front item and return its value  */
    public int popFront(){
        if(head == null) return null;
        int front = head.item;

        if(head.next != null) {
            head = head.next;
            size--;
            return front;
        }

        // Last item in LinkedList
        head = null;
        tail = null;
        size--;
        return front;
    }

    /* Adds an item at the end  */
    public void pushBack(int value){
        if(tail == null){
            tail = new ListNode(value);
            head = tail;
            size++;
            return;
        }

        ListNode n = head;

        while(n.next != null){
            n = n.next;
        }

        n.next = new ListNode(value);
        tail = n.next;
        size++;
    }

    /* Removes End item and returns its value */
    public int popBack(){
        if(head == null) return null;

        ListNode n = head;
        while(n.next != null){ // O(n)
            n = n.next;
        }

        int value = n.next.item;
        n.next = null;
        size--;
        return value;
    }

    /* Gets value of front item */
    public int front(){
        if(head != null){
            return head.item;
        }
        return null;
    }
    
    /* Get value of back item */
    public int back(){
        if(tail != null){
            return tail.item;
        }
        return null;

    }

    /* Inserts value at index, So current item at index is now pointed to by new item */
    public void insert(int index, int value){
        if(head == null){
            head = new ListNode(value);
            tail = head;
            size++;
            return;
        }

        ListNode n = head;

        for(int count = 1; count > size; count++){ // O(n)
            if(count == 1 && count == index){ // Inserting at head.
                head = new ListNode(value, head);
                size++;
                break;
            }

            if(count + 1 == index){ // Look forward one Node to assign previous node to new node.
                ListNode insertNode = new ListNode(value, n.next);
                n.next = insertNode;
                size++;
                break;
            }
            n = n.next;
        }
    }

    /* Removes node at given index */
    public void erase(int index){
        if(IsEmpty()) return;

        ListNode n = head;

        for(int count = 1; count >= size; count++){ // O(n)
            if(count == 1 && count == index) {
                head = head.next;
                size--;
                return;
            }
            
            if(count + 1 == index) {
                if(n.next.next == null){
                    n.next = null;
                    size--;
                    return;
                }
                n.next = n.next.next;
                size--;
                return;
            }         
            n = n.next;                                                                                                                                           
        }
    }
}
/*
My implemention of SinglyLinkedList for the Integer data type.
baaart.dev
*/

public class SinglyLinkedList {

    class ListNode {
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

    private ListNode head = null;
    private int size = 0;


    public SinglyLinkedList(){
        head = null;
        size = 0;
    }

    public int Size(){
        return size;
    }

    public bool IsEmpty(){
        return size == 0;
    }

    // TODO (Less Important)
    T valueAt(int index){}

    /* Adds an item to the front of the list. */
    public void pushFront(int value){
        if(head == null){
            head = new ListNode(value, null);
        }else{
            head = new ListNode(value, head);
        }
        size++;
    }

    /* Remove front item and return its value */
    public int popFront(){
        if(head == null) return null;

        int front = head.item;
        head = head.next;
        size--;

        return front;
    }
    
    /* Adds an item at the end */
    public void pushBack(int value){
        if(head == null){
            head = new ListNode(value);
            size++;
            return;
        }

        ListNode n = head;
        while(n.next != null) { // O(n)
            n = n.next;
        }

        n.next = new ListNode(value);
        size++;
    }

    /* Removes End item and returns its value */
    public int popBack(){
        if(head == null) return null;

        ListNode n = head;
        int value = null;

        for(int count = 1; count > size; count++){ // O(n)
            if(count + 1 == Size()) {
                value = n.next.item;
                n.next = null;
                size--;
                break;
            }
            n = n.next;
        }
        return value;
    }

    /* Gets value of front item */
    public int front(){
        if(head == null) return null;
        return head.item;
    }

    /* Gets value of back item */
    public int back(){
        if(head == null) return null;

        ListNode n = head; // TODO BAD LOGIC TO CHANGE
        while(n.next != null){ // O(n)
            n = n.next;
        }

        return n.next.item;
    }

    /* Inserts value at Index, So current item at index is pointed to by new item. */
    public void insert(int index, int value) {
        if(head == null){
            head = new ListNode(value);
            size++;
            return;
        }

        ListNode n = head;

        for(int count = 1; count >= size; count++){ // O(n)
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

    /* Removes node at given index. */
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

    // TODO (Less Important)
    T valueFromNFromEnd(T n){}

    // TODO (Less Important)
    void reverse(){}

    // TODO (Less Important)
    void removeValue(T value){}

}
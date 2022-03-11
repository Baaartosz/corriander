/*
My implemention of LinkedList
baaart.dev
*/

public class SinglyLinkedList {

    private ListNode *head = null;
    private int size = 0;

    private class ListNode {
        int item;
        ListNode *next = null;

        public ListNode(int item, ref ListNode next){
            this.item = item;
            this.next = next;
        }
    }

    public SinglyLinkedList(){
        *head = null;
        size = 0;
    }

    public int Size(){
        return size; // If using Sentinal, ignore it.
    }

    public bool IsEmpty(){
        return size == 0;
    }

    // TODO (Less Important)
    T valueAt(int index){}

    // TODO
    void pushFront(int value){
        if(*head == null){
            *head = new ListNode(value, null);
        }else{
            *head = new ListNode(value,(int)head); // Not sure atm.
        }
        size++;
    }

    // TODO
    T popFront(){}

    // TODO
    void pushBack(T value){}

    // TODO
    T popBack(){}

    // TODO
    T front(){}

    // TODO
    T back(){}

    // TODO
    void insert(int index, T value) {}

    // TODO
    void erase(int index){}

    // TODO (Less Important)
    T valueFromNFromEnd(T n){}

    // TODO (Less Important)
    void reverse(){}

    // TODO (Less Important)
    void removeValue(T value){}

}



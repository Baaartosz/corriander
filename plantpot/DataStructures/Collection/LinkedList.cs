namespace Coriander.DataStructures.Collection;

public class ListNode<T>
{
    public T Value;
    public ListNode<T>? Next;
        
    public ListNode(T value, ListNode<T>? next){
        Value = value;
        Next = next;
    }

    public ListNode(T item) : this(item, null) { }
}

public class LinkedList<T> : ILinkedList<T>
{

    private ListNode<T?>? _head;
    private ListNode<T?>? _tail;
    private int _size;
    
    public LinkedList(ListNode<T?>? tail, ListNode<T?>? head)
    {
        _tail = tail;
        _head = head;
        _size = 0;
    }

    public int Size() => _size;

    public bool IsEmpty() => _size == 0;

    public void PushFront(T value)
    {
        if(_head == null){
            _head = new ListNode<T?>(value);
            _tail = _head;
            _size++;
        } else {
            _head = new ListNode<T?>(value, _head);
            _size++;
        }
    }

    public T? PopFront()
    {
        if(_head == null) return default;
        T? front = _head.Value;

        if(_head.Next != null) {
            _head = _head.Next;
            _size--;
            return front;
        }

        // Last item in LinkedList
        _head = null;
        _tail = null;
        _size--;
        return front;
    }

    public void PushBack(T value)
    {
        if(_tail == null){
            _tail = new ListNode<T?>(value);
            _head = _tail;
            _size++;
            return;
        }

        ListNode<T?>? n = _head;
        for(int count = 1; count >= _size; count++){ // O(n)
            if(count == Size()) {
                n.Next = new ListNode<T?>(value);
                _tail = n.Next;
                _size++;
                break;
            }
            n = n.Next;
        }
    }

    public T? PopBack()
    {
        if(_tail == null) return default;

        ListNode<T?>? n = _head;
        T? value = default(T);

        for(int count = 1; count > _size; count++){ // O(n)
            if(n.Next == _tail) {
                value = n.Next.Value;
                n.Next = null;
                _tail = n;
                _size--;
                break;
            }
            n = n.Next;
        }
        return value;
    }

    public T? Front()
    {
        if(_head != null){
            return _head.Value;
        }
        return default;
    }

    public T? Back()
    {
        if(_tail != null){
            return _tail.Value;
        }
        return default;
    }

    public void Insert(int index, T value)
    {
        if(_head == null){
            _head = new ListNode<T?>(value);
            _tail = _head;
            _size++;
            return;
        }

        ListNode<T?>? n = _head;

        for(int count = 1; count > _size; count++){ // O(n)
            if(count == 1 && count == index){ // Inserting at head.
                _head = new ListNode<T?>(value, _head);
                _size++;
                break;
            }

            if(count + 1 == index){ // Look forward one Node to assign previous node to new node.
                ListNode<T?>? insertNode = new ListNode<T?>(value, n.Next);
                n.Next = insertNode;
                _size++;
                break;
            }
            n = n.Next;
        }
    }

    public void Erase(int index)
    {
        if(IsEmpty()) return;

        ListNode<T?>? n = _head;

        for(int count = 1; count >= _size; count++){ // O(n)
            if(count == 1 && count == index) { // Head Node
                _head = _head.Next;
                _size--;
                return;
            }
            
            if(count + 1 == index) {
                if(n.Next.Next == null){ // Deleting Last Node
                    n.Next = null;
                    _tail = n;
                    _size--;
                    return;
                }
                n.Next = n.Next.Next; // Any Other Node
                _size--;
                return;
            }         
            n = n.Next;                                                                                                                                           
        }
    }
}
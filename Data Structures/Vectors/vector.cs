// Vector Class
// Initial Attempt Arrays using Indexing ( No Pointers / Pointer Math)
// -> Bartosz Perczynski 
class Vector{

    private int[] array;
    private int size, capacity;
    private int items = 0;

    Vector(int arraySize){
        capacity = arraySize;
        array = new int[capacity];
    }

    public int size() => items;
    public int capacity() => capacity;
    public bool is_empty(){
        return items == 0;
    }
    public int at(int index){
        return array[index];
    }

    public void push(int item){
        if(size() == capacity()) resize(capacity() * 2);
        at(size() + 1) = item;
        items++;
    }

    public void insert(int index, int item){ // Amortized O(n²), Normal O(n)
        if(size() + 1 == capacity()) resize(capacity() * 2); // Amortized Time O(n)
        var newValue = item;
        for(int p = index; p < capacity(); p++){ // O(n)
            tmp = at(p);
            at(p) = newValue;
            newValue = temp;
        }
        items++;
    }
    public void prepend(int item){
        insert(0,item); // insert() handles items++
    }
    public int pop(){
        var tmp = at[size()];
        at(size()) = null;
        items--;
        if(size() < (capacity()/4)){
            resize(capacity()/2); // O
        }
        return tmp;    }

    public void delete(int index){
        at(index) = null;
        items--;
        for(int p = index + 1; p < capacity(); p++){ // O(n)
            var tmp = at(p);
            at(p-1) = tmp;
            at(p) = null;
        }
    }
    public void remove(int item){
        int removed = 0;
        for(int i = 0; i < capacity(); i++){ // O(n)
            if(at(i) == item){
                at(i) = null; 
                removed++;  
            }
            else if(removed > 0){
                var tmp = at(i);
                at(i) = null;
                at(i - removed) = tmp;
            }
        }
    }
    
    public int find(int item){
        for(int i = 0; i < capacity(); i++){ // O(n)
            if(at(i) == item) return i;
        }
        return -1;
    }
    private void resize(int newCapacity){ // O(n)
        var tmp = array;
        array = new int[newCapacity];
        for (int i = 0; i < tmp.Length; i++)
        {
            at(i) = tmp[i];
        }
    }
}
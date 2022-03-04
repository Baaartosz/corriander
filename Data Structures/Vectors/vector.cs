// Vector Class
// Initial Attmpt Arrays using Indexing ( No Pointers / Pointer Math)
// -> Bartosz Perczynski 
class Vector{

    private int[] at; // [3,7,2,0]
    private int size, capacity;
    private int items = 0;

    Vector(int arraySize){
        capacity = arraySize;
        at = new int[capacity];
    }

    public int size() => items;
    public int capacity() => capacity;
    public bool is_empty(){
        return items == 0;
    }
    public int at(int index){
        return at[index];
    }

    public void push(int item){
        if(size() == capacity()) resize(capacity() * 2);
        at(size() + 1) = item;
        items++;
    }

    public void insert(int index, int item){ 
        if(size() + 1 == capacity()) resize(capacity() * 2); // Amortized Time O(n²)
        var newValue = item;
        for(int p = index; p < capacity(); p++){ // O(n)
            tmp = at(p);
            at(p) = newValue;
            newValue = temp;
        }
        items++;
    }
    public void prepend(int item){
        insert(0,item); // insert handles items++
    }
    public int pop(){
        var tmp = at[size()];
        at(size()) = null;
        items--;
        return tmp;
        // TODO - Resize array down if the size is 1/4 of capacity
    }

    public void delete(int index){
        at(index) = null;
        items--;
        for(int p = index + 1; p < capacity(); p++){ //O(n)
            var tmp = at(p);
            at(p-1) = tmp;
            at(p) = null;
        }
    }
    public void remove(int item){
        int itemsRemoved = 0;
        for(int i = 0; i < capacity(); i++){
            if(at(i) == item){
                at(i) = null; 
                itemsRemoved++;  
            }
            if( > 0){

            }
        }
    }
    
    public int find(int item){}
    private void resize(int newCapacity){}
}
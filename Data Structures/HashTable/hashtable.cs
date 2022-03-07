/*
My own implemention of HashTable.
> baaart.dev
*/

class HashTable {
    int items;
    int capacity = 4;
    int[] hashTable = new int[capacity];

    HashTable() {}
    HashTable(int size) {
        capacity = size;
        hashTable = new int[capacity];
    }

    int hashKey(int k, int m){ // - m is size of hash table
        return hash(k) % m;
    }
    
    void add(int key, int value) {// - if key already exists, update value
        hashTable[hashKey(key,capacity)] = value;
        items++;
    }

    bool exists(int key){
        return hashTable[hashKey(key,capacity)] != null;
    }

    int get(int key){
        return hashTable[hashKey(key,capacity)];
    }
    
    void remove(int key){
        hashTable[hashKey(key,capacity)] = null;
        items--;
    }
}
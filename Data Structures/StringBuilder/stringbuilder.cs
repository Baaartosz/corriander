/*
My own implemention of StringBuilder.
> baaart.dev
*/

class StringBuilder {   

    private int capacity = 16; // Char Capacity
    private int chars = 0;

    public int Size() => chars;
    public int Capacity() => capacity;

    char[] _string = new char[16];

    public void append(char[] text){
        if(size() + text.Length >= capacity){
            setCapacity(capacity * 2); // Amortized O(n)
        }
        for(int i = 0; i < text.Length; i++){
            _string[Size() + i] = text[i];
        }
        chars += text.Length;
    }

    public void setCharAt(int index, char c){
        _string[index] = c;
    }

    public void replace(int start, int end, char[] str){
        if(str.Length + Size() >= capacity){  
            setCapacity(capacity*2); // Amortized O(n)
        }
        for(int i = start; i <= Size()+(str.Length-capacity); i++){ // O(n)
            _string[i] = str[start - i];
        }
        chars += str.Length;
    }

    public void trimToSize(){
        char[] tmp = _string;
        _string = new char[Size()];
        for(int i = 0; i <= capacity; i++){ // O(n)
            _string[i] = tmp[i];
        }
    }

    public void setCapacity(){
        setCapacity(capacity * 2);
    }
    public void setCapacity(int size){
        var tmp = _string;
        _string = new char[size];
        for(int c = 0; c < tmp.Length; c++){ // O(n)
            _string[c] = tmp[c];
        }
    }

    public string getString(){
        string s = "";
        for (int i = 0; i < _string.Length; i++)
        {
            s += _string[i];
        }
        return s;
    }   

}
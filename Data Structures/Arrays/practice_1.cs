/*
IsUnique()

Implement an algorithim to determine if a string has all unique characters.

What if you cannot use addiontal data structures?

baaart.dev
*/ 

bool IsUnique(string s){ // First Attempt

    int[] counts = new int[26]; // Alphabet Size
    int offset = (int)'a'; // ASCII Offset Value

    s.ToLower(); // O(1)

    for(int c = 0; c < s.Length; c++) { // O(n)
        counts[(int)s[c] - offset]++;
        if(counts[(int)s[c] - offset] >= 2) return false; // More then one occurance not unique
    }
    return true;
}


bool IsUnique(string s){ // Changed Integer Array to Boolean Array
    if(s.Length > 128) return false; // Exit out of string is longer the all unique chars together.

    bool[] chars = new bool[128];

    for(int c = 0; c < s.Length; c++){ // O(n)
        int value = (int)s[c];

        if(chars[value]) return false;
        chars[value] = true;
    }
    return true;
}
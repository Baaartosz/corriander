/*
URLify

Write a method to replace all spaces in a string with '%20'.

You may assume that the string has sufficent space at the end to hold the additional characters,
and that you are given the 'true' length of the string.

EXAMPLE

Input:  "Mr John Smith    ", 13
Output: "Mr%20John%20Smith"

baaart.dev
*


/*
    First Attempt
    Brute Force
*/
char[] URLify(char[] s, int len){
    /* Not the best way knowing we can assume the array has sufficent
     * space at the end to hold the additional characters */
    char[] n = new char[len * 2]; 
    int offset = 0;
    for (int i = 0; i < len; i++) // O(n)
    {
        if(s[i] != ' ') n[i + offset] = s[i];
        if(s[i] == ' '){
            n[i + offset] = "%";
            n[i + offset + 1] = "2";
            n[i + offset + 2] = "0";
            offset += 2;
        }
    }
    return n;
}

/*
    Second Attmpt

    Utilises empty space in array.
*/
char[] URLify(char[] s, int len){
    int spaces = count(s,0,len,(int)' '); // O(n)

     // (len - 1) for correct array size && 2 extra spaces for each space.
    int newLength = (len - 1) + spaces * 2;

    int offset = spaces * 2;
    int newIndex = 0;

    for (int i = newLength; i >= 0 ; i--) // O(n)
    {
        if(s[i - offset] != (int)' '){
            s[i - newIndex] = s[i - offset];
        }
        if(s[i - offset] == (int)' '){
            s[i - newIndex] = '0';
            s[i - newIndex - 1] = '2';
            s[i - newIndex - 2] = '%';
            newIndex += 2;
        }
    }

    return s;
}

int count(char[] s, int start, int end, int target){
    int c = 0;
    for (int i = start; i < end; i++) // O(n)
        if(s[i] == target)
            c++;
    return c;
}
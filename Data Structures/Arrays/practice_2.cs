/*

Check Permutation

Given two strings, Write a method to decide if one is a permutation of the other.

baaart.dev
*/

int CheckPermutation(string s1, string s2){ // Brute Force Attempt

    int permutations = 0;
    bool previousCheck = false;

    for(int i = 0; i < s2.Length; i++){
        for(int j = 0; j < s1.Length; j++){ // O(n²)
            if(previousCheck && s2[i] == s1[j]){ // Found next char in order.
                permutations++;
                previousCheck = false;
            }
            if(s2[i] == s1[j]){ // Matching char
                previousCheck = true;
                break;
            }
            if(s2[i] != s1[j] && previousCheck) previousCheck = false; // Reset permutation check as no char that matches s1.
        }
    }
    return permutations;
}

bool CheckPermutation(string s1, string s2){ // Brute Force Attempt modifed to boolean

    int permutations = 0;
    bool previousCheck = false;

    for(int i = 0; i < s2.Length; i++){
        for(int j = 0; j < s1.Length; j++){ // O(n²)
            if(previousCheck && s2[i] == s1[j]){ // Found next char in order.
                permutations++;
                previousCheck = false;
            }
            if(s2[i] == s1[j]){ // Matching char
                previousCheck = true;
                break;
            }
            if(s2[i] != s1[j] && previousCheck) previousCheck = false; // Reset permutation check as no char that matches s1.
        }
    }
    return permutations > 0;
}

bool CheckPermutation(string s, string t){ // O(s+t)
    if(s.Length != t.Length) return false; // Permutations have to be the same length;

    int[] letters = new int[128];

    for (int i = 0; i < s.Length; i++)
    {
        letters[(int)s[i]]++;
    }

    for (int i = 0; i < t.Length; i++)
    {
        letters[(int)t[i]]--;
        if(letters[(int)t[i]] < 0) return false;
    }

    return true;
}
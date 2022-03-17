int sumLists(ListNode a,ListNode b){
    int sum;
    int n = 1;
    while( a != null || b != null){
        x = a.value;
        y = b.value;

        if(x != null) x = x * n;
        else x = 0;

        if(y != null) y = y * n;
        else y = 0;

        sum += x + y;
        n *= 10;
        a = a.next;
        b = b.next;
    }
    return sum;
}
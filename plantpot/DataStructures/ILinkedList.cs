namespace Coriander.DataStructures;

/// <summary>
/// A singly linked with a head and tail.
/// </summary>
/// <typeparam name="T">Type which you wish to store.</typeparam>
public interface ILinkedList<T>
{
    public int Size(); /*Returns */
    public bool IsEmpty(); /* Returns if the LinkedList is empty.*/
     
    public void PushFront(T value); /*  Adds an item to the front of the list. */
    public T? PopFront(); /* Remove front item and return its value  */
    
    public void PushBack(T value); /* Adds an item at the end  */
    public T? PopBack(); /* Removes End item and returns its value */

    public T? Front(); /* Gets value of front item */
    public T? Back(); /* Get value of back item */

    public void Insert(int index, T value); /* Inserts value at index, So current item at index is now pointed to by new item */
    public void Erase(int index); /* Removes node at given index */
    
    /* TODO - Additional Extra functions to be programmed.
    public T ValueAt(int index);
    public T ValueFromNFromEnd(T nValue);
    public void Reverse();
    public void RemoveValue(T value);
    */

}
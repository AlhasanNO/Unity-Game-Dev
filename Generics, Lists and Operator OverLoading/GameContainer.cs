public class GameContainer<T>
{
    T item;

    public void SetItem(T item)
    {
        this.item = item;
    }

    public T GetItem()
    {
        return item;
    }
}
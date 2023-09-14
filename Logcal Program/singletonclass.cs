public sealed class Mysingle
{
    private Mysingle() { }
    private static Mysingle instance;
    public static object locker = new Object();

    public static Mysingle Getinstance()
    {

        if (instance == null)
        {
            lock (locker)
            {
                if (instance == null)
                {
                    instance = new Mysingle();
                }
            }
        }

        return instance;
    }


}
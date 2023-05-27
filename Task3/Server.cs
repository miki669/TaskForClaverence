namespace TaskForClaverence.Task3;

public class Server
{
    private static int _count = 0;
    private static readonly object LockObject = new object();
    private static int _writersCount = 0;

    public static int GetCount()
    {
        lock (LockObject)
        {
            return _count;
        }
    }
    public static void AddToCount(int value)
    {
        bool isWriter = false;
        lock (LockObject)
        {
            if (_writersCount == 0)
            {
                _writersCount++;
                isWriter = true;
            }
        }
        if (isWriter)
        {
            _count += value;
            lock (LockObject)
            {
                _writersCount--;
                Monitor.PulseAll(LockObject); // Уведомляем ожидающих читателей.
            }
        }
        else
        {
            lock (LockObject)
            {
                while (_writersCount > 0)
                {
                    Monitor.Wait(LockObject); // Ожидание окончания записи.
                }
            }

            // Здесь выполняются операции чтения count.
            // Можно без блокировки, так как только писатель изменяет count.
        }
    }
}
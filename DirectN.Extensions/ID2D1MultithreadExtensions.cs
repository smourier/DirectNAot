namespace DirectN.Extensions;

[SupportedOSPlatform("windows8.0")]
public static class ID2D1MultithreadExtensions
{
    public static bool GetMultithreadProtected(this IComObject<ID2D1Multithread> mt) => GetMultithreadProtected(mt?.Object!);
    public static bool GetMultithreadProtected(this ID2D1Multithread mt)
    {
        ArgumentNullException.ThrowIfNull(mt);
        return mt.GetMultithreadProtected();
    }

    public static void Enter(this IComObject<ID2D1Multithread> mt) => Enter(mt?.Object!);
    public static void Enter(this ID2D1Multithread mt)
    {
        ArgumentNullException.ThrowIfNull(mt);
        mt.Enter();
    }

    public static void Leave(this IComObject<ID2D1Multithread> mt) => Leave(mt?.Object!);
    public static void Leave(this ID2D1Multithread mt)
    {
        ArgumentNullException.ThrowIfNull(mt);
        mt.Leave();
    }

    public static void RunMultithreadProtected(this IComObject<ID2D1Multithread> mt, Action action) => RunMultithreadProtected(mt?.Object!, action);
    public static void RunMultithreadProtected(this ID2D1Multithread mt, Action action)
    {
        ArgumentNullException.ThrowIfNull(mt);
        ArgumentNullException.ThrowIfNull(action);
        mt.Enter();
        try
        {
            action();
        }
        finally
        {
            mt.Leave();
        }
    }

    public static Task RunMultithreadProtected(this IComObject<ID2D1Multithread> mt, Func<Task> action) => RunMultithreadProtected(mt?.Object!, action);
    public static async Task RunMultithreadProtected(this ID2D1Multithread mt, Func<Task> action)
    {
        ArgumentNullException.ThrowIfNull(mt);
        ArgumentNullException.ThrowIfNull(action);
        mt.Enter();
        try
        {
            await action();
        }
        finally
        {
            mt.Leave();
        }
    }

    public static T RunMultithreadProtected<T>(this IComObject<ID2D1Multithread> mt, Func<T> func) => RunMultithreadProtected(mt?.Object!, func);
    public static T RunMultithreadProtected<T>(this ID2D1Multithread mt, Func<T> func)
    {
        ArgumentNullException.ThrowIfNull(mt);
        ArgumentNullException.ThrowIfNull(func);
        mt.Enter();
        try
        {
            return func();
        }
        finally
        {
            mt.Leave();
        }
    }

    public static Task<T> RunMultithreadProtected<T>(this IComObject<ID2D1Multithread> mt, Func<Task<T>> func) => RunMultithreadProtected(mt?.Object!, func);
    public static async Task<T> RunMultithreadProtected<T>(this ID2D1Multithread mt, Func<Task<T>> func)
    {
        ArgumentNullException.ThrowIfNull(mt);
        ArgumentNullException.ThrowIfNull(func);
        mt.Enter();
        try
        {
            return await func();
        }
        finally
        {
            mt.Leave();
        }
    }
}

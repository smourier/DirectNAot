namespace DirectNAot.Extensions.Com;

public static class ComExtensions
{
    public static void FinalRelease(this object? comObject)
    {
        if (comObject == null)
            return;

        // note: only works on unique instance objects
        ((System.Runtime.InteropServices.Marshalling.ComObject)comObject).FinalRelease();
    }

    public static void SafeDispose(this IComObject? comObject)
    {
        if (comObject == null || comObject.IsDisposed)
            return;

        comObject.Dispose();
    }
}

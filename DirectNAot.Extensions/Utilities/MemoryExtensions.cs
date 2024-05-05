namespace DirectNAot.Extensions.Utilities;

public static class MemoryExtensions
{
    public static unsafe nint ToPointer<T>(this T instance) where T : struct => (nint)Unsafe.AsPointer(ref instance);
    public static unsafe nint ToPointerByRef<T>(this ref T instance) where T : struct => (nint)Unsafe.AsPointer(ref instance);
}

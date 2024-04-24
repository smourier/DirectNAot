namespace DirectNAot.Extensions.Utilities
{
    public static class MemoryExtensions
    {
        public static unsafe IntPtr ToPointer<T>(this T instance) where T : struct => (IntPtr)Unsafe.AsPointer(ref instance);
        public static unsafe IntPtr ToPointerByRef<T>(this ref T instance) where T : struct => (IntPtr)Unsafe.AsPointer(ref instance);
    }
}

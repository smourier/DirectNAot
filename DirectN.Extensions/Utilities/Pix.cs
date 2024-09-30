namespace DirectN.Extensions.Utilities
{
    public static partial class Pix
    {
        public const string DllName = "WinPixEventRuntime";

        public static void PIXEndEvent(IComObject<ID3D12GraphicsCommandList> commandList) => PIXEndEvent(commandList?.Object!);
        public static void PIXEndEvent(IComObject<ID3D12CommandQueue> commandQueue) => PIXEndEvent(commandQueue?.Object!);
        public static void PIXBeginEvent(IComObject<ID3D12GraphicsCommandList> commandList, ulong color, string formatString) => PIXBeginEvent(commandList?.Object!, color, formatString);
        public static void PIXBeginEvent(IComObject<ID3D12CommandQueue> commandQueue, ulong color, string formatString) => PIXBeginEvent(commandQueue?.Object!, color, formatString);
        public static void PIXSetMarker(IComObject<ID3D12GraphicsCommandList> commandList, ulong color, string formatString) => PIXSetMarker(commandList?.Object!, color, formatString);
        public static void PIXSetMarker(IComObject<ID3D12CommandQueue> commandQueue, ulong color, string formatString) => PIXSetMarker(commandQueue?.Object!, color, formatString);

        [LibraryImport(DllName, StringMarshalling = StringMarshalling.Utf8, EntryPoint = "PIXEndEventOnCommandList")]
        public static partial void PIXEndEvent(ID3D12GraphicsCommandList commandList);

        [LibraryImport(DllName, StringMarshalling = StringMarshalling.Utf8, EntryPoint = "PIXEndEventOnCommandQueue")]
        public static partial void PIXEndEvent(ID3D12CommandQueue commandQueue);

        [LibraryImport(DllName, StringMarshalling = StringMarshalling.Utf8, EntryPoint = "PIXBeginEventOnCommandList")]
        public static partial void PIXBeginEvent(ID3D12GraphicsCommandList commandList, ulong color, string formatString);

        [LibraryImport(DllName, StringMarshalling = StringMarshalling.Utf8, EntryPoint = "PIXBeginEventOnCommandQueue")]
        public static partial void PIXBeginEvent(ID3D12CommandQueue commandQueue, ulong color, string formatString);

        [LibraryImport(DllName, StringMarshalling = StringMarshalling.Utf8, EntryPoint = "PIXSetMarkerOnCommandList")]
        public static partial void PIXSetMarker(ID3D12GraphicsCommandList commandList, ulong color, string formatString);

        [LibraryImport(DllName, StringMarshalling = StringMarshalling.Utf8, EntryPoint = "PIXSetMarkerOnCommandQueue")]
        public static partial void PIXSetMarker(ID3D12CommandQueue commandQueue, ulong color, string formatString);

        public static void WithPixEvent(this IComObject<ID3D12GraphicsCommandList> list, Action action, ulong color = 0, string? formatString = null, [CallerMemberName] string? methodName = null)
        {
            ArgumentNullException.ThrowIfNull(action);
            PIXBeginEvent(list, color, formatString, methodName);
            try
            {
                action();
            }
            finally
            {
                PIXEndEvent(list);
            }
        }

        public static T WithPixEvent<T>(this IComObject<ID3D12GraphicsCommandList> list, Func<T> func, ulong color = 0, string? formatString = null, [CallerMemberName] string? methodName = null)
        {
            ArgumentNullException.ThrowIfNull(func);
            PIXBeginEvent(list, color, formatString, methodName);
            try
            {
                return func();
            }
            finally
            {
                PIXEndEvent(list);
            }
        }

        public static void PIXBeginEvent(this IComObject<ID3D12GraphicsCommandList> list, ulong color = 0, string? formatString = null, [CallerMemberName] string? methodName = null)
        {
            ArgumentNullException.ThrowIfNull(list);
            if (methodName != null)
            {
                if (formatString != null)
                {
                    formatString = methodName + ": " + formatString;
                }
                else
                {
                    formatString = methodName;
                }
            }
            PIXBeginEvent(list, color, formatString ?? string.Empty);
        }

        public static void WithPixEvent(this IComObject<ID3D12CommandQueue> queue, Action action, ulong color = 0, string? formatString = null, [CallerMemberName] string? methodName = null)
        {
            ArgumentNullException.ThrowIfNull(action);
            PIXBeginEvent(queue, color, formatString, methodName);
            try
            {
                action();
            }
            finally
            {
                PIXEndEvent(queue);
            }
        }

        public static T WithPixEvent<T>(this IComObject<ID3D12CommandQueue> queue, Func<T> func, ulong color = 0, string? formatString = null, [CallerMemberName] string? methodName = null)
        {
            ArgumentNullException.ThrowIfNull(func);
            PIXBeginEvent(queue, color, formatString, methodName);
            try
            {
                return func();
            }
            finally
            {
                PIXEndEvent(queue);
            }
        }

        public static void PIXBeginEvent(this IComObject<ID3D12CommandQueue> queue, ulong color = 0, string? formatString = null, [CallerMemberName] string? methodName = null)
        {
            ArgumentNullException.ThrowIfNull(queue);
            if (methodName != null)
            {
                if (formatString != null)
                {
                    formatString = methodName + ": " + formatString;
                }
                else
                {
                    formatString = methodName;
                }
            }
            PIXBeginEvent(queue, color, formatString ?? string.Empty);
        }
    }
}

namespace DirectN.Extensions.Utilities;

public static partial class Pix
{
    public const string DllName = "WinPixEventRuntime";

    // PIX import methods start with "PIX"
    // utilities methods start with "Pix"
    [LibraryImport(DllName)]
    public static partial nint PIXGetThreadInfo();

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

    public static bool IsEnabled { get; set; }

    private static readonly Lazy<bool> _isAvailable = new(GetIsAvailable);
    public static bool IsAvailable => _isAvailable.Value;
    private static bool GetIsAvailable()
    {
        if (!IsEnabled)
            return false;

        try
        {
            _ = PIXGetThreadInfo();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public static void PixEndEvent(this IComObject<ID3D12GraphicsCommandList> commandList)
    {
        if (!IsEnabled || !IsAvailable)
            return;

        PIXEndEvent(commandList?.Object!);
    }

    public static void PixEndEvent(this IComObject<ID3D12CommandQueue> commandQueue)
    {
        if (!IsEnabled || !IsAvailable)
            return;

        PIXEndEvent(commandQueue?.Object!);
    }

    public static void PixBeginEvent(IComObject<ID3D12GraphicsCommandList> commandList, ulong color, string formatString)
    {
        if (!IsEnabled || !IsAvailable)
            return;

        PIXBeginEvent(commandList?.Object!, color, formatString);
    }

    public static void PixBeginEvent(IComObject<ID3D12CommandQueue> commandQueue, ulong color, string formatString)
    {
        if (!IsEnabled || !IsAvailable)
            return;

        PIXBeginEvent(commandQueue?.Object!, color, formatString);
    }

    public static void PixSetMarker(IComObject<ID3D12GraphicsCommandList> commandList, ulong color, string formatString)
    {
        if (!IsEnabled || !IsAvailable)
            return;

        PIXSetMarker(commandList?.Object!, color, formatString);
    }

    public static void PixSetMarker(IComObject<ID3D12CommandQueue> commandQueue, ulong color, string formatString)
    {
        if (!IsEnabled || !IsAvailable)
            return;

        PIXSetMarker(commandQueue?.Object!, color, formatString);
    }

    public static void WithPixEvent(this IComObject<ID3D12GraphicsCommandList> list, Action action, ulong color = 0, string? formatString = null, [CallerMemberName] string? methodName = null)
    {
        ArgumentNullException.ThrowIfNull(action);
        PixBeginEvent(list, color, formatString, methodName);
        try
        {
            action();
        }
        finally
        {
            PixEndEvent(list);
        }
    }

    public static T WithPixEvent<T>(this IComObject<ID3D12GraphicsCommandList> list, Func<T> func, ulong color = 0, string? formatString = null, [CallerMemberName] string? methodName = null)
    {
        ArgumentNullException.ThrowIfNull(func);
        PixBeginEvent(list, color, formatString, methodName);
        try
        {
            return func();
        }
        finally
        {
            PixEndEvent(list);
        }
    }

    public static void PixBeginEvent(this IComObject<ID3D12GraphicsCommandList> list, ulong color = 0, string? formatString = null, [CallerMemberName] string? methodName = null)
    {
        ArgumentNullException.ThrowIfNull(list);
        if (!IsEnabled || !IsAvailable)
            return;

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
        PIXBeginEvent(list.Object, color, formatString ?? string.Empty);
    }

    public static void WithPixEvent(this IComObject<ID3D12CommandQueue> queue, Action action, ulong color = 0, string? formatString = null, [CallerMemberName] string? methodName = null)
    {
        ArgumentNullException.ThrowIfNull(action);
        PixBeginEvent(queue, color, formatString, methodName);
        try
        {
            action();
        }
        finally
        {
            PixEndEvent(queue);
        }
    }

    public static T WithPixEvent<T>(this IComObject<ID3D12CommandQueue> queue, Func<T> func, ulong color = 0, string? formatString = null, [CallerMemberName] string? methodName = null)
    {
        ArgumentNullException.ThrowIfNull(func);
        PixBeginEvent(queue, color, formatString, methodName);
        try
        {
            return func();
        }
        finally
        {
            PixEndEvent(queue);
        }
    }

    public static void PixBeginEvent(this IComObject<ID3D12CommandQueue> queue, ulong color = 0, string? formatString = null, [CallerMemberName] string? methodName = null)
    {
        ArgumentNullException.ThrowIfNull(queue);
        if (!IsEnabled || !IsAvailable)
            return;

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
        PIXBeginEvent(queue.Object, color, formatString ?? string.Empty);
    }
}

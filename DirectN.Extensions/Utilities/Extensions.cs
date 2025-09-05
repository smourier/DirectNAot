using System.Security.Cryptography;

namespace DirectN.Extensions.Utilities;

public static class Extensions
{
    public static bool EqualsIgnoreCase(this string? thisString, string? text, bool trim = true)
    {
        if (trim)
        {
            thisString = thisString.Nullify();
            text = text.Nullify();
        }

        if (thisString == null)
            return text == null;

        if (text == null)
            return false;

        if (thisString.Length != text.Length)
            return false;

        return string.Compare(thisString, text, StringComparison.OrdinalIgnoreCase) == 0;
    }

    public static string? Nullify(this string? text)
    {
        if (text == null)
            return null;

        if (string.IsNullOrWhiteSpace(text))
            return null;

        var t = text.Trim();
        return t.Length == 0 ? null : t;
    }

    public static int AddRange<T>(this ICollection<T>? collection, IEnumerable<T>? enumerable)
    {
        if (collection == null || enumerable == null)
            return 0;

        var i = 0;
        foreach (var item in enumerable)
        {
            collection.Add(item);
            i++;
        }
        return i;
    }

    public static HRESULT ThrowOnPInvokeError(this BOOL ret, bool throwOnError = true, [CallerMemberName] string? methodName = null)
    {
        if (ret)
            return Constants.S_OK;

        var gle = Marshal.GetLastPInvokeError();
        if (gle == 0)
            return Constants.S_OK;

        var hr = HRESULT.FromWin32(gle);
        return hr.ThrowOnError(throwOnError, methodName);
    }

    public static int IndexOf<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
        ArgumentNullException.ThrowIfNull(predicate);
        if (source == null)
            return -1;

        var index = 0;
        foreach (var item in source)
        {
            if (predicate(item))
                return index;

            index++;
        }
        return -1;
    }

    public static byte[] LoadFromResource(this Assembly assembly, string name)
    {
        ArgumentNullException.ThrowIfNull(assembly);
        ArgumentNullException.ThrowIfNull(name);
        using var stream = assembly.GetManifestResourceStream(name);
        if (stream == null)
            throw new DirectNException($"0006: Stream '{name}' was not found in assembly {assembly.FullName}.");

        using var ms = new MemoryStream();
        stream.CopyTo(ms);
        return ms.ToArray();
    }

    public static void CopyFromWithPad<T>(this Span<T?> array, T[]? source, int length)
    {
        for (var i = 0; i < length; i++)
        {
            if (source != null && i < source.Length)
            {
                array[i] = source[i];
            }
            else
            {
                array[i] = default;
            }
        }
    }

    public static void CopyFrom(this nint destination, nint source, int length) => Functions.CopyMemory(destination, source, length);
    public static void CopyFrom(this nint destination, nint source, long length) => Functions.CopyMemory(destination, source, (nint)length);
    public static void CopyFrom(this nint destination, nint source, uint length) => Functions.CopyMemory(destination, source, (nint)length);
    public static void CopyFrom(this nint destination, nint source, nint length) => Functions.CopyMemory(destination, source, length);
    public static void CopyFrom(this nint destination, nint source, ulong length) => Functions.CopyMemory(destination, source, (nint)length);
    public static void CopyFrom(this nint destination, nint source, nuint length) => Functions.CopyMemory(destination, source, (nint)length);
    public static unsafe void CopyFrom<T>(this T structure, nint source) where T : unmanaged => Unsafe.CopyBlock(Unsafe.AsPointer(ref structure), (void*)source, (uint)sizeof(T));

    public static void Zero(this nint destination, int length) => Functions.ZeroMemory(destination, length);
    public static void Zero(this nint destination, long length) => Functions.ZeroMemory(destination, (nint)length);
    public static void Zero(this nint destination, uint length) => Functions.ZeroMemory(destination, (nint)length);
    public static void Zero(this nint destination, nint length) => Functions.ZeroMemory(destination, length);
    public static void Zero(this nint destination, ulong length) => Functions.ZeroMemory(destination, (nint)length);
    public static void Zero(this nint destination, nuint length) => Functions.ZeroMemory(destination, (nint)length);

    public static void CopyTo(this nint source, nint destination, int length) => Functions.CopyMemory(destination, source, length);
    public static void CopyTo(this nint source, nint destination, long length) => Functions.CopyMemory(destination, source, (nint)length);
    public static void CopyTo(this nint source, nint destination, uint length) => Functions.CopyMemory(destination, source, (nint)length);
    public static void CopyTo(this nint source, nint destination, nint length) => Functions.CopyMemory(destination, source, length);
    public static void CopyTo(this nint source, nint destination, ulong length) => Functions.CopyMemory(destination, source, (nint)length);
    public static void CopyTo(this nint source, nint destination, nuint length) => Functions.CopyMemory(destination, source, (nint)length);
    public static unsafe void CopyTo<T>(this T structure, nint destination) where T : unmanaged => Unsafe.CopyBlock((void*)destination, Unsafe.AsPointer(ref structure), (uint)sizeof(T));

    public static unsafe nint CopyToPointer<T>(this T? structure) where T : unmanaged
    {
        if (structure == null)
            return 0;

        return (nint)Unsafe.AsPointer(ref (new T[] { structure.Value })[0]);
    }

    public static unsafe uint Length<T>(this IReadOnlyCollection<T>? array)
    {
        if (array == null)
            return 0;

        return (uint)array.Count;
    }

    public static unsafe nint AsPointer<T>(this T[]? array) where T : unmanaged
    {
        if (array == null)
            return 0;

        return (nint)Unsafe.AsPointer(ref MemoryMarshal.GetArrayDataReference(array));
    }

    public static unsafe void CopyTo<T>(this T[] array, nint destination) where T : unmanaged
    {
        ArgumentNullException.ThrowIfNull(array);
        if (array.Length == 0)
            return;

        var source = Unsafe.AsPointer(ref MemoryMarshal.GetArrayDataReference(array));
        var size = (uint)(sizeof(T) * array.Length);
        Unsafe.CopyBlock((void*)destination, source, size);
    }

    public static byte[] IntPtrToBytes(this nint ptr)
    {
        if (nint.Size == 4)
            return BitConverter.GetBytes(ptr.ToInt32());

        return BitConverter.GetBytes(ptr.ToInt64());
    }

    // we don't want unspecified datetimes
    public static bool IsValid(this DateTime dt) => dt != DateTime.MinValue && dt != DateTime.MaxValue && dt.Kind != DateTimeKind.Unspecified;
    public static bool IsValid(this DateTime? dt) => dt.HasValue && IsValid(dt.Value);

    public static Guid ComputeGuidHash(this string? text)
    {
        if (text == null)
            return Guid.Empty;

        return new Guid(MD5.HashData(Encoding.UTF8.GetBytes(text)));
    }

    [return: NotNullIfNotNull(nameof(exception))]
    public static string? GetAllMessages(this Exception? exception) => GetAllMessages(exception, Environment.NewLine);

    [return: NotNullIfNotNull(nameof(exception))]
    public static string? GetAllMessages(this Exception? exception, string separator)
    {
        if (exception == null)
            return null;

        var sb = new StringBuilder();
        AppendMessages(sb, exception, separator);
        return sb.ToString().Replace("..", ".");
    }

    private static void AppendMessages(StringBuilder sb, Exception? e, string separator)
    {
        if (e == null)
            return;

        // this one is not interesting...
        if (e is not TargetInvocationException)
        {
            if (sb.Length > 0)
            {
                sb.Append(separator);
            }
            sb.Append(e.Message);
        }
        AppendMessages(sb, e.InnerException, separator);
    }

    public static string? GetInterestingExceptionMessage(this Exception? exception) => GetInterestingException(exception)?.Message;
    public static Exception? GetInterestingException(this Exception? exception)
    {
        if (exception is TargetInvocationException tie && tie.InnerException != null)
            return GetInterestingException(tie.InnerException);

        return exception;
    }

    public static DateTimeOffset ToDateTimeOffset(this FILETIME fileTime)
    {
        var ft = (((long)fileTime.dwHighDateTime) << 32) + fileTime.dwLowDateTime;
        return DateTimeOffset.FromFileTime(ft);
    }

    public static long CopyTo(this Stream input, Stream output, long count = long.MaxValue, int bufferSize = 0x14000)
    {
        ArgumentNullException.ThrowIfNull(input);
        ArgumentNullException.ThrowIfNull(output);
        if (count <= 0)
            throw new ArgumentException(null, nameof(count));

        if (bufferSize <= 0)
            throw new ArgumentException(null, nameof(bufferSize));

        if (count < bufferSize)
        {
            bufferSize = (int)count;
        }

        var bytes = new byte[bufferSize];
        var total = 0;
        do
        {
            var max = (int)Math.Min(count - total, bytes.Length);
            var read = input.Read(bytes, 0, max);
            if (read == 0)
                break;

            output.Write(bytes, 0, read);
            total += read;
            if (total == count)
                break;
        }
        while (true);
        return total;
    }

    public static void SafeDispose(this IDisposable? disposable)
    {
        if (disposable == null)
            return;

        try
        {
            disposable.Dispose();
        }
        catch
        {
            // continue;
        }
    }

    public static void Dispose(this IEnumerable? disposables, bool throwOnError = false)
    {
        if (disposables == null)
            return;

        if (throwOnError)
        {
            foreach (var disposable in disposables.OfType<IDisposable>())
            {
                disposable?.Dispose();
            }
        }
        else
        {
            foreach (var disposable in disposables.OfType<IDisposable>())
            {
                try
                {
                    disposable?.Dispose();
                }
                catch
                {
                    // continue
                }
            }
        }
    }

    public static void WithDispose(this IEnumerable? disposables, Action action, bool throwOnError = false)
    {
        ArgumentNullException.ThrowIfNull(action);
        if (disposables == null)
        {
            action();
            return;
        }

        try
        {
            action();
        }
        finally
        {
            if (throwOnError)
            {
                foreach (var disposable in disposables.OfType<IDisposable>())
                {
                    disposable?.Dispose();
                }
            }
            else
            {
                foreach (var disposable in disposables.OfType<IDisposable>())
                {
                    try
                    {
                        disposable?.Dispose();
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
        }
    }

    public static T WithDispose<T>(this IEnumerable? disposables, Func<T> func, bool throwOnError = false)
    {
        ArgumentNullException.ThrowIfNull(func);
        if (disposables == null)
            return func();

        try
        {
            return func();
        }
        finally
        {
            if (throwOnError)
            {
                foreach (var disposable in disposables.OfType<IDisposable>())
                {
                    disposable?.Dispose();
                }
            }
            else
            {
                foreach (var disposable in disposables.OfType<IDisposable>())
                {
                    try
                    {
                        disposable?.Dispose();
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
        }
    }

    public static void WithDispose(this IDisposable? disposable, Action action, bool throwOnError = false)
    {
        ArgumentNullException.ThrowIfNull(action);
        if (disposable == null)
        {
            action();
            return;
        }

        try
        {
            action();
        }
        finally
        {
            if (throwOnError)
            {
                disposable.Dispose();
            }
            else
            {
                try
                {
                    disposable.Dispose();
                }
                catch
                {
                    // continue
                }
            }
        }
    }

    public static T WithDispose<T>(this IDisposable? disposable, Func<T> func, bool throwOnError = false)
    {
        ArgumentNullException.ThrowIfNull(func);
        if (disposable == null)
            return func();

        try
        {
            return func();
        }
        finally
        {
            if (throwOnError)
            {
                disposable.Dispose();
            }
            else
            {
                try
                {
                    disposable.Dispose();
                }
                catch
                {
                    // continue
                }
            }
        }
    }

    public static StorageMedium? GetStorageMedium(this IComObject<IDataObject>? dataObject, in FORMATETC format) => GetStorageMedium(dataObject?.Object, format);
    public static StorageMedium? GetStorageMedium(this IDataObject? dataObject, in FORMATETC format)
    {
        if (dataObject == null)
            return null;

        var hr = dataObject.GetData(format, out var medium);
        if (hr.IsError)
            return null;

        return new StorageMedium(medium);
    }

    [return: NotNullIfNotNull(nameof(buffer))]
    public static System.IO.UnmanagedMemoryStream? GetUnmanagedMemoryStream(this SafeBuffer? buffer)
    {
        if (buffer == null)
            return null;

        return new System.IO.UnmanagedMemoryStream(buffer, 0, (long)buffer.ByteLength);
    }

    public static unsafe Span<byte> GetSpan(this SafeBuffer buffer)
    {
        ArgumentNullException.ThrowIfNull(buffer);
        return new((void*)buffer.DangerousGetHandle(), (int)buffer.ByteLength);
    }

    public static unsafe Span<byte> GetSpan(this SafeBuffer buffer, int length)
    {
        ArgumentNullException.ThrowIfNull(buffer);
        return new((void*)buffer.DangerousGetHandle(), Math.Min(length, (int)buffer.ByteLength));
    }

    [return: NotNullIfNotNull(nameof(stream))]
    public static byte[]? ToByteArray(this Stream? stream)
    {
        if (stream == null)
            return null;

        if (stream is MemoryStream m)
            return m.ToArray();

        using var ms = new MemoryStream();
        stream.CopyTo(ms);
        return ms.ToArray();
    }

    [return: NotNullIfNotNull(nameof(stream))]
    public static MemoryStream? ToMemoryStream(this Stream? stream, bool resetPositionToZero = true)
    {
        if (stream == null)
            return null;

        if (stream is not MemoryStream ms)
        {
            ms = new MemoryStream();
            stream.CopyTo(ms);
        }

        if (resetPositionToZero)
        {
            ms.Position = 0;
        }
        return ms;
    }

    [return: NotNullIfNotNull(nameof(buffer))]
    public static unsafe byte[]? ToByteArray(this SafeBuffer buffer)
    {
        if (buffer == null)
            return null;

        var size = (uint)buffer.ByteLength;
        if (size == 0)
            return [];

        var bytes = new byte[size];
        fixed (byte* p = bytes)
        {
            ((nint)p).CopyFrom(buffer.DangerousGetHandle(), size);
            return bytes;
        }
    }

    public static bool DataEqualsTo(this SafeBuffer? buffer, SafeBuffer? other)
    {
        if (buffer is null)
            return other is null;

        if (other is null)
            return false;

        if (buffer.ByteLength != other.ByteLength)
            return false;

        var pointer = buffer.DangerousGetHandle();
        var otherPointer = other.DangerousGetHandle();
        if (pointer == otherPointer)
            return true;

        if (pointer == 0 || otherPointer == 0)
            return false;

        var span = buffer.GetSpan();
        var otherSpan = other.GetSpan();
        return span.SequenceCompareTo(otherSpan) == 0;
    }


    private static readonly ConcurrentDictionary<string, string> _loadedStrings = new(StringComparer.OrdinalIgnoreCase);

    public static string LoadString(string libPath, uint id, int lcid = -1)
    {
        ArgumentNullException.ThrowIfNull(libPath);
        if (lcid == -1) // default => current UI culture
        {
            lcid = Thread.CurrentThread.CurrentUICulture.LCID;
        }

        var key = lcid + "!" + id + "!" + libPath;
        if (_loadedStrings.TryGetValue(key, out var str))
            return str;

        var h = Functions.LoadLibraryExW(PWSTR.From(libPath), HANDLE.Null, LOAD_LIBRARY_FLAGS.LOAD_LIBRARY_AS_IMAGE_RESOURCE);
        if (h.Value == 0)
            return key;

        var oldLcid = Functions.GetThreadUILanguage();
        Functions.SetThreadUILanguage((ushort)lcid);

        var ret = Functions.LoadStringW(new HINSTANCE { Value = h.Value }, id, out var ptr, 0);
        Functions.SetThreadUILanguage(oldLcid);
        if (ret == 0)
            return key;

        // each string starts with its size (a bit like a bstr)
        var len = Marshal.ReadInt16(ptr.Value, -2);
        str = len > 0 ? Marshal.PtrToStringUni(ptr.Value, len) : key;
        _loadedStrings[key] = str;
        Functions.FreeLibrary(h);
        return str;
    }

    public static PropertyDescription? ToDescription(this PROPERTYKEY pk) => PropertyDescription.FromPropertyKey(pk);

    public static string? GetCanonicalName(this PROPERTYKEY pk) => PropertyDescription.FromPropertyKey(pk)?.CanonicalName;

    public static object? ChangeType(this VARENUM vt, object? value)
    {
        object? changed;
        switch (vt)
        {
            case VARENUM.VT_UI1:
                changed = Conversions.ChangeType<byte>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_UI2:
                changed = Conversions.ChangeType<ushort>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_UI4:
                changed = Conversions.ChangeType<uint>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_UI8:
                changed = Conversions.ChangeType<ulong>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_I1:
                changed = Conversions.ChangeType<sbyte>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_I2:
                changed = Conversions.ChangeType<short>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_I4:
                changed = Conversions.ChangeType<int>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_I8:
                changed = Conversions.ChangeType<long>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_BOOL:
                changed = Conversions.ChangeType<bool>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_R4:
                changed = Conversions.ChangeType<float>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_R8:
                changed = Conversions.ChangeType<double>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_LPSTR:
            case VARENUM.VT_LPWSTR:
            case VARENUM.VT_BSTR:
                changed = Conversions.ChangeType<string>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_DECIMAL:
                changed = Conversions.ChangeType<decimal>(value, provider: CultureInfo.InvariantCulture);
                break;

            case VARENUM.VT_DATE:
                changed = Conversions.ChangeType<DateTime>(value, provider: CultureInfo.InvariantCulture).ToOADate();
                break;

            case VARENUM.VT_FILETIME:
                changed = Conversions.ChangeType<DateTime>(value, provider: CultureInfo.InvariantCulture).ToFileTime();
                break;

            case VARENUM.VT_CLSID:
                changed = Conversions.ChangeType<Guid>(value, provider: CultureInfo.InvariantCulture);
                break;

            default:
                throw new NotSupportedException();
        }
        return changed;
    }

    public static D2D_SIZE_F GetScaleFactor(this D2D_SIZE_U size, uint? width = null, uint? height = null, ScaleOptions options = ScaleOptions.Default) => new D2D_SIZE_F(size.width, size.height).GetScaleFactor(width, height, options);
    public static D2D_SIZE_F GetScaleFactor(this D2D_SIZE_U size, int? width = null, int? height = null, ScaleOptions options = ScaleOptions.Default) => new D2D_SIZE_F(size.width, size.height).GetScaleFactor(width, height, options);
    public static D2D_SIZE_F GetScaleFactor(this D2D_SIZE_F size, int? width = null, int? height = null, ScaleOptions options = ScaleOptions.Default)
    {
        float? fw = width.HasValue ? width : null;
        float? fh = height.HasValue ? height : null;
        return GetScaleFactor(size, fw, fh, options);
    }

    public static D2D_SIZE_F GetScaleFactor(this SIZE size, int? width = null, int? height = null, ScaleOptions options = ScaleOptions.Default)
    {
        float? fw = width.HasValue ? width : null;
        float? fh = height.HasValue ? height : null;
        return GetScaleFactor(size, fw, fh, options);
    }

    public static D2D_SIZE_F GetScaleFactor(this D2D_SIZE_F size, uint? width = null, uint? height = null, ScaleOptions options = ScaleOptions.Default)
    {
        float? fw = width.HasValue ? width : null;
        float? fh = height.HasValue ? height : null;
        return GetScaleFactor(size, fw, fh, options);
    }

    public static D2D_SIZE_F GetScaleFactor(this D2D_SIZE_F size, float? width = null, float? height = null, ScaleOptions options = ScaleOptions.Default)
    {
        if (width.HasValue && width.Value <= 0)
            throw new ArgumentOutOfRangeException(nameof(width));

        if (height.HasValue && height.Value <= 0)
            throw new ArgumentOutOfRangeException(nameof(height));

        if (size.width == 0 || size.height == 0 || (!width.HasValue && !height.HasValue))
            return new D2D_SIZE_F(1, 1);

        var scaleW = size.width == 0 ? 0 : (width ?? float.PositiveInfinity) / size.width;
        var scaleH = size.height == 0 ? 0 : (height ?? float.PositiveInfinity) / size.height;
        if (!width.HasValue)
        {
            scaleW = scaleH;
        }
        else if (!height.HasValue)
        {
            scaleH = scaleW;
        }
        else if (options.HasFlag(ScaleOptions.Uniform))
        {
            var minscale = scaleW < scaleH ? scaleW : scaleH;
            scaleW = scaleH = minscale;
        }
        else if (options.HasFlag(ScaleOptions.UniformToFill))
        {
            var maxscale = scaleW > scaleH ? scaleW : scaleH;
            scaleW = scaleH = maxscale;
        }

        if (options.HasFlag(ScaleOptions.UpOnly))
        {
            if (scaleW < 1)
            {
                scaleW = 1;
            }

            if (scaleH < 1)
            {
                scaleH = 1;
            }
        }

        if (options.HasFlag(ScaleOptions.DownOnly))
        {
            if (scaleW > 1)
            {
                scaleW = 1;
            }

            if (scaleH > 1)
            {
                scaleH = 1;
            }
        }
        return new D2D_SIZE_F(scaleW, scaleH);
    }

}

namespace DirectN;

[SupportedOSPlatform("windows6.0.6000")]
public static class IMFAttributesExtensions
{
    public static string Trace(this IComObject<IMFAttributes>? input, string? separator = null) => Trace(input?.Object, separator);
    public static string Trace(this IMFAttributes? input, string? separator = null)
    {
        if (input == null)
            return "<null>";

        separator ??= " | ";
        return string.Join(separator, Enumerate(input).Select(kv => kv.Key + "=" + TraceValue(input, kv.Key)));
    }

    public static string TraceValue(this IComObject<IMFAttributes> input, Guid key) => TraceValue(input?.Object!, key);
    public static string TraceValue(this IMFAttributes input, Guid key)
    {
        ArgumentNullException.ThrowIfNull(input);
        var value = GetValue(input, key);
        if (value == null)
            return "<null>";

        if (value is byte[] bytes)
            return Conversions.ToHexa(bytes, 64);

        if (value is string s)
            return "`" + s + "`";

        return string.Format(CultureInfo.InvariantCulture, "{0}", value);
    }

    [SupportedOSPlatform("windows6.1")]
    public static IEnumerable<IComObject<IMFActivate>> EnumDeviceSources(this IComObject<IMFAttributes> input) => EnumDeviceSources(input?.Object!);

    [SupportedOSPlatform("windows6.1")]
    public static IEnumerable<IComObject<IMFActivate>> EnumDeviceSources(this IMFAttributes input)
    {
        ArgumentNullException.ThrowIfNull(input);
        Functions.MFEnumDeviceSources(input, out var array, out var count).ThrowOnError();
        try
        {
            for (var i = 0; i < count; i++)
            {
                var ptr = Marshal.ReadIntPtr(array, i * nint.Size);
                var activate = ComObject.FromPointer<IMFActivate>(ptr);
                if (activate != null)
                    yield return activate;
            }
        }
        finally
        {
            Marshal.FreeCoTaskMem(array);
        }
    }

    public static void DeleteAllItems(this IComObject<IMFAttributes> input) => DeleteAllItems(input?.Object!);
    public static void DeleteAllItems(this IMFAttributes input)
    {
        ArgumentNullException.ThrowIfNull(input);
        input.DeleteAllItems().ThrowOnError();
    }

    public static void DeleteItem(this IComObject<IMFAttributes> input, Guid key) => DeleteItem(input?.Object!, key);
    public static void DeleteItem(this IMFAttributes input, Guid key)
    {
        ArgumentNullException.ThrowIfNull(input);
        input.DeleteItem(key).ThrowOnError();
    }

    public static void LockStore(this IComObject<IMFAttributes> input) => LockStore(input?.Object!);
    public static void LockStore(this IMFAttributes input)
    {
        ArgumentNullException.ThrowIfNull(input);
        input.LockStore().ThrowOnError();
    }

    public static void UnlockStore(this IComObject<IMFAttributes> input) => UnlockStore(input?.Object!);
    public static void UnlockStore(this IMFAttributes input)
    {
        ArgumentNullException.ThrowIfNull(input);
        input.UnlockStore().ThrowOnError();
    }

    public static void TryGetItemByIndex(this IComObject<IMFAttributes> input, uint index, out Guid key, out object? value) => TryGetItemByIndex(input?.Object!, index, out key, out value);
    public static bool TryGetItemByIndex(this IMFAttributes input, uint index, out Guid key, out object? value)
    {
        ArgumentNullException.ThrowIfNull(input);
        unsafe
        {
            var detached = new PROPVARIANT();
            if (input.GetItemByIndex(index, out key, (nint)(&detached)).IsError)
            {
                value = null;
                return false;
            }

            using var pv = PropVariant.Attach(ref detached);
            value = pv.Value;
            return true;
        }
    }

    public static void Set2UINT32asUINT64(this IComObject<IMFAttributes> input, Guid key, uint high, uint low) => Set2UINT32asUINT64(input?.Object!, key, high, low);
    public static void Set2UINT32asUINT64(this IMFAttributes input, Guid key, uint high, uint low)
    {
        ArgumentNullException.ThrowIfNull(input);
        MFSetAttribute2UINT32asUINT64(input, key, high, low).ThrowOnError();
    }

    public static void SetSize(this IComObject<IMFAttributes> input, Guid key, uint width, uint height) => SetSize(input?.Object!, key, width, height);
    public static void SetSize(this IMFAttributes input, Guid key, uint width, uint height)
    {
        ArgumentNullException.ThrowIfNull(input);
        MFSetAttribute2UINT32asUINT64(input, key, width, height).ThrowOnError();
    }

    public static void SetRatio(this IComObject<IMFAttributes> input, Guid key, uint numerator, uint denominator) => SetRatio(input?.Object!, key, numerator, denominator);
    public static void SetRatio(this IMFAttributes input, Guid key, uint numerator, uint denominator)
    {
        ArgumentNullException.ThrowIfNull(input);
        MFSetAttribute2UINT32asUINT64(input, key, numerator, denominator).ThrowOnError();
    }

    public static bool TryGet2UINT32asUINT64(this IComObject<IMFAttributes> input, Guid key, out uint high, out uint low) => TryGet2UINT32asUINT64(input?.Object!, key, out high, out low);
    public static bool TryGet2UINT32asUINT64(this IMFAttributes input, Guid key, out uint high, out uint low)
    {
        ArgumentNullException.ThrowIfNull(input);
        return MFGetAttribute2UINT32asUINT64(input, key, out high, out low).IsSuccess;
    }

    public static bool TryGetSize(this IComObject<IMFAttributes> input, Guid key, out uint width, out uint height) => TryGetSize(input?.Object!, key, out width, out height);
    public static bool TryGetSize(this IMFAttributes input, Guid key, out uint width, out uint height) => TryGet2UINT32asUINT64(input, key, out width, out height);

    public static bool TryGetRatio(this IComObject<IMFAttributes> input, Guid key, out uint numerator, out uint denominator) => TryGetRatio(input?.Object!, key, out numerator, out denominator);
    public static bool TryGetRatio(this IMFAttributes input, Guid key, out uint numerator, out uint denominator) => TryGet2UINT32asUINT64(input, key, out numerator, out denominator);

    public static ulong Pack2UINT32AsUINT64(uint high, uint low) => ((ulong)high << 32) | low;
    public static void Unpack2UINT32AsUINT64(ulong packed, out uint high, out uint low) { high = (uint)(packed >> 32); low = (uint)packed; }
    public static HRESULT MFSetAttribute2UINT32asUINT64(IMFAttributes attributes, Guid key, uint high, uint low) => attributes?.SetUINT64(key, Pack2UINT32AsUINT64(high, low)) ?? Constants.E_INVALIDARG;
    public static HRESULT MFGetAttribute2UINT32asUINT64(IMFAttributes attributes, Guid key, out uint high, out uint low)
    {
        ArgumentNullException.ThrowIfNull(attributes);
        var hr = attributes.GetUINT64(key, out var packed);
        if (hr.IsError)
        {
            high = 0;
            low = 0;
            return hr;
        }

        Unpack2UINT32AsUINT64(packed, out high, out low);
        return Constants.S_OK;
    }

    public static IEnumerable<KeyValuePair<Guid, MF_ATTRIBUTE_TYPE>> Enumerate(this IComObject<IMFAttributes> input) => Enumerate(input?.Object!);
    public static IEnumerable<KeyValuePair<Guid, MF_ATTRIBUTE_TYPE>> Enumerate(this IMFAttributes input)
    {
        if (input == null)
            yield break;

        for (uint i = 0; i < Count(input); i++)
        {
            input.GetItemByIndex(i, out Guid guid, 0).ThrowOnError();
            input.GetItemType(guid, out var type).ThrowOnError();
            yield return new KeyValuePair<Guid, MF_ATTRIBUTE_TYPE>(guid, type);
        }
    }

    public static KeyValuePair<Guid, object?>[] ToValues(this IComObject<IMFAttributes> input) => ToValues(input?.Object!);
    public static KeyValuePair<Guid, object?>[] ToValues(this IMFAttributes input)
    {
        ArgumentNullException.ThrowIfNull(input);
        return Enumerate(input).Select(kv => new KeyValuePair<Guid, object?>(kv.Key, GetValue(input, kv.Key))).ToArray();
    }

    public static uint Count(this IComObject<IMFAttributes> input) => Count(input?.Object!);
    public static uint Count(this IMFAttributes input)
    {
        ArgumentNullException.ThrowIfNull(input);
        input.GetCount(out var value).ThrowOnError();
        return value;
    }

    public static void Set(this IComObject<IMFAttributes> input, Guid key, nint value) => input?.Object!.SetUnknown(key, value).ThrowOnError();
    public static void Set(this IComObject<IMFAttributes> input, Guid key, double value) => input?.Object!.SetDouble(key, value).ThrowOnError();
    public static void Set(this IComObject<IMFAttributes> input, Guid key, Guid value) => input?.Object!.SetGUID(key, value).ThrowOnError();
    public static void Set(this IComObject<IMFAttributes> input, Guid key, long value) => input?.Object!.SetUINT64(key, (ulong)value).ThrowOnError();
    public static void Set(this IComObject<IMFAttributes> input, Guid key, ulong value) => input?.Object!.SetUINT64(key, value).ThrowOnError();
    public static void Set(this IComObject<IMFAttributes> input, Guid key, int value) => input?.Object!.SetUINT32(key, (uint)value).ThrowOnError();
    public static void Set(this IComObject<IMFAttributes> input, Guid key, uint value) => input?.Object!.SetUINT32(key, value).ThrowOnError();
    public static void Set(this IComObject<IMFAttributes> input, Guid key, bool value) => input?.Object!.SetUINT32(key, (uint)(value ? 1 : 0)).ThrowOnError();
    public static void Set(this IComObject<IMFAttributes> input, Guid key, Enum value) => input?.Object!.SetUINT32(key, (uint)Convert.ChangeType(value, typeof(uint), CultureInfo.InvariantCulture)).ThrowOnError();
    public static void Set(this IComObject<IMFAttributes> input, Guid key, string? value)
    {
        using var p = new Pwstr(value);
        input?.Object!.SetString(key, p).ThrowOnError();
    }

    public static T? Get<T>(this IComObject<IMFAttributes> input, Guid key, T? defaultValue = default, IFormatProvider? provider = null) => Get(input?.Object!, key, defaultValue, provider);
    public static T? Get<T>(this IMFAttributes input, Guid key, T? defaultValue = default, IFormatProvider? provider = null)
    {
        if (!TryGet(input, key, provider, out T? value))
            return defaultValue;

        return value;
    }

    public static bool TryGet<T>(this IComObject<IMFAttributes> input, Guid key, out T? value) => TryGet(input?.Object!, key, null, out value);
    public static bool TryGet<T>(this IComObject<IMFAttributes> input, Guid key, IFormatProvider? provider, out T? value) => TryGet(input?.Object!, key, provider, out value);
    public static bool TryGet<T>(this IMFAttributes input, Guid key, out T? value) => TryGet(input, key, null, out value);
    public static bool TryGet<T>(this IMFAttributes input, Guid key, IFormatProvider? provider, out T? value)
    {
        ArgumentNullException.ThrowIfNull(input);
        if (input.GetItemType(key, out var type).IsError)
        {
            value = default;
            return false;
        }

        T? item;
        switch (type)
        {
            case MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_BLOB:
                if (typeof(T) == typeof(byte[]))
                {
                    value = (T?)(object?)GetBlob(input, key);
                    return true;
                }

                var bytes = GetBlob(input, key);
                if (!Conversions.TryChangeType(bytes, provider, out item))
                {
                    value = default;
                    return false;
                }

                value = item;
                return true;

            case MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_DOUBLE:
                var dbl = GetDouble(input, key);
                if (!Conversions.TryChangeType(dbl, provider, out item))
                {
                    value = default;
                    return false;
                }

                value = item;
                return true;

            case MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_GUID:
                var guid = GetGuid(input, key);
                if (!Conversions.TryChangeType(guid, provider, out item))
                {
                    value = default;
                    return false;
                }

                value = item;
                return true;

            case MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_STRING:
                var s = GetString(input, key);
                if (!Conversions.TryChangeType(s, provider, out item))
                {
                    value = default;
                    return false;
                }

                value = item;
                return true;

            case MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_UINT32:
                var ui = GetUInt32(input, key);
                if (!Conversions.TryChangeType(ui, provider, out item))
                {
                    value = default;
                    return false;
                }

                value = item;
                return true;

            case MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_UINT64:
                var ul = GetUInt64(input, key);
                if (!Conversions.TryChangeType(ul, provider, out item))
                {
                    value = default;
                    return false;
                }

                value = item;
                return true;

            case MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_IUNKNOWN:
                var comType = ComObject.GetComObjectComType(typeof(T));
                if (comType == null)
                {
                    var unk1 = GetUnknown(input, key, typeof(T).GUID);
                    if (typeof(T) == typeof(nint))
                    {
                        value = (T)(object)unk1;
                        return true;
                    }

                    value = (T)ComObject.ComWrappers.GetOrCreateObjectForComInstance(unk1, CreateObjectFlags.UniqueInstance);
                    return true;
                }

                var unk = GetUnknown(input, key, comType.GUID);
                var co = ComObject.FromPointer<T>(unk);
                if (co == null)
                {
                    if (unk != 0)
                    {
                        Marshal.Release(unk);
                    }
                    value = default;
                    return false;
                }

                value = (T)co;
                return true;

            default:
                throw new NotSupportedException();
        }
    }

    public static object? GetValue(this IComObject<IMFAttributes> input, Guid key) => GetValue(input?.Object!, key);
    public static object? GetValue(this IMFAttributes input, Guid key)
    {
        ArgumentNullException.ThrowIfNull(input);
        unsafe
        {
            var detached = new PROPVARIANT();
            if (input.GetItem(key, (nint)(&detached)).IsError)
                return null;

            using var pv = PropVariant.Attach(ref detached);
            return pv.Value;
        }
    }

    public static Guid GetGuid(this IComObject<IMFAttributes> input, Guid key) => GetGuid(input?.Object!, key, Guid.Empty);
    public static Guid GetGuid(this IComObject<IMFAttributes> input, Guid key, Guid defaultValue) => GetGuid(input?.Object!, key, defaultValue);
    public static Guid GetGuid(this IMFAttributes input, Guid key) => GetGuid(input, key, Guid.Empty);
    public static Guid GetGuid(this IMFAttributes input, Guid key, Guid defaultValue)
    {
        ArgumentNullException.ThrowIfNull(input);
        if (input.GetGUID(key, out var value).IsError)
            return defaultValue;

        return value;
    }

    public static double GetDouble(this IComObject<IMFAttributes> input, Guid key, double defaultValue = 0) => GetDouble(input?.Object!, key, defaultValue);
    public static double GetDouble(this IMFAttributes input, Guid key, double defaultValue = 0)
    {
        ArgumentNullException.ThrowIfNull(input);
        if (input.GetDouble(key, out var value).IsError)
            return defaultValue;

        return value;
    }

    public static bool GetBoolean(this IComObject<IMFAttributes> input, Guid key, bool defaultValue = false) => GetBoolean(input?.Object!, key, defaultValue);
    public static bool GetBoolean(this IMFAttributes input, Guid key, bool defaultValue = false)
    {
        ArgumentNullException.ThrowIfNull(input);
        if (input.GetUINT32(key, out var value).IsError)
            return defaultValue;

        return value != 0;
    }

    public static int GetInt32(this IComObject<IMFAttributes> input, Guid key, int defaultValue = 0) => GetInt32(input?.Object!, key, defaultValue);
    public static int GetInt32(this IMFAttributes input, Guid key, int defaultValue = 0)
    {
        ArgumentNullException.ThrowIfNull(input);
        if (input.GetUINT32(key, out var value).IsError)
            return defaultValue;

        return (int)value;
    }

    public static uint GetUInt32(this IComObject<IMFAttributes> input, Guid key, uint defaultValue = 0) => GetUInt32(input?.Object!, key, defaultValue);
    public static uint GetUInt32(this IMFAttributes input, Guid key, uint defaultValue = 0)
    {
        ArgumentNullException.ThrowIfNull(input);
        if (input.GetUINT32(key, out var value).IsError)
            return defaultValue;

        return value;
    }

    public static ulong GetUInt64(this IComObject<IMFAttributes> input, Guid key, ulong defaultValue = 0) => GetUInt64(input?.Object!, key, defaultValue);
    public static ulong GetUInt64(this IMFAttributes input, Guid key, ulong defaultValue = 0)
    {
        ArgumentNullException.ThrowIfNull(input);
        if (input.GetUINT64(key, out var value).IsError)
            return defaultValue;

        return value;
    }

    public static long GetInt64(this IComObject<IMFAttributes> input, Guid key, long defaultValue = 0) => GetInt64(input?.Object!, key, defaultValue);
    public static long GetInt64(this IMFAttributes input, Guid key, long defaultValue = 0)
    {
        ArgumentNullException.ThrowIfNull(input);
        if (input.GetUINT64(key, out var value).IsError)
            return defaultValue;

        return (long)value;
    }

    public static nint GetUnknown(this IComObject<IMFAttributes> input, Guid key, Guid interfaceId) => GetUnknown(input?.Object!, key, interfaceId);
    public static nint GetUnknown(this IMFAttributes input, Guid key, Guid interfaceId)
    {
        ArgumentNullException.ThrowIfNull(input);
        _ = input.GetUnknown(key, interfaceId, out var value);
        return value;
    }

    public static IComObject<T>? GetComObject<T>(this IComObject<IMFAttributes> input, Guid key) => GetComObject<T>(input, key, typeof(T).GUID);
    public static IComObject<T>? GetComObject<T>(this IComObject<IMFAttributes> input, Guid key, Guid interfaceId) => GetComObject<T>(input?.Object!, key, interfaceId);
    public static IComObject<T>? GetComObject<T>(this IMFAttributes input, Guid key) => GetComObject<T>(input, key, typeof(T).GUID);
    public static IComObject<T>? GetComObject<T>(this IMFAttributes input, Guid key, Guid interfaceId)
    {
        ArgumentNullException.ThrowIfNull(input);
        if (input.GetUnknown(key, interfaceId, out var unk).IsError)
            return null;

        return ComObject.FromPointer<T>(unk);
    }

    public static byte[]? GetBlob(this IComObject<IMFAttributes> input, Guid key) => GetBlob(input, key);
    public static byte[]? GetBlob(this IMFAttributes input, Guid key)
    {
        ArgumentNullException.ThrowIfNull(input);
        if (input.GetBlobSize(key, out var size).IsError || size == 0)
            return null;

        var bytes = new byte[(int)size];
        input.GetBlob(key, bytes.AsPointer(), size, 0).ThrowOnError();
        return bytes;
    }

    public static string? GetString(this IComObject<IMFAttributes> input, Guid key, string? defaultValue = null) => GetString(input?.Object!, key, defaultValue);
    public static string? GetString(this IMFAttributes input, Guid key, string? defaultValue = null)
    {
        ArgumentNullException.ThrowIfNull(input);
        if (input.GetStringLength(key, out var length).IsError)
            return defaultValue;

        var p = new AllocPwstr((length + 1) * 2);
        input.GetString(key, p, p.SizeInChars, 0).ThrowOnError();
        return p.ToString();
    }
}

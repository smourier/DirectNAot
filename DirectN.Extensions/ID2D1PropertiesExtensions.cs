namespace DirectN;

[SupportedOSPlatform("windows8.0")]
public static class ID2D1PropertiesExtensions
{
    public static T? GetValue<T>(this IComObject<ID2D1Properties> properties, uint index, T? defaultValue = default)
    {
        ArgumentNullException.ThrowIfNull(properties);
        if (!TryGetValue(properties, index, out var value))
            return default;

        return Conversions.ChangeType(value, defaultValue);
    }

    public static T? GetValue<T>(this IComObject<ID2D1Properties> properties, string name, T? defaultValue = default)
    {
        ArgumentNullException.ThrowIfNull(properties);
        ArgumentNullException.ThrowIfNull(name);
        if (!TryGetValue(properties, name, out var value))
            return default;

        return Conversions.ChangeType(value, defaultValue);
    }

    public static bool TryGetValue(this IComObject<ID2D1Properties> properties, string name, out object? value) => TryGetValue(properties?.Object!, name, out value);
    public static bool TryGetValue(this ID2D1Properties properties, string name, out object? value)
    {
        ArgumentNullException.ThrowIfNull(properties);
        ArgumentNullException.ThrowIfNull(name);
        var index = properties.GetPropertyIndex(PWSTR.From(name));
        return TryGetValue(properties, index, out value);
    }

    public static bool TryGetValue(this IComObject<ID2D1Properties> properties, uint index, out object? value) => TryGetValue(properties?.Object!, index, out value);
    public static bool TryGetValue(this ID2D1Properties properties, uint index, out object? value)
    {
        ArgumentNullException.ThrowIfNull(properties);
        value = null;
        var size = properties.GetValueSize(index);
        var type = properties.GetType(index);
        var bytes = new byte[size];
        var hr = properties.GetValue(index, type, bytes.AsPointer(), size);
        if (hr.IsError)
            return false;

        if (type == D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_BLOB)
        {
            value = bytes;
            return true;
        }

        return TryGetValue(type, bytes.AsPointer(), size, out value);
    }

    private static unsafe bool TryGetValue(D2D1_PROPERTY_TYPE type, nint data, uint size, out object? value)
    {
        value = null;
        if (data == 0 || size == 0)
            return false;

        switch (type)
        {
            case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_BOOL:
                value = *(bool*)data;
                return true;

            case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_STRING:
                var str = Encoding.Unicode.GetString((byte*)data, (int)size);
                if (!string.IsNullOrEmpty(str))
                {
                    while (str[^1] == '0')
                    {
                        str = str[..^1];
                    }
                }

                value = str;
                return true;

            case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UINT32:
                value = *(uint*)data;
                return true;

            case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_INT32:
                value = *(int*)data;
                return true;

            case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_FLOAT:
                value = *(float*)data;
                return true;

            case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_VECTOR2:
                value = *(D2D_VECTOR_2F*)data;
                return true;

            case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_VECTOR3:
                value = *(D2D_VECTOR_3F*)data;
                return true;

            case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_VECTOR4:
                value = *(D2D_VECTOR_4F*)data;
                return true;

            case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_BLOB:
                throw new NotSupportedException();

            case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_ENUM:
                value = *(uint*)data;
                return true;

            case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_CLSID:
                value = *(Guid*)data;
                return true;

            case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_MATRIX_3X2:
                value = *(D2D_MATRIX_3X2_F*)data;
                return true;

            case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_MATRIX_4X3:
                value = *(D2D_MATRIX_4X3_F*)data;
                return true;

            case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_MATRIX_4X4:
                value = *(D2D_MATRIX_4X4_F*)data;
                return true;

            case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_MATRIX_5X4:
                value = *(D2D_MATRIX_5X4_F*)data;
                return true;

            case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_IUNKNOWN:
                if (data != 0)
                {
                    value = ComObject.ComWrappers.GetOrCreateObjectForComInstance(data, CreateObjectFlags.UniqueInstance);
                }
                return true;
        }
        return false;
    }

    public static IReadOnlyList<D2D1Property> GetProperties(this IComObject<ID2D1Properties> properties) => GetProperties(properties?.Object!);
    public static IReadOnlyList<D2D1Property> GetProperties(this ID2D1Properties properties)
    {
        if (properties == null)
            return [];

        var list = new List<D2D1Property>();
        for (uint i = 0; i < properties.GetPropertyCount(); i++)
        {
            var len = properties.GetPropertyNameLength(i);
            using var p = new AllocPwstr((len * 1) * 2);
            properties.GetPropertyName(i, p, p.SizeInChars).ThrowOnError();
            var property = new D2D1Property(properties.GetType(i))
            {
                Name = p.ToString()!
            };

            var size = properties.GetValueSize(i);
            if (size > 0)
            {
                var data = new byte[size];
                properties.GetValue(i, property.Type, data.AsPointer(), size).ThrowOnError();
                property.ValueBytes = data;
            }

            properties.GetSubProperties(i, out var sub);
            property.SubProperties = GetProperties(sub);
            list.Add(property);
        }

        var prop = GetProperty(properties, unchecked((uint)D2D1_PROPERTY.D2D1_PROPERTY_AUTHOR));
        if (prop != null)
        {
            list.Add(prop);
        }

        prop = GetProperty(properties, unchecked((uint)D2D1_PROPERTY.D2D1_PROPERTY_CATEGORY));
        if (prop != null)
        {
            list.Add(prop);
        }

        prop = GetProperty(properties, unchecked((uint)D2D1_PROPERTY.D2D1_PROPERTY_DESCRIPTION));
        if (prop != null)
        {
            list.Add(prop);
        }

        prop = GetProperty(properties, unchecked((uint)D2D1_PROPERTY.D2D1_PROPERTY_DISPLAYNAME));
        if (prop != null)
        {
            list.Add(prop);
        }

        prop = GetProperty(properties, unchecked((uint)D2D1_PROPERTY.D2D1_PROPERTY_CLSID));
        if (prop != null)
        {
            list.Add(prop);
        }

        prop = GetProperty(properties, unchecked((uint)D2D1_PROPERTY.D2D1_PROPERTY_INPUTS));
        if (prop != null)
        {
            list.Add(prop);
        }

        prop = GetProperty(properties, unchecked((uint)D2D1_PROPERTY.D2D1_PROPERTY_MIN_INPUTS));
        if (prop != null)
        {
            list.Add(prop);
        }

        prop = GetProperty(properties, unchecked((uint)D2D1_PROPERTY.D2D1_PROPERTY_MAX_INPUTS));
        if (prop != null)
        {
            list.Add(prop);
        }

        prop = GetProperty(properties, unchecked((uint)D2D1_PROPERTY.D2D1_PROPERTY_CACHED));
        if (prop != null)
        {
            list.Add(prop);
        }

        prop = GetProperty(properties, unchecked((uint)D2D1_PROPERTY.D2D1_PROPERTY_PRECISION));
        if (prop != null)
        {
            list.Add(prop);
        }
        return list;
    }

    public static bool TryGetProperty(this IComObject<ID2D1Properties> properties, string name, out object? value) => TryGetProperty(properties?.Object!, name, out value);
    public static bool TryGetProperty(this ID2D1Properties properties, string name, out object? value)
    {
        if (properties == null)
        {
            value = null;
            return false;
        }

        ArgumentNullException.ThrowIfNull(name);
        var index = properties.GetPropertyIndex(PWSTR.From(name));
        if (index == uint.MaxValue)
        {
            value = null;
            return false;
        }
        return TryGetProperty(properties, index, out value);
    }

    public static bool TryGetProperty(this IComObject<ID2D1Properties> properties, uint index, out object? value) => TryGetProperty(properties?.Object!, index, out value);
    public static bool TryGetProperty(this ID2D1Properties properties, uint index, out object? value)
    {
        if (properties == null)
        {
            value = null;
            return false;
        }

        var size = properties.GetValueSize(index);
        if (size == 0)
        {
            value = null;
            return false;
        }

        var data = new byte[size];
        if (properties.GetValue(index, D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UNKNOWN, data.AsPointer(), data.Length()).IsError)
        {
            value = null;
            return false;
        }

        var type = properties.GetType(index);
        value = D2D1Property.GetValue(type, data);
        return true;
    }

    //public static D2D1Property GetProperty(this IComObject<ID2D1Effect> effect, uint index) => GetProperty(effect?.Object!, index);
    public static D2D1Property? GetProperty(this IComObject<ID2D1Properties> properties, uint index) => GetProperty(properties?.Object!, index);
    public static D2D1Property? GetProperty(this ID2D1Properties properties, uint index)
    {
        if (properties == null)
            return null;

        var prop = new D2D1Property(properties.GetType(index));
        var len = properties.GetPropertyNameLength(index);
        if (len > 0)
        {
            using var p = new AllocPwstr((len + 1) * 2);
            properties.GetPropertyName(index, p, p.SizeInChars);
            prop.Name = p.ToString() ?? string.Empty;
        }

        var size = properties.GetValueSize(index);
        if (size > 0)
        {
            var data = new byte[size];
            if (properties.GetValue(index, D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UNKNOWN, data.AsPointer(), data.Length()).IsSuccess)
            {
                prop.ValueBytes = data;
            }
        }

        if (prop.Type == D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UNKNOWN && prop.Name == null)
            return null;

        return prop;
    }

    public static void SetValue(this ID2D1Properties properties, uint index, string value)
    {
        ArgumentNullException.ThrowIfNull(properties);
        var bytes = value != null ? Encoding.Unicode.GetBytes(value) : null;
        properties.SetValue(index, D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UNKNOWN, bytes.AsPointer(), bytes.Length()).ThrowOnError();
    }

    public static void SetValue(this IComObject<ID2D1Properties> properties, uint index, object value) => SetValue(properties?.Object!, index, value);
    public static void SetValue(this ID2D1Properties properties, uint index, object value)
    {
        ArgumentNullException.ThrowIfNull(properties);
        if (!TryGetData(value, out var type, out var data))
            throw new NotSupportedException();

        properties.SetValue(index, type, data.AsPointer(), data.Length()).ThrowOnError();
    }

    public static void SetValue(this IComObject<ID2D1Properties> properties, string name, object value) => SetValue(properties?.Object!, name, value);
    public static void SetValue(this ID2D1Properties properties, string name, object value)
    {
        ArgumentNullException.ThrowIfNull(properties);
        ArgumentNullException.ThrowIfNull(name);
        if (!TryGetData(value, out var type, out var data))
            throw new NotSupportedException();

        properties.SetValueByName(PWSTR.From(name), type, data.AsPointer(), data.Length()).ThrowOnError();
    }

    public static void SetValue(this IComObject<ID2D1Properties> properties, uint index, D2D1_PROPERTY_TYPE type, byte[] data) => SetValue(properties?.Object!, index, type, data);
    public static void SetValue(this ID2D1Properties properties, uint index, D2D1_PROPERTY_TYPE type, byte[] data)
    {
        ArgumentNullException.ThrowIfNull(properties);
        ArgumentNullException.ThrowIfNull(data);
        properties.SetValue(index, type, data.AsPointer(), data.Length()).ThrowOnError();
    }

    public static void SetValue(this IComObject<ID2D1Properties> properties, string name, D2D1_PROPERTY_TYPE type, byte[] data) => SetValue(properties?.Object!, name, type, data);
    public static void SetValue(this ID2D1Properties properties, string name, D2D1_PROPERTY_TYPE type, byte[] data)
    {
        ArgumentNullException.ThrowIfNull(properties);
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(data);
        properties.SetValueByName(PWSTR.From(name), type, data.AsPointer(), data.Length()).ThrowOnError();
    }

    public static void SetValue(this IComObject<ID2D1Properties> properties, string name, D2D1_PROPERTY_TYPE type, nint data, uint dataLength) => SetValue(properties?.Object!, name, type, data, dataLength);
    public static void SetValue(this ID2D1Properties properties, string name, D2D1_PROPERTY_TYPE type, nint data, uint dataLength)
    {
        ArgumentNullException.ThrowIfNull(properties);
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(data);
        properties.SetValueByName(PWSTR.From(name), type, data, dataLength).ThrowOnError();
    }

    public static bool TryGetData(object value, out D2D1_PROPERTY_TYPE type, [NotNullWhen(true)] out byte[]? data)
    {
        type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UNKNOWN;
        data = null;
        if (value == null)
            return false;

        var vt = value.GetType();
        if (vt.IsEnum && TryGetData(Convert.ToUInt32(value), out type, out data))
        {
            type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_ENUM;
            return true;
        }

        var tc = Type.GetTypeCode(vt);
        switch (tc)
        {
            case TypeCode.Boolean:
            case TypeCode.Int64:
            case TypeCode.UInt64:
            case TypeCode.Int16:
            case TypeCode.UInt16:
            case TypeCode.Byte:
            case TypeCode.SByte:
                type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_INT32;
                data = BitConverter.GetBytes(Convert.ToInt32(value));
                return true;

            case TypeCode.Int32:
                type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_INT32;
                data = BitConverter.GetBytes((int)value);
                return true;

            case TypeCode.UInt32:
                type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UINT32;
                data = BitConverter.GetBytes((uint)value);
                return true;

            case TypeCode.Single:
                type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_FLOAT;
                data = BitConverter.GetBytes((float)value);
                return true;

            case TypeCode.Double:
            case TypeCode.Decimal:
                type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_FLOAT;
                data = BitConverter.GetBytes(Convert.ToSingle(value));
                return true;

            case TypeCode.Char:
                type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_STRING;
                data = Encoding.Unicode.GetBytes(((char)value).ToString() + '\0');
                break;

            case TypeCode.String:
                type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_STRING;
                data = Encoding.Unicode.GetBytes(((string)value) + '\0');
                break;

            case TypeCode.Object:
                if (value is Guid guid)
                {
                    type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_CLSID;
                    data = guid.ToByteArray();
                    return true;
                }

                if (value is byte[] bytes)
                {
                    type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_BLOB;
                    data = bytes;
                    return true;
                }

                unsafe
                {
                    if (value is D2D_VECTOR_2F v2)
                    {
                        type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_VECTOR2;
                        data = new byte[sizeof(D2D_VECTOR_2F)];
                        Functions.CopyMemory(data.AsPointer(), (nint)(&v2), data.Length);
                        return true;
                    }

                    if (value is D2D_VECTOR_3F v3)
                    {
                        type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_VECTOR3;
                        data = new byte[sizeof(D2D_VECTOR_3F)];
                        Functions.CopyMemory(data.AsPointer(), (nint)(&v3), data.Length);
                        return true;
                    }

                    if (value is D2D_VECTOR_4F v4)
                    {
                        type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_VECTOR4;
                        data = new byte[sizeof(D2D_VECTOR_4F)];
                        Functions.CopyMemory(data.AsPointer(), (nint)(&v4), data.Length);
                        return true;
                    }

                    if (value is D2D_MATRIX_3X2_F m32)
                    {
                        type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_MATRIX_3X2;
                        data = new byte[sizeof(D2D_MATRIX_3X2_F)];
                        Functions.CopyMemory(data.AsPointer(), (nint)(&m32), data.Length);
                        return true;
                    }

                    if (value is D2D_MATRIX_4X3_F m43)
                    {
                        type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_MATRIX_4X3;
                        data = new byte[sizeof(D2D_MATRIX_4X3_F)];
                        Functions.CopyMemory(data.AsPointer(), (nint)(&m43), data.Length);
                        return true;
                    }

                    if (value is D2D_MATRIX_4X4_F m44)
                    {
                        type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_MATRIX_4X4;
                        data = new byte[sizeof(D2D_MATRIX_4X4_F)];
                        Functions.CopyMemory(data.AsPointer(), (nint)(&m44), data.Length);
                        return true;
                    }

                    if (value is D2D_MATRIX_5X4_F m54)
                    {
                        type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_MATRIX_5X4;
                        data = new byte[sizeof(D2D_MATRIX_5X4_F)];
                        Functions.CopyMemory(data.AsPointer(), (nint)(&m54), data.Length);
                        return true;
                    }
                }

                if (value is IComObject co && ComWrappers.TryGetComInstance(co.Object, out var unk1))
                {
                    type = typeof(ID2D1ColorContext).IsAssignableFrom(co.InterfaceType) ? D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_COLOR_CONTEXT : D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_IUNKNOWN;
                    data = unk1.IntPtrToBytes();
                    Marshal.Release(unk1);
                    return true;
                }

                if (ComWrappers.TryGetComInstance(value, out var unk2))
                {
                    type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_IUNKNOWN;
                    data = unk2.IntPtrToBytes();
                    Marshal.Release(unk2);
                    return true;
                }
                break;
        }
        return false;
    }

    public static void SetValue(this ID2D1Properties properties, int index, bool value) => SetValue(properties, index, value ? 1 : 0);
    public static void SetValue(this ID2D1Properties properties, int index, Guid value) => SetValue(properties, index, value.ToByteArray());
    public static void SetValue(this ID2D1Properties properties, int index, float value) => SetValue(properties, index, BitConverter.GetBytes(value));
    public static void SetValue(this ID2D1Properties properties, int index, uint value) => SetValue(properties, index, BitConverter.GetBytes(value));
    public static void SetValue(this ID2D1Properties properties, int index, int value) => SetValue(properties, index, BitConverter.GetBytes(value));
    public static void SetValue(this ID2D1Properties properties, int index, byte[] value, D2D1_PROPERTY_TYPE type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UNKNOWN)
    {
        ArgumentNullException.ThrowIfNull(properties);
        ArgumentNullException.ThrowIfNull(value);
        properties.SetValue((uint)index, type, value.AsPointer(), value.Length()).ThrowOnError();
    }

    public static void SetValueByName(this ID2D1Properties properties, string name, object? value)
    {
        ArgumentNullException.ThrowIfNull(properties);
        ArgumentNullException.ThrowIfNull(name);
        if (value is null)
        {
            SetValueByName(properties, name, null);
            return;
        }

        var type = value.GetType();
        if (type.IsEnum)
        {
            value = (int)value;
        }

        if (value is bool bv)
        {
            SetValueByName(properties, name, bv);
            return;
        }

        if (value is Guid gv)
        {
            SetValueByName(properties, name, gv);
            return;
        }

        if (value is float fv)
        {
            SetValueByName(properties, name, fv);
            return;
        }

        if (value is uint uiv)
        {
            SetValueByName(properties, name, uiv);
            return;
        }

        if (value is int iv)
        {
            SetValueByName(properties, name, iv);
            return;
        }

        if (value is byte[] byv)
        {
            SetValueByName(properties, name, byv);
            return;
        }

        if (value is string sv)
        {
            SetValueByName(properties, name, sv);
            return;
        }

        if (value is ValueType vt) // matrix & vector types
        {
            unsafe
            {
#pragma warning disable CA1421 // This method uses runtime marshalling even when the 'DisableRuntimeMarshallingAttribute' is applied
                var size = (uint)Marshal.SizeOf(vt);
#pragma warning restore CA1421 // This method uses runtime marshalling even when the 'DisableRuntimeMarshallingAttribute' is applied
                SetValueByName(properties, name, (nint)Unsafe.AsPointer(ref vt), size);
            }
            return;
        }
        throw new NotSupportedException("Value of type '" + value.GetType().FullName + "' is not supported.");
    }

    public static void SetValueByName(this ID2D1Properties properties, string name, string? value)
    {
        ArgumentNullException.ThrowIfNull(properties);
        ArgumentNullException.ThrowIfNull(name);
        var bytes = value != null ? Encoding.Unicode.GetBytes(value) : null;
        SetValueByName(properties, name, bytes);
    }

    public static void SetValueByName(this ID2D1Properties properties, string name, bool value) => SetValueByName(properties, name, value ? 1 : 0);
    public static void SetValueByName(this ID2D1Properties properties, string name, Guid value) => SetValueByName(properties, name, value.ToByteArray());
    public static void SetValueByName(this ID2D1Properties properties, string name, float value) => SetValueByName(properties, name, BitConverter.GetBytes(value));
    public static void SetValueByName(this ID2D1Properties properties, string name, uint value) => SetValueByName(properties, name, BitConverter.GetBytes(value));
    public static void SetValueByName(this ID2D1Properties properties, string name, int value) => SetValueByName(properties, name, BitConverter.GetBytes(value));
    public static void SetValueByName(this ID2D1Properties properties, string name, byte[]? value, D2D1_PROPERTY_TYPE type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UNKNOWN) => SetValueByName(properties, name, value.AsPointer(), value.Length(), type);
    public static void SetValueByName(this ID2D1Properties properties, string name, nint valuePointer, uint valueSize, D2D1_PROPERTY_TYPE type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UNKNOWN)
    {
        ArgumentNullException.ThrowIfNull(properties);
        ArgumentNullException.ThrowIfNull(name);
        properties.SetValueByName(PWSTR.From(name), type, valuePointer, valueSize).ThrowOnError();
    }
}

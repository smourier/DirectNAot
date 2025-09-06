namespace DirectN.Extensions.Utilities;

public sealed class PropVariant : IDisposable
{
    private PROPVARIANT _inner;

    public PROPVARIANT Detached => _inner;
    public ref PROPVARIANT RefDetached => ref _inner;

    public static int Size { get; } = GetSizeOf32();
    private static int GetSizeOf32() { unsafe { return sizeof(PROPVARIANT); } }

    public PropVariant()
    {
        // it's a VT_EMPTY
    }

    public PropVariant(object? value, VARENUM? type = null)
    {
        if (value == null)
        {
            _inner.Anonymous.Anonymous.vt = type ?? VARENUM.VT_NULL;
            return;
        }

        value = Unwrap(value);

        if (value is nint ptr)
        {
            _inner.Anonymous.Anonymous.Anonymous.punkVal = ptr;
            _inner.Anonymous.Anonymous.vt = type ?? (nint.Size == 4 ? VARENUM.VT_I4 : VARENUM.VT_I8);
            return;
        }

        if (value is nuint uptr)
        {
            _inner.Anonymous.Anonymous.Anonymous.punkVal = (nint)uptr;
            _inner.Anonymous.Anonymous.vt = type ?? (nint.Size == 4 ? VARENUM.VT_UI4 : VARENUM.VT_UI8);
            return;
        }

        if (value is System.Runtime.InteropServices.Marshalling.ComObject co)
        {
            var sw = ComObject.ComWrappers;
            _inner.Anonymous.Anonymous.Anonymous.punkVal = sw.GetOrCreateComInterfaceForObject(co, CreateComInterfaceFlags.None);
            _inner.Anonymous.Anonymous.vt = type ?? VARENUM.VT_UNKNOWN;
            return;
        }

        if (value is char[] chars)
        {
            value = new string(chars);
        }

        if (value is char[][] charray)
        {
            var strings = new string[charray.GetLength(0)];
            for (var i = 0; i < charray.Length; i++)
            {
                strings[i] = new string(charray[i]);
            }
            value = strings;
        }

        if (value is Array array)
        {
            ConstructArray(array, type);
            return;
        }

        if (value is not string && value is IEnumerable enumerable)
        {
            ConstructEnumerable(enumerable, type);
            return;
        }

        if (value == null)
        {
            _inner.Anonymous.Anonymous.vt = type ?? VARENUM.VT_NULL;
            return;
        }

        var valueType = value.GetType();
        var vt = FromType(valueType, type, false);
        var tc = Type.GetTypeCode(valueType);
        switch (tc)
        {
            case TypeCode.Boolean:
                _inner.Anonymous.Anonymous.Anonymous.boolVal = new VARIANT_BOOL { Value = (bool)value ? (short)-1 : (short)0 };
                vt = VARENUM.VT_BOOL;
                break;

            case TypeCode.Byte:
                _inner.Anonymous.Anonymous.Anonymous.bVal = (byte)value;
                vt = VARENUM.VT_UI1;
                break;

            case TypeCode.Char:
                chars = [(char)value];
                // note: all strings (PWSTR, PSTR, BSTR) point to same place
                _inner.Anonymous.Anonymous.Anonymous.pwszVal = new PWSTR { Value = MarshalString(new string(chars), VARENUM.VT_LPWSTR) };
                vt = VARENUM.VT_LPWSTR;
                break;

            case TypeCode.DateTime:
                if (type == VARENUM.VT_FILETIME)
                {
                    var ft = Conversions.ToPositiveFILETIME((DateTime)value);
                    Functions.InitPropVariantFromFileTime(ft, out _inner);
                    return;
                }

                var dt = (DateTime)value;
                _inner.Anonymous.Anonymous.Anonymous.dblVal = dt.ToOADate();
                vt = VARENUM.VT_DATE;
                break;

            case TypeCode.Empty:
            case TypeCode.DBNull:
                break;

            case TypeCode.Decimal:
                _inner.Anonymous.decVal = (decimal)value;
                vt = VARENUM.VT_DECIMAL;
                break;

            case TypeCode.Double:
                _inner.Anonymous.Anonymous.Anonymous.dblVal = (double)value;
                vt = VARENUM.VT_R8;
                break;

            case TypeCode.Int16:
                _inner.Anonymous.Anonymous.Anonymous.iVal = (short)value;
                vt = VARENUM.VT_I2;
                break;

            case TypeCode.Int32:
                _inner.Anonymous.Anonymous.Anonymous.lVal = (int)value;
                vt = VARENUM.VT_I4;
                break;

            case TypeCode.Int64:
                _inner.Anonymous.Anonymous.Anonymous.hVal = (long)value;
                vt = VARENUM.VT_I8;
                break;

            case TypeCode.SByte:
                _inner.Anonymous.Anonymous.Anonymous.cVal.Value = (sbyte)value;
                vt = VARENUM.VT_I1;
                break;

            case TypeCode.Single:
                _inner.Anonymous.Anonymous.Anonymous.fltVal = (float)value;
                vt = VARENUM.VT_R4;
                break;

            case TypeCode.String:
                // note: all strings (PWSTR, PSTR, BSTR) point to same place
                _inner.Anonymous.Anonymous.Anonymous.pwszVal = new PWSTR { Value = MarshalString((string)value, VARENUM.VT_LPWSTR) };
                vt = VARENUM.VT_LPWSTR;
                break;

            case TypeCode.UInt16:
                _inner.Anonymous.Anonymous.Anonymous.uiVal = (ushort)value;
                vt = VARENUM.VT_UI2;
                break;

            case TypeCode.UInt32:
                _inner.Anonymous.Anonymous.Anonymous.ulVal = (uint)value;
                vt = VARENUM.VT_UI4;
                break;

            case TypeCode.UInt64:
                _inner.Anonymous.Anonymous.Anonymous.uhVal = (ulong)value;
                vt = VARENUM.VT_UI8;
                break;

            //case TypeCode.Object:
            default:
                if (value is Guid guid)
                {
                    _inner.Anonymous.Anonymous.Anonymous.puuid = Marshal.AllocCoTaskMem(16);
                    Marshal.Copy(guid.ToByteArray(), 0, _inner.Anonymous.Anonymous.Anonymous.puuid, 16);
                    _inner.Anonymous.Anonymous.vt = VARENUM.VT_CLSID;
                    return;
                }

                if (value is DateTimeOffset dto)
                {
                    if (type == VARENUM.VT_FILETIME)
                    {
                        var ft = Conversions.ToPositiveFILETIME(dto.DateTime);
                        Functions.InitPropVariantFromFileTime(ft, out _inner);
                        return;
                    }

                    _inner.Anonymous.Anonymous.Anonymous.dblVal = dto.DateTime.ToOADate();
                    vt = VARENUM.VT_DATE;
                    break;
                }

                if (value is FILETIME filetime)
                {
                    _inner.Anonymous.Anonymous.Anonymous.filetime = filetime;
                    break;
                }
                throw new ArgumentException("Value of type '" + value.GetType().FullName + "' is not supported.", nameof(value));
        }

        _inner.Anonymous.Anonymous.vt = vt;
    }

    public VARENUM VarType { get => _inner.Anonymous.Anonymous.vt; }
    public object? Value
    {
        get
        {
            switch (_inner.Anonymous.Anonymous.vt)
            {
                case VARENUM.VT_EMPTY:
                case VARENUM.VT_NULL: // DbNull
                    return null;

                case VARENUM.VT_I1:
                    return _inner.Anonymous.Anonymous.Anonymous.cVal.Value;

                case VARENUM.VT_UI1:
                    return _inner.Anonymous.Anonymous.Anonymous.bVal;

                case VARENUM.VT_I2:
                    return _inner.Anonymous.Anonymous.Anonymous.iVal;

                case VARENUM.VT_UI2:
                    return _inner.Anonymous.Anonymous.Anonymous.uiVal;

                case VARENUM.VT_I4:
                case VARENUM.VT_INT:
                    return _inner.Anonymous.Anonymous.Anonymous.lVal;

                case VARENUM.VT_UI4:
                case VARENUM.VT_UINT:
                    return _inner.Anonymous.Anonymous.Anonymous.ulVal;

                case VARENUM.VT_I8:
                    return _inner.Anonymous.Anonymous.Anonymous.hVal;

                case VARENUM.VT_UI8:
                    return _inner.Anonymous.Anonymous.Anonymous.uhVal;

                case VARENUM.VT_R4:
                    return _inner.Anonymous.Anonymous.Anonymous.fltVal;

                case VARENUM.VT_R8:
                    return _inner.Anonymous.Anonymous.Anonymous.dblVal;

                case VARENUM.VT_BOOL:
                    return _inner.Anonymous.Anonymous.Anonymous.boolVal.Value != 0;

                case VARENUM.VT_ERROR:
                    return _inner.Anonymous.Anonymous.Anonymous.scode;

                case VARENUM.VT_CY:
                    return _inner.Anonymous.decVal;

                case VARENUM.VT_DATE:
                    return DateTime.FromOADate(_inner.Anonymous.Anonymous.Anonymous.dblVal);

                case VARENUM.VT_FILETIME:
                    return _inner.Anonymous.Anonymous.Anonymous.filetime.ToDateTime();

                case VARENUM.VT_BSTR:
                    return Marshal.PtrToStringBSTR(_inner.Anonymous.Anonymous.Anonymous.bstrVal.Value);

                case VARENUM.VT_BLOB:
                    var blob = new byte[_inner.Anonymous.Anonymous.Anonymous.blob.cbSize];
                    Marshal.Copy(_inner.Anonymous.Anonymous.Anonymous.blob.pBlobData, blob, 0, blob.Length);
                    return blob;

                case VARENUM.VT_CLSID:
                    var guid = new byte[16];
                    Marshal.Copy(_inner.Anonymous.Anonymous.Anonymous.puuid, guid, 0, guid.Length);
                    return new Guid(guid);

                case VARENUM.VT_LPSTR:
                    // all strings point to same place anyway
                    return Marshal.PtrToStringAnsi(_inner.Anonymous.Anonymous.Anonymous.bstrVal.Value);

                case VARENUM.VT_LPWSTR:
                    // all strings point to same place anyway
                    return Marshal.PtrToStringUni(_inner.Anonymous.Anonymous.Anonymous.bstrVal.Value);

                case VARENUM.VT_UNKNOWN:
                case VARENUM.VT_DISPATCH:
                    var sw = ComObject.ComWrappers;
                    return sw.GetOrCreateObjectForComInstance(_inner.Anonymous.Anonymous.Anonymous.punkVal, CreateObjectFlags.UniqueInstance);

                case VARENUM.VT_DECIMAL:
                    return _inner.Anonymous.decVal;

                default:
                    if (_inner.Anonymous.Anonymous.vt.HasFlag(VARENUM.VT_VECTOR))
                    {
                        var et = _inner.Anonymous.Anonymous.vt & ~VARENUM.VT_VECTOR;
                        if (TryGetVectorValue(et, out var vector))
                            return vector;
                    }

                    if (OperatingSystem.IsWindowsVersionAtLeast(6, 0, 6000))
                    {
                        Functions.PropVariantToVariant(_inner, out var inner).ThrowOnError();
                        using var v = new Variant(inner);
                        return v.Value;
                    }

                    throw new NotSupportedException("Value of property type " + _inner.Anonymous.Anonymous.vt + " is not supported.");
            }
        }
    }

    public nint Serialize(out uint size, bool throwOnError = true)
    {
        Functions.StgSerializePropVariant(_inner, out var ptr, out size).ThrowOnError(throwOnError);
        return ptr;
    }

    public byte[]? Serialize(bool throwOnError = true)
    {
        var hr = Functions.StgSerializePropVariant(_inner, out var ptr, out var size).ThrowOnError(throwOnError);
        if (hr.IsError)
            return null;

        var bytes = new byte[size];
        Marshal.Copy(ptr, bytes, 0, bytes.Length);
        Marshal.FreeCoTaskMem(ptr);
        return bytes;
    }

    public Variant? ToVariant(bool throwOnError = true)
    {
        var hr = Functions.PropVariantToVariant(_inner, out var inner).ThrowOnError(throwOnError);
        if (hr.IsError)
            return null;

        return new Variant(inner);
    }

    public unsafe PropVariant? ChangeType(VARENUM type, bool throwOnError = true)
    {
        if (type == (VARENUM.VT_VARIANT | VARENUM.VT_BYREF) || type == VARENUM.VT_VARIANT)
        {
            Functions.PropVariantCopy(out var inner, _inner).ThrowOnError(throwOnError);

            var copy = new PROPVARIANT();
            copy.Anonymous.Anonymous.vt = type;
            copy.Anonymous.Anonymous.Anonymous.pvarVal = Marshal.AllocCoTaskMem(Size);
            copy.Anonymous.Anonymous.Anonymous.pvarVal.CopyFrom((nint)(&inner), Size);
            return Attach(ref copy, false);
        }

        var hr = Functions.PropVariantChangeType(out var inner2, _inner, 0, type).ThrowOnError(throwOnError);
        if (hr.IsError)
            return null;

        return new PropVariant { _inner = inner2 };
    }

    public void CopyFrom(PropVariant source, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(source);
        if (source == this)
            return;

        Clear(throwOnError);
        Functions.PropVariantCopy(out var inner, source._inner).ThrowOnError(throwOnError);
        _inner = inner;
    }

    public PropVariant? Copy(bool throwOnError = true)
    {
        var hr = Functions.PropVariantCopy(out var inner, _inner).ThrowOnError(throwOnError);
        if (hr.IsError)
            return null;

        return new PropVariant { _inner = inner };
    }

    [SupportedOSPlatform("windows8.0")]
    public object? ToWinRTPropertyValue(bool throwOnError = true) => ToWinRTPropertyValue(Constants.IID_IPropertyValue, throwOnError);

    [SupportedOSPlatform("windows8.0")]
    public object? ToWinRTPropertyValue(Guid iid, bool throwOnError = true)
    {
        Functions.PropVariantToWinRTPropertyValue(_inner, iid, out var obj).ThrowOnError(throwOnError);
        return obj;
    }

    public PROPVARIANT Detach()
    {
        var pv = _inner;
        Zero();
        return pv;
    }

    public unsafe void DetachTo(nint propVariantPtr)
    {
        if (propVariantPtr == 0)
            throw new ArgumentException(null, nameof(propVariantPtr));

        var pv = _inner;
        Zero();
        *(PROPVARIANT*)propVariantPtr = pv;
    }

    public unsafe void DetachToByRef(nint propVariantPtr)
    {
        if (propVariantPtr == 0)
            throw new ArgumentException(null, nameof(propVariantPtr));

        var variant = (PROPVARIANT*)propVariantPtr;
        if (!variant->Anonymous.Anonymous.vt.HasFlag(VARENUM.VT_BYREF))
            throw new ArgumentException($"Target type is {variant->Anonymous.Anonymous.vt}, not a VT_BYREF variant.", nameof(propVariantPtr));

        var vt = variant->Anonymous.Anonymous.vt & ~VARENUM.VT_BYREF;
        if (vt != VarType && variant->Anonymous.Anonymous.vt != VarType)
            throw new ArgumentException($"Source type {VarType} and target type {variant->Anonymous.Anonymous.vt} are incompatible.", nameof(propVariantPtr));

        switch (vt)
        {
            case VARENUM.VT_EMPTY:
            case VARENUM.VT_NULL:
                break;

            case VARENUM.VT_I1:
                *(sbyte*)variant->Anonymous.Anonymous.Anonymous.pcVal.Value = _inner.Anonymous.Anonymous.Anonymous.cVal;
                break;

            case VARENUM.VT_I2:
                *(short*)variant->Anonymous.Anonymous.Anonymous.piVal = _inner.Anonymous.Anonymous.Anonymous.iVal;
                break;

            case VARENUM.VT_I4:
            case VARENUM.VT_INT:
                *(int*)variant->Anonymous.Anonymous.Anonymous.plVal = _inner.Anonymous.Anonymous.Anonymous.lVal;
                break;

            case VARENUM.VT_I8:
                *(long*)variant->Anonymous.Anonymous.Anonymous.plVal = _inner.Anonymous.Anonymous.Anonymous.hVal;
                break;

            case VARENUM.VT_UI1:
                *(byte*)variant->Anonymous.Anonymous.Anonymous.pbVal = _inner.Anonymous.Anonymous.Anonymous.bVal;
                break;

            case VARENUM.VT_UI2:
                *(ushort*)variant->Anonymous.Anonymous.Anonymous.puiVal = _inner.Anonymous.Anonymous.Anonymous.uiVal;
                break;

            case VARENUM.VT_UI4:
            case VARENUM.VT_UINT:
            case VARENUM.VT_ERROR:
                *(uint*)variant->Anonymous.Anonymous.Anonymous.pulVal = _inner.Anonymous.Anonymous.Anonymous.ulVal;
                break;

            case VARENUM.VT_UI8:
                *(ulong*)variant->Anonymous.Anonymous.Anonymous.pulVal = _inner.Anonymous.Anonymous.Anonymous.uhVal;
                break;

            case VARENUM.VT_R4:
                *(float*)variant->Anonymous.Anonymous.Anonymous.pfltVal = _inner.Anonymous.Anonymous.Anonymous.fltVal;
                break;

            case VARENUM.VT_R8:
            case VARENUM.VT_DATE:
                *(double*)variant->Anonymous.Anonymous.Anonymous.pdblVal = _inner.Anonymous.Anonymous.Anonymous.dblVal;
                break;

            case VARENUM.VT_BOOL:
                *(VARIANT_BOOL*)variant->Anonymous.Anonymous.Anonymous.pboolVal = _inner.Anonymous.Anonymous.Anonymous.boolVal;
                break;

            case VARENUM.VT_DECIMAL:
                *(decimal*)variant->Anonymous.Anonymous.Anonymous.pdecVal = _inner.Anonymous.decVal;
                break;

            case VARENUM.VT_CY:
                *(CY*)variant->Anonymous.Anonymous.Anonymous.pcyVal = _inner.Anonymous.Anonymous.Anonymous.cyVal;
                break;

            case VARENUM.VT_BSTR:
                *(BSTR*)variant->Anonymous.Anonymous.Anonymous.pbstrVal = _inner.Anonymous.Anonymous.Anonymous.bstrVal;
                break;

            case VARENUM.VT_VARIANT:
                *(nint*)variant->Anonymous.Anonymous.Anonymous.pvarVal = _inner.Anonymous.Anonymous.Anonymous.pvarVal;
                break;

            case VARENUM.VT_UNKNOWN:
            case VARENUM.VT_DISPATCH:
                *(nint*)variant->Anonymous.Anonymous.Anonymous.ppunkVal = _inner.Anonymous.Anonymous.Anonymous.punkVal;
                break;

            default:
                throw new NotSupportedException("Target property type " + _inner.Anonymous.Anonymous.vt + " is not supported.");
        }

        Zero();
    }

    public static PropVariant Attach(ref PROPVARIANT detached, bool zeroDetached = true)
    {
        var pv = new PropVariant { _inner = detached };
        if (zeroDetached)
        {
            unsafe
            {
                var ptr = Unsafe.AsPointer(ref detached);
                Functions.ZeroMemory((nint)ptr, Size);
            }
        }
        return pv;
    }

    public override string ToString()
    {
        object? value;
        try
        {
            value = Value;
        }
        catch
        {
            return "[" + VarType + "]";
        }
        if (value == null)
            return "<null>";

        if (value is string svalue)
            return "[" + VarType + "] `" + svalue + "`";

        if (value is not byte[] && value is IEnumerable enumerable)
            return "[" + VarType + "] " + string.Join(", ", enumerable.OfType<object>());

        if (value is byte[] bytes)
            return "[" + VarType + "] bytes[" + bytes.Length + "]";

        return "[" + VarType + "] " + value;
    }

    ~PropVariant() => Dispose();
    public void Dispose() { Clear(false); GC.SuppressFinalize(this); }

    private void Zero()
    {
        unsafe
        {
            fixed (PROPVARIANT* p = &_inner)
            {
                Functions.ZeroMemory((nint)p, Size);
            }
        }
    }

    private void ConstructEnumerable(IEnumerable enumerable, VARENUM? type = null)
    {
        var et = GetElementType(enumerable);
        if (et == null)
            throw new ArgumentException("Enumerable type '" + enumerable.GetType().FullName + "' is not supported.", nameof(enumerable));

        var count = GetCount(enumerable);
#pragma warning disable IL3050 // Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.
        var array = Array.CreateInstance(et, count);
#pragma warning restore IL3050 // Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.
        var i = 0;
        foreach (var obj in enumerable)
        {
            array.SetValue(obj, i++);
        }
        ConstructArray(array, type);
    }

    private void ConstructBlob(byte[] bytes)
    {
        _inner.Anonymous.Anonymous.Anonymous.blob.cbSize = (uint)bytes.Length;
        _inner.Anonymous.Anonymous.Anonymous.blob.pBlobData = Marshal.AllocCoTaskMem(bytes.Length);
        Marshal.Copy(bytes, 0, _inner.Anonymous.Anonymous.Anonymous.blob.pBlobData, bytes.Length);
        _inner.Anonymous.Anonymous.vt = VARENUM.VT_BLOB;
    }

    private void ConstructArray(Array array, VARENUM? type = null)
    {
        // special case for bools which are shorts...
        if (array is bool[] bools)
        {
            var shorts = new short[bools.Length];
            for (var i = 0; i < bools.Length; i++)
            {
                shorts[i] = bools[i] ? ((short)-1) : ((short)0);
            }
            ConstructVector(shorts, typeof(short), VARENUM.VT_BOOL);
            return;
        }

        var et = array.GetType().GetElementType();
        if (et == null)
            throw new NotSupportedException();

        if (type == VARENUM.VT_BLOB)
        {
            if (array is not byte[] bytes)
                throw new ArgumentException("Property type " + type + " is only supported for arrays of bytes.", nameof(type));

            ConstructBlob(bytes);
            return;
        }

        ConstructVector(array, et, FromType(et, type, false));
    }

    private void ConstructVector(Array array, Type type, VARENUM vt)
    {
        if (array.Length > 0)
        {
            int size;
            if (type == typeof(string))
            {
                size = nint.Size;
            }
            else if (type == typeof(object))
            {
                size = Variant.Size;
            }
            else
            {
#pragma warning disable IL3050 // Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.
#pragma warning disable CA1421 // This method uses runtime marshalling even when the 'DisableRuntimeMarshallingAttribute' is applied
                size = Marshal.SizeOf(type);
#pragma warning restore CA1421 // This method uses runtime marshalling even when the 'DisableRuntimeMarshallingAttribute' is applied
#pragma warning restore IL3050 // Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.
            }

            var elementSize = size;
            size *= array.Length;
            var ptr = Marshal.AllocCoTaskMem(size);

            // any CA will do
            _inner.Anonymous.Anonymous.Anonymous.cai.cElems = (uint)array.Length;
            _inner.Anonymous.Anonymous.Anonymous.cai.pElems = ptr;

            if (type == typeof(string))
            {
                for (var i = 0; i < array.Length; i++)
                {
                    var str = MarshalString((string?)array.GetValue(i)!, vt);
                    Marshal.WriteIntPtr(ptr, elementSize * i, str);
                }
            }
            else if (type == typeof(object))
            {
                for (var i = 0; i < array.Length; i++)
                {
                    var variantValue = array.GetValue(i);
                    var variant = new Variant(variantValue);
                    unsafe
                    {
                        var p = (VARIANT*)(ptr + elementSize * i);
                        *p = variant.Detach();
                    }
                }
            }
            else
            {
                Functions.CopyMemory(ptr, Marshal.UnsafeAddrOfPinnedArrayElement(array, 0), size);
            }
        }
        _inner.Anonymous.Anonymous.vt = vt | VARENUM.VT_VECTOR;
    }

    private bool TryGetVectorValue(VARENUM vt, out object? value)
    {
        value = null;
        var ret = false;
        uint size;
        switch (vt)
        {
            case VARENUM.VT_LPSTR:
            case VARENUM.VT_LPWSTR:
            case VARENUM.VT_BSTR:
                var strings = new string?[_inner.Anonymous.Anonymous.Anonymous.cai.cElems];
                for (var i = 0; i < strings.Length; i++)
                {
                    var str = Marshal.ReadIntPtr(_inner.Anonymous.Anonymous.Anonymous.cai.pElems, nint.Size * i);
                    strings[i] = PtrTostring(str, vt);
                }
                value = strings;
                ret = true;
                break;

            case VARENUM.VT_BOOL:
                var shorts = new short[_inner.Anonymous.Anonymous.Anonymous.cai.cElems];
                unsafe
                {
                    size = _inner.Anonymous.Anonymous.Anonymous.cai.cElems * sizeof(short);
                }
                Functions.CopyMemory(Marshal.UnsafeAddrOfPinnedArrayElement(shorts, 0), _inner.Anonymous.Anonymous.Anonymous.cai.pElems, (nint)size);
                var bools = new bool[shorts.Length];
                for (var i = 0; i < shorts.Length; i++)
                {
                    bools[i] = shorts[i] != 0;
                }
                value = bools;
                ret = true;
                break;

            case VARENUM.VT_VARIANT:
                var variants = new object?[_inner.Anonymous.Anonymous.Anonymous.cai.cElems];
                var variantSize = Size;
                unsafe
                {
                    for (var i = 0; i < variants.Length; i++)
                    {
                        var pv = _inner.Anonymous.Anonymous.Anonymous.cai.pElems + Size * i;
                        using var v = new Variant(*(VARIANT*)pv);
                        variants[i] = v.Value;
                        v.Detach();
                    }
                }
                value = variants;
                ret = true;
                break;

            case VARENUM.VT_I1:
            case VARENUM.VT_UI1:
            case VARENUM.VT_I2:
            case VARENUM.VT_UI2:
            case VARENUM.VT_I4:
            case VARENUM.VT_INT:
            case VARENUM.VT_UI4:
            case VARENUM.VT_UINT:
            case VARENUM.VT_I8:
            case VARENUM.VT_UI8:
            case VARENUM.VT_R4:
            case VARENUM.VT_R8:
            case VARENUM.VT_ERROR:
            case VARENUM.VT_CY:
            case VARENUM.VT_DATE:
            case VARENUM.VT_FILETIME:
            case VARENUM.VT_CLSID:
            case VARENUM.VT_UNKNOWN:
            case VARENUM.VT_DISPATCH:
                var et = FromType(vt);
#pragma warning disable IL3050 // Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.
                var values = Array.CreateInstance(et, _inner.Anonymous.Anonymous.Anonymous.cai.cElems);
#pragma warning disable CA1421 // This method uses runtime marshalling even when the 'DisableRuntimeMarshallingAttribute' is applied
                size = _inner.Anonymous.Anonymous.Anonymous.cai.cElems * (uint)Marshal.SizeOf(et);
#pragma warning restore CA1421 // This method uses runtime marshalling even when the 'DisableRuntimeMarshallingAttribute' is applied
#pragma warning restore IL3050 // Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.
                Functions.CopyMemory(Marshal.UnsafeAddrOfPinnedArrayElement(values, 0), _inner.Anonymous.Anonymous.Anonymous.cai.pElems, (nint)size);
                value = values;
                ret = true;
                break;
        }
        return ret;
    }

    public static PropVariant? Deserialize(byte[] bytes, bool throwOnError = true)
    {
        if (bytes == null)
            return null;

        var hr = Functions.StgDeserializePropVariant(bytes.AsPointer(), bytes.Length(), out var inner).ThrowOnError(throwOnError);
        if (hr.IsError)
            return null;

        return new PropVariant { _inner = inner };
    }

    public static PropVariant? Deserialize(nint ptr, uint size, bool throwOnError = true)
    {
        if (ptr == 0)
            return null;

        var hr = Functions.StgDeserializePropVariant(ptr, size, out var inner).ThrowOnError(throwOnError);
        if (hr.IsError)
            return null;

        return new PropVariant { _inner = inner };
    }

    public static PropVariant? FromVariant(object? value, bool throwOnError = true)
    {
        if (value == null)
            return null;

        value = Unwrap(value);
        using var mv = new Variant(value);
        Functions.VariantToPropVariant(mv.Detached, out var inner).ThrowOnError(throwOnError);
        return new PropVariant { _inner = inner };
    }

    [SupportedOSPlatform("windows8.0")]
    public static PropVariant? FromWinRTPropertyValue(nint propertyValue, bool throwOnError = true)
    {
        if (propertyValue == 0)
            return null;

        var hr = Functions.WinRTPropertyValueToPropVariant(propertyValue, out var inner).ThrowOnError(throwOnError);
        if (hr.IsError)
            return null;

        return new PropVariant { _inner = inner };
    }

    public void Clear(bool throwOnError = true) => Functions.PropVariantClear(ref _inner).ThrowOnError(throwOnError);

    internal static int GetCount(IEnumerable enumerable)
    {
        if (enumerable is ICollection col)
            return col.Count;

        var count = 0;
        var e = enumerable.GetEnumerator();
        Using(e, () =>
        {
            while (e.MoveNext())
            {
                count++;
            }
        });
        return count;

        static void Using(object resource, Action action)
        {
            try
            {
                action();
            }
            finally
            {
                (resource as IDisposable)?.Dispose();
            }
        }
    }

    internal static Type? GetElementType(Type collectionType)
    {
#pragma warning disable IL2070 // 'this' argument does not satisfy 'DynamicallyAccessedMembersAttribute' in call to target method. The parameter of method does not have matching annotations.
        foreach (var iface in collectionType.GetInterfaces())
        {
            if (!iface.IsGenericType)
                continue;

            if (iface.GetGenericTypeDefinition() == typeof(IEnumerable<>))
                return iface.GetGenericArguments()[0];

            if (iface.GetGenericTypeDefinition() == typeof(ICollection<>))
                return iface.GetGenericArguments()[0];

            if (iface.GetGenericTypeDefinition() == typeof(IList<>))
                return iface.GetGenericArguments()[0];
        }
#pragma warning restore IL2070 // 'this' argument does not satisfy 'DynamicallyAccessedMembersAttribute' in call to target method. The parameter of method does not have matching annotations.
        return null;
    }

    internal static Type? GetElementType(IEnumerable enumerable)
    {
        var et = GetElementType(enumerable.GetType());
        if (et != null)
            return et;

        foreach (var obj in enumerable)
        {
            return obj.GetType();
        }
        return null;
    }

    internal static Type FromType(VARENUM type)
    {
        switch (type)
        {
            case VARENUM.VT_I1:
                return typeof(sbyte);

            case VARENUM.VT_UI1:
                return typeof(byte);

            case VARENUM.VT_I2:
                return typeof(short);

            case VARENUM.VT_UI2:
                return typeof(ushort);

            case VARENUM.VT_UI4:
            case VARENUM.VT_UINT:
                return typeof(uint);

            case VARENUM.VT_I8:
                return typeof(long);

            case VARENUM.VT_UI8:
                return typeof(ulong);

            case VARENUM.VT_R4:
                return typeof(float);

            case VARENUM.VT_R8:
                return typeof(double);

            case VARENUM.VT_BOOL:
                return typeof(bool);

            case VARENUM.VT_I4:
            case VARENUM.VT_INT:
            case VARENUM.VT_ERROR:
                return typeof(int);

            case VARENUM.VT_DATE:
                return typeof(DateTime);

            case VARENUM.VT_FILETIME:
                return typeof(FILETIME);

            case VARENUM.VT_BLOB:
                return typeof(byte[]);

            case VARENUM.VT_CLSID:
                return typeof(Guid);

            case VARENUM.VT_BSTR:
            case VARENUM.VT_LPSTR:
            case VARENUM.VT_LPWSTR:
                return typeof(string);

            case VARENUM.VT_UNKNOWN:
            case VARENUM.VT_DISPATCH:
                return typeof(object);

            case VARENUM.VT_CY:
            case VARENUM.VT_DECIMAL:
                return typeof(decimal);

            default:
                throw new ArgumentException("Property type " + type + " is not supported.", nameof(type));
        }
    }

    public static string? PtrTostring(nint ptr, VARENUM vt)
    {
        if (ptr == 0)
            return null;

        switch (vt)
        {
            case VARENUM.VT_LPWSTR:
                return Marshal.PtrToStringUni(ptr);

            case VARENUM.VT_BSTR:
                return Marshal.PtrToStringBSTR(ptr);

            case VARENUM.VT_LPSTR:
                return Marshal.PtrToStringAnsi(ptr);

            default:
                throw new NotSupportedException("A string can only be of property type VT_LPWSTR, VT_LPSTR or VT_BSTR.");
        }
    }

    public static nint MarshalString(string? text, VARENUM vt)
    {
        if (text == null)
            return 0;

        switch (vt)
        {
            case VARENUM.VT_LPWSTR:
                return Marshal.StringToCoTaskMemUni(text);

            case VARENUM.VT_BSTR:
                return Marshal.StringToBSTR(text);

            case VARENUM.VT_LPSTR:
                return Marshal.StringToCoTaskMemAnsi(text);

            default:
                throw new NotSupportedException("A string can only be of property type VT_LPWSTR, VT_LPSTR or VT_BSTR.");
        }
    }

    public static object? Unwrap(object? value)
    {
        if (value is IComObject co)
            return Unwrap(co.Object);

        if (value is Variant variant)
            return Unwrap(variant.Value);

        if (value is PropVariant propVariant)
            return Unwrap(propVariant.Value);

        if (value is VARIANT v)
        {
            var dest = new VARIANT();
            if (Functions.VariantCopyInd(ref dest, v).ThrowOnError().IsOk)
            {
                v = dest;
            }

            var v2 = Variant.Attach(ref v, false);
            value = v2.Value;
            v2.Detach();
            return Unwrap(value);
        }

        if (value is PROPVARIANT pv)
        {
            var pv2 = Attach(ref pv, false);
            value = pv2.Value;
            pv2.Detach();
            return Unwrap(value);
        }

        if (value is IValueGet vg)
            return Unwrap(vg.GetValue());

        return value;
    }

    internal static VARENUM FromType(Type type, VARENUM? vt, bool forVariant)
    {
        if (type == null)
            return VARENUM.VT_NULL;

        var tc = Type.GetTypeCode(type);
        switch (tc)
        {
            case TypeCode.Boolean:
                return VARENUM.VT_BOOL;

            case TypeCode.Byte:
                return VARENUM.VT_UI1;

            case TypeCode.Char:
                if (forVariant)
                    return VARENUM.VT_BSTR;

                return VARENUM.VT_LPWSTR;

            case TypeCode.DateTime:
                if (vt == VARENUM.VT_FILETIME)
                    return VARENUM.VT_FILETIME;

                return VARENUM.VT_DATE;

            case TypeCode.DBNull:
                return VARENUM.VT_NULL;

            case TypeCode.Decimal:
                return VARENUM.VT_DECIMAL;

            case TypeCode.Double:
                return VARENUM.VT_R8;

            case TypeCode.Empty:
                return VARENUM.VT_EMPTY;

            case TypeCode.Int16:
                return VARENUM.VT_I2;

            case TypeCode.Int32:
                return VARENUM.VT_I4;

            case TypeCode.Int64:
                return VARENUM.VT_I8;

            case TypeCode.SByte:
                return VARENUM.VT_I1;

            case TypeCode.Single:
                return VARENUM.VT_R4;

            case TypeCode.String:
                if (forVariant)
                    return VARENUM.VT_BSTR;

                if (!vt.HasValue)
                    return VARENUM.VT_LPWSTR;

                if (vt != VARENUM.VT_LPSTR && vt != VARENUM.VT_BSTR && vt != VARENUM.VT_LPWSTR)
                    throw new ArgumentException("Property type " + vt + " is not supported for string.", nameof(type));

                return vt.Value;

            case TypeCode.UInt16:
                return VARENUM.VT_UI2;

            case TypeCode.UInt32:
                return VARENUM.VT_UI4;

            case TypeCode.UInt64:
                return VARENUM.VT_UI8;

            // case TypeCode.Object:
            default:
                if (type == typeof(Guid))
                {
                    if (forVariant)
                        return VARENUM.VT_BSTR;

                    return VARENUM.VT_CLSID;
                }

                if (type == typeof(FILETIME))
                {
                    if (forVariant)
                        return VARENUM.VT_DATE;

                    return VARENUM.VT_FILETIME;
                }

                if (type == typeof(byte))
                {
                    if (forVariant)
                        return VARENUM.VT_UI1 | VARENUM.VT_ARRAY;

                    if (!vt.HasValue)
                        return VARENUM.VT_UI1 | VARENUM.VT_VECTOR;

                    if (vt != VARENUM.VT_BLOB && vt != (VARENUM.VT_UI1 | VARENUM.VT_VECTOR))
                        throw new ArgumentException("Property type " + vt + " is not supported for array of bytes.", nameof(type));

                    return vt.Value;
                }

                if (type == typeof(object))
                    return VARENUM.VT_VARIANT;

                throw new ArgumentException("Value of type '" + type.FullName + "' is not supported.", nameof(type));
        }
    }
}

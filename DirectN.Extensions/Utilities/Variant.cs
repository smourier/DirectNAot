namespace DirectN.Extensions.Utilities;

public sealed class Variant : IDisposable
{
    private VARIANT _inner;

    public VARIANT Detached => _inner;
    public ref VARIANT RefDetached => ref _inner;

    public static int Size { get; } = GetSizeOf32();
    private static int GetSizeOf32() { unsafe { return sizeof(VARIANT); } }

    internal Variant(VARIANT inner)
    {
        _inner = inner;
    }

    public Variant()
    {
        // it's a VT_EMPTY
    }

    public Variant(object? value, VARENUM? type = null)
    {
        if (value == null)
        {
            _inner.Anonymous.Anonymous.vt = VARENUM.VT_NULL;
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
            _inner.Anonymous.Anonymous.vt = VARENUM.VT_UNKNOWN;
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
            _inner.Anonymous.Anonymous.vt = VARENUM.VT_NULL;
            return;
        }

        var valueType = value.GetType();
        var details = System.Runtime.InteropServices.Marshalling.StrategyBasedComWrappers.DefaultIUnknownInterfaceDetailsStrategy.GetComExposedTypeDetails(valueType.TypeHandle);
        if (details != null)
        {
            // favor IDispatch for late-bound clients
            nint unk;
            if (type != VARENUM.VT_UNKNOWN)
            {
                unk = ComObject.GetOrCreateComInstance<IDispatch>(value);
                if (unk != 0)
                {
                    _inner.Anonymous.Anonymous.Anonymous.pdispVal = unk;
                    _inner.Anonymous.Anonymous.vt = VARENUM.VT_DISPATCH;
                    return;
                }
            }

            unk = ComObject.GetOrCreateComInstance(value, throwOnError: true);
            if (unk == 0)
                throw new ArgumentException("Value of type '" + value.GetType().FullName + "' is not supported.", nameof(value));

            _inner.Anonymous.Anonymous.Anonymous.punkVal = unk;
            _inner.Anonymous.Anonymous.vt = VARENUM.VT_UNKNOWN;
            return;
        }

        var vt = PropVariant.FromType(valueType, type, true, null);
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
                _inner.Anonymous.Anonymous.Anonymous.bstrVal = new BSTR { Value = PropVariant.MarshalString(new string(chars), VARENUM.VT_BSTR) };
                vt = VARENUM.VT_BSTR;
                break;

            case TypeCode.DateTime:
                if (type == VARENUM.VT_FILETIME)
                {
                    var ft = Conversions.ToPositiveFILETIME((DateTime)value);
                    Functions.InitVariantFromFileTime(ft, out _inner);
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
                _inner.Anonymous.Anonymous.Anonymous.llVal = (long)value;
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
                _inner.Anonymous.Anonymous.Anonymous.bstrVal = new BSTR { Value = PropVariant.MarshalString((string)value, VARENUM.VT_BSTR) };
                vt = VARENUM.VT_BSTR;
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
                _inner.Anonymous.Anonymous.Anonymous.ullVal = (ulong)value;
                vt = VARENUM.VT_UI8;
                break;

            //case TypeCode.Object:
            default:
                if (value is Guid guid)
                {
                    _inner.Anonymous.Anonymous.Anonymous.bstrVal = new BSTR { Value = PropVariant.MarshalString(guid.ToString("B"), VARENUM.VT_BSTR) };
                    vt = VARENUM.VT_BSTR;
                    break;
                }

                if (value is DateTimeOffset dto)
                {
                    if (type == VARENUM.VT_FILETIME)
                    {
                        var ft = Conversions.ToPositiveFILETIMEUtc(dto.UtcDateTime);
                        Functions.InitVariantFromFileTime(ft, out _inner);
                        return;
                    }

                    _inner.Anonymous.Anonymous.Anonymous.dblVal = dto.DateTime.ToOADate();
                    vt = VARENUM.VT_DATE;
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
            if (VarType == VARENUM.VT_VARIANT || VarType.HasFlag(VARENUM.VT_BYREF))
            {
                using var value = CopyValue();
                return value?.Value;
            }

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
                    return _inner.Anonymous.Anonymous.Anonymous.llVal;

                case VARENUM.VT_UI8:
                    return _inner.Anonymous.Anonymous.Anonymous.ullVal;

                case VARENUM.VT_R4:
                    return _inner.Anonymous.Anonymous.Anonymous.fltVal;

                case VARENUM.VT_R8:
                    return _inner.Anonymous.Anonymous.Anonymous.dblVal;

                case VARENUM.VT_BOOL:
                    return _inner.Anonymous.Anonymous.Anonymous.boolVal.Value != 0;

                case VARENUM.VT_ERROR:
                    return _inner.Anonymous.Anonymous.Anonymous.scode;

                case VARENUM.VT_CY:
                    return _inner.Anonymous.Anonymous.Anonymous.cyVal.int64 / 10000m;

                case VARENUM.VT_DATE:
                    return DateTime.FromOADate(_inner.Anonymous.Anonymous.Anonymous.dblVal);

                case VARENUM.VT_BSTR:
                    return _inner.Anonymous.Anonymous.Anonymous.bstrVal.Value != 0 ? Marshal.PtrToStringBSTR(_inner.Anonymous.Anonymous.Anonymous.bstrVal.Value) : null;

                case VARENUM.VT_LPSTR:
                    // all strings point to same place anyway
                    return Marshal.PtrToStringAnsi(_inner.Anonymous.Anonymous.Anonymous.bstrVal.Value);

                case VARENUM.VT_LPWSTR:
                    // all strings point to same place anyway
                    return Marshal.PtrToStringUni(_inner.Anonymous.Anonymous.Anonymous.bstrVal.Value);

                case VARENUM.VT_UNKNOWN:
                case VARENUM.VT_DISPATCH:
                    if (_inner.Anonymous.Anonymous.Anonymous.punkVal == 0)
                        return null;

                    var sw = ComObject.ComWrappers;
                    return sw.GetOrCreateObjectForComInstance(_inner.Anonymous.Anonymous.Anonymous.punkVal, CreateObjectFlags.UniqueInstance);

                case VARENUM.VT_DECIMAL:
                    return _inner.Anonymous.decVal;

                default:
                    if (_inner.Anonymous.Anonymous.vt.HasFlag(VARENUM.VT_ARRAY))
                    {
                        var et = _inner.Anonymous.Anonymous.vt & ~VARENUM.VT_ARRAY;
                        if (TryGetArrayValue(et, out var array))
                            return array;
                    }

                    throw new NotSupportedException("Value of property type " + _inner.Anonymous.Anonymous.vt + " is not supported.");
            }
        }
    }

    internal unsafe Variant? CopyValue(bool throwOnError = true)
    {
        if (VarType == VARENUM.VT_VARIANT || VarType == (VARENUM.VT_VARIANT | VARENUM.VT_BYREF))
        {
            var pointer = _inner.Anonymous.Anonymous.Anonymous.pvarVal;
            if (pointer == 0)
            {
                if (throwOnError)
                    throw new InvalidOperationException("The referenced variant is null.");

                return null;
            }

            var innerValue = *(VARIANT*)pointer;
            using var borrowed = Attach(ref innerValue);
            try
            {
                return borrowed.CopyValue(throwOnError);
            }
            finally
            {
                borrowed.Detach();
            }
        }

        var inner = new VARIANT();
        var hr = VarType.HasFlag(VARENUM.VT_BYREF)
            ? Functions.VariantCopyInd(ref inner, _inner)
            : Functions.VariantCopy(ref inner, _inner);
        hr.ThrowOnError(throwOnError);
        return hr.IsError ? null : new Variant(inner);
    }

    public Variant? ChangeType(VARENUM type, bool throwOnError = true)
    {
        if (type.HasFlag(VARENUM.VT_BYREF))
        {
            if (throwOnError)
                throw new ArgumentException("By-reference values require caller-owned storage. Use the storage overload or Attach instead.", nameof(type));

            return null;
        }

        if (type == VARENUM.VT_VARIANT)
            return CopyValue(throwOnError);

        var inner = new VARIANT();

        var hr = Functions.VariantChangeType(ref inner, _inner, 0, type).ThrowOnError(throwOnError);
        if (hr.IsError)
            return null;

        return new Variant { _inner = inner };
    }

    public unsafe Variant? ChangeType(VARENUM type, nint referencedVariant, bool throwOnError = true)
    {
        if (referencedVariant == 0)
            throw new ArgumentException(null, nameof(referencedVariant));

        var valueType = type & ~VARENUM.VT_BYREF;
        var elementType = valueType & ~VARENUM.VT_ARRAY;
        if (!type.HasFlag(VARENUM.VT_BYREF) || elementType is not
            (VARENUM.VT_I1 or VARENUM.VT_UI1 or VARENUM.VT_I2 or VARENUM.VT_UI2 or
             VARENUM.VT_I4 or VARENUM.VT_UI4 or VARENUM.VT_I8 or VARENUM.VT_UI8 or
             VARENUM.VT_INT or VARENUM.VT_UINT or VARENUM.VT_R4 or VARENUM.VT_R8 or
             VARENUM.VT_BOOL or VARENUM.VT_ERROR or VARENUM.VT_CY or VARENUM.VT_DATE or
             VARENUM.VT_BSTR or VARENUM.VT_UNKNOWN or VARENUM.VT_DISPATCH or
             VARENUM.VT_DECIMAL or VARENUM.VT_VARIANT))
        {
            if (throwOnError)
                throw new ArgumentException("The type must be a supported by-reference variant type.", nameof(type));

            return null;
        }

        using var value = valueType == VARENUM.VT_VARIANT || valueType == VarType
            ? CopyValue(throwOnError)
            : ChangeType(valueType, throwOnError);
        if (value == null)
            return null;

        var result = new Variant();
        var storage = (VARIANT*)referencedVariant;
        var hr = Functions.VariantClear(ref *storage).ThrowOnError(throwOnError);
        if (hr.IsError)
            return null;

        *storage = value.Detach();
        result._inner.Anonymous.Anonymous.vt = type;
        result._inner.Anonymous.Anonymous.Anonymous.pvarVal = valueType == VARENUM.VT_VARIANT
            ? referencedVariant
            : valueType == VARENUM.VT_DECIMAL
                ? (nint)(&storage->Anonymous.decVal)
                : (nint)(&storage->Anonymous.Anonymous.Anonymous);
        return result;
    }

    public void CopyFrom(Variant source, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(source);
        if (source == this)
            return;

        using var copy = source.Copy(throwOnError);
        if (copy == null)
            return;

        Clear(throwOnError);
        if (VarType != VARENUM.VT_EMPTY)
            return;

        _inner = copy.Detach();
    }

    public Variant? Copy(bool throwOnError = true)
    {
        if (VarType == VARENUM.VT_VARIANT)
            return CopyValue(throwOnError);

        var inner = new VARIANT();
        var hr = Functions.VariantCopy(ref inner, _inner).ThrowOnError(throwOnError);
        return hr.IsError ? null : new Variant(inner);
    }

    public VARIANT Detach()
    {
        var pv = _inner;
        Zero();
        return pv;
    }

    public unsafe void DetachTo(nint variantPtr)
    {
        if (variantPtr == 0)
            throw new ArgumentException(null, nameof(variantPtr));

        var pv = _inner;
        Zero();
        *(VARIANT*)variantPtr = pv;
    }

    public unsafe void DetachToByRef(nint variantPtr)
    {
        if (variantPtr == 0)
            throw new ArgumentException(null, nameof(variantPtr));

        var variant = (VARIANT*)variantPtr;
        if (!variant->Anonymous.Anonymous.vt.HasFlag(VARENUM.VT_BYREF))
            throw new ArgumentException($"Target type is {variant->Anonymous.Anonymous.vt}, not a VT_BYREF variant.", nameof(variantPtr));

        if (variant->Anonymous.Anonymous.Anonymous.byref == 0)
            throw new ArgumentException("The target reference is null.", nameof(variantPtr));

        if (VarType.HasFlag(VARENUM.VT_BYREF) || VarType == VARENUM.VT_VARIANT)
        {
            using var value = CopyValue()!;
            value.DetachToByRef(variantPtr);
            Clear();
            return;
        }

        var vt = variant->Anonymous.Anonymous.vt & ~VARENUM.VT_BYREF;
        if (vt != VARENUM.VT_VARIANT && vt != VarType)
            throw new ArgumentException($"Source type {VarType} and target type {variant->Anonymous.Anonymous.vt} are incompatible.", nameof(variantPtr));

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
                *(long*)variant->Anonymous.Anonymous.Anonymous.pllVal = _inner.Anonymous.Anonymous.Anonymous.llVal;
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
                *(ulong*)variant->Anonymous.Anonymous.Anonymous.pullVal = _inner.Anonymous.Anonymous.Anonymous.ullVal;
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
                Functions.VariantClear(ref *(VARIANT*)variant->Anonymous.Anonymous.Anonymous.pvarVal).ThrowOnError();
                *(VARIANT*)variant->Anonymous.Anonymous.Anonymous.pvarVal = Detach();
                return;

            case VARENUM.VT_UNKNOWN:
            case VARENUM.VT_DISPATCH:
                *(nint*)variant->Anonymous.Anonymous.Anonymous.ppunkVal = _inner.Anonymous.Anonymous.Anonymous.punkVal;
                break;

            default:
                throw new NotSupportedException("Target property type " + _inner.Anonymous.Anonymous.vt + " is not supported.");
        }

        Zero();
    }

    public static Variant Attach(ref VARIANT detached, bool zeroDetached = true)
    {
        var pv = new Variant { _inner = detached };
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

    public static object? Unwrap(object? value) => PropVariant.Unwrap(value);

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

    ~Variant() => Dispose();
    public void Dispose() { Clear(false); GC.SuppressFinalize(this); }

    private void Zero()
    {
        unsafe
        {
            fixed (VARIANT* p = &_inner)
            {
                Functions.ZeroMemory((nint)p, Size);
            }
        }
    }

    private void ConstructEnumerable(IEnumerable enumerable, VARENUM? type = null)
    {
        type &= ~VARENUM.VT_ARRAY;
        ConstructArray(PropVariant.MaterializeEnumerable(enumerable, ref type, true), type);
    }

    private void ConstructArray(Array array, VARENUM? type = null)
    {
        type &= ~VARENUM.VT_ARRAY;

        // special case for bools which are shorts...
        if (array is bool[] bools)
        {
            var shorts = new short[bools.Length];
            for (var i = 0; i < bools.Length; i++)
            {
                shorts[i] = bools[i] ? ((short)-1) : ((short)0);
            }
            ConstructSafeArray(shorts, VARENUM.VT_BOOL);
            return;
        }

        if (array is Guid[] guids)
        {
            var strings = new string[guids.Length];
            for (var i = 0; i < strings.Length; i++)
            {
                strings[i] = guids[i].ToString("B");
            }
            ConstructSafeArray(strings, VARENUM.VT_BSTR);
            return;
        }

        if (array is DateTime[] dates)
        {
            ConstructSafeArray(dates.Select(date => date.ToOADate()).ToArray(), VARENUM.VT_DATE);
            return;
        }

        var et = array.GetType().GetElementType();
        if (et == null)
            throw new NotSupportedException();

        if (array.Length > 0)
        {
            var objectVt = PropVariant.GetObjectType(array.GetValue(0), type);
            if (objectVt != null)
            {
                ConstructSafeArray(array, objectVt.Value);
                return;
            }
        }

        var vt = PropVariant.FromType(et, type, true, VARENUM.VT_VARIANT);
        ConstructSafeArray(array, vt);
    }

    private void ConstructSafeArray(Array array, VARENUM vt)
    {
        unsafe
        {
            var bounds = new SAFEARRAYBOUND { cElements = (uint)array.Length };
            var sa = Functions.SafeArrayCreate(vt, 1, bounds);
            if (sa == 0)
                throw new OutOfMemoryException();

            var psa = (SAFEARRAY*)sa;
            try
            {
                Functions.SafeArrayAccessData(*psa, out var ptr).ThrowOnError();
                try
                {
                    switch (vt)
                    {
                        case VARENUM.VT_VARIANT:
                            for (var i = 0; i < array.Length; i++)
                            {
                                var item = array.GetValue(i);
                                using var variant = new Variant(item);
                                variant.DetachTo(ptr + Size * i);
                            }
                            break;

                        case VARENUM.VT_LPSTR:
                        case VARENUM.VT_LPWSTR:
                        case VARENUM.VT_BSTR:
                            for (var i = 0; i < array.Length; i++)
                            {
                                var str = PropVariant.MarshalString((string?)array.GetValue(i), vt);
                                Marshal.WriteIntPtr(ptr, nint.Size * i, str);
                            }
                            break;

                        case VARENUM.VT_BOOL:
                            for (var i = 0; i < array.Length; i++)
                            {
                                var item = Conversions.ChangeType<bool>(array.GetValue(i));
                                Marshal.WriteInt16(ptr, 2 * i, (short)(item ? -1 : 0));
                            }
                            break;

                        case VARENUM.VT_UNKNOWN:
                        case VARENUM.VT_DISPATCH:
                            for (var i = 0; i < array.Length; i++)
                            {
                                var item = array.GetValue(i);
                                using var variant = new Variant(item, vt);
                                // any p*** variable will do (all same offset)
                                Marshal.WriteIntPtr(ptr, nint.Size * i, variant.Detached.Anonymous.Anonymous.Anonymous.punkVal);
                                variant.Detach();
                            }
                            break;

                        default:
                            var size = checked((nint)PropVariant.SizeofForVector(vt) * array.Length);
                            PropVariant.CopyArrayMemory(array, ptr, size, true);
                            break;
                    }
                }
                finally
                {
                    Functions.SafeArrayUnaccessData(*psa).ThrowOnError();
                }
            }
            catch
            {
                Functions.SafeArrayDestroy(*psa);
                throw;
            }

            _inner.Anonymous.Anonymous.vt = vt | VARENUM.VT_ARRAY;
            _inner.Anonymous.Anonymous.Anonymous.parray = sa;
        }
    }

    private static int GetCount(in SAFEARRAY psa)
    {
        Functions.SafeArrayGetLBound(psa, 1, out var l).ThrowOnError();
        Functions.SafeArrayGetUBound(psa, 1, out var u).ThrowOnError();
        return u - l + 1;
    }

    private bool TryGetArrayValue(VARENUM vt, out object? value)
    {
        value = null;
        if (_inner.Anonymous.Anonymous.Anonymous.parray == 0)
            return false;

        unsafe
        {
            var psa = (SAFEARRAY*)_inner.Anonymous.Anonymous.Anonymous.parray;
            if (psa->cDims != 1)
                return false;

            var count = GetCount(*psa);

            Functions.SafeArrayAccessData(*psa, out var ptr).ThrowOnError();
            try
            {
                var ret = false;
                uint size;
                switch (vt)
                {
                    case VARENUM.VT_LPSTR:
                    case VARENUM.VT_LPWSTR:
                    case VARENUM.VT_BSTR:
                        var strings = new string?[count];
                        for (var i = 0; i < strings.Length; i++)
                        {
                            var str = Marshal.ReadIntPtr(ptr, (int)(psa->cbElements * i));
                            strings[i] = PropVariant.PtrTostring(str, vt);
                        }

                        value = strings;
                        ret = true;
                        break;

                    case VARENUM.VT_BOOL:
                        var shorts = new short[count];
                        size = checked((uint)shorts.Length * sizeof(short));
                        PropVariant.CopyArrayMemory(shorts, ptr, (nint)size, false);
                        var bools = new bool[shorts.Length];
                        for (var i = 0; i < shorts.Length; i++)
                        {
                            bools[i] = shorts[i] != 0;
                        }

                        value = bools;
                        ret = true;
                        break;

                    case VARENUM.VT_UNKNOWN:
                    case VARENUM.VT_DISPATCH:
                        var objects = new object?[count];
                        for (var i = 0; i < objects.Length; i++)
                        {
                            var pointer = Marshal.ReadIntPtr(ptr, checked(i * nint.Size));
                            if (pointer != 0)
                            {
                                objects[i] = ComObject.ComWrappers.GetOrCreateObjectForComInstance(pointer, CreateObjectFlags.UniqueInstance);
                            }
                        }

                        value = objects;
                        return true;

                    case VARENUM.VT_DATE:
                        var dates = new DateTime[count];
                        for (var i = 0; i < dates.Length; i++)
                        {
                            dates[i] = DateTime.FromOADate(BitConverter.Int64BitsToDouble(Marshal.ReadInt64(ptr, checked(i * sizeof(double)))));
                        }

                        value = dates;
                        return true;

                    case VARENUM.VT_VARIANT:
                        var variants = new object?[count];
                        var variantSize = Size;
                        for (var i = 0; i < variants.Length; i++)
                        {
                            var pv = ptr + Size * i;
                            using var v = new Variant { _inner = *(VARIANT*)pv };
                            try
                            {
                                variants[i] = v.Value;
                            }
                            finally
                            {
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
                    case VARENUM.VT_DECIMAL:
                        var arrayType = PropVariant.FromTypeArray(vt);
                        var et = PropVariant.FromType(vt);
                        var values = Array.CreateInstanceFromArrayType(arrayType, count);
                        size = checked((uint)count * PropVariant.SizeofForVector(vt));
                        PropVariant.CopyArrayMemory(values, ptr, (nint)size, false);
                        value = values;
                        ret = true;
                        break;
                }
                return ret;
            }
            finally
            {
                Functions.SafeArrayUnaccessData(*psa).ThrowOnError();
            }
        }
    }

    public void Clear(bool throwOnError = true) => Functions.VariantClear(ref _inner).ThrowOnError(throwOnError);
}

namespace DirectN.Extensions.Utilities
{
    public sealed class Variant : IDisposable
    {
        private VARIANT _inner;

        public VARIANT Detached => _inner;

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
                _inner.Anonymous.Anonymous.vt = type ?? VARENUM.VT_UNKNOWN;
                return;
            }

            if (value is nuint uptr)
            {
                _inner.Anonymous.Anonymous.Anonymous.punkVal = (nint)uptr;
                _inner.Anonymous.Anonymous.vt = type ?? VARENUM.VT_UNKNOWN;
                return;
            }

            if (value is System.Runtime.InteropServices.Marshalling.ComObject co)
            {
                var sw = Com.ComObject.ComWrappers;
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
            var vt = PropVariant.FromType(valueType, type, true);
            var tc = Type.GetTypeCode(valueType);
            switch (tc)
            {
                case TypeCode.Boolean:
                    _inner.Anonymous.Anonymous.Anonymous.boolVal = new VARIANT_BOOL { Value = (bool)value ? (short)(-1) : (short)0 };
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
                            var ft = Conversions.ToPositiveFILETIME(dto.DateTime);
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
                        return _inner.Anonymous.decVal;

                    case VARENUM.VT_DATE:
                        return DateTime.FromOADate(_inner.Anonymous.Anonymous.Anonymous.dblVal);

                    case VARENUM.VT_BSTR:
                        return Marshal.PtrToStringBSTR(_inner.Anonymous.Anonymous.Anonymous.bstrVal.Value);

                    case VARENUM.VT_LPSTR:
                        // all strings point to same place anyway
                        return Marshal.PtrToStringAnsi(_inner.Anonymous.Anonymous.Anonymous.bstrVal.Value);

                    case VARENUM.VT_LPWSTR:
                        // all strings point to same place anyway
                        return Marshal.PtrToStringUni(_inner.Anonymous.Anonymous.Anonymous.bstrVal.Value);

                    case VARENUM.VT_UNKNOWN:
                    case VARENUM.VT_DISPATCH:
                        var sw = Com.ComObject.ComWrappers;
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

        public Variant? ChangeType(VARENUM type, bool throwOnError = true)
        {
            var inner = new VARIANT();
            var hr = Functions.VariantChangeType(ref inner, _inner, 0, type).ThrowOnError(throwOnError);
            if (hr.IsError)
                return null;

            return new Variant { _inner = inner };
        }

        public void CopyFrom(Variant source, bool throwOnError = true)
        {
            ArgumentNullException.ThrowIfNull(source);
            if (source == this)
                return;

            Clear(throwOnError);
            var inner = new VARIANT();
            Functions.VariantCopy(ref inner, source._inner).ThrowOnError(throwOnError);
            _inner = inner;
        }

        public Variant? Copy(bool throwOnError = true)
        {
            var inner = new VARIANT();
            var hr = Functions.VariantCopy(ref inner, _inner).ThrowOnError(throwOnError);
            if (hr.IsError)
                return null;

            return new Variant { _inner = inner };
        }

        public VARIANT Detach()
        {
            var pv = _inner;
            Zero();
            return pv;
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
            var value = Value;
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
            var et = PropVariant.GetElementType(enumerable);
            if (et == null)
                throw new ArgumentException("Enumerable type '" + enumerable.GetType().FullName + "' is not supported.", nameof(enumerable));

            var count = PropVariant.GetCount(enumerable);
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

        private void ConstructArray(Array array, VARENUM? type = null)
        {
            // special case for bools which are shorts...
            if (array is bool[] bools)
            {
                var shorts = new short[bools.Length];
                for (var i = 0; i < bools.Length; i++)
                {
                    shorts[i] = bools[i] ? ((short)(-1)) : ((short)0);
                }
                ConstructSafeArray(shorts, typeof(short), VARENUM.VT_BOOL);
                return;
            }

            if (array is Guid[] guids)
            {
                var strings = new string[guids.Length];
                for (var i = 0; i < strings.Length; i++)
                {
                    strings[i] = guids[i].ToString("B");
                }
                ConstructSafeArray(strings, typeof(string), VARENUM.VT_BSTR);
                return;
            }

            var et = array.GetType().GetElementType();
            if (et == null)
                throw new NotSupportedException();

            ConstructSafeArray(array, et, PropVariant.FromType(et, type, true));
        }

        private void ConstructSafeArray(Array array, Type type, VARENUM vt)
        {
            unsafe
            {
                var bounds = new SAFEARRAYBOUND { lLbound = 0, cElements = (uint)array.Length };
                var sa = Functions.SafeArrayCreate(vt, 1, bounds);
                if (sa == 0)
                    throw new OutOfMemoryException();

                var psa = (SAFEARRAY*)sa;
                Functions.SafeArrayAccessData(*psa, out var ptr).ThrowOnError();
                try
                {
                    if (type == typeof(string))
                    {
                        for (var i = 0; i < array.Length; i++)
                        {
                            var str = PropVariant.MarshalString((string?)array.GetValue(i)!, vt);
                            Marshal.WriteIntPtr(ptr, nint.Size * i, str);
                        }
                    }
                    else if (type == typeof(object))
                    {
                        for (var i = 0; i < array.Length; i++)
                        {
                            var variantValue = array.GetValue(i);
                            using var variant = new Variant(variantValue);
                            unsafe
                            {
                                var p = (VARIANT*)(ptr + Size * i);
                                *p = variant.Detach();
                            }
                        }
                    }
                    else
                    {
#pragma warning disable IL3050 // Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.
#pragma warning disable CA1421 // This method uses runtime marshalling even when the 'DisableRuntimeMarshallingAttribute' is applied
                        var size = Marshal.SizeOf(type) * array.Length;
#pragma warning restore CA1421 // This method uses runtime marshalling even when the 'DisableRuntimeMarshallingAttribute' is applied
#pragma warning restore IL3050 // Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.

                        Functions.CopyMemory(ptr, Marshal.UnsafeAddrOfPinnedArrayElement(array, 0), size);
                    }
                }
                catch
                {
                    Functions.SafeArrayDestroy(*psa);
                    throw;
                }
                finally
                {
                    Functions.SafeArrayUnaccessData(*psa).ThrowOnError();
                }

                _inner.Anonymous.Anonymous.vt = vt | VARENUM.VT_ARRAY;
                _inner.Anonymous.Anonymous.Anonymous.parray = sa;
            }
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

                Functions.SafeArrayGetLBound(*psa, 1, out var l).ThrowOnError();
                Functions.SafeArrayGetUBound(*psa, 1, out var u).ThrowOnError();
                var count = u - l + 1;

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
                            size = (uint)(shorts.Length * sizeof(short));
                            Functions.CopyMemory(Marshal.UnsafeAddrOfPinnedArrayElement(shorts, 0), ptr, (nint)size);
                            var bools = new bool[shorts.Length];
                            for (var i = 0; i < shorts.Length; i++)
                            {
                                bools[i] = shorts[i] != 0;
                            }
                            value = bools;
                            ret = true;
                            break;

                        case VARENUM.VT_VARIANT:
                            var variants = new object?[count];
                            var variantSize = Size;
                            for (var i = 0; i < variants.Length; i++)
                            {
                                var pv = ptr + Size * i;
                                using var v = new Variant { _inner = *(VARIANT*)pv };
                                variants[i] = v.Value;
                                v.Detach();
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
                        case VARENUM.VT_UNKNOWN:
                        case VARENUM.VT_DISPATCH:
                            var et = PropVariant.FromType(vt);
#pragma warning disable IL3050 // Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.
                            var values = Array.CreateInstance(et, psa->cbElements);
#pragma warning disable CA1421 // This method uses runtime marshalling even when the 'DisableRuntimeMarshallingAttribute' is applied
                            size = (uint)(values.Length * Marshal.SizeOf(et));
#pragma warning restore CA1421 // This method uses runtime marshalling even when the 'DisableRuntimeMarshallingAttribute' is applied
#pragma warning restore IL3050 // Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.
                            Functions.CopyMemory(Marshal.UnsafeAddrOfPinnedArrayElement(values, 0), ptr, (nint)size);
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
}

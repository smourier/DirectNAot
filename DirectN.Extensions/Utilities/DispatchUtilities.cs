namespace DirectN.Extensions.Utilities;

public static class DispatchUtilities
{
    // see why we need this dumb thing here
    // https://github.com/MicrosoftEdge/WebView2Feedback/issues/347
    private const uint LOCALE_USER_DEFAULT = 0x00000400;

    public static unsafe string? CallMethodNullifiedValue(this IComObject<IDispatch>? disp, string name, object?[]? arguments = null) => CallMethodNullifiedValue(disp?.Object, name, arguments);
    public static unsafe string? CallMethodNullifiedValue(this IDispatch? disp, string name, object?[]? arguments = null)
    {
        if (!TryCallMethod(disp, name, out var value, arguments) || value is null)
            return null;

        if (value is string str)
            return str.Nullify();

        return value.ToString().Nullify();
    }

    public static unsafe IComObject<T>? CallMethodComObject<T>(this IComObject<IDispatch>? disp, string name, object?[]? arguments = null) => CallMethodComObject<T>(disp?.Object, name, arguments);
    public static unsafe IComObject<T>? CallMethodComObject<T>(this IDispatch? disp, string name, object?[]? arguments = null)
    {
        if (!TryCallMethod(disp, name, out object? value, arguments))
            return null;

        if (value is not System.Runtime.InteropServices.Marshalling.ComObject co)
            return null;

        return new ComObject<T>(co);
    }

    public static unsafe T? CallMethod<T>(this IComObject<IDispatch>? disp, string name, object?[]? arguments = null, T? defaultValue = default) => CallMethod(disp?.Object, name, arguments, defaultValue);
    public static unsafe T? CallMethod<T>(this IDispatch? disp, string name, object?[]? arguments = null, T? defaultValue = default)
    {
        if (!TryCallMethod(disp, name, out object? value, arguments))
            return defaultValue;

        if (Conversions.TryChangeType(value, null, out T? result))
            return result;

        return defaultValue;
    }

    public static unsafe object? CallObjectMethod(this IComObject<IDispatch>? disp, string name, object?[]? arguments = null, object? defaultValue = null) => CallObjectMethod(disp?.Object, name, arguments, defaultValue);
    public static unsafe object? CallObjectMethod(this IDispatch? disp, string name, object?[]? arguments = null, object? defaultValue = null)
    {
        if (!TryCallMethod(disp, name, out object? value, arguments))
            return defaultValue;

        return value;
    }

    public static unsafe bool TryCallMethod(this IComObject<IDispatch>? disp, string name, out object? value, object?[]? arguments = null) => TryCallMethod(disp?.Object, name, out value, arguments);
    public static unsafe bool TryCallMethod(this IDispatch? disp, string name, out object? value, object?[]? arguments = null)
    {
        ArgumentNullException.ThrowIfNull(name);
        value = null;
        if (disp == null)
            return false;

        var pwstr = new Pwstr(name);
        var names = new PWSTR[] { pwstr };
        var ids = new int[names.Length];
        var hr = disp.GetIDsOfNames(Guid.Empty, names, names.Length(), LOCALE_USER_DEFAULT, ids);
        if (hr.IsError)
            return false;

        var argsCount = arguments?.Length ?? 0;
        var dispParams = new DISPPARAMS();
        if (argsCount > 0)
        {
            var vars = new VARIANT[argsCount];
            for (var i = 0; i < argsCount; i++)
            {
                using var varg = new Variant(arguments![argsCount - 1 - i]);
                vars[i] = varg.Detach();
            }

            fixed (VARIANT* pVars = vars)
            {
                dispParams.rgvarg = (nint)pVars;
                dispParams.cArgs = (uint)argsCount;
            }
        }

        var id = ids[0];
        var v = new VARIANT();
        hr = disp.Invoke(id, Guid.Empty, LOCALE_USER_DEFAULT, DISPATCH_FLAGS.DISPATCH_METHOD, dispParams, (nint)(&v), 0, 0);
        if (hr.IsError)
            return false;

        using var pv = Variant.Attach(ref v);
        value = pv.Value;
        return true;
    }

    public static unsafe bool TryGetProperty(this IComObject<IDispatch>? disp, string name, out object? value) => TryGetProperty(disp?.Object, name, out value);
    public static unsafe bool TryGetProperty(this IDispatch? disp, string name, out object? value)
    {
        ArgumentNullException.ThrowIfNull(name);
        value = null;
        if (disp == null)
            return false;

        var pwstr = new Pwstr(name);
        var names = new PWSTR[] { pwstr };
        var ids = new int[names.Length];
        var hr = disp.GetIDsOfNames(Guid.Empty, names, names.Length(), LOCALE_USER_DEFAULT, ids);
        if (hr.IsError)
            return false;

        var id = ids[0];
        var v = new VARIANT();
        hr = disp.Invoke(id, Guid.Empty, LOCALE_USER_DEFAULT, DISPATCH_FLAGS.DISPATCH_PROPERTYGET, new DISPPARAMS(), (nint)(&v), 0, 0);
        if (hr.IsError)
            return false;

        using var pv = Variant.Attach(ref v);
        value = pv.Value;
        return true;
    }

    public static unsafe bool TryGetPropertyWithParameters(this IComObject<IDispatch>? disp, string name, object?[] parameters, out object? value) => TryGetPropertyWithParameters(disp?.Object, name, parameters, out value);
    public static unsafe bool TryGetPropertyWithParameters(this IDispatch? disp, string name, object?[] parameters, out object? value)
    {
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(parameters);
        value = null;
        if (disp == null)
            return false;

        var pwstr = new Pwstr(name);
        var names = new PWSTR[] { pwstr };
        var ids = new int[names.Length];
        var hr = disp.GetIDsOfNames(Guid.Empty, names, names.Length(), LOCALE_USER_DEFAULT, ids);
        if (hr.IsError)
            return false;

        var argsCount = parameters?.Length ?? 0;
        var dispParams = new DISPPARAMS();
        if (argsCount > 0)
        {
            var vars = new VARIANT[argsCount];
            for (var i = 0; i < argsCount; i++)
            {
                using var varg = new Variant(parameters![argsCount - 1 - i]);
                vars[i] = varg.Detach();
            }

            fixed (VARIANT* pVars = vars)
            {
                dispParams.rgvarg = (nint)pVars;
                dispParams.cArgs = (uint)argsCount;
            }
        }

        var id = ids[0];
        var v = new VARIANT();
        hr = disp.Invoke(id, Guid.Empty, LOCALE_USER_DEFAULT, DISPATCH_FLAGS.DISPATCH_PROPERTYGET, dispParams, (nint)(&v), 0, 0);
        if (hr.IsError)
            return false;

        using var pv = Variant.Attach(ref v);
        value = pv.Value;
        return true;
    }

    public static object? GetObjectProperty(this IComObject<IDispatch>? disp, string name, object? defaultValue = null) => GetObjectProperty(disp?.Object, name, defaultValue);
    public static object? GetObjectProperty(this IDispatch? disp, string name, object? defaultValue = null)
    {
        if (!TryGetProperty(disp, name, out object? value))
            return defaultValue;

        return value;
    }

    public static IComObject<T>? GetComObjectProperty<T>(this IComObject<IDispatch>? disp, string name) => GetComObjectProperty<T>(disp?.Object, name);
    public static IComObject<T>? GetComObjectProperty<T>(this IDispatch? disp, string name)
    {
        if (!TryGetProperty(disp, name, out object? value))
            return null;

        if (value is not System.Runtime.InteropServices.Marshalling.ComObject co)
            return null;

        return new ComObject<T>(co);
    }

    public static string? GetNullifiedProperty(this IComObject<IDispatch>? disp, string name) => GetNullifiedProperty(disp?.Object, name);
    public static string? GetNullifiedProperty(this IDispatch? disp, string name)
    {
        if (!TryGetProperty(disp, name, out string? value))
            return null;

        return value.Nullify();
    }

    public static T? GetProperty<T>(this IComObject<IDispatch>? disp, string name, T? defaultValue = default) => GetProperty(disp?.Object, name, defaultValue);
    public static T? GetProperty<T>(this IDispatch? disp, string name, T? defaultValue = default)
    {
        if (!TryGetProperty(disp, name, out T? value))
            return defaultValue;

        return value;
    }

    public static unsafe bool TryGetProperty<T>(this IComObject<IDispatch>? disp, string name, out T? value) => TryGetProperty(disp?.Object, name, out value);
    public static unsafe bool TryGetProperty<T>(this IDispatch? disp, string name, out T? value)
    {
        if (!TryGetProperty(disp, name, out object? obj))
        {
            value = default;
            return false;
        }

        // anything can be converted into a string so we need to check this case first
        if (typeof(T) == typeof(string) && obj is not string)
        {
            // handle nested IDispatch (our own implementation in DispatchObject does that)
            if (obj is IDispatch d1)
                return d1.TryGetValue(out value);
        }

        if (Conversions.TryChangeType(obj, null, out value))
            return true;

        if (obj is IDispatch d2)
            return d2.TryGetValue(out value);

        return false;
    }

    public static unsafe bool TryGetValue(this IComObject<IDispatch>? disp, out object? value) => TryGetValue(disp?.Object, out value);
    public static unsafe bool TryGetValue(this IDispatch? disp, out object? value)
    {
        value = null;
        if (disp == null)
            return false;

        var v = new VARIANT();
        var hr = disp.Invoke(0, Guid.Empty, LOCALE_USER_DEFAULT, DISPATCH_FLAGS.DISPATCH_PROPERTYGET, new DISPPARAMS(), (nint)(&v), 0, 0);
        if (hr.IsSuccess)
        {
            using var pv = Variant.Attach(ref v);
            value = pv.Value;
            return true;
        }
        return false;
    }

    public static unsafe bool TryGetValue<T>(this IComObject<IDispatch>? disp, out T? value) => TryGetValue(disp?.Object, out value);
    public static unsafe bool TryGetValue<T>(this IDispatch? disp, out T? value)
    {
        if (!TryGetValue(disp, out object? obj))
        {
            value = default;
            return false;
        }

        return Conversions.TryChangeType(obj, null, out value);
    }

    public static object? GetObjectValue(this IComObject<IDispatch>? disp, object? defaultValue = null) => GetObjectValue(disp?.Object, defaultValue);
    public static object? GetObjectValue(this IDispatch? disp, object? defaultValue = null)
    {
        if (!TryGetValue(disp, out object? value))
            return defaultValue;

        return value;
    }

    public static T? GetValue<T>(this IComObject<IDispatch>? disp, T? defaultValue = default) => GetValue(disp?.Object, defaultValue);
    public static T? GetValue<T>(this IDispatch? disp, T? defaultValue = default)
    {
        if (!TryGetValue(disp, out T? value))
            return defaultValue;

        return value;
    }

    public static string? GetNullifiedValue(this IComObject<IDispatch>? disp) => GetNullifiedValue(disp?.Object);
    public static string? GetNullifiedValue(this IDispatch? disp)
    {
        if (!TryGetValue(disp, out string? value))
            return null;

        return value.Nullify();
    }

    public static unsafe HRESULT SetProperty(this IComObject<IDispatch> disp, string name, object? value, DISPATCH_FLAGS flags = DISPATCH_FLAGS.DISPATCH_PROPERTYPUT, VARENUM? type = null, bool throwOnError = true)
        => SetProperty(disp?.Object!, name, value, flags, type, throwOnError);

    public static unsafe HRESULT SetProperty(this IDispatch disp, string name, object? value, DISPATCH_FLAGS flags = DISPATCH_FLAGS.DISPATCH_PROPERTYPUT, VARENUM? type = null, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(disp);
        ArgumentNullException.ThrowIfNull(name);

        var pwstr = new Pwstr(name);
        var names = new PWSTR[] { pwstr };
        var ids = new int[names.Length];
        var hr = disp.GetIDsOfNames(Guid.Empty, names, names.Length(), LOCALE_USER_DEFAULT, ids);
        if (hr.IsError)
            return hr;

        var dispParams = new DISPPARAMS();
        var vars = new VARIANT[1];
        using var varg = new Variant(value, type);
        vars[0] = varg.Detach();

        fixed (VARIANT* pVars = vars)
        {
            dispParams.rgvarg = (nint)pVars;
            dispParams.cArgs = 1;
        }

        var pp = DISPID.DISPID_PROPERTYPUT;
        dispParams.rgdispidNamedArgs = (nint)(&pp);
        dispParams.cNamedArgs = 1;

        var id = ids[0];
        hr = disp.Invoke(id, Guid.Empty, LOCALE_USER_DEFAULT, flags, dispParams, 0, 0, 0);
        if (hr.IsError)
            return hr;

        return Constants.S_OK;
    }
}

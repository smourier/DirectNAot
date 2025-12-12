namespace DirectN.Extensions.Utilities;

public static class Clipboard
{
    public const uint CF_HDROP = 15;
    public const uint CF_BITMAP = 2;
    public const uint CF_TEXT = 1;
    public const uint CF_UNICODETEXT = 13;
    public const string CF_RTF = "Rich Text Format";
    public const string CFSTR_SHELLIDLIST = "Shell IDList Array";
    public const string CFSTR_FILENAMEW = "FileNameW";
    public const string CFSTR_FILEDESCRIPTORW = "FileGroupDescriptorW";
    public const string CFSTR_SHELLIDLISTOFFSET = "Shell Object Offsets";
    public const string CFSTR_PREFERREDDROPEFFECT = "Preferred DropEffect";
    public const string CFSTR_PERFORMEDDROPEFFECT = "Performed DropEffect";
    public const string CFSTR_LOGICALPERFORMEDDROPEFFECT = "Logical Performed DropEffect";
    public const string CFSTR_INDRAGLOOP = "InShellDragLoop";
    public const string CFSTR_INETURL = "UniformResourceLocatorW";
    public const string CFSTR_TARGETCLSID = "TargetCLSID";
    public const string CFSTR_DROPDESCRIPTION = "DropDescription";
    public const string CFSTR_SHELLDROPHANDLER = "DropHandlerCLSID";
    public const string CFSTR_INVOKECOMMAND_DROPPARAM = "InvokeCommand DropParam";
    public const string CFSTR_PASTESUCCEEDED = "Paste Succeeded";
    public const string CFSTR_FILECONTENTS = "FileContents";

    public static void Empty() => WithClipboard(Functions.EmptyClipboard);
    public static void Flush() => WithClipboard(Functions.OleFlushClipboard);

    public static ushort RegisterFormat(string format)
    {
        ArgumentNullException.ThrowIfNull(format);
        return (ushort)Functions.RegisterClipboardFormatW(PWSTR.From(format));
    }

    public static string GetFormatName(uint format)
    {
        using var pwstr = new AllocPwstr(1024);
        if (Functions.GetClipboardFormatNameW(format, pwstr, (int)pwstr.SizeInChars) == 0)
            return format.ToString();

        return pwstr.ToString() ?? format.ToString();
    }

    public static bool IsCurrent(IDataObject? dataObject)
    {
        if (dataObject == null)
            return false;

        return Functions.OleIsCurrentClipboard(dataObject).IsOk;
    }

    public static IReadOnlyList<string> GetFormats(bool throwOnError = true) => GetDataObject(throwOnError)?.GetFormats(throwOnError) ?? [];
    public static DataObject? GetDataObject(bool throwOnError = true)
    {
        Functions.OleGetClipboard(out var obj).ThrowOnError(throwOnError);
        if (obj == null)
            return null;

        return new DataObject(new ComObject<IDataObject>(obj));
    }

    public static void SetDataObject(IComObject<IDataObject> dataObject, bool throwOnError = true) => SetDataObject(dataObject?.Object!, throwOnError);
    public static void SetDataObject(IDataObject dataObject, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(dataObject);
        Functions.OleSetClipboard(dataObject).ThrowOnError(throwOnError);
    }

    public static string? GetText() => WithClipboard(() =>
    {
        var unicode = true;
        var handle = Functions.GetClipboardData(CF_UNICODETEXT);
        if (handle == 0)
        {
            handle = Functions.GetClipboardData(CF_TEXT);
            if (handle == 0)
                return null;

            unicode = false;
        }

        var hglobal = new HGLOBAL { Value = handle.Value };
        var lok = Functions.GlobalLock(hglobal);
        if (lok == 0)
            return null;

        try
        {
            string? text;
            if (unicode)
            {
                text = Marshal.PtrToStringUni(lok);
            }
            else
            {
                text = Marshal.PtrToStringAnsi(lok);
            }
            return text;
        }
        finally
        {
            Functions.GlobalUnlock(hglobal);
        }
    });

    public static void SetText(string text) => WithClipboard(() =>
    {
        Functions.EmptyClipboard();
        if (text is null)
            return;

        var hglobal = Marshal.StringToHGlobalUni(text);
        Functions.SetClipboardData(CF_UNICODETEXT, hglobal);
    });

    public static void WithClipboard(Action action, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(action);
        if (!Functions.OpenClipboard(IntPtr.Zero))
        {
            if (throwOnError)
                throw new Win32Exception(Marshal.GetLastWin32Error());

            return;
        }

        try
        {
            action();
        }
        finally
        {
            Functions.CloseClipboard();
        }
    }

    public static T? WithClipboard<T>(Func<T> action, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(action);
        if (!Functions.OpenClipboard(IntPtr.Zero))
        {
            if (throwOnError)
                throw new Win32Exception(Marshal.GetLastWin32Error());

            return default;
        }

        try
        {
            return action();
        }
        finally
        {
            Functions.CloseClipboard();
        }
    }

    public unsafe static HRESULT TryGet<T>(this IDataObject dataObject, ushort format, out T defaultValue) where T : unmanaged
    {
        if (dataObject is null)
        {
            defaultValue = default;
            return Constants.E_POINTER;
        }

        var hr = dataObject.GetData(new FORMATETC
        {
            cfFormat = format,
            dwAspect = (uint)DVASPECT.DVASPECT_CONTENT,
            lindex = -1,
            tymed = (uint)TYMED.TYMED_HGLOBAL,
        }, out var medium);
        if (hr.IsError)
        {
            defaultValue = default;
            return hr;
        }

        try
        {
            if (medium.tymed != (uint)TYMED.TYMED_HGLOBAL || medium.u.hGlobal == 0)
            {
                defaultValue = default;
                return Constants.E_FAIL;
            }

            var ptr = Functions.GlobalLock(medium.u.hGlobal);
            if (ptr == 0)
            {
                defaultValue = default;
                return Constants.E_FAIL;
            }

            defaultValue = *(T*)ptr;
            Functions.GlobalUnlock(medium.u.hGlobal);
            return Constants.S_OK;
        }
        finally
        {
            Functions.ReleaseStgMedium(ref medium);
        }
    }

    public unsafe static T Get<T>(this IDataObject dataObject, ushort format, T defaultValue) where T : unmanaged
    {
        var hr = TryGet<T>(dataObject, format, out var value);
        if (hr.IsError)
            return defaultValue;

        return value;
    }

    public unsafe static HRESULT Set<T>(this IDataObject dataObject, ushort format, T value, bool throwOnError = true) where T : unmanaged
    {
        if (dataObject is null)
            return Constants.E_POINTER;

        var ptr = Marshal.AllocHGlobal(sizeof(T));
        *(T*)ptr = value;

        return dataObject.SetData(new FORMATETC
        {
            cfFormat = format,
            dwAspect = (uint)DVASPECT.DVASPECT_CONTENT,
            lindex = -1,
            tymed = (uint)TYMED.TYMED_HGLOBAL,
        }, new STGMEDIUM
        {
            tymed = (uint)TYMED.TYMED_HGLOBAL,
            u = new STGMEDIUM._u_e__Union { hGlobal = ptr },
        }, true).ThrowOnError(throwOnError);
    }

    public unsafe static HRESULT TryGet(this IDataObject dataObject, ushort format, out Span<byte> defaultValue)
    {
        if (dataObject is null)
        {
            defaultValue = default;
            return Constants.E_POINTER;
        }

        var hr = dataObject.GetData(new FORMATETC
        {
            cfFormat = format,
            dwAspect = (uint)DVASPECT.DVASPECT_CONTENT,
            lindex = -1,
            tymed = (uint)TYMED.TYMED_HGLOBAL,
        }, out var medium);
        if (hr.IsError)
        {
            defaultValue = default;
            return hr;
        }
        try
        {
            if (medium.tymed != (uint)TYMED.TYMED_HGLOBAL || medium.u.hGlobal == 0)
            {
                defaultValue = default;
                return Constants.E_FAIL;
            }

            var ptr = Functions.GlobalLock(medium.u.hGlobal);
            if (ptr == 0)
            {
                defaultValue = default;
                return Constants.E_FAIL;
            }

            var size = Functions.GlobalSize(medium.u.hGlobal);
            defaultValue = new Span<byte>(ptr.ToPointer(), (int)size);
            Functions.GlobalUnlock(medium.u.hGlobal);
            return Constants.S_OK;
        }
        finally
        {
            Functions.ReleaseStgMedium(ref medium);
        }
    }

    public unsafe static HRESULT Set(this IDataObject dataObject, ushort format, ReadOnlySpan<byte> bytes, bool throwOnError = true)
    {
        if (dataObject is null)
            return Constants.E_POINTER;

        var ptr = Marshal.AllocHGlobal(bytes.Length);
        bytes.CopyTo(new Span<byte>(ptr.ToPointer(), bytes.Length));

        return dataObject.SetData(new FORMATETC
        {
            cfFormat = format,
            dwAspect = (uint)DVASPECT.DVASPECT_CONTENT,
            lindex = -1,
            tymed = (uint)TYMED.TYMED_HGLOBAL,
        }, new STGMEDIUM
        {
            tymed = (uint)TYMED.TYMED_HGLOBAL,
            u = new STGMEDIUM._u_e__Union { hGlobal = ptr },
        }, true).ThrowOnError(throwOnError);
    }

    public static bool Has(this IDataObject dataObject, ushort format)
    {
        if (dataObject is null)
            return false;

        return dataObject.QueryGetData(new FORMATETC { cfFormat = format, tymed = (uint)TYMED.TYMED_HGLOBAL }).IsOk;
    }

    public unsafe static HRESULT Set(this IDataObject dataObject, ushort format, bool throwOnError = true)
    {
        if (dataObject is null)
            return Constants.E_POINTER;

        return dataObject.SetData(new FORMATETC
        {
            cfFormat = format,
            tymed = (uint)TYMED.TYMED_HGLOBAL,
        }, new STGMEDIUM
        {
            tymed = (uint)TYMED.TYMED_HGLOBAL,
        }, true).ThrowOnError(throwOnError);
    }
}

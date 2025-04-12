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

    public static uint RegisterFormat(string format)
    {
        ArgumentNullException.ThrowIfNull(format);
        return Functions.RegisterClipboardFormatW(PWSTR.From(format));
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
}

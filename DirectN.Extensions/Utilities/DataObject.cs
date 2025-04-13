namespace DirectN.Extensions.Utilities;

public class DataObject(IComObject<IDataObject>? dataObject, bool owned = true) : InterlockedComObject<IDataObject>(dataObject)
{
    [SupportedOSPlatform("windows6.0.6000")]
    public static DataObject Create()
    {
        // note this data object only supports SetData(..., ..., true); (release)
        Functions.SHCreateDataObject(0, 0, 0, null, typeof(IDataObject).GUID, out var obj).ThrowOnError();
        return new DataObject(new ComObject<IDataObject>(obj));
    }

    public bool Owned { get; } = owned;

    protected override IComObject<IDataObject>? ExchangeDisposable(IComObject<IDataObject>? disposable) => throw new NotSupportedException();
    protected override void Dispose(bool disposing)
    {
        if (!Owned)
            return;

        base.Dispose(disposing);
    }

    public IReadOnlyList<string> GetFormats(bool throwOnError = true)
    {
        var list = new List<string>();
        foreach (var fmt in EnumerateFormats(throwOnError))
        {
            list.Add(Clipboard.GetFormatName(fmt.cfFormat));
            if (fmt.ptd != 0)
            {
                Marshal.FreeCoTaskMem(fmt.ptd);
            }
        }
        return list;
    }

    public unsafe IEnumerable<FORMATETC> EnumerateFormats(bool throwOnError)
    {
        var list = new List<FORMATETC>();
        ComObject.Object.EnumFormatEtc((uint)DATADIR.DATADIR_GET, out var obj).ThrowOnError(throwOnError);
        if (obj != null)
        {
            using var formats = new ComObject<IEnumFORMATETC>(obj);
            uint fetched = 0;
            var format = new FORMATETC[1];
            do
            {
                formats.Object.Next(1, format, (nint)(&fetched));
                if (fetched > 0)
                {
                    list.Add(format[0]);
                }
            }
            while (fetched > 0);
        }
        return list;
    }

    public byte[]? GetBytes(string format, int? index = null, bool throwOnError = true) => GetBytes(Functions.RegisterClipboardFormatW(PWSTR.From(format)), index, throwOnError);
    public byte[]? GetBytes(uint format, int? index = null, bool throwOnError = true)
    {
        using var stream = GetStream(format, index, throwOnError);
        if (stream == null)
            return null;

        return stream.ToByteArray();
    }

    public Stream? GetStream(string format, int? index = null, bool throwOnError = true) => GetStream(Functions.RegisterClipboardFormatW(PWSTR.From(format)), index, throwOnError);
    public Stream? GetStream(uint format, int? index = null, bool throwOnError = true)
    {
        var formats = EnumerateFormats(throwOnError);
        FORMATETC fmt;
        if (index.HasValue)
        {
            fmt = formats.FirstOrDefault(f => f.cfFormat == (short)format && f.lindex == index.Value);
        }
        else
        {
            fmt = formats.FirstOrDefault(f => f.cfFormat == (short)format);
        }

        using var medium = ComObject.GetStorageMedium(fmt);
        return medium?.GetDetachedStream();
    }

    public unsafe IReadOnlyList<string> GetFilesPath(bool throwOnError = true)
    {
        var list = new List<string>();
        var bytes = GetBytes(Clipboard.CF_HDROP, throwOnError: throwOnError);
        if (bytes != null)
        {
            fixed (void* ptr = bytes)
            {
                var dropFiles = Unsafe.Read<DROPFILES>(ptr);
                var offset = (int)dropFiles.pFiles;
                if (dropFiles.fWide)
                {
                    for (var i = (int)dropFiles.pFiles; i < bytes.Length; i += 2)
                    {
                        if (bytes[i] == 0 && bytes[i + 1] == 0)
                        {
                            if (i > (offset + 2))
                            {
                                var s = Encoding.Unicode.GetString(bytes, offset, i - offset);
                                list.Add(s);
                                offset = i + 2;
                            }
                        }
                    }
                }
                else
                {
                    for (var i = (int)dropFiles.pFiles; i < bytes.Length; i++)
                    {
                        if (bytes[i] == 0)
                        {
                            if (i > (offset + 1))
                            {
                                var s = Encoding.Default.GetString(bytes, offset, i - offset);
                                list.Add(s);
                                offset = i + 1;
                            }
                        }
                    }
                }
            }
        }
        return list;
    }
}

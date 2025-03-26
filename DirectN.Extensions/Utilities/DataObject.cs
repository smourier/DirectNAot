namespace DirectN.Extensions.Utilities;

public class DataObject(IComObject<IDataObject>? dataObject) : InterlockedComObject<IDataObject>(dataObject)
{
    public unsafe IReadOnlyList<string> GetDataFormats(bool throwOnError = true)
    {
        var list = new List<string>();
        const uint DATADIR_GET = 1;
        ComObject.Object.EnumFormatEtc(DATADIR_GET, out var obj).ThrowOnError(throwOnError);
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
                    list.Add(Clipboard.GetFormatName(format[0].cfFormat));
                    if (format[0].ptd != 0)
                    {
                        Marshal.FreeCoTaskMem(format[0].ptd);
                    }
                }
            }
            while (fetched > 0);
        }
        return list;
    }
}

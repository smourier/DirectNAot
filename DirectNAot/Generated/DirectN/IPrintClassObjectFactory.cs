namespace DirectN;

[GeneratedComInterface, Guid("9af593dd-9b02-48a8-9bad-69ace423f88b")]
public partial interface IPrintClassObjectFactory
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPrintClassObject(PWSTR pszPrinterName, in Guid riid, out nint ppNewObject);
}

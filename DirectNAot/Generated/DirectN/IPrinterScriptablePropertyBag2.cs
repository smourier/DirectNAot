namespace DirectN;

[GeneratedComInterface, Guid("2a1c53c4-8638-4b3e-b518-2773c94556a3")]
public partial interface IPrinterScriptablePropertyBag2 : IPrinterScriptablePropertyBag
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetReadStreamAsXML(BSTR bstrName, out nint ppXmlNode);
}

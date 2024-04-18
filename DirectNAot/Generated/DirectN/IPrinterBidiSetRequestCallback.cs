namespace DirectN;

[GeneratedComInterface, Guid("c52d32dd-f2b4-4052-8502-ec4305ecb71f")]
public partial interface IPrinterBidiSetRequestCallback
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Completed(BSTR bstrResponse, [MarshalAs(UnmanagedType.Error)] HRESULT hrStatus);
}

namespace DirectN;

[GeneratedComInterface, Guid("2072838a-316f-467a-a949-27f68c44a854")]
public partial interface IPrinterScriptableSequentialStream : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Read(int cbRead, out IDispatch ppArray);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Write(IDispatch pArray, out int pcbWritten);
}

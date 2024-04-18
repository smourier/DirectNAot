namespace DirectN;

[GeneratedComInterface, Guid("7edf9a92-4750-41a5-a17f-879a6f4f7dcb")]
public partial interface IPrinterScriptableStream : IPrinterScriptableSequentialStream
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Commit();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Seek(int lOffset, STREAM_SEEK streamSeek, out int plPosition);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetSize(int lSize);
}

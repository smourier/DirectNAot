namespace DirectN;

[GeneratedComInterface, Guid("07d11ff8-1753-4873-b749-6cdaf068e4c3")]
public partial interface IPrintWriteStreamFlush
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT FlushData();
}

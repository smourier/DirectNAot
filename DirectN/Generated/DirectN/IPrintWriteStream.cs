#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("65bb7f1b-371e-4571-8ac7-912f510c1a38")]
public partial interface IPrintWriteStream
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteBytes(nint pvBuffer, uint cbBuffer, out uint pcbWritten);
    
    [PreserveSig]
    void Close();
}

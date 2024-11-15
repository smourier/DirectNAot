#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("4d47a67c-66cc-4430-850e-daf466fe5bc4")]
public partial interface IPrintReadStream
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Seek(long dlibMove, uint dwOrigin, nint /* optional ulong* */ plibNewPosition);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReadBytes(nint pvBuffer, uint cbRequested, out uint pcbRead, out BOOL pbEndOfFile);
}

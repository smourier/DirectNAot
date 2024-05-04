#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("00000000-0000-0000-0000-000000000000")]
public partial interface GdiplusAbort
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Abort();
}

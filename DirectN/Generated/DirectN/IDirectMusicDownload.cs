#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("d2ac287b-b39b-11d1-8704-00600893b1bd")]
public partial interface IDirectMusicDownload
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBuffer(out nint ppvBuffer, ref uint pdwSize);
}

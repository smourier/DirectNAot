#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("1e00486a-78dd-11d2-8dd3-006097c9a2b2")]
public partial interface IBufferingTime
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBufferingTime(ref uint pdwMilliseconds);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBufferingTime(uint dwMilliseconds);
}

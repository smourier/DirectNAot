#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amstream/nn-amstream-idirectdrawmediasampleallocator
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("ab6b4afc-f6e4-11d0-900d-00c04fd9189d")]
public partial interface IDirectDrawMediaSampleAllocator
{
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-idirectdrawmediasampleallocator-getdirectdraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDirectDraw([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectDraw>))] out IDirectDraw ppDirectDraw);
}

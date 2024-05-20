#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddstream/nn-ddstream-idirectdrawstreamsample
[GeneratedComInterface, Guid("f4104fcf-9a70-11d0-8fde-00c04fd9189d")]
public partial interface IDirectDrawStreamSample : IStreamSample
{
    // https://learn.microsoft.com/windows/win32/api/ddstream/nf-ddstream-idirectdrawstreamsample-getsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSurface(out IDirectDrawSurface ppDirectDrawSurface, out RECT pRect);
    
    // https://learn.microsoft.com/windows/win32/api/ddstream/nf-ddstream-idirectdrawstreamsample-setrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRect(in RECT pRect);
}

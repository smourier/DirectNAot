#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/presentation/nn-presentation-ipresentationbuffer
[GeneratedComInterface, Guid("2e217d3a-5abb-4138-9a13-a775593c89ca")]
public partial interface IPresentationBuffer
{
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationbuffer-getavailableevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAvailableEvent(out HANDLE availableEventHandle);
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationbuffer-isavailable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsAvailable(nint /* byte array */ isAvailable);
}

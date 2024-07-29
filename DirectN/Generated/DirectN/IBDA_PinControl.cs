#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_pincontrol
[GeneratedComInterface, Guid("0ded49d5-a8b7-4d5d-97a1-12b0c195874d")]
public partial interface IBDA_PinControl
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_pincontrol-getpinid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPinID(ref uint pulPinID);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_pincontrol-getpintype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPinType(ref uint pulPinType);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_pincontrol-registrationcontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegistrationContext(ref uint pulRegistrationCtx);
}

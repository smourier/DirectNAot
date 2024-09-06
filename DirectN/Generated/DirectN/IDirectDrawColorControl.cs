#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddraw/nn-ddraw-idirectdrawcolorcontrol
[GeneratedComInterface, Guid("4b9f0ee0-0d7e-11d0-9b06-00a0c903a3b8")]
public partial interface IDirectDrawColorControl
{
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawcolorcontrol-getcolorcontrols
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColorControls(ref DDCOLORCONTROL param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawcolorcontrol-setcolorcontrols
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetColorControls(ref DDCOLORCONTROL param0);
}

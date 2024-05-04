#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mixerocx/nn-mixerocx-imixerocxnotify
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("81a3bd31-dee1-11d1-8508-00a0c91f9ca0")]
public partial interface IMixerOCXNotify
{
    // https://learn.microsoft.com/windows/win32/api/mixerocx/nf-mixerocx-imixerocxnotify-oninvalidaterect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnInvalidateRect(in RECT lpcRect);
    
    // https://learn.microsoft.com/windows/win32/api/mixerocx/nf-mixerocx-imixerocxnotify-onstatuschange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnStatusChange(uint ulStatusFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mixerocx/nf-mixerocx-imixerocxnotify-ondatachange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDataChange(uint ulDataFlags);
}

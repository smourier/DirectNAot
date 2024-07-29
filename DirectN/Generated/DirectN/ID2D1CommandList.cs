#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/nn-d2d1_1-id2d1commandlist
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("b4f34a19-2383-4d76-94f6-ec343657c3dc")]
public partial interface ID2D1CommandList : ID2D1Image
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandlist-stream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stream(ID2D1CommandSink sink);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandlist-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
}

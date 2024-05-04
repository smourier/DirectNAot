#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("4c06bb9b-626c-4614-8329-cc6a21b93fa0")]
public partial interface IWMFrameInterpProps
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFrameRateIn(int lFrameRate, int lScale);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFrameRateOut(int lFrameRate, int lScale);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFrameInterpEnabled([MarshalAs(UnmanagedType.U4)] bool bFIEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetComplexityLevel(int iComplexity);
}

namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgidebug/nn-dxgidebug-idxgidebug
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("119e7452-de9e-40fe-8806-88f90c12b441")]
public partial interface IDXGIDebug
{
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgidebug-reportliveobjects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ReportLiveObjects(Guid apiid, DXGI_DEBUG_RLO_FLAGS flags);
}

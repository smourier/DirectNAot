#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositionvisualdebug
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("fed2b808-5eb4-43a0-aea3-35f65280f91b")]
public partial interface IDCompositionVisualDebug : IDCompositionVisual2
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisualdebug-enableheatmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnableHeatMap(in D3DCOLORVALUE color);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisualdebug-disableheatmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisableHeatMap();
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisualdebug-enableredrawregions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnableRedrawRegions();
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisualdebug-disableredrawregions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisableRedrawRegions();
}

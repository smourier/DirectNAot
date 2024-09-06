#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositiontarget
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("eacdd04c-117e-4e17-88f4-d1b12b0e3d89")]
public partial interface IDCompositionTarget
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontarget-setroot
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRoot(IDCompositionVisual? visual);
}

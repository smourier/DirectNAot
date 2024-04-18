namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositionfiltereffect
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("30c421d5-8cb2-4e9f-b133-37be270d4ac2")]
public partial interface IDCompositionFilterEffect : IDCompositionEffect
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionfiltereffect-setinput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetInput(uint index, nint input, uint flags);
}

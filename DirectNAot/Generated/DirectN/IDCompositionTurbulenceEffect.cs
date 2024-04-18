namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositionturbulenceeffect
[GeneratedComInterface, Guid("a6a55bda-c09c-49f3-9193-a41922c89715")]
public partial interface IDCompositionTurbulenceEffect : IDCompositionFilterEffect
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionturbulenceeffect-setoffset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetOffset(in D2D_VECTOR_2F offset);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionturbulenceeffect-setbasefrequency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBaseFrequency(in D2D_VECTOR_2F frequency);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionturbulenceeffect-setsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetSize(in D2D_VECTOR_2F size);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionturbulenceeffect-setnumoctaves
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetNumOctaves(uint numOctaves);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionturbulenceeffect-setseed
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetSeed(uint seed);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionturbulenceeffect-setnoise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetNoise(D2D1_TURBULENCE_NOISE noise);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionturbulenceeffect-setstitchable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetStitchable([MarshalAs(UnmanagedType.U4)] bool stitchable);
}

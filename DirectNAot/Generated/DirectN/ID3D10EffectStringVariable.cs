namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10effectstringvariable
[GeneratedComInterface, Guid("71417501-8df9-4e0a-a78a-255f9756baff")]
public partial interface ID3D10EffectStringVariable : ID3D10EffectVariable
{
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectstringvariable-getstring
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetString(out PSTR ppString);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectstringvariable-getstringarray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetStringArray(out PSTR ppStrings, uint Offset, uint Count);
}

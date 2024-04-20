namespace DirectN;

[GeneratedComInterface, Guid("06b64f9e-7fda-11d2-b4f2-00c04f797396")]
public partial interface IEnumSpObjectTokens
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, out ISpObjectToken pelt, nint /* optional uint */ pceltFetched);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out IEnumSpObjectTokens ppEnum);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Item(uint Index, out ISpObjectToken ppToken);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(ref uint pCount);
}

namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/comcat/nn-comcat-ienumguid
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("0002e000-0000-0000-c000-000000000046")]
public partial interface IEnumGUID
{
    // https://learn.microsoft.com/windows/win32/api/comcat/nf-comcat-ienumguid-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, out Guid rgelt, nint/* nint */ pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/comcat/nf-comcat-ienumguid-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/comcat/nf-comcat-ienumguid-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/comcat/nf-comcat-ienumguid-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out IEnumGUID ppenum);
}

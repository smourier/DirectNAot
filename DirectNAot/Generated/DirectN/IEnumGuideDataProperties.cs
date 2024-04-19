namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdatif/nn-bdatif-ienumguidedataproperties
[GeneratedComInterface, Guid("ae44423b-4571-475c-ad2c-f40a771d80ef")]
public partial interface IEnumGuideDataProperties
{
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-ienumguidedataproperties-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, out IGuideDataProperty ppprop, out uint pcelt);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-ienumguidedataproperties-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-ienumguidedataproperties-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-ienumguidedataproperties-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out IEnumGuideDataProperties ppenum);
}

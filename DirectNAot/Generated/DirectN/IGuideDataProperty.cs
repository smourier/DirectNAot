#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdatif/nn-bdatif-iguidedataproperty
[GeneratedComInterface, Guid("88ec5e58-bb73-41d6-99ce-66c524b8b591")]
public partial interface IGuideDataProperty
{
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-iguidedataproperty-get_name
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Name(out BSTR pbstrName);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-iguidedataproperty-get_language
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Language(out int idLang);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-iguidedataproperty-get_value
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Value(out VARIANT pvar);
}

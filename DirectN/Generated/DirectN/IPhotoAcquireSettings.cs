#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/photoacquire/nn-photoacquire-iphotoacquiresettings
[GeneratedComInterface, Guid("00f2b868-dd67-487c-9553-049240767e91")]
public partial interface IPhotoAcquireSettings
{
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquiresettings-initializefromregistry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeFromRegistry(PWSTR pszRegistryKey);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquiresettings-setflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFlags(uint dwPhotoAcquireFlags);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquiresettings-setoutputfilenametemplate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputFilenameTemplate(PWSTR pszTemplate);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquiresettings-setsequencepaddingwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSequencePaddingWidth(uint dwWidth);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquiresettings-setsequencezeropadding
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSequenceZeroPadding(BOOL fZeroPad);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquiresettings-setgrouptag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGroupTag(PWSTR pszGroupTag);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquiresettings-setacquisitiontime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAcquisitionTime(in FILETIME pftAcquisitionTime);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquiresettings-getflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFlags(out uint pdwPhotoAcquireFlags);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquiresettings-getoutputfilenametemplate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputFilenameTemplate(out BSTR pbstrTemplate);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquiresettings-getsequencepaddingwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSequencePaddingWidth(out uint pdwWidth);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquiresettings-getsequencezeropadding
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSequenceZeroPadding(out BOOL pfZeroPad);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquiresettings-getgrouptag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGroupTag(out BSTR pbstrGroupTag);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquiresettings-getacquisitiontime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAcquisitionTime(out FILETIME pftAcquisitionTime);
}

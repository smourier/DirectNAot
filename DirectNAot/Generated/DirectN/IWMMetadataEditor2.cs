namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmmetadataeditor2
[GeneratedComInterface, Guid("203cffe3-2e18-4fdf-b59d-6e71530534cf")]
public partial interface IWMMetadataEditor2 : IWMMetadataEditor
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmmetadataeditor2-openex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenEx(PWSTR pwszFilename, uint dwDesiredAccess, uint dwShareMode);
}

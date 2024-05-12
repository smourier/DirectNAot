#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wcsplugin/nn-wcsplugin-igamutmapmodelplugin
[GeneratedComInterface, Guid("2dd80115-ad1e-41f6-a219-a4f4b583d1f9")]
public partial interface IGamutMapModelPlugIn
{
    // https://learn.microsoft.com/windows/win32/api/wcsplugin/nf-wcsplugin-igamutmapmodelplugin-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(BSTR bstrXml, IDeviceModelPlugIn pSrcPlugIn, IDeviceModelPlugIn pDestPlugIn, in GamutBoundaryDescription pSrcGBD, in GamutBoundaryDescription pDestGBD);
    
    // https://learn.microsoft.com/windows/win32/api/wcsplugin/nf-wcsplugin-igamutmapmodelplugin-sourcetodestinationappearancecolors
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SourceToDestinationAppearanceColors(uint cColors, [MarshalUsing(CountElementName = nameof(cColors))] in JChColorF[] pInputColors, [In][Out][MarshalUsing(CountElementName = nameof(cColors))] JChColorF[] pOutputColors);
}

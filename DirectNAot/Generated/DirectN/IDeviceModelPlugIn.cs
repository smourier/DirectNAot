#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wcsplugin/nn-wcsplugin-idevicemodelplugin
[GeneratedComInterface, Guid("1cd63475-07c4-46fe-a903-d655316d11fd")]
public partial interface IDeviceModelPlugIn
{
    // https://learn.microsoft.com/windows/win32/api/wcsplugin/nf-wcsplugin-idevicemodelplugin-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(BSTR bstrXml, uint cNumModels, uint iModelPosition);
    
    // https://learn.microsoft.com/windows/win32/api/wcsplugin/nf-wcsplugin-idevicemodelplugin-getnumchannels
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNumChannels(out uint pNumChannels);
    
    // https://learn.microsoft.com/windows/win32/api/wcsplugin/nf-wcsplugin-idevicemodelplugin-devicetocolorimetriccolors
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeviceToColorimetricColors(uint cColors, uint cChannels, in float pDeviceValues, [In][Out][MarshalUsing(CountElementName = nameof(cColors))] XYZColorF[] pXYZColors);
    
    // https://learn.microsoft.com/windows/win32/api/wcsplugin/nf-wcsplugin-idevicemodelplugin-colorimetrictodevicecolors
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ColorimetricToDeviceColors(uint cColors, uint cChannels, [MarshalUsing(CountElementName = nameof(cColors))] in XYZColorF[] pXYZColors, out float pDeviceValues);
    
    // https://learn.microsoft.com/windows/win32/api/wcsplugin/nf-wcsplugin-idevicemodelplugin-colorimetrictodevicecolorswithblack
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ColorimetricToDeviceColorsWithBlack(uint cColors, uint cChannels, [MarshalUsing(CountElementName = nameof(cColors))] in XYZColorF[] pXYZColors, [MarshalUsing(CountElementName = nameof(cColors))] in BlackInformation[] pBlackInformation, out float pDeviceValues);
    
    // https://learn.microsoft.com/windows/win32/api/wcsplugin/nf-wcsplugin-idevicemodelplugin-settransformdevicemodelinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTransformDeviceModelInfo(uint iModelPosition, IDeviceModelPlugIn pIDeviceModelOther);
    
    // https://learn.microsoft.com/windows/win32/api/wcsplugin/nf-wcsplugin-idevicemodelplugin-getprimarysamples
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPrimarySamples(out PrimaryXYZColors pPrimaryColor);
    
    // https://learn.microsoft.com/windows/win32/api/wcsplugin/nf-wcsplugin-idevicemodelplugin-getgamutboundarymeshsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGamutBoundaryMeshSize(out uint pNumVertices, out uint pNumTriangles);
    
    // https://learn.microsoft.com/windows/win32/api/wcsplugin/nf-wcsplugin-idevicemodelplugin-getgamutboundarymesh
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGamutBoundaryMesh(uint cChannels, uint cVertices, uint cTriangles, out float pVertices, [In][Out][MarshalUsing(CountElementName = nameof(cTriangles))] GamutShellTriangle[] pTriangles);
    
    // https://learn.microsoft.com/windows/win32/api/wcsplugin/nf-wcsplugin-idevicemodelplugin-getneutralaxissize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNeutralAxisSize(out uint pcColors);
    
    // https://learn.microsoft.com/windows/win32/api/wcsplugin/nf-wcsplugin-idevicemodelplugin-getneutralaxis
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNeutralAxis(uint cColors, [In][Out][MarshalUsing(CountElementName = nameof(cColors))] XYZColorF[] pXYZColors);
}

#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ivmrimagepresenterexclmodeconfig
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("e6f7ce40-4673-44f1-8f77-5499d68cb4ea")]
public partial interface IVMRImagePresenterExclModeConfig : IVMRImagePresenterConfig
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrimagepresenterexclmodeconfig-setxlcmodeddobjandprimarysurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetXlcModeDDObjAndPrimarySurface(IDirectDraw7 lpDDObj, IDirectDrawSurface7 lpPrimarySurf);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrimagepresenterexclmodeconfig-getxlcmodeddobjandprimarysurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetXlcModeDDObjAndPrimarySurface([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectDraw7>))] out IDirectDraw7 lpDDObj, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectDrawSurface7>))] out IDirectDrawSurface7 lpPrimarySurf);
}

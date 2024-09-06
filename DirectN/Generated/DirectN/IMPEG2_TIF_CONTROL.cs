#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdatif/nn-bdatif-impeg2_tif_control
[GeneratedComInterface, Guid("f9bac2f9-4149-4916-b2ef-faa202326862")]
public partial interface IMPEG2_TIF_CONTROL
{
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-impeg2_tif_control-registertif
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterTIF(nint pUnkTIF, ref uint ppvRegistrationContext);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-impeg2_tif_control-unregistertif
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterTIF(uint pvRegistrationContext);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-impeg2_tif_control-addpids
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddPIDs(uint ulcPIDs, in uint pulPIDs);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-impeg2_tif_control-deletepids
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeletePIDs(uint ulcPIDs, in uint pulPIDs);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-impeg2_tif_control-getpidcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPIDCount(out uint pulcPIDs);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-impeg2_tif_control-getpids
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPIDs(out uint pulcPIDs, out uint pulPIDs);
}

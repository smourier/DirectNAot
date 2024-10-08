﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_2/nn-dxgi1_2-idxgioutput1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("00cddea8-939b-4b83-a340-a685226666cc")]
public partial interface IDXGIOutput1 : IDXGIOutput
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgioutput1-getdisplaymodelist1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplayModeList1(DXGI_FORMAT EnumFormat, DXGI_ENUM_MODES Flags, ref uint pNumModes, nint /* optional DXGI_MODE_DESC1* */ pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgioutput1-findclosestmatchingmode1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindClosestMatchingMode1(in DXGI_MODE_DESC1 pModeToMatch, out DXGI_MODE_DESC1 pClosestMatch, nint pConcernedDevice);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgioutput1-getdisplaysurfacedata1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplaySurfaceData1([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIResource>))] IDXGIResource pDestination);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgioutput1-duplicateoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DuplicateOutput(nint pDevice, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIOutputDuplication>))] out IDXGIOutputDuplication ppOutputDuplication);
}

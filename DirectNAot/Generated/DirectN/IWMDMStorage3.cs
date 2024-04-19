﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iwmdmstorage3
[GeneratedComInterface, Guid("97717eea-926a-464e-96a4-247b0216026e")]
public partial interface IWMDMStorage3 : IWMDMStorage2
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstorage3-getmetadata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMetadata(out IWMDMMetaData ppMetadata);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstorage3-setmetadata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMetadata(IWMDMMetaData pMetadata);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstorage3-createemptymetadataobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateEmptyMetadataObject(out IWMDMMetaData ppMetadata);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstorage3-setenumpreference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEnumPreference(ref WMDM_STORAGE_ENUM_MODE pMode, uint nViews, nint/* nint */ pViews);
}

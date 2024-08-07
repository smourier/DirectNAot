﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mediaobj/nn-mediaobj-ienumdmo
[GeneratedComInterface, Guid("2c3cd98a-2bfa-4a53-9c27-5249ba64ba0f")]
public partial interface IEnumDMO
{
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-ienumdmo-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint cItemsToFetch, [In][Out][MarshalUsing(CountElementName = nameof(cItemsToFetch))] Guid[] pCLSID, [In][Out][MarshalUsing(CountElementName = nameof(cItemsToFetch))] PWSTR[] Names, out uint pcItemsFetched);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-ienumdmo-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint cItemsToSkip);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-ienumdmo-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-ienumdmo-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumDMO>))] out IEnumDMO ppEnum);
}

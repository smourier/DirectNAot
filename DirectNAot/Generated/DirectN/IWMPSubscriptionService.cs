﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/subscriptionservices/nn-subscriptionservices-iwmpsubscriptionservice
[GeneratedComInterface, Guid("376055f8-2a59-4a73-9501-dca5273a7a10")]
public partial interface IWMPSubscriptionService
{
    // https://learn.microsoft.com/windows/win32/api/subscriptionservices/nf-subscriptionservices-iwmpsubscriptionservice-allowplay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT allowPlay(HWND hwnd, IWMPMedia pMedia, [MarshalAs(UnmanagedType.U4)] ref bool pfAllowPlay);
    
    // https://learn.microsoft.com/windows/win32/api/subscriptionservices/nf-subscriptionservices-iwmpsubscriptionservice-allowcdburn
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT allowCDBurn(HWND hwnd, IWMPPlaylist pPlaylist, [MarshalAs(UnmanagedType.U4)] ref bool pfAllowBurn);
    
    // https://learn.microsoft.com/windows/win32/api/subscriptionservices/nf-subscriptionservices-iwmpsubscriptionservice-allowpdatransfer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT allowPDATransfer(HWND hwnd, IWMPPlaylist pPlaylist, [MarshalAs(UnmanagedType.U4)] ref bool pfAllowTransfer);
    
    // https://learn.microsoft.com/windows/win32/api/subscriptionservices/nf-subscriptionservices-iwmpsubscriptionservice-startbackgroundprocessing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT startBackgroundProcessing(HWND hwnd);
}

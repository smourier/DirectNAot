﻿#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("6c44df74-72b9-4992-a1ec-ef996e0422d4")]
public partial interface ISpVoice : ISpEventSource
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutput(nint pUnkOutput, BOOL fAllowFormatChanges);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputObjectToken([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpObjectToken>))] out ISpObjectToken ppObjectToken);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpStreamFormat>))] out ISpStreamFormat ppStream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Pause();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Resume();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVoice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpObjectToken>))] ISpObjectToken pToken);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVoice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpObjectToken>))] out ISpObjectToken ppToken);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Speak(PWSTR pwcs, uint dwFlags, nint /* optional uint* */ pulStreamNumber);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SpeakStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream pStream, uint dwFlags, nint /* optional uint* */ pulStreamNumber);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatus(ref SPVOICESTATUS pStatus, out PWSTR ppszLastBookmark);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(PWSTR pItemType, int lNumItems, ref uint pulNumSkipped);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPriority(SPVPRIORITY ePriority);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPriority(ref SPVPRIORITY pePriority);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAlertBoundary(SPEVENTENUM eBoundary);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAlertBoundary(ref SPEVENTENUM peBoundary);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRate(int RateAdjust);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRate(ref int pRateAdjust);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVolume(ushort usVolume);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVolume(ref ushort pusVolume);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WaitUntilDone(uint msTimeout);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSyncSpeakTimeout(uint msTimeout);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSyncSpeakTimeout(ref uint pmsTimeout);
    
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    HANDLE SpeakCompleteEvent();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsUISupported(PWSTR pszTypeOfUI, nint pvExtraData, uint cbExtraData, ref BOOL pfSupported);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisplayUI(HWND hwndParent, PWSTR pszTitle, PWSTR pszTypeOfUI, nint pvExtraData, uint cbExtraData);
}

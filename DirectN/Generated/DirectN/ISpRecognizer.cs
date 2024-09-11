#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("c2b5f241-daa0-4507-9e16-5a1eaa2b7a5c")]
public partial interface ISpRecognizer : ISpProperties
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRecognizer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpObjectToken>))] ISpObjectToken pRecognizer);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecognizer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpObjectToken>))] out ISpObjectToken ppRecognizer);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInput(nint pUnkInput, BOOL fAllowFormatChanges);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputObjectToken([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpObjectToken>))] out ISpObjectToken ppToken);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpStreamFormat>))] out ISpStreamFormat ppStream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRecoContext([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpRecoContext>))] out ISpRecoContext ppNewCtxt);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecoProfile([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpObjectToken>))] out ISpObjectToken ppToken);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRecoProfile([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpObjectToken>))] ISpObjectToken pToken);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsSharedInstance();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecoState(ref SPRECOSTATE pState);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRecoState(SPRECOSTATE NewState);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatus(ref SPRECOGNIZERSTATUS pStatus);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormat(SPSTREAMFORMATTYPE WaveFormatType, ref Guid pFormatId, out nint ppCoMemWFEX);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsUISupported(PWSTR pszTypeOfUI, nint pvExtraData, uint cbExtraData, ref BOOL pfSupported);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisplayUI(HWND hwndParent, PWSTR pszTitle, PWSTR pszTypeOfUI, nint pvExtraData, uint cbExtraData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EmulateRecognition([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpPhrase>))] ISpPhrase pPhrase);
}

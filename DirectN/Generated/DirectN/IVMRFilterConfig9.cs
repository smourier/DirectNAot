#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/nn-vmr9-ivmrfilterconfig9
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("5a804648-4f66-4867-9c43-4f5c822cf1b8")]
public partial interface IVMRFilterConfig9
{
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrfilterconfig9-setimagecompositor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetImageCompositor([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IVMRImageCompositor9>))] IVMRImageCompositor9 lpVMRImgCompositor);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrfilterconfig9-setnumberofstreams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNumberOfStreams(uint dwMaxStreams);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrfilterconfig9-getnumberofstreams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNumberOfStreams(out uint pdwMaxStreams);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrfilterconfig9-setrenderingprefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRenderingPrefs(uint dwRenderFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrfilterconfig9-getrenderingprefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRenderingPrefs(out uint pdwRenderFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrfilterconfig9-setrenderingmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRenderingMode(uint Mode);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrfilterconfig9-getrenderingmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRenderingMode(out uint pMode);
}

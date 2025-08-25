#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("79eac9c1-baf9-11ce-8c82-00aa004ba90b")]
public partial interface IBindStatusCallback
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnStartBinding(uint dwReserved, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBinding>))] IBinding pib);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPriority(out int pnPriority);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnLowResource(uint reserved);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnProgress(uint ulProgress, uint ulProgressMax, uint ulStatusCode, PWSTR szStatusText);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnStopBinding(HRESULT hresult, PWSTR szError);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBindInfo(out uint grfBINDF, ref BINDINFO pbindinfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDataAvailable(uint grfBSCF, uint dwSize, in FORMATETC pformatetc, in STGMEDIUM pstgmed);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnObjectAvailable(in Guid riid, nint punk);
}

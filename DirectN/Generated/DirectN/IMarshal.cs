#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidlbase/nn-objidlbase-imarshal
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000003-0000-0000-c000-000000000046")]
public partial interface IMarshal
{
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imarshal-getunmarshalclass
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUnmarshalClass(in Guid riid, nint /* optional void* */ pv, uint dwDestContext, nint /* optional void* */ pvDestContext, uint mshlflags, out Guid pCid);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imarshal-getmarshalsizemax
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMarshalSizeMax(in Guid riid, nint /* optional void* */ pv, uint dwDestContext, nint /* optional void* */ pvDestContext, uint mshlflags, out uint pSize);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-imarshal-marshalinterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MarshalInterface(IStream pStm, in Guid riid, nint /* optional void* */ pv, uint dwDestContext, nint /* optional void* */ pvDestContext, uint mshlflags);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-imarshal-unmarshalinterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnmarshalInterface(IStream pStm, in Guid riid, out nint ppv);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-imarshal-releasemarshaldata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseMarshalData(IStream pStm);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-imarshal-disconnectobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisconnectObject(uint dwReserved);
}

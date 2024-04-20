namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxcore_interface/nn-dxcore_interface-idxcoreadapter
[GeneratedComInterface, Guid("f0db4c7f-fe5a-42a2-bd62-f2a6cf6fc83e")]
public partial interface IDXCoreAdapter
{
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapter-isvalid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsValid();
    
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapter-isattributesupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsAttributeSupported(in Guid attributeGUID);
    
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapter-ispropertysupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsPropertySupported(DXCoreAdapterProperty property);
    
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapter-getproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperty(DXCoreAdapterProperty property, nuint bufferSize, nint propertyData);
    
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapter-getpropertysize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertySize(DXCoreAdapterProperty property, out nuint bufferSize);
    
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapter-isquerystatesupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsQueryStateSupported(DXCoreAdapterState property);
    
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapter-querystate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryState(DXCoreAdapterState state, nuint inputStateDetailsSize, nint/* nint */ inputStateDetails, nuint outputBufferSize, nint outputBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapter-issetstatesupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsSetStateSupported(DXCoreAdapterState property);
    
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapter-setstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetState(DXCoreAdapterState state, nuint inputStateDetailsSize, nint/* nint */ inputStateDetails, nuint inputDataSize, nint inputData);
    
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapter-getfactory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFactory(in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppvFactory);
}

namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/nn-d2d1_1-id2d1properties
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("483473d7-cd46-4f9d-9d3a-3112aa80159d")]
public partial interface ID2D1Properties
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1properties-getpropertycount
    [PreserveSig]
    uint GetPropertyCount();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1properties-getpropertyname(uint32_pwstr_uint32)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyName(uint index, [MarshalUsing(CountElementName = nameof(nameCount))] out PWSTR[] name, uint nameCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1properties-getpropertynamelength(u)
    [PreserveSig]
    uint GetPropertyNameLength(uint index);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1properties-gettype(uint32)
    [PreserveSig]
    D2D1_PROPERTY_TYPE GetType(uint index);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1properties-getpropertyindex
    [PreserveSig]
    uint GetPropertyIndex(PWSTR name);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1properties-setvaluebyname(pcwstr_constbyte_uint32)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetValueByName(PWSTR name, D2D1_PROPERTY_TYPE type, nint /* byte array */ data, uint dataSize);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1properties-setvalue(u_constbyte_uint32)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetValue(uint index, D2D1_PROPERTY_TYPE type, nint /* byte array */ data, uint dataSize);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1properties-getvaluebyname(pcwstr)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValueByName(PWSTR name, D2D1_PROPERTY_TYPE type, nint /* byte array */ data, uint dataSize);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1properties-getvalue(u_t)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValue(uint index, D2D1_PROPERTY_TYPE type, nint /* byte array */ data, uint dataSize);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1properties-getvaluesize(u)
    [PreserveSig]
    uint GetValueSize(uint index);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1properties-getsubproperties(uint32_id2d1properties)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSubProperties(uint index, out ID2D1Properties subProperties);
}

#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("ce17c09b-4efa-44d5-a4c9-59d9585ab0cd")]
public partial interface ISpeechDataKey : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBinaryValue(BSTR ValueName, VARIANT Value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBinaryValue(BSTR ValueName, out VARIANT Value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStringValue(BSTR ValueName, BSTR Value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStringValue(BSTR ValueName, out BSTR Value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLongValue(BSTR ValueName, int Value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLongValue(BSTR ValueName, out int Value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenKey(BSTR SubKeyName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechDataKey>))] out ISpeechDataKey SubKey);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateKey(BSTR SubKeyName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechDataKey>))] out ISpeechDataKey SubKey);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteKey(BSTR SubKeyName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteValue(BSTR ValueName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumKeys(int Index, out BSTR SubKeyName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumValues(int Index, out BSTR ValueName);
}

#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("c74a3adc-b727-4500-a84a-b526721c8b8c")]
public partial interface ISpeechObjectToken : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Id(out BSTR ObjectId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DataKey([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechDataKey>))] out ISpeechDataKey DataKey);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Category([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechObjectTokenCategory>))] out ISpeechObjectTokenCategory Category);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDescription(int Locale, out BSTR Description);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetId(BSTR Id, BSTR CategoryID, VARIANT_BOOL CreateIfNotExist);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttribute(BSTR AttributeName, out BSTR AttributeValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInstance(nint pUnkOuter, SpeechTokenContext ClsContext, out nint Object);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Remove(BSTR ObjectStorageCLSID);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStorageFileName(BSTR ObjectStorageCLSID, BSTR KeyName, BSTR FileName, SpeechTokenShellFolder Folder, out BSTR FilePath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveStorageFileName(BSTR ObjectStorageCLSID, BSTR KeyName, VARIANT_BOOL DeleteFile);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsUISupported(BSTR TypeOfUI, in VARIANT ExtraData, nint Object, out VARIANT_BOOL Supported);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisplayUI(int hWnd, BSTR Title, BSTR TypeOfUI, in VARIANT ExtraData, nint Object);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MatchesAttributes(BSTR Attributes, out VARIANT_BOOL Matches);
}

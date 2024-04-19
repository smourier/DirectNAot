namespace DirectN;

[GeneratedComInterface, Guid("0f37bd92-d6a1-4854-b950-3a969d27f30e")]
public partial interface IDvbServiceAttributeDescriptor
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTag(nint /* byte array */ pbVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLength(nint /* byte array */ pbVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCountOfRecords(nint /* byte array */ pbVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordServiceId(byte bRecordIndex, out ushort pwVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordNumericSelectionFlag(byte bRecordIndex, [MarshalAs(UnmanagedType.U4)] out bool pfVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordVisibleServiceFlag(byte bRecordIndex, [MarshalAs(UnmanagedType.U4)] out bool pfVal);
}

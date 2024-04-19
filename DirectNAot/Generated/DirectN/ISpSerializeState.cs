namespace DirectN;

[GeneratedComInterface, Guid("21b501a0-0ec7-46c9-92c3-a2bc784c54b9")]
public partial interface ISpSerializeState
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSerializedState(out nint /* byte array */ ppbData, out uint pulSize, uint dwReserved);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSerializedState(nint /* byte array */ pbData, uint ulSize, uint dwReserved);
}

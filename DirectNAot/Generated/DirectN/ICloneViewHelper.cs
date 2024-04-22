namespace DirectN;

[GeneratedComInterface, Guid("f6a3d4c4-5632-4d83-b0a1-fb88712b1eb7")]
public partial interface ICloneViewHelper
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConnectedIDs(PWSTR wszAdaptorName, ref uint pulCount, ref uint pulID, uint ulFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetActiveTopology(PWSTR wszAdaptorName, uint ulSourceID, ref uint pulCount, ref uint pulTargetID);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetActiveTopology(PWSTR wszAdaptorName, uint ulSourceID, uint ulCount, in uint pulTargetID);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Commit([MarshalAs(UnmanagedType.U4)] bool fFinalCall);
}

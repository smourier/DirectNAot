namespace DirectN;

[GeneratedComInterface, Guid("e85ccef5-aaaa-47f0-b5e3-61f7aecdc4c1")]
public partial interface IViewHelper
{
    // https://learn.microsoft.com/windows/win32/api/cloneviewhelper/nf-cloneviewhelper-iviewhelper-getconnectedids
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConnectedIDs(PWSTR wszAdaptorName, ref uint pulCount, ref uint pulID, uint ulFlags);
    
    // https://learn.microsoft.com/windows/win32/api/cloneviewhelper/nf-cloneviewhelper-iviewhelper-getactivetopology
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetActiveTopology(PWSTR wszAdaptorName, uint ulSourceID, ref uint pulCount, ref uint pulTargetID);
    
    // https://learn.microsoft.com/windows/win32/api/cloneviewhelper/nf-cloneviewhelper-iviewhelper-setactivetopology
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetActiveTopology(PWSTR wszAdaptorName, uint ulSourceID, uint ulCount, in uint pulTargetID);
    
    // https://learn.microsoft.com/windows/win32/api/cloneviewhelper/nf-cloneviewhelper-iviewhelper-commit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Commit();
    
    // https://learn.microsoft.com/windows/win32/api/cloneviewhelper/nf-cloneviewhelper-iviewhelper-setconfiguration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetConfiguration(IStream pIStream, out uint pulStatus);
    
    // https://learn.microsoft.com/windows/win32/api/cloneviewhelper/nf-cloneviewhelper-iviewhelper-getproceedonnewconfiguration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProceedOnNewConfiguration();
}

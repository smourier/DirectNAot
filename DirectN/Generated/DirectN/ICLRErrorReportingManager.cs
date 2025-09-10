#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("980d2f1a-bf79-4c08-812a-bb9778928f78")]
public partial interface ICLRErrorReportingManager
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBucketParametersForCurrentException(out BucketParameters pParams);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginCustomDump(ECustomDumpFlavor dwFlavor, uint dwNumItems, [In][MarshalUsing(CountElementName = nameof(dwNumItems))] CustomDumpItem[] items, uint dwReserved);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndCustomDump();
}

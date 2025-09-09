#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nn-wmcodecdsp-itoc
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("d6f05441-a919-423b-91a0-89d5b4a8ab77")]
public partial interface IToc
{
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itoc-setdescriptor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDescriptor(ref TOC_DESCRIPTOR pDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itoc-getdescriptor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDescriptor(ref TOC_DESCRIPTOR pDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itoc-setdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDescription(PWSTR pwszDescription);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itoc-getdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDescription(ref ushort pwDescriptionSize, [MarshalUsing(CountElementName = nameof(pwDescriptionSize))] PWSTR pwszDescription);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itoc-setcontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetContext(uint dwContextSize, nint /* byte array */ pbtContext);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itoc-getcontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContext(ref uint pdwContextSize, nint /* byte array */ pbtContext);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itoc-getentrylistcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEntryListCount(ref ushort pwCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itoc-getentrylistbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEntryListByIndex(ushort wEntryListIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITocEntryList>))] out ITocEntryList ppEntryList);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itoc-addentrylist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddEntryList([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITocEntryList>))] ITocEntryList pEntryList, ref ushort pwEntryListIndex);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itoc-addentrylistbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddEntryListByIndex(ushort wEntryListIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITocEntryList>))] ITocEntryList pEntryList);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itoc-removeentrylistbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveEntryListByIndex(ushort wEntryListIndex);
}

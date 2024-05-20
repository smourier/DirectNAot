#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/DirectShow/ikspropertyset
[GeneratedComInterface, Guid("31efac30-515c-11d0-a9aa-00aa0061be93")]
public partial interface IKsPropertySet
{
    // https://learn.microsoft.com/windows/win32/DirectShow/ikspropertyset-set
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Set(in Guid guidPropSet, uint dwPropID, nint pInstanceData, uint cbInstanceData, nint pPropData, uint cbPropData);
    
    // https://learn.microsoft.com/windows/win32/DirectShow/ikspropertyset-get
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Get(in Guid guidPropSet, uint dwPropID, nint pInstanceData, uint cbInstanceData, nint pPropData, uint cbPropData, out uint pcbReturned);
    
    // https://learn.microsoft.com/windows/win32/DirectShow/ikspropertyset-querysupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QuerySupported(in Guid guidPropSet, uint dwPropID, out uint pTypeSupport);
}

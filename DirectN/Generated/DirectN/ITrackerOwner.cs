#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("eb24c20b-9816-4ac7-8cff-36f67a118f4e")]
public partial interface ITrackerOwner
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTrackerHandle(out TrackerHandle returnValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteTrackerHandle(TrackerHandle handle);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTrackerValue(TrackerHandle handle, nint value);
    
    [PreserveSig]
    byte TryGetSafeTrackerValue(TrackerHandle handle, out nint returnValue);
}

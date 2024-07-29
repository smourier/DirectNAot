#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oleidl/nn-oleidl-ienumoleverb
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000104-0000-0000-c000-000000000046")]
public partial interface IEnumOLEVERB
{
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ienumoleverb-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, [In][Out][MarshalUsing(CountElementName = nameof(celt))] OLEVERB[] rgelt, nint /* optional uint* */ pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ienumoleverb-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ienumoleverb-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ienumoleverb-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumOLEVERB>))] out IEnumOLEVERB ppenum);
}

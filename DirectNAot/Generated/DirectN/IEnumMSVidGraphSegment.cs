#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("3dd2903e-e0aa-11d2-b63a-00c04f79498e")]
public partial interface IEnumMSVidGraphSegment
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, out IMSVidGraphSegment rgelt, out uint pceltFetched);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out IEnumMSVidGraphSegment ppenum);
}

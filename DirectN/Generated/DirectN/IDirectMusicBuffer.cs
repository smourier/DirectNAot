#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("d2ac2878-b39b-11d1-8704-00600893b1bd")]
public partial interface IDirectMusicBuffer
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Flush();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TotalTime(ref long prtTime);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PackStructured(long rt, uint dwChannelGroup, uint dwChannelMessage);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PackUnstructured(long rt, uint dwChannelGroup, uint cb, nint /* byte array */ lpb);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetReadPtr();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNextEvent(ref long prt, ref uint pdwChannelGroup, ref uint pdwLength, out nint /* byte array */ ppData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRawBufferPtr(out nint /* byte array */ ppData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStartTime(ref long prt);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUsedBytes(ref uint pcb);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxBytes(ref uint pcb);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBufferFormat(ref Guid pGuidFormat);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStartTime(long rt);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUsedBytes(uint cb);
}

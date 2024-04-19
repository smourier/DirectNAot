namespace DirectN;

[GeneratedComInterface, Guid("9880499b-cce9-11d2-b503-00c04f797396")]
public partial interface ISpTTSEngineSite : ISpEventSink
{
    [PreserveSig]
    uint GetActions();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Write(nint pBuff, uint cb, out uint pcbWritten);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRate(out int pRateAdjust);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVolume(out ushort pusVolume);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSkipInfo(out SPVSKIPTYPE peType, out int plNumItems);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CompleteSkip(int ulNumSkipped);
}

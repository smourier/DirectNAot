namespace DirectN;

[GeneratedComInterface, Guid("86ca3b85-49ad-4b6e-aed5-eddb18540f41")]
public partial interface ID3D12ManualWriteTrackingResource
{
    [PreserveSig]
    public void TrackWrite(uint Subresource, nint/* nint */ pWrittenRange);
}

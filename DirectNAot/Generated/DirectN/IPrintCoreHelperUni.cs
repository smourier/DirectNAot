namespace DirectN;

[GeneratedComInterface, Guid("7e8e51d6-e5ee-4426-817b-958b9444eb79")]
public partial interface IPrintCoreHelperUni : IPrintCoreHelper
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateGDLSnapshot(ref DEVMODEA pDevmode, uint cbSize, uint dwFlags, out IStream ppSnapshotStream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateDefaultGDLSnapshot(uint dwFlags, out IStream ppSnapshotStream);
}

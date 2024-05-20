#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidanalogtuner2
[GeneratedComInterface, Guid("37647bf7-3dde-4cc8-a4dc-0d534d3d0037")]
public partial interface IMSVidAnalogTuner2 : IMSVidAnalogTuner
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidanalogtuner2-get_tvformats
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TVFormats(out int Formats);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidanalogtuner2-get_tunermodes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TunerModes(out int Modes);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidanalogtuner2-get_numauxinputs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NumAuxInputs(out int Inputs);
}

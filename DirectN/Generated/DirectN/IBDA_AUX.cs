#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_aux
[GeneratedComInterface, Guid("7def4c09-6e66-4567-a819-f0e17f4a81ab")]
public partial interface IBDA_AUX
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_aux-querycapabilities
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryCapabilities(out uint pdwNumAuxInputsBSTR);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_aux-enumcapability
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumCapability(uint dwIndex, out uint dwInputID, out Guid pConnectorType, out uint ConnTypeNum, out uint NumVideoStds, out ulong AnalogStds);
}

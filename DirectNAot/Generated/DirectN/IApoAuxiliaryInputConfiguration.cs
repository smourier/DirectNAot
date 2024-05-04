#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/nn-audioenginebaseapo-iapoauxiliaryinputconfiguration
[GeneratedComInterface, Guid("4ceb0aab-fa19-48ed-a857-87771ae1b768")]
public partial interface IApoAuxiliaryInputConfiguration
{
    // https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/nf-audioenginebaseapo-iapoauxiliaryinputconfiguration-addauxiliaryinput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddAuxiliaryInput(uint dwInputId, uint cbDataSize, nint /* byte array */ pbyData, in APO_CONNECTION_DESCRIPTOR pInputConnection);
    
    // https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/nf-audioenginebaseapo-iapoauxiliaryinputconfiguration-removeauxiliaryinput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAuxiliaryInput(uint dwInputId);
    
    // https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/nf-audioenginebaseapo-iapoauxiliaryinputconfiguration-isinputformatsupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsInputFormatSupported(IAudioMediaType pRequestedInputFormat, out IAudioMediaType ppSupportedInputFormat);
}

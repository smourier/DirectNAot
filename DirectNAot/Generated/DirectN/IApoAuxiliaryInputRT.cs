#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/nn-audioenginebaseapo-iapoauxiliaryinputrt
[GeneratedComInterface, Guid("f851809c-c177-49a0-b1b2-b66f017943ab")]
public partial interface IApoAuxiliaryInputRT
{
    // https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/nf-audioenginebaseapo-iapoauxiliaryinputrt-acceptinput
    [PreserveSig]
    void AcceptInput(uint dwInputId, in APO_CONNECTION_PROPERTY pInputConnection);
}

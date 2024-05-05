#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("c3a9e92a-da88-46b0-a110-6cf953026cb9")]
public partial interface IMFMediaKeySessionNotify2 : IMFMediaKeySessionNotify
{
    [PreserveSig]
    void KeyMessage2(MF_MEDIAKEYSESSION_MESSAGETYPE eMessageType, BSTR destinationURL, nint /* byte array */ pbMessage, uint cbMessage);
    
    [PreserveSig]
    void KeyStatusChange();
}

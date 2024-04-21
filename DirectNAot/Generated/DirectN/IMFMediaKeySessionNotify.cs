namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfmediakeysessionnotify
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("6a0083f9-8947-4c1d-9ce0-cdee22b23135")]
public partial interface IMFMediaKeySessionNotify
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediakeysessionnotify-keymessage
    [PreserveSig]
    void KeyMessage(BSTR? destinationURL, nint /* byte array */ message, uint cb);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediakeysessionnotify-keyadded
    [PreserveSig]
    void KeyAdded();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediakeysessionnotify-keyerror
    [PreserveSig]
    void KeyError(ushort code, uint systemCode);
}

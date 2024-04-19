namespace DirectN;

[GeneratedComInterface, Guid("af67f125-ab39-4e93-b4a2-cc2e66e182a7")]
public partial interface ISpeechFileStream : ISpeechBaseStream
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Open(BSTR FileName, SpeechStreamFileMode FileMode, VARIANT_BOOL DoEvents);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
}

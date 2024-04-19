namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/ns-audioengineextensionapo-audio_systemeffects_property_change_notification
[StructLayout(LayoutKind.Sequential)]
public partial struct AUDIO_SYSTEMEFFECTS_PROPERTY_CHANGE_NOTIFICATION
{
    public nint endpoint;
    public Guid propertyStoreContext;
    public AUDIO_SYSTEMEFFECTS_PROPERTYSTORE_TYPE propertyStoreType;
    public nint propertyStore;
    public PROPERTYKEY propertyKey;
}

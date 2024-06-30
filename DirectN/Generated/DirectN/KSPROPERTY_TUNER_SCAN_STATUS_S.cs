#nullable enable
namespace DirectN;

public partial struct KSPROPERTY_TUNER_SCAN_STATUS_S
{
    public KSIDENTIFIER Property;
    public TunerLockType LockStatus;
    public uint CurrentFrequency;
}

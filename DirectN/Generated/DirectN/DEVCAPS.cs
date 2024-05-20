﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DEVCAPS
{
    public int CanRecord;
    public int CanRecordStrobe;
    public int HasAudio;
    public int HasVideo;
    public int UsesFiles;
    public int CanSave;
    public int DeviceType;
    public int TCRead;
    public int TCWrite;
    public int CTLRead;
    public int IndexRead;
    public int Preroll;
    public int Postroll;
    public int SyncAcc;
    public int NormRate;
    public int CanPreview;
    public int CanMonitorSrc;
    public int CanTest;
    public int VideoIn;
    public int AudioIn;
    public int Calibrate;
    public int SeekType;
    public int SimulatedHardware;
}

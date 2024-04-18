namespace DirectN;

public enum PrintJobStatus
{
    PrintJobStatus_Paused = 1,
    PrintJobStatus_Error = 2,
    PrintJobStatus_Deleting = 4,
    PrintJobStatus_Spooling = 8,
    PrintJobStatus_Printing = 16,
    PrintJobStatus_Offline = 32,
    PrintJobStatus_PaperOut = 64,
    PrintJobStatus_Printed = 128,
    PrintJobStatus_Deleted = 256,
    PrintJobStatus_BlockedDeviceQueue = 512,
    PrintJobStatus_UserIntervention = 1024,
    PrintJobStatus_Restarted = 2048,
    PrintJobStatus_Complete = 4096,
    PrintJobStatus_Retained = 8192,
}

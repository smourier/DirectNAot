namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/devicetopology/ne-devicetopology-connectortype
public enum ConnectorType
{
    Unknown_Connector = 0,
    Physical_Internal = 1,
    Physical_External = 2,
    Software_IO = 3,
    Software_Fixed = 4,
    Network = 5,
}

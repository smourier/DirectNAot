namespace DirectN;

[Flags]
public enum GameInputKind
{
    GameInputKindUnknown = 0x00000000,
    GameInputKindRawDeviceReport = 0x00000001,
    GameInputKindControllerAxis = 0x00000002,
    GameInputKindControllerButton = 0x00000004,
    GameInputKindControllerSwitch = 0x00000008,
    GameInputKindController = 0x0000000E,
    GameInputKindKeyboard = 0x00000010,
    GameInputKindMouse = 0x00000020,
    GameInputKindTouch = 0x00000100,
    GameInputKindMotion = 0x00001000,
    GameInputKindArcadeStick = 0x00010000,
    GameInputKindFlightStick = 0x00020000,
    GameInputKindGamepad = 0x00040000,
    GameInputKindRacingWheel = 0x00080000,
    GameInputKindUiNavigation = 0x01000000
}

public enum GameInputEnumerationKind
{
    GameInputNoEnumeration = 0,
    GameInputAsyncEnumeration = 1,
    GameInputBlockingEnumeration = 2
}

[Flags]
public enum GameInputFocusPolicy
{
    GameInputDefaultFocusPolicy = 0x00000000,
    GameInputDisableBackgroundInput = 0x00000001,
    GameInputExclusiveForegroundInput = 0x00000002
}

public enum GameInputSwitchKind
{
    GameInputUnknownSwitchKind = -1,
    GameInput2WaySwitch = 0,
    GameInput4WaySwitch = 1,
    GameInput8WaySwitch = 2
}

public enum GameInputSwitchPosition
{
    GameInputSwitchCenter = 0,
    GameInputSwitchUp = 1,
    GameInputSwitchUpRight = 2,
    GameInputSwitchRight = 3,
    GameInputSwitchDownRight = 4,
    GameInputSwitchDown = 5,
    GameInputSwitchDownLeft = 6,
    GameInputSwitchLeft = 7,
    GameInputSwitchUpLeft = 8
}

public enum GameInputKeyboardKind
{
    GameInputUnknownKeyboard = -1,
    GameInputAnsiKeyboard = 0,
    GameInputIsoKeyboard = 1,
    GameInputKsKeyboard = 2,
    GameInputAbntKeyboard = 3,
    GameInputJisKeyboard = 4
}

[Flags]
public enum GameInputMouseButtons
{
    GameInputMouseNone = 0x00000000,
    GameInputMouseLeftButton = 0x00000001,
    GameInputMouseRightButton = 0x00000002,
    GameInputMouseMiddleButton = 0x00000004,
    GameInputMouseButton4 = 0x00000008,
    GameInputMouseButton5 = 0x00000010,
    GameInputMouseWheelTiltLeft = 0x00000020,
    GameInputMouseWheelTiltRight = 0x00000040
}

public enum GameInputTouchShape
{
    GameInputTouchShapeUnknown = -1,
    GameInputTouchShapePoint = 0,
    GameInputTouchShape1DLinear = 1,
    GameInputTouchShape1DRadial = 2,
    GameInputTouchShape1DIrregular = 3,
    GameInputTouchShape2DRectangular = 4,
    GameInputTouchShape2DElliptical = 5,
    GameInputTouchShape2DIrregular = 6
}

public enum GameInputMotionAccuracy
{
    GameInputMotionAccuracyUnknown = -1,
    GameInputMotionUnavailable = 0,
    GameInputMotionUnreliable = 1,
    GameInputMotionApproximate = 2,
    GameInputMotionAccurate = 3
}

[Flags]
public enum GameInputArcadeStickButtons
{
    GameInputArcadeStickNone = 0x00000000,
    GameInputArcadeStickMenu = 0x00000001,
    GameInputArcadeStickView = 0x00000002,
    GameInputArcadeStickUp = 0x00000004,
    GameInputArcadeStickDown = 0x00000008,
    GameInputArcadeStickLeft = 0x00000010,
    GameInputArcadeStickRight = 0x00000020,
    GameInputArcadeStickAction1 = 0x00000040,
    GameInputArcadeStickAction2 = 0x00000080,
    GameInputArcadeStickAction3 = 0x00000100,
    GameInputArcadeStickAction4 = 0x00000200,
    GameInputArcadeStickAction5 = 0x00000400,
    GameInputArcadeStickAction6 = 0x00000800,
    GameInputArcadeStickSpecial1 = 0x00001000,
    GameInputArcadeStickSpecial2 = 0x00002000
}

[Flags]
public enum GameInputFlightStickButtons
{
    GameInputFlightStickNone = 0x00000000,
    GameInputFlightStickMenu = 0x00000001,
    GameInputFlightStickView = 0x00000002,
    GameInputFlightStickFirePrimary = 0x00000004,
    GameInputFlightStickFireSecondary = 0x00000008
}

[Flags]
public enum GameInputGamepadButtons
{
    GameInputGamepadNone = 0x00000000,
    GameInputGamepadMenu = 0x00000001,
    GameInputGamepadView = 0x00000002,
    GameInputGamepadA = 0x00000004,
    GameInputGamepadB = 0x00000008,
    GameInputGamepadX = 0x00000010,
    GameInputGamepadY = 0x00000020,
    GameInputGamepadDPadUp = 0x00000040,
    GameInputGamepadDPadDown = 0x00000080,
    GameInputGamepadDPadLeft = 0x00000100,
    GameInputGamepadDPadRight = 0x00000200,
    GameInputGamepadLeftShoulder = 0x00000400,
    GameInputGamepadRightShoulder = 0x00000800,
    GameInputGamepadLeftThumbstick = 0x00001000,
    GameInputGamepadRightThumbstick = 0x00002000
}

[Flags]
public enum GameInputRacingWheelButtons
{
    GameInputRacingWheelNone = 0x00000000,
    GameInputRacingWheelMenu = 0x00000001,
    GameInputRacingWheelView = 0x00000002,
    GameInputRacingWheelPreviousGear = 0x00000004,
    GameInputRacingWheelNextGear = 0x00000008,
    GameInputRacingWheelDpadUp = 0x00000010,
    GameInputRacingWheelDpadDown = 0x00000020,
    GameInputRacingWheelDpadLeft = 0x00000040,
    GameInputRacingWheelDpadRight = 0x00000080
}

[Flags]
public enum GameInputUiNavigationButtons
{
    GameInputUiNavigationNone = 0x00000000,
    GameInputUiNavigationMenu = 0x00000001,
    GameInputUiNavigationView = 0x00000002,
    GameInputUiNavigationAccept = 0x00000004,
    GameInputUiNavigationCancel = 0x00000008,
    GameInputUiNavigationUp = 0x00000010,
    GameInputUiNavigationDown = 0x00000020,
    GameInputUiNavigationLeft = 0x00000040,
    GameInputUiNavigationRight = 0x00000080,
    GameInputUiNavigationContext1 = 0x00000100,
    GameInputUiNavigationContext2 = 0x00000200,
    GameInputUiNavigationContext3 = 0x00000400,
    GameInputUiNavigationContext4 = 0x00000800,
    GameInputUiNavigationPageUp = 0x00001000,
    GameInputUiNavigationPageDown = 0x00002000,
    GameInputUiNavigationPageLeft = 0x00004000,
    GameInputUiNavigationPageRight = 0x00008000,
    GameInputUiNavigationScrollUp = 0x00010000,
    GameInputUiNavigationScrollDown = 0x00020000,
    GameInputUiNavigationScrollLeft = 0x00040000,
    GameInputUiNavigationScrollRight = 0x00080000
}

[Flags]
public enum GameInputDeviceStatus
{
    GameInputDeviceNoStatus = 0x00000000,
    GameInputDeviceConnected = 0x00000001,
    GameInputDeviceInputEnabled = 0x00000002,
    GameInputDeviceOutputEnabled = 0x00000004,
    GameInputDeviceRawIoEnabled = 0x00000008,
    GameInputDeviceAudioCapture = 0x00000010,
    GameInputDeviceAudioRender = 0x00000020,
    GameInputDeviceSynchronized = 0x00000040,
    GameInputDeviceWireless = 0x00000080,
    GameInputDeviceUserIdle = 0x00100000,
    GameInputDeviceAnyStatus = 0x00FFFFFF
}

public enum GameInputBatteryStatus
{
    GameInputBatteryUnknown = -1,
    GameInputBatteryNotPresent = 0,
    GameInputBatteryDischarging = 1,
    GameInputBatteryIdle = 2,
    GameInputBatteryCharging = 3
}

public enum GameInputDeviceFamily
{
    GameInputFamilyVirtual = -1,
    GameInputFamilyAggregate = 0,
    GameInputFamilyXboxOne = 1,
    GameInputFamilyXbox360 = 2,
    GameInputFamilyHid = 3,
    GameInputFamilyI8042 = 4
}

[Flags]
public enum GameInputDeviceCapabilities
{
    GameInputDeviceCapabilityNone = 0x00000000,
    GameInputDeviceCapabilityAudio = 0x00000001,
    GameInputDeviceCapabilityPluginModule = 0x00000002,
    GameInputDeviceCapabilityPowerOff = 0x00000004,
    GameInputDeviceCapabilitySynchronization = 0x00000008,
    GameInputDeviceCapabilityWireless = 0x00000010
}

public enum GameInputRawDeviceReportKind
{
    GameInputRawInputReport = 0,
    GameInputRawOutputReport = 1,
    GameInputRawFeatureReport = 2
}

[Flags]
public enum GameInputRawDeviceReportItemFlags
{
    GameInputDefaultItem = 0x00000000,
    GameInputConstantItem = 0x00000001,
    GameInputArrayItem = 0x00000002,
    GameInputRelativeItem = 0x00000004,
    GameInputWraparoundItem = 0x00000008,
    GameInputNonlinearItem = 0x00000010,
    GameInputStableItem = 0x00000020,
    GameInputNullableItem = 0x00000040,
    GameInputVolatileItem = 0x00000080,
    GameInputBufferedItem = 0x00000100
}

public enum GameInputRawDeviceItemCollectionKind
{
    GameInputUnknownItemCollection = -1,
    GameInputPhysicalItemCollection = 0,
    GameInputApplicationItemCollection = 1,
    GameInputLogicalItemCollection = 2,
    GameInputReportItemCollection = 3,
    GameInputNamedArrayItemCollection = 4,
    GameInputUsageSwitchItemCollection = 5,
    GameInputUsageModifierItemCollection = 6
}

public enum GameInputRawDevicePhysicalUnitKind
{
    GameInputPhysicalUnitUnknown = -1,
    GameInputPhysicalUnitNone = 0,
    GameInputPhysicalUnitTime = 1,
    GameInputPhysicalUnitFrequency = 2,
    GameInputPhysicalUnitLength = 3,
    GameInputPhysicalUnitVelocity = 4,
    GameInputPhysicalUnitAcceleration = 5,
    GameInputPhysicalUnitMass = 6,
    GameInputPhysicalUnitMomentum = 7,
    GameInputPhysicalUnitForce = 8,
    GameInputPhysicalUnitPressure = 9,
    GameInputPhysicalUnitAngle = 10,
    GameInputPhysicalUnitAngularVelocity = 11,
    GameInputPhysicalUnitAngularAcceleration = 12,
    GameInputPhysicalUnitAngularMass = 13,
    GameInputPhysicalUnitAngularMomentum = 14,
    GameInputPhysicalUnitAngularTorque = 15,
    GameInputPhysicalUnitElectricCurrent = 16,
    GameInputPhysicalUnitElectricCharge = 17,
    GameInputPhysicalUnitElectricPotential = 18,
    GameInputPhysicalUnitEnergy = 19,
    GameInputPhysicalUnitPower = 20,
    GameInputPhysicalUnitTemperature = 21,
    GameInputPhysicalUnitLuminousIntensity = 22,
    GameInputPhysicalUnitLuminousFlux = 23,
    GameInputPhysicalUnitIlluminance = 24
}

public enum GameInputLabel
{
    GameInputLabelUnknown = -1,
    GameInputLabelNone = 0,
    GameInputLabelXboxGuide = 1,
    GameInputLabelXboxBack = 2,
    GameInputLabelXboxStart = 3,
    GameInputLabelXboxMenu = 4,
    GameInputLabelXboxView = 5,
    GameInputLabelXboxA = 7,
    GameInputLabelXboxB = 8,
    GameInputLabelXboxX = 9,
    GameInputLabelXboxY = 10,
    GameInputLabelXboxDPadUp = 11,
    GameInputLabelXboxDPadDown = 12,
    GameInputLabelXboxDPadLeft = 13,
    GameInputLabelXboxDPadRight = 14,
    GameInputLabelXboxLeftShoulder = 15,
    GameInputLabelXboxLeftTrigger = 16,
    GameInputLabelXboxLeftStickButton = 17,
    GameInputLabelXboxRightShoulder = 18,
    GameInputLabelXboxRightTrigger = 19,
    GameInputLabelXboxRightStickButton = 20,
    GameInputLabelXboxPaddle1 = 21,
    GameInputLabelXboxPaddle2 = 22,
    GameInputLabelXboxPaddle3 = 23,
    GameInputLabelXboxPaddle4 = 24,
    GameInputLabelLetterA = 25,
    GameInputLabelLetterB = 26,
    GameInputLabelLetterC = 27,
    GameInputLabelLetterD = 28,
    GameInputLabelLetterE = 29,
    GameInputLabelLetterF = 30,
    GameInputLabelLetterG = 31,
    GameInputLabelLetterH = 32,
    GameInputLabelLetterI = 33,
    GameInputLabelLetterJ = 34,
    GameInputLabelLetterK = 35,
    GameInputLabelLetterL = 36,
    GameInputLabelLetterM = 37,
    GameInputLabelLetterN = 38,
    GameInputLabelLetterO = 39,
    GameInputLabelLetterP = 40,
    GameInputLabelLetterQ = 41,
    GameInputLabelLetterR = 42,
    GameInputLabelLetterS = 43,
    GameInputLabelLetterT = 44,
    GameInputLabelLetterU = 45,
    GameInputLabelLetterV = 46,
    GameInputLabelLetterW = 47,
    GameInputLabelLetterX = 48,
    GameInputLabelLetterY = 49,
    GameInputLabelLetterZ = 50,
    GameInputLabelNumber0 = 51,
    GameInputLabelNumber1 = 52,
    GameInputLabelNumber2 = 53,
    GameInputLabelNumber3 = 54,
    GameInputLabelNumber4 = 55,
    GameInputLabelNumber5 = 56,
    GameInputLabelNumber6 = 57,
    GameInputLabelNumber7 = 58,
    GameInputLabelNumber8 = 59,
    GameInputLabelNumber9 = 60,
    GameInputLabelArrowUp = 61,
    GameInputLabelArrowUpRight = 62,
    GameInputLabelArrowRight = 63,
    GameInputLabelArrowDownRight = 64,
    GameInputLabelArrowDown = 65,
    GameInputLabelArrowDownLLeft = 66,
    GameInputLabelArrowLeft = 67,
    GameInputLabelArrowUpLeft = 68,
    GameInputLabelArrowUpDown = 69,
    GameInputLabelArrowLeftRight = 70,
    GameInputLabelArrowUpDownLeftRight = 71,
    GameInputLabelArrowClockwise = 72,
    GameInputLabelArrowCounterClockwise = 73,
    GameInputLabelArrowReturn = 74,
    GameInputLabelIconBranding = 75,
    GameInputLabelIconHome = 76,
    GameInputLabelIconMenu = 77,
    GameInputLabelIconCross = 78,
    GameInputLabelIconCircle = 79,
    GameInputLabelIconSquare = 80,
    GameInputLabelIconTriangle = 81,
    GameInputLabelIconStar = 82,
    GameInputLabelIconDPadUp = 83,
    GameInputLabelIconDPadDown = 84,
    GameInputLabelIconDPadLeft = 85,
    GameInputLabelIconDPadRight = 86,
    GameInputLabelIconDialClockwise = 87,
    GameInputLabelIconDialCounterClockwise = 88,
    GameInputLabelIconSliderLeftRight = 89,
    GameInputLabelIconSliderUpDown = 90,
    GameInputLabelIconWheelUpDown = 91,
    GameInputLabelIconPlus = 92,
    GameInputLabelIconMinus = 93,
    GameInputLabelIconSuspension = 94,
    GameInputLabelHome = 95,
    GameInputLabelGuide = 96,
    GameInputLabelMode = 97,
    GameInputLabelSelect = 98,
    GameInputLabelMenu = 99,
    GameInputLabelView = 100,
    GameInputLabelBack = 101,
    GameInputLabelStart = 102,
    GameInputLabelOptions = 103,
    GameInputLabelShare = 104,
    GameInputLabelUp = 105,
    GameInputLabelDown = 106,
    GameInputLabelLeft = 107,
    GameInputLabelRight = 108,
    GameInputLabelLB = 109,
    GameInputLabelLT = 110,
    GameInputLabelLSB = 111,
    GameInputLabelL1 = 112,
    GameInputLabelL2 = 113,
    GameInputLabelL3 = 114,
    GameInputLabelRB = 115,
    GameInputLabelRT = 116,
    GameInputLabelRSB = 117,
    GameInputLabelR1 = 118,
    GameInputLabelR2 = 119,
    GameInputLabelR3 = 120,
    GameInputLabelP1 = 121,
    GameInputLabelP2 = 122,
    GameInputLabelP3 = 123,
    GameInputLabelP4 = 124
}

public enum GameInputLocation
{
    GameInputLocationUnknown = -1,
    GameInputLocationChassis = 0,
    GameInputLocationDisplay = 1,
    GameInputLocationAxis = 2,
    GameInputLocationButton = 3,
    GameInputLocationSwitch = 4,
    GameInputLocationKey = 5,
    GameInputLocationTouchPad = 6
}

[Flags]
public enum GameInputFeedbackAxes
{
    GameInputFeedbackAxisNone = 0x00000000,
    GameInputFeedbackAxisLinearX = 0x00000001,
    GameInputFeedbackAxisLinearY = 0x00000002,
    GameInputFeedbackAxisLinearZ = 0x00000004,
    GameInputFeedbackAxisAngularX = 0x00000008,
    GameInputFeedbackAxisAngularY = 0x00000010,
    GameInputFeedbackAxisAngularZ = 0x00000020,
    GameInputFeedbackAxisNormal = 0x00000040
}

public enum GameInputFeedbackEffectState
{
    GameInputFeedbackStopped = 0,
    GameInputFeedbackRunning = 1,
    GameInputFeedbackPaused = 2
}

public enum GameInputForceFeedbackEffectKind
{
    GameInputForceFeedbackConstant = 0,
    GameInputForceFeedbackRamp = 1,
    GameInputForceFeedbackSineWave = 2,
    GameInputForceFeedbackSquareWave = 3,
    GameInputForceFeedbackTriangleWave = 4,
    GameInputForceFeedbackSawtoothUpWave = 5,
    GameInputForceFeedbackSawtoothDownWave = 6,
    GameInputForceFeedbackSpring = 7,
    GameInputForceFeedbackFriction = 8,
    GameInputForceFeedbackDamper = 9,
    GameInputForceFeedbackInertia = 10
}

[Flags]
public enum GameInputRumbleMotors
{
    GameInputRumbleNone = 0x00000000,
    GameInputRumbleLowFrequency = 0x00000001,
    GameInputRumbleHighFrequency = 0x00000002,
    GameInputRumbleLeftTrigger = 0x00000004,
    GameInputRumbleRightTrigger = 0x00000008
}

public partial struct GameInputKeyState
{
    public uint scanCode;
    public uint codePoint;
    public byte virtualKey;
    [MarshalAs(UnmanagedType.U1)]
    public bool isDeadKey;
}

public partial struct GameInputMouseState
{
    public GameInputMouseButtons buttons;
    public long positionX;
    public long positionY;
    public long wheelX;
    public long wheelY;
}

public partial struct GameInputTouchState
{
    public ulong touchId;
    public uint sensorIndex;
    public float positionX;
    public float positionY;
    public float pressure;
    public float proximity;
    public float contactRectTop;
    public float contactRectLeft;
    public float contactRectRight;
    public float contactRectBottom;
}

public partial struct GameInputMotionState
{
    public float accelerationX;
    public float accelerationY;
    public float accelerationZ;
    public float angularVelocityX;
    public float angularVelocityY;
    public float angularVelocityZ;
    public float magneticFieldX;
    public float magneticFieldY;
    public float magneticFieldZ;
    public float orientationW;
    public float orientationX;
    public float orientationY;
    public float orientationZ;
    public GameInputMotionAccuracy accelerometerAccuracy;
    public GameInputMotionAccuracy gyroscopeAccuracy;
    public GameInputMotionAccuracy magnetometerAccuracy;
    public GameInputMotionAccuracy orientationAccuracy;
}

public partial struct GameInputArcadeStickState
{
    public GameInputArcadeStickButtons buttons;
}

public partial struct GameInputFlightStickState
{
    public GameInputFlightStickButtons buttons;
    public GameInputSwitchPosition hatSwitch;
    public float roll;
    public float pitch;
    public float yaw;
    public float throttle;
}

public partial struct GameInputGamepadState
{
    public GameInputGamepadButtons buttons;
    public float leftTrigger;
    public float rightTrigger;
    public float leftThumbstickX;
    public float leftThumbstickY;
    public float rightThumbstickX;
    public float rightThumbstickY;
}

public partial struct GameInputRacingWheelState
{
    public GameInputRacingWheelButtons buttons;
    public int patternShifterGear;
    public float wheel;
    public float throttle;
    public float brake;
    public float clutch;
    public float handbrake;
}

public partial struct GameInputUiNavigationState
{
    public GameInputUiNavigationButtons buttons;
}

public partial struct GameInputBatteryState
{
    public float chargeRate;
    public float maxChargeRate;
    public float remainingCapacity;
    public float fullChargeCapacity;
    public GameInputBatteryStatus status;
}

public partial struct GameInputString
{
    public uint sizeInBytes;
    public uint codePointCount;
    public nint data;
}

public partial struct GameInputUsage
{
    public ushort page;
    public ushort id;
}

public partial struct GameInputVersion
{
    public ushort major;
    public ushort minor;
    public ushort build;
    public ushort revision;
}

public partial struct GameInputRawDeviceItemCollectionInfo
{
    public GameInputRawDeviceItemCollectionKind kind;
    public uint childCount;
    public uint siblingCount;
    public uint usageCount;
    public nint usages;
    public nint parent;
    public nint firstSibling;
    public nint previousSibling;
    public nint nextSibling;
    public nint lastSibling;
    public nint firstChild;
    public nint lastChild;
}

public partial struct GameInputRawDeviceReportItemInfo
{
    public uint bitOffset;
    public uint bitSize;
    public long logicalMin;
    public long logicalMax;
    public double physicalMin;
    public double physicalMax;
    public GameInputRawDevicePhysicalUnitKind physicalUnits;
    public uint rawPhysicalUnits;
    public int rawPhysicalUnitsExponent;
    public GameInputRawDeviceReportItemFlags flags;
    public uint usageCount;
    public nint usages;
    public nint collection;
    public nint itemString;
}

public partial struct GameInputRawDeviceReportInfo
{
    public GameInputRawDeviceReportKind kind;
    public uint id;
    public uint size;
    public uint itemCount;
    public nint items;
}

public partial struct GameInputControllerAxisInfo
{
    public GameInputKind mappedInputKinds;
    public GameInputLabel label;
    [MarshalAs(UnmanagedType.U1)]
    public bool isContinuous;
    [MarshalAs(UnmanagedType.U1)]
    public bool isNonlinear;
    [MarshalAs(UnmanagedType.U1)]
    public bool isQuantized;
    [MarshalAs(UnmanagedType.U1)]
    public bool hasRestValue;
    public float restValue;
    public ulong resolution;
    public ushort legacyDInputIndex;
    public ushort legacyHidIndex;
    public uint rawReportIndex;
    public nint inputReport;
    public nint inputReportItem;
}

public partial struct GameInputControllerButtonInfo
{
    public GameInputKind mappedInputKinds;
    public GameInputLabel label;
    public ushort legacyDInputIndex;
    public ushort legacyHidIndex;
    public uint rawReportIndex;
    public nint inputReport;
    public nint inputReportItem;
}

[InlineArray(Length)]
public partial struct InlineArrayGameInputLabel_9
{
    public const int Length = 9;
    public GameInputLabel value;
}

public partial struct GameInputControllerSwitchInfo
{
    public GameInputKind mappedInputKinds;
    public GameInputLabel label;
    public InlineArrayGameInputLabel_9 positionLabels;
    public GameInputSwitchKind kind;
    public ushort legacyDInputIndex;
    public ushort legacyHidIndex;
    public uint rawReportIndex;
    public nint inputReport;
    public nint inputReportItem;
}

public partial struct GameInputKeyboardInfo
{
    public GameInputKeyboardKind kind;
    public uint layout;
    public uint keyCount;
    public uint functionKeyCount;
    public uint maxSimultaneousKeys;
    public uint platformType;
    public uint platformSubtype;
    public nint nativeLanguage;
}

public partial struct GameInputMouseInfo
{
    public GameInputMouseButtons supportedButtons;
    public uint sampleRate;
    public uint sensorDpi;
    [MarshalAs(UnmanagedType.U1)]
    public bool hasWheelX;
    [MarshalAs(UnmanagedType.U1)]
    public bool hasWheelY;
}

public partial struct GameInputTouchSensorInfo
{
    public GameInputKind mappedInputKinds;
    public GameInputLabel label;
    public GameInputLocation location;
    public uint locationId;
    public ulong resolutionX;
    public ulong resolutionY;
    public GameInputTouchShape shape;
    public float aspectRatio;
    public float orientation;
    public float physicalWidth;
    public float physicalHeight;
    public float maxPressure;
    public float maxProximity;
    public uint maxTouchPoints;
}

public partial struct GameInputMotionInfo
{
    public float maxAcceleration;
    public float maxAngularVelocity;
    public float maxMagneticFieldStrength;
}

public partial struct GameInputArcadeStickInfo
{
    public GameInputLabel menuButtonLabel;
    public GameInputLabel viewButtonLabel;
    public GameInputLabel stickUpLabel;
    public GameInputLabel stickDownLabel;
    public GameInputLabel stickLeftLabel;
    public GameInputLabel stickRightLabel;
    public GameInputLabel actionButton1Label;
    public GameInputLabel actionButton2Label;
    public GameInputLabel actionButton3Label;
    public GameInputLabel actionButton4Label;
    public GameInputLabel actionButton5Label;
    public GameInputLabel actionButton6Label;
    public GameInputLabel specialButton1Label;
    public GameInputLabel specialButton2Label;
}

public partial struct GameInputFlightStickInfo
{
    public GameInputLabel menuButtonLabel;
    public GameInputLabel viewButtonLabel;
    public GameInputLabel firePrimaryButtonLabel;
    public GameInputLabel fireSecondaryButtonLabel;
    public GameInputSwitchKind hatSwitchKind;
}

public partial struct GameInputGamepadInfo
{
    public GameInputLabel menuButtonLabel;
    public GameInputLabel viewButtonLabel;
    public GameInputLabel aButtonLabel;
    public GameInputLabel bButtonLabel;
    public GameInputLabel xButtonLabel;
    public GameInputLabel yButtonLabel;
    public GameInputLabel dpadUpLabel;
    public GameInputLabel dpadDownLabel;
    public GameInputLabel dpadLeftLabel;
    public GameInputLabel dpadRightLabel;
    public GameInputLabel leftShoulderButtonLabel;
    public GameInputLabel rightShoulderButtonLabel;
    public GameInputLabel leftThumbstickButtonLabel;
    public GameInputLabel rightThumbstickButtonLabel;
}

public partial struct GameInputRacingWheelInfo
{
    public GameInputLabel menuButtonLabel;
    public GameInputLabel viewButtonLabel;
    public GameInputLabel previousGearButtonLabel;
    public GameInputLabel nextGearButtonLabel;
    public GameInputLabel dpadUpLabel;
    public GameInputLabel dpadDownLabel;
    public GameInputLabel dpadLeftLabel;
    public GameInputLabel dpadRightLabel;
    [MarshalAs(UnmanagedType.U1)]
    public bool hasClutch;
    [MarshalAs(UnmanagedType.U1)]
    public bool hasHandbrake;
    [MarshalAs(UnmanagedType.U1)]
    public bool hasPatternShifter;
    public int minPatternShifterGear;
    public int maxPatternShifterGear;
    public float maxWheelAngle;
}

public partial struct GameInputUiNavigationInfo
{
    public GameInputLabel menuButtonLabel;
    public GameInputLabel viewButtonLabel;
    public GameInputLabel acceptButtonLabel;
    public GameInputLabel cancelButtonLabel;
    public GameInputLabel upButtonLabel;
    public GameInputLabel downButtonLabel;
    public GameInputLabel leftButtonLabel;
    public GameInputLabel rightButtonLabel;
    public GameInputLabel contextButton1Label;
    public GameInputLabel contextButton2Label;
    public GameInputLabel contextButton3Label;
    public GameInputLabel contextButton4Label;
    public GameInputLabel pageUpButtonLabel;
    public GameInputLabel pageDownButtonLabel;
    public GameInputLabel pageLeftButtonLabel;
    public GameInputLabel pageRightButtonLabel;
    public GameInputLabel scrollUpButtonLabel;
    public GameInputLabel scrollDownButtonLabel;
    public GameInputLabel scrollLeftButtonLabel;
    public GameInputLabel scrollRightButtonLabel;
    public GameInputLabel guideButtonLabel;
}

public partial struct GameInputForceFeedbackMotorInfo
{
    public GameInputFeedbackAxes supportedAxes;
    public GameInputLocation location;
    public uint locationId;
    public uint maxSimultaneousEffects;
    [MarshalAs(UnmanagedType.U1)]
    public bool isConstantEffectSupported;
    [MarshalAs(UnmanagedType.U1)]
    public bool isRampEffectSupported;
    [MarshalAs(UnmanagedType.U1)]
    public bool isSineWaveEffectSupported;
    [MarshalAs(UnmanagedType.U1)]
    public bool isSquareWaveEffectSupported;
    [MarshalAs(UnmanagedType.U1)]
    public bool isTriangleWaveEffectSupported;
    [MarshalAs(UnmanagedType.U1)]
    public bool isSawtoothUpWaveEffectSupported;
    [MarshalAs(UnmanagedType.U1)]
    public bool isSawtoothDownWaveEffectSupported;
    [MarshalAs(UnmanagedType.U1)]
    public bool isSpringEffectSupported;
    [MarshalAs(UnmanagedType.U1)]
    public bool isFrictionEffectSupported;
    [MarshalAs(UnmanagedType.U1)]
    public bool isDamperEffectSupported;
    [MarshalAs(UnmanagedType.U1)]
    public bool isInertiaEffectSupported;
}

public partial struct GameInputHapticWaveformInfo
{
    public GameInputUsage usage;
    [MarshalAs(UnmanagedType.U1)]
    public bool isDurationSupported;
    [MarshalAs(UnmanagedType.U1)]
    public bool isIntensitySupported;
    [MarshalAs(UnmanagedType.U1)]
    public bool isRepeatSupported;
    [MarshalAs(UnmanagedType.U1)]
    public bool isRepeatDelaySupported;
    public ulong defaultDuration;
}

public partial struct GameInputHapticFeedbackMotorInfo
{
    public GameInputRumbleMotors mappedRumbleMotors;
    public GameInputLocation location;
    public uint locationId;
    public uint waveformCount;
    public nint waveformInfo;
}

[InlineArray(Length)]
public partial struct APP_LOCAL_DEVICE_ID
{
    public const int Length = 32;
    public byte value;
}

public partial struct GameInputDeviceInfo
{
    public uint infoSize;
    public ushort vendorId;
    public ushort productId;
    public ushort revisionNumber;
    public byte interfaceNumber;
    public byte collectionNumber;
    public GameInputUsage usage;
    public GameInputVersion hardwareVersion;
    public GameInputVersion firmwareVersion;
    public APP_LOCAL_DEVICE_ID deviceId;
    public APP_LOCAL_DEVICE_ID deviceRootId;
    public GameInputDeviceFamily deviceFamily;
    public GameInputDeviceCapabilities capabilities;
    public GameInputKind supportedInput;
    public GameInputRumbleMotors supportedRumbleMotors;
    public uint inputReportCount;
    public uint outputReportCount;
    public uint featureReportCount;
    public uint controllerAxisCount;
    public uint controllerButtonCount;
    public uint controllerSwitchCount;
    public uint touchPointCount;
    public uint touchSensorCount;
    public uint forceFeedbackMotorCount;
    public uint hapticFeedbackMotorCount;
    public uint deviceStringCount;
    public uint deviceDescriptorSize;
    public nint inputReportInfo;
    public nint outputReportInfo;
    public nint featureReportInfo;
    public nint controllerAxisInfo;
    public nint controllerButtonInfo;
    public nint controllerSwitchInfo;
    public nint keyboardInfo;
    public nint mouseInfo;
    public nint touchSensorInfo;
    public nint motionInfo;
    public nint arcadeStickInfo;
    public nint flightStickInfo;
    public nint gamepadInfo;
    public nint racingWheelInfo;
    public nint uiNavigationInfo;
    public nint forceFeedbackMotorInfo;
    public nint hapticFeedbackMotorInfo;
    public nint displayName;
    public nint deviceStrings;
    public nint deviceDescriptorData;
}

public partial struct GameInputForceFeedbackEnvelope
{
    public ulong attackDuration;
    public ulong sustainDuration;
    public ulong releaseDuration;
    public float attackGain;
    public float sustainGain;
    public float releaseGain;
    public uint playCount;
    public ulong repeatDelay;
}

public partial struct GameInputForceFeedbackMagnitude
{
    public float linearX;
    public float linearY;
    public float linearZ;
    public float angularX;
    public float angularY;
    public float angularZ;
    public float normal;
}

public partial struct GameInputForceFeedbackConditionParams
{
    public GameInputForceFeedbackMagnitude magnitude;
    public float positiveCoefficient;
    public float negativeCoefficient;
    public float maxPositiveMagnitude;
    public float maxNegativeMagnitude;
    public float deadZone;
    public float bias;
}

public partial struct GameInputForceFeedbackConstantParams
{
    public GameInputForceFeedbackEnvelope envelope;
    public GameInputForceFeedbackMagnitude magnitude;
}

public partial struct GameInputForceFeedbackPeriodicParams
{
    public GameInputForceFeedbackEnvelope envelope;
    public GameInputForceFeedbackMagnitude magnitude;
    public float frequency;
    public float phase;
    public float bias;
}

public partial struct GameInputForceFeedbackRampParams
{
    public GameInputForceFeedbackEnvelope envelope;
    public GameInputForceFeedbackMagnitude startMagnitude;
    public GameInputForceFeedbackMagnitude endMagnitude;
}

public partial struct GameInputForceFeedbackParams
{
    public GameInputForceFeedbackEffectKind kind;
    public GameInputForceFeedbackParamsData data;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct GameInputForceFeedbackParamsData
    {
        [FieldOffset(0)]
        GameInputForceFeedbackConstantParams constant;

        [FieldOffset(0)]
        GameInputForceFeedbackRampParams ramp;

        [FieldOffset(0)]
        GameInputForceFeedbackPeriodicParams sineWave;

        [FieldOffset(0)]
        GameInputForceFeedbackPeriodicParams squareWave;

        [FieldOffset(0)]
        GameInputForceFeedbackPeriodicParams triangleWave;

        [FieldOffset(0)]
        GameInputForceFeedbackPeriodicParams sawtoothUpWave;

        [FieldOffset(0)]
        GameInputForceFeedbackPeriodicParams sawtoothDownWave;

        [FieldOffset(0)]
        GameInputForceFeedbackConditionParams spring;

        [FieldOffset(0)]
        GameInputForceFeedbackConditionParams friction;

        [FieldOffset(0)]
        GameInputForceFeedbackConditionParams damper;

        [FieldOffset(0)]
        GameInputForceFeedbackConditionParams inertia;
    }
}

public partial struct GameInputHapticFeedbackParams
{
    public uint waveformIndex;
    public ulong duration;
    public float intensity;
    public uint playCount;
    public ulong repeatDelay;
}

public partial struct GameInputRumbleParams
{
    public float lowFrequency;
    public float highFrequency;
    public float leftTrigger;
    public float rightTrigger;
}

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void GameInputReadingCallback(
    ulong callbackToken,
    nint context,
    nint /*IGameInputReading*/ reading,
    [MarshalAs(UnmanagedType.U1)]
    bool hasOverrunOccurred);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void GameInputDeviceCallback(
    ulong callbackToken,
    nint context,
    nint /*IGameInputDevice*/ device,
    ulong timestamp,
    GameInputDeviceStatus currentStatus,
    GameInputDeviceStatus previousStatus);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void GameInputGuideButtonCallback(
    ulong callbackToken,
    nint context,
    nint /*IGameInputDevice*/ device,
    ulong timestamp,
    [MarshalAs(UnmanagedType.U1)]
    bool isPressed);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void GameInputKeyboardLayoutCallback(
    ulong callbackToken,
    nint context,
    nint /*IGameInputDevice*/ device,
    ulong timestamp,
    uint currentLayout,
    uint previousLayout);

[GeneratedComInterface, Guid("11BE2A7E-4254-445A-9C09-FFC40F006918")]
public partial interface IGameInput
{
    [PreserveSig]
    ulong GetCurrentTimestamp();

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentReading(GameInputKind inputKind, IGameInputDevice device, out IGameInputReading reading);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNextReading(IGameInputReading referenceReading, GameInputKind inputKind, IGameInputDevice device, out IGameInputReading reading);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPreviousReading(IGameInputReading referenceReading, GameInputKind inputKind, IGameInputDevice device, out IGameInputReading reading);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTemporalReading(ulong timestamp, IGameInputDevice device, out IGameInputReading reading);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterReadingCallback(IGameInputDevice device,
        GameInputKind inputKind,
        float analogThreshold,
        nint context,
        GameInputReadingCallback callbackFunc,
        out ulong callbackToken);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterDeviceCallback(
        IGameInputDevice device,
        GameInputKind inputKind,
        GameInputDeviceStatus statusFilter,
        GameInputEnumerationKind enumerationKind,
        nint context,
        GameInputDeviceCallback callbackFunc,
        out ulong callbackToken);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterGuideButtonCallback(
        IGameInputDevice device,
        nint context,
        GameInputGuideButtonCallback callbackFunc,
        out ulong callbackToken);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterKeyboardLayoutCallback(
        IGameInputDevice device,
        nint context,
        GameInputKeyboardLayoutCallback callbackFunc,
        out ulong callbackToken);

    [PreserveSig]
    void StopCallback(ulong callbackToken);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U1)]
    bool UnregisterCallback(ulong callbackToken, ulong timeoutInMicroseconds);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDispatcher(out IGameInputDispatcher dispatcher);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateAggregateDevice(GameInputKind inputKind, out IGameInputDevice device);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindDeviceFromId(in APP_LOCAL_DEVICE_ID value, out IGameInputDevice device);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindDeviceFromObject(IUnknown value, out IGameInputDevice device);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindDeviceFromPlatformHandle(HANDLE value, out IGameInputDevice device);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindDeviceFromPlatformString(PWSTR value, out IGameInputDevice device);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnableOemDeviceSupport(ushort avendorId, ushort aproductId, byte interfaceNumber, byte collectionNumber);

    [PreserveSig]
    void SetFocusPolicy(GameInputFocusPolicy policy);
}

[GeneratedComInterface, Guid("2156947A-E1FA-4DE0-A30B-D812931DBD8D")]
public partial interface IGameInputReading
{
    [PreserveSig]
    GameInputKind GetInputKind();

    [PreserveSig]
    ulong GetSequenceNumber(GameInputKind inputKind);

    [PreserveSig]
    ulong GetTimestamp();

    [PreserveSig]
    void GetDevice(out IGameInputDevice device);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U1)]
    bool GetRawReport(out IGameInputRawDeviceReport report);

    [PreserveSig]
    uint GetControllerAxisCount();

    [PreserveSig]
    uint GetControllerAxisState(uint stateArrayCount, [In][Out][MarshalUsing(CountElementName = nameof(stateArrayCount))] float[] stateArray);

    [PreserveSig]
    uint GetControllerButtonCount();

    [PreserveSig]
    uint GetControllerButtonState(uint stateArrayCount, [In][Out][MarshalUsing(CountElementName = nameof(stateArrayCount))] float[] stateArray);

    [PreserveSig]
    uint GetControllerSwitchCount();

    [PreserveSig]
    uint GetControllerSwitchState(uint stateArrayCount, [In][Out][MarshalUsing(CountElementName = nameof(stateArrayCount))] GameInputSwitchPosition[] stateArray);

    [PreserveSig]
    uint GetKeyCount();

    [PreserveSig]
    uint GetKeyState(uint stateArrayCount, [In][Out][MarshalUsing(CountElementName = nameof(stateArrayCount))] GameInputKeyState[] stateArray);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U1)]
    bool GetMouseState(out GameInputMouseState state);

    [PreserveSig]
    uint GetTouchCount();

    [PreserveSig]
    uint GetTouchState(uint stateArrayCount, [In][Out][MarshalUsing(CountElementName = nameof(stateArrayCount))] GameInputTouchState[] stateArray);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U1)]
    bool GetMotionState(GameInputMotionState state);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U1)]
    bool GetArcadeStickState(out GameInputArcadeStickState state);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U1)]
    bool GetFlightStickState(out GameInputFlightStickState state);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U1)]
    bool GetGamepadState(GameInputGamepadState state);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U1)]
    bool GetRacingWheelState(GameInputRacingWheelState state);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U1)]
    bool GetUiNavigationState(GameInputUiNavigationState state);
}

[GeneratedComInterface, Guid("31DD86FB-4C1B-408A-868F-439B3CD47125")]
public partial interface IGameInputDevice
{
    [PreserveSig]
    nint GetDeviceInfo();

    [PreserveSig]
    GameInputDeviceStatus GetDeviceStatus();

    [PreserveSig]
    void GetBatteryState(out GameInputBatteryState state);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateForceFeedbackEffect(uint motorIndex, in GameInputForceFeedbackParams @params, out IGameInputForceFeedbackEffect effect);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U1)]
    bool IsForceFeedbackMotorPoweredOn(uint motorIndex);

    [PreserveSig]
    void SetForceFeedbackMotorGain(uint motorIndex, float masterGain);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHapticMotorState(uint motorIndex, in GameInputHapticFeedbackParams @params);

    [PreserveSig]
    void SetRumbleState(in GameInputRumbleParams @params);

    [PreserveSig]
    void SetInputSynchronizationState([MarshalAs(UnmanagedType.U1)] bool enabled);

    [PreserveSig]
    void SendInputSynchronizationHint();

    [PreserveSig]
    void PowerOff();

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRawDeviceReport(uint reportId, GameInputRawDeviceReportKind reportKind, out IGameInputRawDeviceReport report);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRawDeviceFeature(uint reportId, out IGameInputRawDeviceReport report);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRawDeviceFeature(IGameInputRawDeviceReport report);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendRawDeviceOutput(IGameInputRawDeviceReport report);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendRawDeviceOutputWithResponse(IGameInputRawDeviceReport requestReport, out IGameInputRawDeviceReport responseReport);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ExecuteRawDeviceIoControl(
        uint controlCode,
        nint inputBufferSize,
        nint inputBuffer,
        nint outputBufferSize,
        nint outputBuffer,
        out nint outputSize);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U1)]
    bool AcquireExclusiveRawDeviceAccess(ulong timeoutInMicroseconds);

    [PreserveSig]
    void ReleaseExclusiveRawDeviceAccess();
}

[GeneratedComInterface, Guid("415EED2E-98CB-42C2-8F28-B94601074E31")]
public partial interface IGameInputDispatcher
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U1)]
    bool Dispatch(ulong quotaInMicroseconds);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenWaitHandle(out HANDLE waitHandle);
}

[GeneratedComInterface, Guid("51BDA05E-F742-45D9-B085-9444AE48381D")]
public partial interface IGameInputForceFeedbackEffect
{
    [PreserveSig]
    void GetDevice(IGameInputDevice device);

    [PreserveSig]
    uint GetMotorIndex();

    [PreserveSig]
    float GetGain();

    [PreserveSig]
    void SetGain(float gain);

    [PreserveSig]
    void GetParams(out GameInputForceFeedbackParams @params);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U1)]
    bool SetParams(in GameInputForceFeedbackParams @params);

    [PreserveSig]
    GameInputFeedbackEffectState GetState();

    [PreserveSig]
    void SetState(GameInputFeedbackEffectState state);
}

[GeneratedComInterface, Guid("61F08CF1-1FFC-40CA-A2B8-E1AB8BC5B6DC")]
public partial interface IGameInputRawDeviceReport
{
    [PreserveSig]
    void GetDevice(IGameInputDevice device);

    [PreserveSig]
    nint GetReportInfo();

    [PreserveSig]
    nint GetRawDataSize();

    [PreserveSig]
    nint GetRawData(nint bufferSize, nint buffer);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U1)]
    bool SetRawData(nint bufferSize, nint buffer);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U1)]
    bool GetItemValue(uint itemIndex, out long value);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U1)]
    bool SetItemValue(uint itemIndex, long value);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U1)]
    bool ResetItemValue(uint itemIndex);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U1)]
    bool ResetAllItems();
}

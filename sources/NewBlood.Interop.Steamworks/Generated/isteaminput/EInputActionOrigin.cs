namespace NewBlood.Interop.Steamworks;

public enum EInputActionOrigin
{
    k_EInputActionOrigin_None,
    k_EInputActionOrigin_SteamController_A,
    k_EInputActionOrigin_SteamController_B,
    k_EInputActionOrigin_SteamController_X,
    k_EInputActionOrigin_SteamController_Y,
    k_EInputActionOrigin_SteamController_LeftBumper,
    k_EInputActionOrigin_SteamController_RightBumper,
    k_EInputActionOrigin_SteamController_LeftGrip,
    k_EInputActionOrigin_SteamController_RightGrip,
    k_EInputActionOrigin_SteamController_Start,
    k_EInputActionOrigin_SteamController_Back,
    k_EInputActionOrigin_SteamController_LeftPad_Touch,
    k_EInputActionOrigin_SteamController_LeftPad_Swipe,
    k_EInputActionOrigin_SteamController_LeftPad_Click,
    k_EInputActionOrigin_SteamController_LeftPad_DPadNorth,
    k_EInputActionOrigin_SteamController_LeftPad_DPadSouth,
    k_EInputActionOrigin_SteamController_LeftPad_DPadWest,
    k_EInputActionOrigin_SteamController_LeftPad_DPadEast,
    k_EInputActionOrigin_SteamController_RightPad_Touch,
    k_EInputActionOrigin_SteamController_RightPad_Swipe,
    k_EInputActionOrigin_SteamController_RightPad_Click,
    k_EInputActionOrigin_SteamController_RightPad_DPadNorth,
    k_EInputActionOrigin_SteamController_RightPad_DPadSouth,
    k_EInputActionOrigin_SteamController_RightPad_DPadWest,
    k_EInputActionOrigin_SteamController_RightPad_DPadEast,
    k_EInputActionOrigin_SteamController_LeftTrigger_Pull,
    k_EInputActionOrigin_SteamController_LeftTrigger_Click,
    k_EInputActionOrigin_SteamController_RightTrigger_Pull,
    k_EInputActionOrigin_SteamController_RightTrigger_Click,
    k_EInputActionOrigin_SteamController_LeftStick_Move,
    k_EInputActionOrigin_SteamController_LeftStick_Click,
    k_EInputActionOrigin_SteamController_LeftStick_DPadNorth,
    k_EInputActionOrigin_SteamController_LeftStick_DPadSouth,
    k_EInputActionOrigin_SteamController_LeftStick_DPadWest,
    k_EInputActionOrigin_SteamController_LeftStick_DPadEast,
    k_EInputActionOrigin_SteamController_Gyro_Move,
    k_EInputActionOrigin_SteamController_Gyro_Pitch,
    k_EInputActionOrigin_SteamController_Gyro_Yaw,
    k_EInputActionOrigin_SteamController_Gyro_Roll,
    k_EInputActionOrigin_SteamController_Reserved0,
    k_EInputActionOrigin_SteamController_Reserved1,
    k_EInputActionOrigin_SteamController_Reserved2,
    k_EInputActionOrigin_SteamController_Reserved3,
    k_EInputActionOrigin_SteamController_Reserved4,
    k_EInputActionOrigin_SteamController_Reserved5,
    k_EInputActionOrigin_SteamController_Reserved6,
    k_EInputActionOrigin_SteamController_Reserved7,
    k_EInputActionOrigin_SteamController_Reserved8,
    k_EInputActionOrigin_SteamController_Reserved9,
    k_EInputActionOrigin_SteamController_Reserved10,
    k_EInputActionOrigin_PS4_X,
    k_EInputActionOrigin_PS4_Circle,
    k_EInputActionOrigin_PS4_Triangle,
    k_EInputActionOrigin_PS4_Square,
    k_EInputActionOrigin_PS4_LeftBumper,
    k_EInputActionOrigin_PS4_RightBumper,
    k_EInputActionOrigin_PS4_Options,
    k_EInputActionOrigin_PS4_Share,
    k_EInputActionOrigin_PS4_LeftPad_Touch,
    k_EInputActionOrigin_PS4_LeftPad_Swipe,
    k_EInputActionOrigin_PS4_LeftPad_Click,
    k_EInputActionOrigin_PS4_LeftPad_DPadNorth,
    k_EInputActionOrigin_PS4_LeftPad_DPadSouth,
    k_EInputActionOrigin_PS4_LeftPad_DPadWest,
    k_EInputActionOrigin_PS4_LeftPad_DPadEast,
    k_EInputActionOrigin_PS4_RightPad_Touch,
    k_EInputActionOrigin_PS4_RightPad_Swipe,
    k_EInputActionOrigin_PS4_RightPad_Click,
    k_EInputActionOrigin_PS4_RightPad_DPadNorth,
    k_EInputActionOrigin_PS4_RightPad_DPadSouth,
    k_EInputActionOrigin_PS4_RightPad_DPadWest,
    k_EInputActionOrigin_PS4_RightPad_DPadEast,
    k_EInputActionOrigin_PS4_CenterPad_Touch,
    k_EInputActionOrigin_PS4_CenterPad_Swipe,
    k_EInputActionOrigin_PS4_CenterPad_Click,
    k_EInputActionOrigin_PS4_CenterPad_DPadNorth,
    k_EInputActionOrigin_PS4_CenterPad_DPadSouth,
    k_EInputActionOrigin_PS4_CenterPad_DPadWest,
    k_EInputActionOrigin_PS4_CenterPad_DPadEast,
    k_EInputActionOrigin_PS4_LeftTrigger_Pull,
    k_EInputActionOrigin_PS4_LeftTrigger_Click,
    k_EInputActionOrigin_PS4_RightTrigger_Pull,
    k_EInputActionOrigin_PS4_RightTrigger_Click,
    k_EInputActionOrigin_PS4_LeftStick_Move,
    k_EInputActionOrigin_PS4_LeftStick_Click,
    k_EInputActionOrigin_PS4_LeftStick_DPadNorth,
    k_EInputActionOrigin_PS4_LeftStick_DPadSouth,
    k_EInputActionOrigin_PS4_LeftStick_DPadWest,
    k_EInputActionOrigin_PS4_LeftStick_DPadEast,
    k_EInputActionOrigin_PS4_RightStick_Move,
    k_EInputActionOrigin_PS4_RightStick_Click,
    k_EInputActionOrigin_PS4_RightStick_DPadNorth,
    k_EInputActionOrigin_PS4_RightStick_DPadSouth,
    k_EInputActionOrigin_PS4_RightStick_DPadWest,
    k_EInputActionOrigin_PS4_RightStick_DPadEast,
    k_EInputActionOrigin_PS4_DPad_North,
    k_EInputActionOrigin_PS4_DPad_South,
    k_EInputActionOrigin_PS4_DPad_West,
    k_EInputActionOrigin_PS4_DPad_East,
    k_EInputActionOrigin_PS4_Gyro_Move,
    k_EInputActionOrigin_PS4_Gyro_Pitch,
    k_EInputActionOrigin_PS4_Gyro_Yaw,
    k_EInputActionOrigin_PS4_Gyro_Roll,
    k_EInputActionOrigin_PS4_DPad_Move,
    k_EInputActionOrigin_PS4_Reserved1,
    k_EInputActionOrigin_PS4_Reserved2,
    k_EInputActionOrigin_PS4_Reserved3,
    k_EInputActionOrigin_PS4_Reserved4,
    k_EInputActionOrigin_PS4_Reserved5,
    k_EInputActionOrigin_PS4_Reserved6,
    k_EInputActionOrigin_PS4_Reserved7,
    k_EInputActionOrigin_PS4_Reserved8,
    k_EInputActionOrigin_PS4_Reserved9,
    k_EInputActionOrigin_PS4_Reserved10,
    k_EInputActionOrigin_XBoxOne_A,
    k_EInputActionOrigin_XBoxOne_B,
    k_EInputActionOrigin_XBoxOne_X,
    k_EInputActionOrigin_XBoxOne_Y,
    k_EInputActionOrigin_XBoxOne_LeftBumper,
    k_EInputActionOrigin_XBoxOne_RightBumper,
    k_EInputActionOrigin_XBoxOne_Menu,
    k_EInputActionOrigin_XBoxOne_View,
    k_EInputActionOrigin_XBoxOne_LeftTrigger_Pull,
    k_EInputActionOrigin_XBoxOne_LeftTrigger_Click,
    k_EInputActionOrigin_XBoxOne_RightTrigger_Pull,
    k_EInputActionOrigin_XBoxOne_RightTrigger_Click,
    k_EInputActionOrigin_XBoxOne_LeftStick_Move,
    k_EInputActionOrigin_XBoxOne_LeftStick_Click,
    k_EInputActionOrigin_XBoxOne_LeftStick_DPadNorth,
    k_EInputActionOrigin_XBoxOne_LeftStick_DPadSouth,
    k_EInputActionOrigin_XBoxOne_LeftStick_DPadWest,
    k_EInputActionOrigin_XBoxOne_LeftStick_DPadEast,
    k_EInputActionOrigin_XBoxOne_RightStick_Move,
    k_EInputActionOrigin_XBoxOne_RightStick_Click,
    k_EInputActionOrigin_XBoxOne_RightStick_DPadNorth,
    k_EInputActionOrigin_XBoxOne_RightStick_DPadSouth,
    k_EInputActionOrigin_XBoxOne_RightStick_DPadWest,
    k_EInputActionOrigin_XBoxOne_RightStick_DPadEast,
    k_EInputActionOrigin_XBoxOne_DPad_North,
    k_EInputActionOrigin_XBoxOne_DPad_South,
    k_EInputActionOrigin_XBoxOne_DPad_West,
    k_EInputActionOrigin_XBoxOne_DPad_East,
    k_EInputActionOrigin_XBoxOne_DPad_Move,
    k_EInputActionOrigin_XBoxOne_LeftGrip_Lower,
    k_EInputActionOrigin_XBoxOne_LeftGrip_Upper,
    k_EInputActionOrigin_XBoxOne_RightGrip_Lower,
    k_EInputActionOrigin_XBoxOne_RightGrip_Upper,
    k_EInputActionOrigin_XBoxOne_Share,
    k_EInputActionOrigin_XBoxOne_Reserved6,
    k_EInputActionOrigin_XBoxOne_Reserved7,
    k_EInputActionOrigin_XBoxOne_Reserved8,
    k_EInputActionOrigin_XBoxOne_Reserved9,
    k_EInputActionOrigin_XBoxOne_Reserved10,
    k_EInputActionOrigin_XBox360_A,
    k_EInputActionOrigin_XBox360_B,
    k_EInputActionOrigin_XBox360_X,
    k_EInputActionOrigin_XBox360_Y,
    k_EInputActionOrigin_XBox360_LeftBumper,
    k_EInputActionOrigin_XBox360_RightBumper,
    k_EInputActionOrigin_XBox360_Start,
    k_EInputActionOrigin_XBox360_Back,
    k_EInputActionOrigin_XBox360_LeftTrigger_Pull,
    k_EInputActionOrigin_XBox360_LeftTrigger_Click,
    k_EInputActionOrigin_XBox360_RightTrigger_Pull,
    k_EInputActionOrigin_XBox360_RightTrigger_Click,
    k_EInputActionOrigin_XBox360_LeftStick_Move,
    k_EInputActionOrigin_XBox360_LeftStick_Click,
    k_EInputActionOrigin_XBox360_LeftStick_DPadNorth,
    k_EInputActionOrigin_XBox360_LeftStick_DPadSouth,
    k_EInputActionOrigin_XBox360_LeftStick_DPadWest,
    k_EInputActionOrigin_XBox360_LeftStick_DPadEast,
    k_EInputActionOrigin_XBox360_RightStick_Move,
    k_EInputActionOrigin_XBox360_RightStick_Click,
    k_EInputActionOrigin_XBox360_RightStick_DPadNorth,
    k_EInputActionOrigin_XBox360_RightStick_DPadSouth,
    k_EInputActionOrigin_XBox360_RightStick_DPadWest,
    k_EInputActionOrigin_XBox360_RightStick_DPadEast,
    k_EInputActionOrigin_XBox360_DPad_North,
    k_EInputActionOrigin_XBox360_DPad_South,
    k_EInputActionOrigin_XBox360_DPad_West,
    k_EInputActionOrigin_XBox360_DPad_East,
    k_EInputActionOrigin_XBox360_DPad_Move,
    k_EInputActionOrigin_XBox360_Reserved1,
    k_EInputActionOrigin_XBox360_Reserved2,
    k_EInputActionOrigin_XBox360_Reserved3,
    k_EInputActionOrigin_XBox360_Reserved4,
    k_EInputActionOrigin_XBox360_Reserved5,
    k_EInputActionOrigin_XBox360_Reserved6,
    k_EInputActionOrigin_XBox360_Reserved7,
    k_EInputActionOrigin_XBox360_Reserved8,
    k_EInputActionOrigin_XBox360_Reserved9,
    k_EInputActionOrigin_XBox360_Reserved10,
    k_EInputActionOrigin_Switch_A,
    k_EInputActionOrigin_Switch_B,
    k_EInputActionOrigin_Switch_X,
    k_EInputActionOrigin_Switch_Y,
    k_EInputActionOrigin_Switch_LeftBumper,
    k_EInputActionOrigin_Switch_RightBumper,
    k_EInputActionOrigin_Switch_Plus,
    k_EInputActionOrigin_Switch_Minus,
    k_EInputActionOrigin_Switch_Capture,
    k_EInputActionOrigin_Switch_LeftTrigger_Pull,
    k_EInputActionOrigin_Switch_LeftTrigger_Click,
    k_EInputActionOrigin_Switch_RightTrigger_Pull,
    k_EInputActionOrigin_Switch_RightTrigger_Click,
    k_EInputActionOrigin_Switch_LeftStick_Move,
    k_EInputActionOrigin_Switch_LeftStick_Click,
    k_EInputActionOrigin_Switch_LeftStick_DPadNorth,
    k_EInputActionOrigin_Switch_LeftStick_DPadSouth,
    k_EInputActionOrigin_Switch_LeftStick_DPadWest,
    k_EInputActionOrigin_Switch_LeftStick_DPadEast,
    k_EInputActionOrigin_Switch_RightStick_Move,
    k_EInputActionOrigin_Switch_RightStick_Click,
    k_EInputActionOrigin_Switch_RightStick_DPadNorth,
    k_EInputActionOrigin_Switch_RightStick_DPadSouth,
    k_EInputActionOrigin_Switch_RightStick_DPadWest,
    k_EInputActionOrigin_Switch_RightStick_DPadEast,
    k_EInputActionOrigin_Switch_DPad_North,
    k_EInputActionOrigin_Switch_DPad_South,
    k_EInputActionOrigin_Switch_DPad_West,
    k_EInputActionOrigin_Switch_DPad_East,
    k_EInputActionOrigin_Switch_ProGyro_Move,
    k_EInputActionOrigin_Switch_ProGyro_Pitch,
    k_EInputActionOrigin_Switch_ProGyro_Yaw,
    k_EInputActionOrigin_Switch_ProGyro_Roll,
    k_EInputActionOrigin_Switch_DPad_Move,
    k_EInputActionOrigin_Switch_Reserved1,
    k_EInputActionOrigin_Switch_Reserved2,
    k_EInputActionOrigin_Switch_Reserved3,
    k_EInputActionOrigin_Switch_Reserved4,
    k_EInputActionOrigin_Switch_Reserved5,
    k_EInputActionOrigin_Switch_Reserved6,
    k_EInputActionOrigin_Switch_Reserved7,
    k_EInputActionOrigin_Switch_Reserved8,
    k_EInputActionOrigin_Switch_Reserved9,
    k_EInputActionOrigin_Switch_Reserved10,
    k_EInputActionOrigin_Switch_RightGyro_Move,
    k_EInputActionOrigin_Switch_RightGyro_Pitch,
    k_EInputActionOrigin_Switch_RightGyro_Yaw,
    k_EInputActionOrigin_Switch_RightGyro_Roll,
    k_EInputActionOrigin_Switch_LeftGyro_Move,
    k_EInputActionOrigin_Switch_LeftGyro_Pitch,
    k_EInputActionOrigin_Switch_LeftGyro_Yaw,
    k_EInputActionOrigin_Switch_LeftGyro_Roll,
    k_EInputActionOrigin_Switch_LeftGrip_Lower,
    k_EInputActionOrigin_Switch_LeftGrip_Upper,
    k_EInputActionOrigin_Switch_RightGrip_Lower,
    k_EInputActionOrigin_Switch_RightGrip_Upper,
    k_EInputActionOrigin_Switch_JoyConButton_N,
    k_EInputActionOrigin_Switch_JoyConButton_E,
    k_EInputActionOrigin_Switch_JoyConButton_S,
    k_EInputActionOrigin_Switch_JoyConButton_W,
    k_EInputActionOrigin_Switch_Reserved15,
    k_EInputActionOrigin_Switch_Reserved16,
    k_EInputActionOrigin_Switch_Reserved17,
    k_EInputActionOrigin_Switch_Reserved18,
    k_EInputActionOrigin_Switch_Reserved19,
    k_EInputActionOrigin_Switch_Reserved20,
    k_EInputActionOrigin_PS5_X,
    k_EInputActionOrigin_PS5_Circle,
    k_EInputActionOrigin_PS5_Triangle,
    k_EInputActionOrigin_PS5_Square,
    k_EInputActionOrigin_PS5_LeftBumper,
    k_EInputActionOrigin_PS5_RightBumper,
    k_EInputActionOrigin_PS5_Option,
    k_EInputActionOrigin_PS5_Create,
    k_EInputActionOrigin_PS5_Mute,
    k_EInputActionOrigin_PS5_LeftPad_Touch,
    k_EInputActionOrigin_PS5_LeftPad_Swipe,
    k_EInputActionOrigin_PS5_LeftPad_Click,
    k_EInputActionOrigin_PS5_LeftPad_DPadNorth,
    k_EInputActionOrigin_PS5_LeftPad_DPadSouth,
    k_EInputActionOrigin_PS5_LeftPad_DPadWest,
    k_EInputActionOrigin_PS5_LeftPad_DPadEast,
    k_EInputActionOrigin_PS5_RightPad_Touch,
    k_EInputActionOrigin_PS5_RightPad_Swipe,
    k_EInputActionOrigin_PS5_RightPad_Click,
    k_EInputActionOrigin_PS5_RightPad_DPadNorth,
    k_EInputActionOrigin_PS5_RightPad_DPadSouth,
    k_EInputActionOrigin_PS5_RightPad_DPadWest,
    k_EInputActionOrigin_PS5_RightPad_DPadEast,
    k_EInputActionOrigin_PS5_CenterPad_Touch,
    k_EInputActionOrigin_PS5_CenterPad_Swipe,
    k_EInputActionOrigin_PS5_CenterPad_Click,
    k_EInputActionOrigin_PS5_CenterPad_DPadNorth,
    k_EInputActionOrigin_PS5_CenterPad_DPadSouth,
    k_EInputActionOrigin_PS5_CenterPad_DPadWest,
    k_EInputActionOrigin_PS5_CenterPad_DPadEast,
    k_EInputActionOrigin_PS5_LeftTrigger_Pull,
    k_EInputActionOrigin_PS5_LeftTrigger_Click,
    k_EInputActionOrigin_PS5_RightTrigger_Pull,
    k_EInputActionOrigin_PS5_RightTrigger_Click,
    k_EInputActionOrigin_PS5_LeftStick_Move,
    k_EInputActionOrigin_PS5_LeftStick_Click,
    k_EInputActionOrigin_PS5_LeftStick_DPadNorth,
    k_EInputActionOrigin_PS5_LeftStick_DPadSouth,
    k_EInputActionOrigin_PS5_LeftStick_DPadWest,
    k_EInputActionOrigin_PS5_LeftStick_DPadEast,
    k_EInputActionOrigin_PS5_RightStick_Move,
    k_EInputActionOrigin_PS5_RightStick_Click,
    k_EInputActionOrigin_PS5_RightStick_DPadNorth,
    k_EInputActionOrigin_PS5_RightStick_DPadSouth,
    k_EInputActionOrigin_PS5_RightStick_DPadWest,
    k_EInputActionOrigin_PS5_RightStick_DPadEast,
    k_EInputActionOrigin_PS5_DPad_North,
    k_EInputActionOrigin_PS5_DPad_South,
    k_EInputActionOrigin_PS5_DPad_West,
    k_EInputActionOrigin_PS5_DPad_East,
    k_EInputActionOrigin_PS5_Gyro_Move,
    k_EInputActionOrigin_PS5_Gyro_Pitch,
    k_EInputActionOrigin_PS5_Gyro_Yaw,
    k_EInputActionOrigin_PS5_Gyro_Roll,
    k_EInputActionOrigin_PS5_DPad_Move,
    k_EInputActionOrigin_PS5_LeftGrip,
    k_EInputActionOrigin_PS5_RightGrip,
    k_EInputActionOrigin_PS5_LeftFn,
    k_EInputActionOrigin_PS5_RightFn,
    k_EInputActionOrigin_PS5_Reserved5,
    k_EInputActionOrigin_PS5_Reserved6,
    k_EInputActionOrigin_PS5_Reserved7,
    k_EInputActionOrigin_PS5_Reserved8,
    k_EInputActionOrigin_PS5_Reserved9,
    k_EInputActionOrigin_PS5_Reserved10,
    k_EInputActionOrigin_PS5_Reserved11,
    k_EInputActionOrigin_PS5_Reserved12,
    k_EInputActionOrigin_PS5_Reserved13,
    k_EInputActionOrigin_PS5_Reserved14,
    k_EInputActionOrigin_PS5_Reserved15,
    k_EInputActionOrigin_PS5_Reserved16,
    k_EInputActionOrigin_PS5_Reserved17,
    k_EInputActionOrigin_PS5_Reserved18,
    k_EInputActionOrigin_PS5_Reserved19,
    k_EInputActionOrigin_PS5_Reserved20,
    k_EInputActionOrigin_SteamDeck_A,
    k_EInputActionOrigin_SteamDeck_B,
    k_EInputActionOrigin_SteamDeck_X,
    k_EInputActionOrigin_SteamDeck_Y,
    k_EInputActionOrigin_SteamDeck_L1,
    k_EInputActionOrigin_SteamDeck_R1,
    k_EInputActionOrigin_SteamDeck_Menu,
    k_EInputActionOrigin_SteamDeck_View,
    k_EInputActionOrigin_SteamDeck_LeftPad_Touch,
    k_EInputActionOrigin_SteamDeck_LeftPad_Swipe,
    k_EInputActionOrigin_SteamDeck_LeftPad_Click,
    k_EInputActionOrigin_SteamDeck_LeftPad_DPadNorth,
    k_EInputActionOrigin_SteamDeck_LeftPad_DPadSouth,
    k_EInputActionOrigin_SteamDeck_LeftPad_DPadWest,
    k_EInputActionOrigin_SteamDeck_LeftPad_DPadEast,
    k_EInputActionOrigin_SteamDeck_RightPad_Touch,
    k_EInputActionOrigin_SteamDeck_RightPad_Swipe,
    k_EInputActionOrigin_SteamDeck_RightPad_Click,
    k_EInputActionOrigin_SteamDeck_RightPad_DPadNorth,
    k_EInputActionOrigin_SteamDeck_RightPad_DPadSouth,
    k_EInputActionOrigin_SteamDeck_RightPad_DPadWest,
    k_EInputActionOrigin_SteamDeck_RightPad_DPadEast,
    k_EInputActionOrigin_SteamDeck_L2_SoftPull,
    k_EInputActionOrigin_SteamDeck_L2,
    k_EInputActionOrigin_SteamDeck_R2_SoftPull,
    k_EInputActionOrigin_SteamDeck_R2,
    k_EInputActionOrigin_SteamDeck_LeftStick_Move,
    k_EInputActionOrigin_SteamDeck_L3,
    k_EInputActionOrigin_SteamDeck_LeftStick_DPadNorth,
    k_EInputActionOrigin_SteamDeck_LeftStick_DPadSouth,
    k_EInputActionOrigin_SteamDeck_LeftStick_DPadWest,
    k_EInputActionOrigin_SteamDeck_LeftStick_DPadEast,
    k_EInputActionOrigin_SteamDeck_LeftStick_Touch,
    k_EInputActionOrigin_SteamDeck_RightStick_Move,
    k_EInputActionOrigin_SteamDeck_R3,
    k_EInputActionOrigin_SteamDeck_RightStick_DPadNorth,
    k_EInputActionOrigin_SteamDeck_RightStick_DPadSouth,
    k_EInputActionOrigin_SteamDeck_RightStick_DPadWest,
    k_EInputActionOrigin_SteamDeck_RightStick_DPadEast,
    k_EInputActionOrigin_SteamDeck_RightStick_Touch,
    k_EInputActionOrigin_SteamDeck_L4,
    k_EInputActionOrigin_SteamDeck_R4,
    k_EInputActionOrigin_SteamDeck_L5,
    k_EInputActionOrigin_SteamDeck_R5,
    k_EInputActionOrigin_SteamDeck_DPad_Move,
    k_EInputActionOrigin_SteamDeck_DPad_North,
    k_EInputActionOrigin_SteamDeck_DPad_South,
    k_EInputActionOrigin_SteamDeck_DPad_West,
    k_EInputActionOrigin_SteamDeck_DPad_East,
    k_EInputActionOrigin_SteamDeck_Gyro_Move,
    k_EInputActionOrigin_SteamDeck_Gyro_Pitch,
    k_EInputActionOrigin_SteamDeck_Gyro_Yaw,
    k_EInputActionOrigin_SteamDeck_Gyro_Roll,
    k_EInputActionOrigin_SteamDeck_Reserved1,
    k_EInputActionOrigin_SteamDeck_Reserved2,
    k_EInputActionOrigin_SteamDeck_Reserved3,
    k_EInputActionOrigin_SteamDeck_Reserved4,
    k_EInputActionOrigin_SteamDeck_Reserved5,
    k_EInputActionOrigin_SteamDeck_Reserved6,
    k_EInputActionOrigin_SteamDeck_Reserved7,
    k_EInputActionOrigin_SteamDeck_Reserved8,
    k_EInputActionOrigin_SteamDeck_Reserved9,
    k_EInputActionOrigin_SteamDeck_Reserved10,
    k_EInputActionOrigin_SteamDeck_Reserved11,
    k_EInputActionOrigin_SteamDeck_Reserved12,
    k_EInputActionOrigin_SteamDeck_Reserved13,
    k_EInputActionOrigin_SteamDeck_Reserved14,
    k_EInputActionOrigin_SteamDeck_Reserved15,
    k_EInputActionOrigin_SteamDeck_Reserved16,
    k_EInputActionOrigin_SteamDeck_Reserved17,
    k_EInputActionOrigin_SteamDeck_Reserved18,
    k_EInputActionOrigin_SteamDeck_Reserved19,
    k_EInputActionOrigin_SteamDeck_Reserved20,
    k_EInputActionOrigin_Horipad_M1,
    k_EInputActionOrigin_Horipad_M2,
    k_EInputActionOrigin_Horipad_L4,
    k_EInputActionOrigin_Horipad_R4,
    k_EInputActionOrigin_Count,
    k_EInputActionOrigin_MaximumPossibleValue = 32767,
}

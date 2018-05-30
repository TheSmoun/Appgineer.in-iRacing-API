﻿// -----------------------------------------------------
//
// Distributed under GNU GPLv3.
//
// -----------------------------------------------------
//
// Copyright (c) 2018, appgineering.com
// All rights reserved.
// 
// This file is part of the Appgineer.in iRacing API.
//
// -----------------------------------------------------

using System.ComponentModel;
using AiRAPI.Data.Enums;

// ReSharper disable InconsistentNaming

namespace AiRAPI.Data
{
    public interface ITelemetry : INotifyPropertyChanged
    {
        double SessionTime { get; }
        long SessionTick { get; }
        int SessionNum { get; }
        SessionState SessionState { get; }
        int SessionUniqueID { get; }
        SessionFlags SessionFlags { get; }
        double SessionTimeRemain { get; }
        int SessionLapsRemain { get; }
        int SessionLapsRemainEx { get; }
        int RadioTransmitCarIdx { get; }
        int RadioTransmitRadioIdx { get; }
        int RadioTransmitFrequencyIdx { get; }
        int DisplayUnits { get; }
        bool DriverMarker { get; }
        bool IsOnTrack { get; }
        bool IsReplayPlaying { get; }
        int ReplayFrameNum { get; }
        int ReplayFrameNumEnd { get; }
        bool IsDiskLoggingEnabled { get; }
        bool IsDiskLoggingActive { get; }
        float FrameRate { get; }
        float CpuUsageBG { get; }
        int PlayerCarPosition { get; }
        int PlayerCarClassPosition { get; }
        TrackLocation PlayerTrackSurface { get; }
        int PlayerCarIdx { get; }
        int PlayerCarTeamIncidentCount { get; }
        int PlayerCarMyIncidentCount { get; }
        int PlayerCarDriverIncidentCount { get; }
        int[] CarIdxLap { get; }
        int[] CarIdxLapCompleted { get; }
        float[] CarIdxLapDistPct { get; }
        TrackLocation[] CarIdxTrackSurface { get; }
        bool[] CarIdxOnPitRoad { get; }
        int[] CarIdxPosition { get; }
        int[] CarIdxClassPosition { get; }
        float[] CarIdxF2Time { get; }
        float[] CarIdxEstTime { get; }
        bool OnPitRoad { get; }
        float[] CarIdxSteer { get; }
        float[] CarIdxRPM { get; }
        int[] CarIdxGear { get; }
        float SteeringWheelAngle { get; }
        float Throttle { get; }
        float Brake { get; }
        float Clutch { get; }
        int Gear { get; }
        float RPM { get; }
        int Lap { get; }
        int LapCompleted { get; }
        float LapDist { get; }
        float LapDistPct { get; }
        int RaceLaps { get; }
        int LapBestLap { get; }
        float LapBestLapTime { get; }
        float LapLastLapTime { get; }
        float LapCurrentLapTime { get; }
        int LapLasNLapSeq { get; }
        float LapLastNLapTime { get; }
        int LapBestBLapLap { get; }
        float LapBestNLapTime { get; }
        float LapDeltaToBestLap { get; }
        float LapDeltaToBestLap_DD { get; }
        bool LapDeltaToBestLap_OK { get; }
        float LapDeltaToOptimalLap { get; }
        float LapDeltaToOptimalLap_DD { get; }
        bool LapDeltaToOptimalLap_OK { get; }
        float LapDeltaToSessionBestLap { get; }
        float LapDeltaToSessionBestLap_DD { get; }
        bool LapDeltaToSessionBestLap_OK { get; }
        float LapDeltaToSessionOptimalLap { get; }
        float LapDeltaToSessionOptimalLap_DD { get; }
        bool LapDeltaToSessionOptimalLap_OK { get; }
        float LapDeltaToSessionLastLap { get; }
        float LapDeltaToSessionLastLap_DD { get; }
        bool LapDeltaToSessionLastLap_OK { get; }
        float LongAccel { get; }
        float LatAccel { get; }
        float VertAccel { get; }
        float RollRate { get; }
        float PitchRate { get; }
        float YawRate { get; }
        float Speed { get; }
        float VelocityX { get; }
        float VelocityY { get; }
        float VelocityZ { get; }
        float Yaw { get; }
        float YawNorth { get; }
        float Pitch { get; }
        float Roll { get; }
        int EnterExitReset { get; }
        float TrackTemp { get; }
        float TrackTempCrew { get; }
        float AirTemp { get; }
        int WeatherType { get; }
        int Skies { get; }
        float AirDensity { get; }
        float AirPressure { get; }
        float WindVel { get; }
        float WindDir { get; }
        float RelativeHumidity { get; }
        float FogLevel { get; }
        int DCLapStatus { get; }
        int DCDriversSoFar { get; }
        bool OkToReloadTextures { get; }
        float PitRepairLeft { get; }
        float PitOptRepairLeft { get; }
        int CamCarIdx { get; }
        int CamCameraNumber { get; }
        int CamGroupNumber { get; }
        CameraState CamCameraState { get; }
        bool IsOnTrackCar { get; }
        bool IsInGarage { get; }
        float SteeringWheelTorque { get; }
        float SteeringWheelPctTorque { get; }
        float SteeringWheelPctTorqueSign { get; }
        float SteeringWheelPctTorqueSignStops { get; }
        float SteeringWheelPctDamper { get; }
        float SteeringWheelAngleMax { get; }
        float ShiftIndicatorPct { get; }
        float ShiftPowerPct { get; }
        float ShiftGrindRPM { get; }
        float ThrottleRaw { get; }
        float BrakeRaw { get; }
        float SteeringWheelPeakForceNm { get; }
        EngineWarnings EngineWarnings { get; }
        float FuelLevel { get; }
        float FuelLevelPct { get; }
        long PitSvFlags { get; }
        float PitSvLFP { get; }
        float PitSvRFP { get; }
        float PitSvLRP { get; }
        float PitSvRRP { get; }
        float PitSvFuel { get; }
        float ReplayPlaySpeed { get; }
        bool ReplayPlaySlowMotion { get; }
        double ReplaySessionTime { get; }
        int ReplaySessionNum { get; }
        float dcBrakeBias { get; }
        float dcTractionControl { get; }
        float dcABS { get; }
        float dcThrottleShape { get; }
        float dcFuelMixture { get; }
        float WaterTemp { get; }
        float WaterLevel { get; }
        float FuelPress { get; }
        float FuelUsePerHour { get; }
        float OilTemp { get; }
        float OilPress { get; }
        float OilLevel { get; }
        float Voltage { get; }
        float ManifoldPress { get; }
        float RRbrakeLinePress { get; }
        float RRcoldPressure { get; }
        float RRtempCL { get; }
        float RRtempCM { get; }
        float RRtempCR { get; }
        float RRwearL { get; }
        float RRwearM { get; }
        float RRwearR { get; }
        float LRbrakeLinePress { get; }
        float LRcoldPressure { get; }
        float LRtempCL { get; }
        float LRtempCM { get; }
        float LRtempCR { get; }
        float LRwearL { get; }
        float LRwearM { get; }
        float LRwearR { get; }
        float RFbrakeLinePressure { get; }
        float RFcoldPressure { get; }
        float RFtempCL { get; }
        float RFtempCM { get; }
        float RFtempCR { get; }
        float RFwearL { get; }
        float RFwearM { get; }
        float RFwearR { get; }
        float LFbrakeLinePress { get; }
        float LFcoldPressure { get; }
        float LFtempCL { get; }
        float LFtempCM { get; }
        float LFtempCR { get; }
        float LFwearL { get; }
        float LFwearM { get; }
        float LFwearR { get; }
        float RRshockDefl { get; }
        float RRshockVel { get; }
        float LRshockDefl { get; }
        float LRshockVel { get; }
        float RFshockDefl { get; }
        float RFshockVel { get; }
        float LFshockDefl { get; }
        float LFshockVel { get; }
    }
}

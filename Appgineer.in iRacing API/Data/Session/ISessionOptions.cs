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

namespace AiRAPI.Data.Session
{
    public interface ISessionOptions : INotifyPropertyChanged
    {
        int NumStarters { get; }
        string StartingGrid { get; }
        string QualifyingScoring { get; }
        string CourseCautions { get; }
        RaceStartingType StartingType { get; }
        string Restarts { get; }
        string WeatherType { get; }
        string Skies { get; }
        string WindDirection { get; }
        string WindSpeed { get; }
        string WeatherTemp { get; }
        string RelativeHumidity { get; }
        string FogLevel { get; }
        bool IsOfficial { get; }
        string CommercialMode { get; }
        bool IsNightSession { get; }
        bool IsFixedSetup { get; }
        string StrictLapsChecking { get; }
        bool HasOpenRegistration { get; }
        int HardcoreLevel { get; }
    }
}

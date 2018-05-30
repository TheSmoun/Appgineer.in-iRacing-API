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

namespace AiRAPI.Ordering
{
    public static class DataOrders
    {
        public static IDataOrder Position { get; } = new PositionDataOrder();
        public static IDataOrder LivePosition { get; } = new LivePositionDataOrder();
        public static IDataOrder ClassPosition { get; } = new ClassPositionDataOrder();
        public static IDataOrder LiveClassPosition { get; } = new ClassLivePositionDataOrder();
        public static IDataOrder StartPosition { get; } = new StartPositionDataOrder();
        public static IDataOrder LapsLed { get; } = new LeadLapsDataOrder();
        public static IDataOrder FastestLap { get; } = new FastestLapDataOrder();
        public static IDataOrder PitLaneTime { get; } = new FastestPitLaneTimeDataOrder();
        public static IDataOrder PitStopTime { get; } = new FastestPitStopTimeDataOrder();
        public static IDataOrder PitStopCount { get; } = new PitStopCountDataOrder();
    }
}

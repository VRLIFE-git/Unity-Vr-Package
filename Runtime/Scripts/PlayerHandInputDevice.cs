﻿using System;

namespace Vrlife.Core.Vr
{
    [Serializable]
    public class PlayerHandInputDevice
    {
        public readonly TrackingInformation TrackingInformation;
        public readonly InteractionInformation InteractionInformation;

        public PlayerHandInputDevice(HumanBodyPart part, XrGeneralSettings settings)
        {
            TrackingInformation = new TrackingInformation(part);
            InteractionInformation = new InteractionInformation(part, settings);
        }
    }
}
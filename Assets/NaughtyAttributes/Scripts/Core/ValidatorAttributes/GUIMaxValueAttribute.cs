﻿using System;

namespace NaughtyAttributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class GUIMaxValueAttribute : GUIValidatorAttribute
    {
        public float MaxValue { get; private set; }

        public GUIMaxValueAttribute(float maxValue)
        {
            MaxValue = maxValue;
        }

        public GUIMaxValueAttribute(int maxValue)
        {
            MaxValue = maxValue;
        }
    }
}

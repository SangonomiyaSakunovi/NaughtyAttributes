﻿using System;

namespace NaughtyAttributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class GUIShowNativePropertyAttribute : SangoGUIDrawerSpecialAttribute
    {
    }
}

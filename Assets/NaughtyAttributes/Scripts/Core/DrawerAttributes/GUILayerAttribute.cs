﻿using System;

namespace NaughtyAttributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class GUILayerAttribute : SangoGUIDrawerAttribute
    {
    }
}
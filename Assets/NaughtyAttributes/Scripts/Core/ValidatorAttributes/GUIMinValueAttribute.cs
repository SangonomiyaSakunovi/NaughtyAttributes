using System;

namespace NaughtyAttributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class GUIMinValueAttribute : GUIValidatorAttribute
    {
        public float MinValue { get; private set; }

        public GUIMinValueAttribute(float minValue)
        {
            MinValue = minValue;
        }

        public GUIMinValueAttribute(int minValue)
        {
            MinValue = minValue;
        }
    }
}

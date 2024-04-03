using System;

namespace NaughtyAttributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class GUILabelAttribute : GUIMetaAttribute
    {
        public string Label { get; private set; }

        public GUILabelAttribute(string label)
        {
            Label = label;
        }
    }
}

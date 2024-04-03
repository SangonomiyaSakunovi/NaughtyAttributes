using System;

namespace NaughtyAttributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class GUIFoldoutAttribute : GUIMetaAttribute, ISangoGUIGroupAttribute
    {
        public string Name { get; private set; }

        public GUIFoldoutAttribute(string name)
        {
            Name = name;
        }
    }
}

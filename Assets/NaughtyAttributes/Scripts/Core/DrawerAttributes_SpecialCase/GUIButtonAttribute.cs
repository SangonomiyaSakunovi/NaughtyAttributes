using System;

namespace NaughtyAttributes
{
    public enum GUIButtonEnableMode
    {
        /// <summary>
        /// Button should be active always
        /// </summary>
        Always,
        /// <summary>
        /// Button should be active only in editor
        /// </summary>
        Editor,
        /// <summary>
        /// Button should be active only in playmode
        /// </summary>
        Playmode
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class GUIButtonAttribute : SangoGUIDrawerSpecialAttribute
    {
        public string Text { get; private set; }
        public GUIButtonEnableMode SelectedEnableMode { get; private set; }

        public GUIButtonAttribute(string text = null, GUIButtonEnableMode enabledMode = GUIButtonEnableMode.Always)
        {
            this.Text = text;
            this.SelectedEnableMode = enabledMode;
        }
    }
}

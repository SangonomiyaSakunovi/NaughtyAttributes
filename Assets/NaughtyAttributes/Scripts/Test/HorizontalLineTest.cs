using UnityEngine;

namespace NaughtyAttributes.Test
{
    public class HorizontalLineTest : MonoBehaviour
    {
        [GUIHorizontalLine(color: GUIDrawerColor.Black)]
        [Header("Black")]
        [GUIHorizontalLine(color: GUIDrawerColor.Blue)]
        [Header("Blue")]
        [GUIHorizontalLine(color: GUIDrawerColor.Gray)]
        [Header("Gray")]
        [GUIHorizontalLine(color: GUIDrawerColor.Green)]
        [Header("Green")]
        [GUIHorizontalLine(color: GUIDrawerColor.Indigo)]
        [Header("Indigo")]
        [GUIHorizontalLine(color: GUIDrawerColor.Orange)]
        [Header("Orange")]
        [GUIHorizontalLine(color: GUIDrawerColor.Pink)]
        [Header("Pink")]
        [GUIHorizontalLine(color: GUIDrawerColor.Red)]
        [Header("Red")]
        [GUIHorizontalLine(color: GUIDrawerColor.Violet)]
        [Header("Violet")]
        [GUIHorizontalLine(color: GUIDrawerColor.White)]
        [Header("White")]
        [GUIHorizontalLine(color: GUIDrawerColor.Yellow)]
        [Header("Yellow")]
        [GUIHorizontalLine(10.0f)]
        [Header("Thick")]
        public int line0;

        public HorizontalLineNest1 nest1;
    }

    [System.Serializable]
    public class HorizontalLineNest1
    {
        [GUIHorizontalLine]
        public int line1;

        public HorizontalLineNest2 nest2;
    }

    [System.Serializable]
    public class HorizontalLineNest2
    {
        [GUIHorizontalLine]
        public int line2;
    }
}

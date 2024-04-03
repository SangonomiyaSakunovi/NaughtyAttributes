using UnityEngine;

namespace NaughtyAttributes.Test
{
    public class BoxGroupTest : MonoBehaviour
    {
        [GUIBoxGroup("Integers")]
        public int int0;
        [GUIBoxGroup("Integers")]
        public int int1;

        [GUIBoxGroup("Floats")]
        public float float0;
        [GUIBoxGroup("Floats")]
        public float float1;

        [GUIBoxGroup("Sliders")]
        [GUISlider(0, 1)]
        public Vector2 slider0;
        [GUIBoxGroup("Sliders")]
        [GUISlider(0, 1)]
        public Vector2 slider1;

        public string str0;
        public string str1;

        [GUIBoxGroup]
        public Transform trans0;
        [GUIBoxGroup]
        public Transform trans1;
    }
}

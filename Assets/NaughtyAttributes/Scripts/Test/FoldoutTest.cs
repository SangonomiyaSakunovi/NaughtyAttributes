using UnityEngine;

namespace NaughtyAttributes.Test
{
    public class FoldoutTest : MonoBehaviour
    {
        [GUIFoldout("Integers")]
        public int int0;
        [GUIFoldout("Integers")]
        public int int1;

        [GUIFoldout("Floats")]
        public float float0;
        [GUIFoldout("Floats")]
        public float float1;

        [GUIFoldout("Sliders")]
        [GUISlider(0, 1)]
        public Vector2 slider0;
        [GUIFoldout("Sliders")]
        [GUISlider(0, 1)]
        public Vector2 slider1;

        public string str0;
        public string str1;

        [GUIFoldout("Transforms")]
        public Transform trans0;
        [GUIFoldout("Transforms")]
        public Transform trans1;
    }
}

using UnityEngine;
using System.Collections.Generic;

namespace NaughtyAttributes.Test
{
    //[CreateAssetMenu(fileName = "TestScriptableObjectB", menuName = "NaughtyAttributes/TestScriptableObjectB")]
    public class _TestScriptableObjectB : ScriptableObject
    {
        [GUISlider(0, 10)]
        public Vector2Int slider;
    }
}
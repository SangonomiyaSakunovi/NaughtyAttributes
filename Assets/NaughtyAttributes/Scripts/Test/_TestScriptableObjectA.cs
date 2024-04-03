using UnityEngine;
using System.Collections.Generic;

namespace NaughtyAttributes.Test
{
    //[CreateAssetMenu(fileName = "TestScriptableObjectA", menuName = "NaughtyAttributes/TestScriptableObjectA")]
    public class _TestScriptableObjectA : ScriptableObject
    {
        [GUIExpandable]
        public List<_TestScriptableObjectB> listB;
    }
}
using UnityEngine;
using System.Collections.Generic;

namespace NaughtyAttributes.Test
{
    public class DropdownTest : MonoBehaviour
    {
        [GUIDropdown("intValues")]
        public int intValue;

#pragma warning disable 414
        private int[] intValues = new int[] { 1, 2, 3 };
#pragma warning restore 414

        public DropdownNest1 nest1;
    }

    [System.Serializable]
    public class DropdownNest1
    {
        [GUIDropdown("StringValues")]
        public string stringValue;

        private List<string> StringValues { get { return new List<string>() { "A", "B", "C" }; } }

        public DropdownNest2 nest2;
    }

    [System.Serializable]
    public class DropdownNest2
    {
        [GUIDropdown("GetVectorValues")]
        public Vector3 vectorValue;

        private GUIDropdownList<Vector3> GetVectorValues()
        {
            return new GUIDropdownList<Vector3>()
            {
                { "Right", Vector3.right },
                { "Up", Vector3.up },
                { "Forward", Vector3.forward }
            };
        }
    }
}

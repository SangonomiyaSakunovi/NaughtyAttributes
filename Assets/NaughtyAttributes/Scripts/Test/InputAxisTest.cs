using UnityEngine;

namespace NaughtyAttributes.Test
{
    public class InputAxisTest : MonoBehaviour
    {
        [GUIInputAxis]
        public string inputAxis0;

        public InputAxisNest1 nest1;

        [GUIButton]
        private void LogInputAxis0()
        {
            Debug.Log(inputAxis0);
        }
    }

    [System.Serializable]
    public class InputAxisNest1
    {
        [GUIInputAxis]
        public string inputAxis1;

        public InputAxisNest2 nest2;
    }

    [System.Serializable]
    public struct InputAxisNest2
    {
        [GUIInputAxis]
        public string inputAxis2;
    }
}

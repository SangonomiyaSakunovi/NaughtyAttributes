using UnityEngine;

namespace NaughtyAttributes.Test
{
    public class TagTest : MonoBehaviour
    {
        [GUITag]
        public string tag0;

        public TagNest1 nest1;

        [GUIButton]
        private void LogTag0()
        {
            Debug.Log(tag0);
        }
    }

    [System.Serializable]
    public class TagNest1
    {
        [GUITag]
        public string tag1;

        public TagNest2 nest2;
    }

    [System.Serializable]
    public struct TagNest2
    {
        [GUITag]
        public string tag2;
    }
}

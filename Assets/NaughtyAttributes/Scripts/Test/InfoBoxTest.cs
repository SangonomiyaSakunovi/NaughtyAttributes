using UnityEngine;

namespace NaughtyAttributes.Test
{
    public class InfoBoxTest : MonoBehaviour
    {
        [GUIInfoBox("Normal", GUIInfoBoxType.Normal)]
        public int normal;

        public InfoBoxNest1 nest1;
    }

    [System.Serializable]
    public class InfoBoxNest1
    {
        [GUIInfoBox("Warning", GUIInfoBoxType.Warning)]
        public int warning;

        public InfoBoxNest2 nest2;
    }

    [System.Serializable]
    public class InfoBoxNest2
    {
        [GUIInfoBox("Error", GUIInfoBoxType.Error)]
        public int error;
    }
}

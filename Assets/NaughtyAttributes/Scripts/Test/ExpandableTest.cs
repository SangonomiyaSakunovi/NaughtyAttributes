using UnityEngine;

namespace NaughtyAttributes.Test
{
    public class ExpandableTest : MonoBehaviour
    {
        // See #294
        public int precedingField = 5;

        [GUIExpandable]
        public ScriptableObject obj0;

        public ExpandableScriptableObjectNest1 nest1;
    }

    [System.Serializable]
    public class ExpandableScriptableObjectNest1
    {
        [GUIExpandable]
        public ScriptableObject obj1;

        public ExpandableScriptableObjectNest2 nest2;
    }

    [System.Serializable]
    public class ExpandableScriptableObjectNest2
    {
        [GUIExpandable]
        public ScriptableObject obj2;
    }
}

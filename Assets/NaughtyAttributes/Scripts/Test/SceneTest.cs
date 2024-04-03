using UnityEngine;

namespace NaughtyAttributes.Test
{
    public class SceneTest : MonoBehaviour
    {
        [GUIScene]
        public string scene0;

        public SceneNest1 nest1;
    }

    [System.Serializable]
    public class SceneNest1
    {
        [GUIScene]
        public string scene1;

        public SceneNest2 nest2;
    }

    [System.Serializable]
    public struct SceneNest2
    {
        [GUIScene]
        public int scene2;
    }
}

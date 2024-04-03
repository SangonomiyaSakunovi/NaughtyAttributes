using UnityEngine;

namespace NaughtyAttributes.Test
{
    public class ShowAssetPreviewTest : MonoBehaviour
    {
        [GUIShowAssets]
        public Sprite sprite0;

        [GUIShowAssets(96, 96)]
        public GameObject prefab0;

        public ShowAssetPreviewNest1 nest1;
    }

    [System.Serializable]
    public class ShowAssetPreviewNest1
    {
        [GUIShowAssets]
        public Sprite sprite1;

        [GUIShowAssets(96, 96)]
        public GameObject prefab1;

        public ShowAssetPreviewNest2 nest2;
    }

    [System.Serializable]
    public class ShowAssetPreviewNest2
    {
        [GUIShowAssets]
        public Sprite sprite2;

        [GUIShowAssets(96, 96)]
        public GameObject prefab2;
    }
}

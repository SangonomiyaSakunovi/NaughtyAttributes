using UnityEngine;

namespace NaughtyAttributes.Test
{
    public class LayerTest : MonoBehaviour
    {
        [GUILayer]
        public int layerNumber0;

        [GUILayer]
        public string layerName0;

        public LayerNest1 nest1;

        [GUIButton]
        public void DebugLog()
        {
            Debug.LogFormat("{0} = {1}", nameof(layerNumber0), layerNumber0);
            Debug.LogFormat("{0} = {1}", nameof(layerName0), layerName0);
            Debug.LogFormat("LayerToName({0}) = {1}", layerNumber0, LayerMask.LayerToName(layerNumber0));
            Debug.LogFormat("NameToLayer({0}) = {1}", layerName0, LayerMask.NameToLayer(layerName0));
        }
    }

    [System.Serializable]
    public class LayerNest1
    {
        [GUILayer]
        public int layerNumber1;

        [GUILayer]
        public string layerName1;

        public LayerNest2 nest2;
    }

    [System.Serializable]
    public struct LayerNest2
    {
        [GUILayer]
        public int layerNumber2;

        [GUILayer]
        public string layerName2;
    }
}

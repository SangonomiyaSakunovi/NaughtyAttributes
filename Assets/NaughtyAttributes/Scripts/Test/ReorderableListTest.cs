using System.Collections.Generic;
using UnityEngine;

namespace NaughtyAttributes.Test
{
    public class ReorderableListTest : MonoBehaviour
    {
        [GUIReordList]
        public int[] intArray;

        [GUIReordList]
        public List<Vector3> vectorList;

        [GUIReordList]
        public List<SomeStruct> structList;

        [GUIReordList]
        public GameObject[] gameObjectsList;

        [GUIReordList]
        public List<Transform> transformsList;

        [GUIReordList]
        public List<MonoBehaviour> monoBehavioursList;
    }

    [System.Serializable]
    public struct SomeStruct
    {
        public int Int;
        public float Float;
        public Vector3 Vector;
    }
}

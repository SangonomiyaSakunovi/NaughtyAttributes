using UnityEngine;

namespace NaughtyAttributes.Test
{
    public class MinMaxValueTest : MonoBehaviour
    {
        [GUIMinValue(0)]
        public int min0Int;

        [GUIMaxValue(0)]
        public int max0Int;

        [GUIMinValue(0), GUIMaxValue(1)]
        public float range01Float;

        [GUIMinValue(0), GUIMaxValue(1)]
        public Vector2 range01Vector2;

        [GUIMinValue(0), GUIMaxValue(1)]
        public Vector3 range01Vector3;

        [GUIMinValue(0), GUIMaxValue(1)]
        public Vector4 range01Vector4;

        [GUIMinValue(0)]
        public Vector2Int min0Vector2Int;

        [GUIMaxValue(100)]
        public Vector2Int max100Vector2Int;

        [GUIMinValue(0)]
        public Vector3Int min0Vector3Int;

        [GUIMaxValue(100)]
        public Vector3Int max100Vector3Int;

        public MinMaxValueNest1 nest1;
    }

    [System.Serializable]
    public class MinMaxValueNest1
    {
        [GUIMinValue(0)]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public int min0Int;

        [GUIMaxValue(0)]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public int max0Int;

        [GUIMinValue(0), GUIMaxValue(1)]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public float range01Float;

        [GUIMinValue(0), GUIMaxValue(1)]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public Vector2 range01Vector2;

        [GUIMinValue(0), GUIMaxValue(1)]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public Vector3 range01Vector3;

        [GUIMinValue(0), GUIMaxValue(1)]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public Vector4 range01Vector4;

        [GUIMinValue(0)]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public Vector2Int min0Vector2Int;

        [GUIMaxValue(100)]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public Vector2Int max100Vector2Int;

        [GUIMinValue(0)]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public Vector3Int min0Vector3Int;

        [GUIMaxValue(100)]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public Vector3Int max100Vector3Int;

        public MinMaxValueNest2 nest2;
    }

    [System.Serializable]
    public class MinMaxValueNest2
    {
        [GUIMinValue(0)]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public int min0Int;

        [GUIMaxValue(0)]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public int max0Int;

        [GUIMinValue(0), GUIMaxValue(1)]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public float range01Float;

        [GUIMinValue(0), GUIMaxValue(1)]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public Vector2 range01Vector2;

        [GUIMinValue(0), GUIMaxValue(1)]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public Vector3 range01Vector3;

        [GUIMinValue(0), GUIMaxValue(1)]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public Vector4 range01Vector4;

        [GUIMinValue(0)]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public Vector2Int min0Vector2Int;

        [GUIMaxValue(100)]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public Vector2Int max100Vector2Int;

        [GUIMinValue(0)]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public Vector3Int min0Vector3Int;

        [GUIMaxValue(100)]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public Vector3Int max100Vector3Int;
    }
}

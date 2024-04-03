using UnityEngine;

namespace NaughtyAttributes.Test
{
    public class CurveRangeTest : MonoBehaviour
    {
        [GUICurveRange(0f, 0f, 1f, 1f, GUIDrawerColor.Yellow)]
        public AnimationCurve[] curves;

        [GUICurveRange(-1, -1, 1, 1, GUIDrawerColor.Red)]
        public AnimationCurve curve;

        [GUICurveRange(GUIDrawerColor.Orange)]
        public AnimationCurve curve1;

        [GUICurveRange(0, 0, 10, 10)]
        public AnimationCurve curve2;

        public CurveRangeNest1 nest1;

        [System.Serializable]
        public class CurveRangeNest1
        {
            [GUICurveRange(0, 0, 1, 1, GUIDrawerColor.Green)]
            public AnimationCurve curve;

            public CurveRangeNest2 nest2;
        }

        [System.Serializable]
        public class CurveRangeNest2
        {
            [GUICurveRange(0, 0, 5, 5, GUIDrawerColor.Blue)]
            public AnimationCurve curve;
        }
    }
}

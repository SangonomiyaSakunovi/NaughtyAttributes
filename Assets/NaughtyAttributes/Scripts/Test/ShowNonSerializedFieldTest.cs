using UnityEngine;

namespace NaughtyAttributes.Test
{
    public class ShowNonSerializedFieldTest : MonoBehaviour
    {
#pragma warning disable 414
        [GUIShowNonSerializedField]
        private ushort myUShort = ushort.MaxValue;

        [GUIShowNonSerializedField]
        private short myShort = short.MaxValue;

        [GUIShowNonSerializedField]
        private uint myUInt = uint.MaxValue;

        [GUIShowNonSerializedField]
        private int myInt = 10;

        [GUIShowNonSerializedField]
        private ulong myULong = ulong.MaxValue;

        [GUIShowNonSerializedField]
        private long myLong = long.MaxValue;

        [GUIShowNonSerializedField]
        private const float PI = 3.14159f;

        [GUIShowNonSerializedField]
        private static readonly Vector3 CONST_VECTOR = Vector3.one;
#pragma warning restore 414
    }
}

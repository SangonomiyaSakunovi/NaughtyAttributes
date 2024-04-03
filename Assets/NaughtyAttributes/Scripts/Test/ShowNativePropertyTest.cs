using UnityEngine;

namespace NaughtyAttributes.Test
{
    public class ShowNativePropertyTest : MonoBehaviour
    {
        [GUIShowNativeProperty]
        private Transform Transform
        {
            get
            {
                return transform;
            }
        }

        [GUIShowNativeProperty]
        private Transform ParentTransform
        {
            get
            {
                return transform.parent;
            }
        }

        [GUIShowNativeProperty]
        private ushort MyUShort
        {
            get
            {
                return ushort.MaxValue;
            }
        }

        [GUIShowNativeProperty]
        private short MyShort
        {
            get
            {
                return short.MaxValue;
            }
        }

        [GUIShowNativeProperty]
        private ulong MyULong
        {
            get
            {
                return ulong.MaxValue;
            }
        }

        [GUIShowNativeProperty]
        private long MyLong
        {
            get
            {
                return long.MaxValue;
            }
        }

        [GUIShowNativeProperty]
        private uint MyUInt
        {
            get
            {
                return uint.MaxValue;
            }
        }

        [GUIShowNativeProperty]
        private int MyInt
        {
            get
            {
                return int.MaxValue;
            }
        }
    }
}

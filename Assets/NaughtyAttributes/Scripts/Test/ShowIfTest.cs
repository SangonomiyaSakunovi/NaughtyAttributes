using System;
using UnityEngine;

namespace NaughtyAttributes.Test
{
    public class ShowIfTest : MonoBehaviour
    {
        public bool show1;
        public bool show2;
        public ShowIfEnum enum1;
        [GUIEnumFlags] public ShowIfEnumFlag enum2;

        [GUIShowIf(GUIConditionOperator.And, "show1", "show2")]
        [GUIReordList]
        public int[] showIfAll;

        [GUIShowIf(GUIConditionOperator.Or, "show1", "show2")]
        [GUIReordList]
        public int[] showIfAny;

        [GUIShowIf("enum1", ShowIfEnum.Case0)]
        [GUIReordList]
        public int[] showIfEnum;

        [GUIShowIf("enum2", ShowIfEnumFlag.Flag0)]
        [GUIReordList]
        public int[] showIfEnumFlag;

        [GUIShowIf("enum2", ShowIfEnumFlag.Flag0 | ShowIfEnumFlag.Flag1)]
        [GUIReordList]
        public int[] showIfEnumFlagMulti;

        public ShowIfNest1 nest1;
    }

    [System.Serializable]
    public class ShowIfNest1
    {
        public bool show1;
        public bool show2;
        public ShowIfEnum enum1;
        [GUIEnumFlags] public ShowIfEnumFlag enum2;
        public bool Show1 { get { return show1; } }
        public bool Show2 { get { return show2; } }
        public ShowIfEnum Enum1 { get { return enum1; } }
        public ShowIfEnumFlag Enum2 { get { return enum2; } }

        [GUIShowIf(GUIConditionOperator.And, "Show1", "Show2")]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public int showIfAll;

        [GUIShowIf(GUIConditionOperator.Or, "Show1", "Show2")]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public int showIfAny;

        [GUIShowIf("Enum1", ShowIfEnum.Case1)]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public int showIfEnum;

        [GUIShowIf("Enum2", ShowIfEnumFlag.Flag0)]
        [GUIAllowNesting]
        public int showIfEnumFlag;

        [GUIShowIf("Enum2", ShowIfEnumFlag.Flag0 | ShowIfEnumFlag.Flag1)]
        [GUIAllowNesting]
        public int showIfEnumFlagMulti;

        public ShowIfNest2 nest2;
    }

    [System.Serializable]
    public class ShowIfNest2
    {
        public bool show1;
        public bool show2;
        public ShowIfEnum enum1;
        [GUIEnumFlags] public ShowIfEnumFlag enum2;
        public bool GetShow1() { return show1; }
        public bool GetShow2() { return show2; }
        public ShowIfEnum GetEnum1() { return enum1; }
        public ShowIfEnumFlag GetEnum2() { return enum2; }

        [GUIShowIf(GUIConditionOperator.And, "GetShow1", "GetShow2")]
        [GUISlider(0.0f, 1.0f)] // AllowNesting attribute is not needed, because the field is already marked with a custom naughty property drawer
        public Vector2 showIfAll = new Vector2(0.25f, 0.75f);

        [GUIShowIf(GUIConditionOperator.Or, "GetShow1", "GetShow2")]
        [GUISlider(0.0f, 1.0f)] // AllowNesting attribute is not needed, because the field is already marked with a custom naughty property drawer
        public Vector2 showIfAny = new Vector2(0.25f, 0.75f);

        [GUIShowIf("GetEnum1", ShowIfEnum.Case2)]
        [GUISlider(0.0f, 1.0f)] // AllowNesting attribute is not needed, because the field is already marked with a custom naughty property drawer
        public Vector2 showIfEnum = new Vector2(0.25f, 0.75f);

        [GUIShowIf("GetEnum2", ShowIfEnumFlag.Flag0)]
        [GUISlider(0.0f, 1.0f)] // AllowNesting attribute is not needed, because the field is already marked with a custom naughty property drawer
        public Vector2 showIfEnumFlag;

        [GUIShowIf("GetEnum2", ShowIfEnumFlag.Flag0 | ShowIfEnumFlag.Flag1)]
        [GUISlider(0.0f, 1.0f)] // AllowNesting attribute is not needed, because the field is already marked with a custom naughty property drawer
        public Vector2 showIfEnumFlagMulti;
    }

    public enum ShowIfEnum
    {
        Case0,
        Case1,
        Case2
    }

    [Flags]
    public enum ShowIfEnumFlag
    {
        Flag0 = 1,
        Flag1 = 2,
        Flag2 = 4,
        Flag3 = 8
    }
}

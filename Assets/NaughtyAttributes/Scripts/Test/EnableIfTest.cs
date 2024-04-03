using System;
using UnityEngine;

namespace NaughtyAttributes.Test
{
    public class EnableIfTest : MonoBehaviour
    {
        public bool enable1;
        public bool enable2;
        public EnableIfEnum enum1;
        [GUIEnumFlags] public EnableIfEnumFlag enum2;

        [GUIEnableIf(GUIConditionOperator.And, "enable1", "enable2")]
        [GUIReordList]
        public int[] enableIfAll;

        [GUIEnableIf(GUIConditionOperator.Or, "enable1", "enable2")]
        [GUIReordList]
        public int[] enableIfAny;

        [GUIEnableIf("enum1", EnableIfEnum.Case0)]
        [GUIReordList]
        public int[] enableIfEnum;

        [GUIEnableIf("enum2", EnableIfEnumFlag.Flag0)]
        [GUIReordList]
        public int[] enableIfEnumFlag;

        [GUIEnableIf("enum2", EnableIfEnumFlag.Flag0 | EnableIfEnumFlag.Flag1)]
        [GUIReordList]
        public int[] enableIfEnumFlagMulti;

        public EnableIfNest1 nest1;
    }

    [System.Serializable]
    public class EnableIfNest1
    {
        public bool enable1;
        public bool enable2;
        public EnableIfEnum enum1;
        [GUIEnumFlags] public EnableIfEnumFlag enum2;
        public bool Enable1 { get { return enable1; } }
        public bool Enable2 { get { return enable2; } }
        public EnableIfEnum Enum1 { get { return enum1; } }
        public EnableIfEnumFlag Enum2 { get { return enum2; } }

        [GUIEnableIf(GUIConditionOperator.And, "Enable1", "Enable2")]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public int enableIfAll;

        [GUIEnableIf(GUIConditionOperator.Or, "Enable1", "Enable2")]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public int enableIfAny;

        [GUIEnableIf("Enum1", EnableIfEnum.Case1)]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public int enableIfEnum;

        [GUIEnableIf("Enum2", EnableIfEnumFlag.Flag0)]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public int enableIfEnumFlag;

        [GUIEnableIf("Enum2", EnableIfEnumFlag.Flag0 | EnableIfEnumFlag.Flag1)]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public int enableIfEnumFlagMulti;

        public EnableIfNest2 nest2;
    }

    [System.Serializable]
    public class EnableIfNest2
    {
        public bool enable1;
        public bool enable2;
        public EnableIfEnum enum1;
        [GUIEnumFlags] public EnableIfEnumFlag enum2;
        public bool GetEnable1() { return enable1; }
        public bool GetEnable2() { return enable2; }
        public EnableIfEnum GetEnum1() { return enum1; }
        public EnableIfEnumFlag GetEnum2() { return enum2; }

        [GUIEnableIf(GUIConditionOperator.And, "GetEnable1", "GetEnable2")]
        [GUISlider(0.0f, 1.0f)] // AllowNesting attribute is not needed, because the field is already marked with a custom naughty property drawer
        public Vector2 enableIfAll = new Vector2(0.25f, 0.75f);

        [GUIEnableIf(GUIConditionOperator.Or, "GetEnable1", "GetEnable2")]
        [GUISlider(0.0f, 1.0f)] // AllowNesting attribute is not needed, because the field is already marked with a custom naughty property drawer
        public Vector2 enableIfAny = new Vector2(0.25f, 0.75f);

        [GUIEnableIf("GetEnum1", EnableIfEnum.Case2)]
        [GUISlider(0.0f, 1.0f)] // AllowNesting attribute is not needed, because the field is already marked with a custom naughty property drawer
        public Vector2 enableIfEnum = new Vector2(0.25f, 0.75f);

        [GUIEnableIf("GetEnum2", EnableIfEnumFlag.Flag0)]
        [GUISlider(0.0f, 1.0f)] // AllowNesting attribute is not needed, because the field is already marked with a custom naughty property drawer
        public Vector2 enableIfEnumFlag;

        [GUIEnableIf("GetEnum2", EnableIfEnumFlag.Flag0 | EnableIfEnumFlag.Flag1)]
        [GUISlider(0.0f, 1.0f)] // AllowNesting attribute is not needed, because the field is already marked with a custom naughty property drawer
        public Vector2 enableIfEnumFlagMulti;
    }

    [System.Serializable]
    public enum EnableIfEnum
    {
        Case0,
        Case1,
        Case2
    }

    [Flags]
    public enum EnableIfEnumFlag
    {
        Flag0 = 1,
        Flag1 = 2,
        Flag2 = 4,
        Flag3 = 8
    }
}

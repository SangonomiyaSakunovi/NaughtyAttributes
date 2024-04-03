using UnityEngine;

namespace NaughtyAttributes.Test
{
    public class RequiredTest : MonoBehaviour
    {
        [GUIRequired]
        [SerializeField]
        private Transform trans0;

        public RequiredNest1 nest1;
    }

    [System.Serializable]
    public class RequiredNest1
    {
        [GUIRequired]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public Transform trans1;

        public RequiredNest2 nest2;
    }

    [System.Serializable]
    public class RequiredNest2
    {
        [GUIRequired("trans2 is invalid custom message - hohoho")]
        [GUIAllowNesting] // Because it's nested we need to explicitly allow nesting
        public Transform trans2;
    }
}

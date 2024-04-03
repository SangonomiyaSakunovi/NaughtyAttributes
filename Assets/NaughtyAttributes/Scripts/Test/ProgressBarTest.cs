using UnityEngine;

namespace NaughtyAttributes.Test
{
    public class ProgressBarTest : MonoBehaviour
    {
        [Header("Constant ProgressBar")]
        [GUIProgressBar("Health", 100, GUIDrawerColor.Red)]
        public float health = 50.0f;

        [Header("Nested ProgressBar")]
        public ProgressBarNest1 nest1;

        [Header("Dynamic ProgressBar")]
        [GUIProgressBar("Elixir", "maxElixir", color: GUIDrawerColor.Violet)]
        public int elixir = 50;
        public int maxElixir = 100;
    }

    [System.Serializable]
    public class ProgressBarNest1
    {
        [GUIProgressBar("Mana", 100, GUIDrawerColor.Blue)]
        public float mana = 25.0f;

        public ProgressBarNest2 nest2;
    }

    [System.Serializable]
    public class ProgressBarNest2
    {
        [GUIProgressBar("Stamina", 100, GUIDrawerColor.Green)]
        public float stamina = 75.0f;
    }
}

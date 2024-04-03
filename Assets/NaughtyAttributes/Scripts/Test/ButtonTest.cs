using System.Collections;
using UnityEngine;

namespace NaughtyAttributes.Test
{
    public class ButtonTest : MonoBehaviour
    {
        public int myInt;

        [GUIButton(enabledMode: GUIButtonEnableMode.Always)]
        private void IncrementMyInt()
        {
            myInt++;
        }

        [GUIButton("Decrement My Int", GUIButtonEnableMode.Editor)]
        private void DecrementMyInt()
        {
            myInt--;
        }

        [GUIButton(enabledMode: GUIButtonEnableMode.Playmode)]
        private void LogMyInt(string prefix = "MyInt = ")
        {
            Debug.Log(prefix + myInt);
        }

        [GUIButton("StartCoroutine")]
        private IEnumerator IncrementMyIntCoroutine()
        {
            int seconds = 5;
            for (int i = 0; i < seconds; i++)
            {
                myInt++;
                yield return new WaitForSeconds(1.0f);
            }
        }
    }
}

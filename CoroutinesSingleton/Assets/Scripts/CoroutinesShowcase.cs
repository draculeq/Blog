using System.Collections;
using Deadbit.Utils;
using Deadbit.Utils.Extensions;
using UnityEngine;

class CoroutinesShowcase : MonoBehaviour
{
    void Start()
    {
        this.StartDelayed(1.5f, () => Debug.Log("I am the message! (delayed by 1.5sec)"));
        Coroutines.Instance.StartDelayed(3, () => Debug.Log("I am the message! (delayed by 3 frames)"));
        Coroutines.Instance.Begin(TestCoroutine());
    }

    IEnumerator TestCoroutine()
    {
        for (int i = 0; i<5; i++)
{
            yield return new WaitForSeconds(1);
            Debug.Log("Test: " + i);
        }
    }
}
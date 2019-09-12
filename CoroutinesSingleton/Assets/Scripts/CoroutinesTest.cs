using Deadbit.Utils;
using Deadbit.Utils.Extensions;
using UnityEngine;

class CoroutinesTest : MonoBehaviour
{
    void Start()
    {
        Log("Preparing messages...");
        this.StartDelayed(1.5f, () => Log("I am the message! (delayed by 1.5sec)"));
        this.StartDelayed(3, () => Log("I am the message! (delayed by 3 frames)"));
        Log("Message sent!");


        Coroutines.Instance.StartDelayed(1f, () => Log("Coroutines Test"));
    }

    private void Log(string message)
    {
        Debug.LogFormat(LogType.Log, LogOption.NoStacktrace, this, string.Format("[Frame: {1}, Time: {2}] {0}", message, Time.frameCount, Time.time));
    }
}

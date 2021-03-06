﻿using System;
using System.Collections;
using UnityEngine;

namespace Deadbit.Utils.Extensions
{
    public static class MonoBehaviourExt
    {
        /// <summary>
        /// Invoke Coroutine which fire method after time
        /// </summary>
        /// <param name="monobehaviour">GameObject on which you want to perform the method</param>
        /// <param name="delay">Desired delay</param>
        /// <param name="callback">Delayed method</param>
        public static Coroutine StartDelayed(this MonoBehaviour monobehaviour, float delay, Action callback)
        {
            var coroutine = DelayedFire(delay, callback);
            return monobehaviour.StartCoroutine(coroutine);
        }

        public static Coroutine StartDelayed(this MonoBehaviour monobehaviour, int numberOfFrames, Action callback)
        {
            var coroutine = DelayedFire(numberOfFrames, callback);
            return monobehaviour.StartCoroutine(coroutine);
        }

        private static IEnumerator DelayedFire(float delay, Action callback)
        {
            yield return new WaitForSeconds(delay);
            callback();
        }

        private static IEnumerator DelayedFire(int numberOfFrames, Action callback)
        {
            while (numberOfFrames > 0)
            {
                yield return null;
                numberOfFrames--;
            }
            callback();
        }
    }
}
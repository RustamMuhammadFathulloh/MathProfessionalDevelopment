using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace SimpleTimer
{
    public class Timer : MonoBehaviour
    {
        public TMP_Text TimerText;
        float elapsedTime;
              

        void Update()
        {
            elapsedTime += Time.deltaTime;
            int minutes = Mathf.FloorToInt(elapsedTime/60);
            int seconds = Mathf.FloorToInt(elapsedTime % 60);
            TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}

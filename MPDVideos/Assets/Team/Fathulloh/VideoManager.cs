using CommonFeatures;
using ScriptableObjectArchitecture;
using System.Collections;
using UnityEngine;

namespace Math5_Lesson1
{
    public class VideoManager : Introduction
    {
        public BoolVariable StartAnim;

        private void Awake()
        {
            //StartFeatures.GetComponent<StartFeature>().SetInitialTexts(StartTexts);
            //VideoOpening();
        }


        void Update()
        {
            if (StartAnim.Value)
            {
                StartAnim.Value = false;

                VideoAnimationMethod();
            }
        }


        public void VideoAnimationMethod()
        {
            //Debug.Log("VideoManager work");

            FinishFeatures.GetComponent<FinishFeatures>().FinishAnimation();

            StartCoroutine(Transition());
        }

        IEnumerator Transition()
        {
            yield return new WaitForSeconds(2.5f);
            StartFeatureSwitch(false);
        }

    }
}

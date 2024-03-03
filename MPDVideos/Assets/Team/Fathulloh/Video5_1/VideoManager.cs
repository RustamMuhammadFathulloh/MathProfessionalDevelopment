using CommonFeatures;
using ScriptableObjectArchitecture;
using System.Collections;
using UnityEngine;

namespace Math5_Lesson1
{
    public class VideoManager : Introduction
    {
        public BoolVariable StartAnim;
        
        public GameObject TitleObject;
        public AudioClip[] AudioClips5_1;

        private AudioSource _audioSource;
        private int _audioIndex;

        private void Awake()
        {
            _audioSource = gameObject.GetComponent<AudioSource>();
        }

        //void Update()
        //{
        //    if (StartAnim.Value)
        //    {
        //        StartAnim.Value = false;

        //        VideoAnimationMethod();
        //    }
        //}


        public void VideoAnimationMethod()
        {
            Debug.Log("VideoManager work");



            //FinishFeatures.GetComponent<FinishFeatures>().FinishAnimation();

            StartCoroutine(Transition());
        }

        IEnumerator Transition()
        {
            yield return new WaitForSeconds(2.5f);
            //StartFeatureSwitch(false);
        }






        
        public void PlayAudio()
        {
            _audioSource.PlayOneShot(AudioClips5_1[_audioIndex]);
            _audioIndex++;
        }

    }
}

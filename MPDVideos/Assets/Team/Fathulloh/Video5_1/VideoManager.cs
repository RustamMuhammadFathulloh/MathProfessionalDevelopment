using CommonFeatures;
using ScriptableObjectArchitecture;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;

namespace Math5_Lesson1
{
    public class VideoManager : Introduction
    {
        //public BoolVariable StartAnim;
        [Header("First Parent")]
        public GameObject FirstParent;
        public GameObject TitleObject;
        public Image[] Lines;
        public GameObject[] LeftNodes;
        public GameObject RightNode;
        public GameObject OperationsEllips;

        [Header("Second Parent")]
        public GameObject SecondParent;
        public EachObject TasviriyAnanaviyText;
        public EachObject UslubiyYondashuvText;
        public EachObject PicAbstractText;
        public EachObject PicRepreseText;
        public Image[] LinesParent2;
        public GameObject GreenRect;
        public GameObject OrangeRect;

        [Header("Common things")]
        public AudioClip[] AudioClips5_1;
        public GameObject Transition1;
        public GameObject Transition2;
        private AudioSource _audioSource;
        private int _audioIndex;

        private void Awake()
        {
            _audioSource = gameObject.GetComponent<AudioSource>();
        }        


        public void VideoAnimationMethod()
        {
            // 1- audio play qilinmaydi. 2- va 3- audiolar esa StartFwatureni ichida play bo'ladi. 
            _audioIndex = 3;

            StartCoroutine(FirstParentAnimations());
            //StartCoroutine(SecondParentAnimation());

            //FinishFeatures.GetComponent<FinishFeatures>().FinishAnimation();
            //StartCoroutine(Transition());
        }


        float duration1 = 0.5f;
        float durationOne = 1;

        IEnumerator FirstParentAnimations()
        {            
            yield return new WaitForSeconds(0.1f);
            TitleObject.GetComponent<EachObject>().FadeText(1, duration1);
            yield return new WaitForSeconds(duration1);
            PlayAudio();  //4
            yield return new WaitForSeconds(duration1);
            TitleObject.GetComponent<EachObject>().Movement(new Vector2(0, Screen.height / 4), duration1);
            yield return new WaitForSeconds(2 * duration1);

            //Lines
            float duration0 = 0.5f;
            Lines[0].DOFillAmount(1, duration0);
            yield return new WaitForSeconds(duration0);
            Lines[1].DOFillAmount(1, duration0 * 3);
            yield return new WaitForSeconds(duration0 * 3);
            Lines[2].DOFillAmount(1, duration0);
            yield return new WaitForSeconds(2 * duration0);            

            // LeftNode
            PlayAudio();  // 5
            for (int i = 0; i < LeftNodes.Length; i++)
            {
                LeftNodes[i].transform.DOScale(1, duration0);
                yield return new WaitForSeconds(1.4f + i * 0.1f);
            }
            yield return new WaitForSeconds((float)AudioClips5_1[4].length / 2);

            PlayAudio();  // 6
            Lines[3].DOFillAmount(1, duration0);
            yield return new WaitForSeconds(2);
            OperationsEllips.transform.DOScale(1, duration0);
            yield return new WaitForSeconds(3 * duration0);

            PlayAudio();  // 7
            float durQuarter = 0.25f;
            OperationsEllips.transform.GetChild(0).transform.DOScale(1, 1);
            yield return new WaitForSeconds(AudioClips5_1[6].length + durQuarter);
            PlayAudio();  // 8
            OperationsEllips.transform.GetChild(1).transform.DOScale(1, 1);
            yield return new WaitForSeconds(AudioClips5_1[7].length + durQuarter);
            PlayAudio();  // 9
            OperationsEllips.transform.GetChild(2).transform.DOScale(1, 1);
            yield return new WaitForSeconds(AudioClips5_1[8].length);

            
            PlayAudio();  // 10
            Lines[4].DOFillAmount(1, 3 * duration0);
            yield return new WaitForSeconds(3 * duration0);
            Lines[5].DOFillAmount(1, duration0);
            yield return new WaitForSeconds(duration0);
            RightNode.transform.DOScale(1, duration0);
            yield return new WaitForSeconds(AudioClips5_1[9].length - 3 * duration0);

            StartCoroutine(SecondParentAnimation());
        }


        IEnumerator SecondParentAnimation()
        {
            yield return new WaitForSeconds(0.1f);
            Transition1.SetActive(true);
            yield return new WaitForSeconds(0.25f);
            FirstParent.SetActive(false);
            SecondParent.SetActive(true);
            yield return new WaitForSeconds(duration1);

            PlayAudio();  // 11
            TasviriyAnanaviyText.FadeText(1, duration1);
            yield return new WaitForSeconds(5);
            TasviriyAnanaviyText.FadeText(0, duration1);
            yield return new WaitForSeconds(duration1);
            UslubiyYondashuvText.MoveToInitialPos(duration1);
            PicAbstractText.MoveToCenter(duration1);
            yield return new WaitForSeconds(duration1);

            for (int i = 0; i < LinesParent2.Length; i++)
            {
                if (i % 2 == 0)
                {
                    LinesParent2[i].DOFillAmount(1, 0.2f);
                    yield return new WaitForSeconds(0.2f);
                }
                else
                {
                    LinesParent2[i].DOFillAmount(1, 0.8f);
                    yield return new WaitForSeconds(0.8f);
                }
            }
            yield return new WaitForSeconds(duration1);
            PicRepreseText.MoveToCenter(duration1);


        }


        IEnumerator Transition()
        {
            yield return new WaitForSeconds(2.5f);
            //StartFeatureSwitch(false);
        }

        
        public void PlayAudio()
        {
            _audioSource.PlayOneShot(AudioClips5_1[_audioIndex]);
            Debug.Log(_audioIndex + 1 + "  =  " + AudioClips5_1[_audioIndex].length + "  =  " + DateTime.Now);
            _audioIndex++;
        }

    }
}

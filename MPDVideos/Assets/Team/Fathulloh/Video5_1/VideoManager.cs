using CommonFeatures;
using ScriptableObjectArchitecture;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;
using TMPro;

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
        public Image SystemBracket;
        public EachObject AbstractRepresentation;
        public TMP_Text[] FadedTexts;

        [Header("Third Parent")]
        public GameObject ThirdParent;
        public EachObject LetsBeginToTeach;
        public EachObject TeachingOrderOfOperation;
        public TMP_Text TaskNumberText;
        public Image[] TaskTextImages;


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

            //StartCoroutine(FirstParentAnimations());
            StartCoroutine(SecondParentAnimation());
            //StartCoroutine(ThirdParentAnimation());
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
            yield return new WaitForSeconds((float)AudioClips5_1[4].length / 3);

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
            _audioIndex = 10;
            yield return new WaitForSeconds(0.1f);
            Transition1.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            FirstParent.SetActive(false);
            SecondParent.SetActive(true);
            yield return new WaitForSeconds(duration1);            
            TasviriyAnanaviyText.FadeText(1, duration1);
            yield return new WaitForSeconds(duration1);

            PlayAudio();  // 11
            Transition1.SetActive(false);
            yield return new WaitForSeconds(3);
            TasviriyAnanaviyText.FadeText(0, duration1);
            yield return new WaitForSeconds(duration1);
            UslubiyYondashuvText.MoveToInitialPos(duration1);
            PicAbstractText.MoveToInitialPos(duration1);
            yield return new WaitForSeconds(duration1);

            PicRepreseText.MoveToInitialPos(duration1);

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

            GreenRect.GetComponent<Image>().DOFade(1, duration1);
            GreenRect.transform.GetChild(0).GetComponent<TMP_Text>().DOFade(1, duration1);
            yield return new WaitForSeconds(duration1);
            OrangeRect.GetComponent<Image>().DOFade(1, duration1);
            OrangeRect.transform.GetChild(0).GetComponent<TMP_Text>().DOFade(1, duration1);
            yield return new WaitForSeconds(duration1);

            SystemBracket.DOFillAmount(1, durationOne);
            yield return new WaitForSeconds(durationOne);

            FadedTexts[0].DOFade(1, duration1);
            yield return new WaitForSeconds(duration1);
            FadedTexts[1].DOFade(1, duration1);
            yield return new WaitForSeconds(duration1);

            AbstractRepresentation.MoveToInitialPos(1);
            yield return new WaitForSeconds(durationOne);

            FadedTexts[2].DOFade(1, duration1);
            yield return new WaitForSeconds(duration1);
            FadedTexts[3].DOFade(1, duration1);
            yield return new WaitForSeconds(2 * duration1);

            StartCoroutine(ThirdParentAnimation());
        }


        IEnumerator ThirdParentAnimation()
        {
            _audioIndex = 11;
            yield return new WaitForSeconds(0.1f);
            Transition1.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            SecondParent.SetActive(false);
            ThirdParent.SetActive(true);
            yield return new WaitForSeconds(duration1);
            LetsBeginToTeach.FadeText(1, duration1);
            yield return new WaitForSeconds(duration1);

            PlayAudio();  // 12
            Transition1.SetActive(false);
            yield return new WaitForSeconds(AudioClips5_1[11].length);
            LetsBeginToTeach.FadeText(0, duration1);
            yield return new WaitForSeconds(duration1);

            PlayAudio();  // 13
            TeachingOrderOfOperation.MoveToInitialPos(duration1);
            yield return new WaitForSeconds(AudioClips5_1[12].length - 1);
                        
            TaskNumberText.DOFade(1, duration1);
            yield return new WaitForSeconds(duration1);

            //Masala shartini ko'rsatish.
            PlayAudio();  // 14
            TaskTextImages[0].DOFade(0, durationOne);
            yield return new WaitForSeconds(5 * durationOne);
            TaskTextImages[1].DOFade(0, durationOne);
            TaskTextImages[2].DOFade(0, durationOne);
            yield return new WaitForSeconds(3 * durationOne);
            TaskTextImages[3].DOFade(0, durationOne);
            yield return new WaitForSeconds(3 * durationOne);
            TaskTextImages[4].DOFade(0, durationOne);
            yield return new WaitForSeconds(durationOne);



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

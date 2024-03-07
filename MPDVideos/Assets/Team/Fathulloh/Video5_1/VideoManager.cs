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
        public GameObject BlackRectangleUpper;
        public Image BlackLineAmount1;
        public GameObject BlackRectangleLower;
        public Image BlackLineAmount2;
        public Image[] RectFadedImages;
        public TMP_Text[] RectFadedTexts;
        public GameObject HandCursor;
        public GameObject SecondHandCursor;
        public Image BlueArrow;
        public BracketManager BracketUpper;
        public BracketManager BracketLower;
        public TMP_Text[] MisolTexts_1;
        public TMP_Text[] MisolTexts_2;
        public TMP_Text[] MisolTexts_3;
        public GameObject TextRectangleParent;
        public Image UnderLine;

        [Header("Common things")]
        public AudioClip[] AudioClips5_1;
        public GameObject Transition1;
        public GameObject Transition2;
        

        private AudioSource _audioSource;
        private int _audioIndex;
        readonly float durationHalf = 0.5f;
        readonly float durationOne = 1;
        readonly float durationSevenFive = 0.75f;
        readonly float durationQuarter = 0.25f;

        private void Awake()
        {
            _audioSource = gameObject.GetComponent<AudioSource>();
        }        


        public void VideoAnimationMethod()
        {
            // 1- audio play qilinmaydi. 2- va 3- audiolar esa StartFwatureni ichida play bo'ladi. 
            _audioIndex = 3;

            //StartCoroutine(FirstParentAnimations());
            //StartCoroutine(SecondParentAnimation());
            StartCoroutine(ThirdParentAnimation());
            //FinishFeatures.GetComponent<FinishFeatures>().FinishAnimation();
            //StartCoroutine(Transition());
        }
                

        IEnumerator FirstParentAnimations()
        {            
            yield return new WaitForSeconds(0.1f);
            TitleObject.GetComponent<EachObject>().FadeText(1, durationHalf);
            yield return new WaitForSeconds(durationHalf);
            PlayAudio();  //4
            yield return new WaitForSeconds(durationHalf);
            TitleObject.GetComponent<EachObject>().Movement(new Vector2(0, Screen.height / 4), durationHalf);
            yield return new WaitForSeconds(2 * durationHalf);

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
            yield return new WaitForSeconds(durationHalf);            
            TasviriyAnanaviyText.FadeText(1, durationHalf);
            yield return new WaitForSeconds(durationHalf);

            PlayAudio();  // 11
            Transition1.SetActive(false);  // Reset transition
            yield return new WaitForSeconds(4);
            TasviriyAnanaviyText.FadeText(0, durationHalf);
            yield return new WaitForSeconds(durationHalf);
            UslubiyYondashuvText.MoveToInitialPos(durationOne);
            PicAbstractText.MoveToInitialPos(durationHalf);
            yield return new WaitForSeconds(durationHalf);

            PicRepreseText.MoveToInitialPos(durationHalf);

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
            yield return new WaitForSeconds(durationHalf);

            GreenRect.GetComponent<Image>().DOFade(1, durationHalf);
            GreenRect.transform.GetChild(0).GetComponent<TMP_Text>().DOFade(1, durationHalf);
            yield return new WaitForSeconds(durationHalf);
            OrangeRect.GetComponent<Image>().DOFade(1, durationHalf);
            OrangeRect.transform.GetChild(0).GetComponent<TMP_Text>().DOFade(1, durationHalf);
            yield return new WaitForSeconds(durationHalf);

            SystemBracket.DOFillAmount(1, durationHalf);
            yield return new WaitForSeconds(durationHalf + 0.1f);

            FadedTexts[0].DOFade(1, durationHalf - 0.1f);
            yield return new WaitForSeconds(durationHalf);
            FadedTexts[1].DOFade(1, durationHalf - 0.1f);
            yield return new WaitForSeconds(durationHalf);

            AbstractRepresentation.MoveToInitialPos(durationHalf);
            yield return new WaitForSeconds(durationHalf + 0.1f);

            FadedTexts[2].DOFade(1, durationHalf);
            yield return new WaitForSeconds(durationHalf);
            FadedTexts[3].DOFade(1, durationHalf);
            yield return new WaitForSeconds(2 * durationHalf);

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
            yield return new WaitForSeconds(durationHalf);
            LetsBeginToTeach.FadeText(1, durationHalf);
            yield return new WaitForSeconds(durationHalf);

            PlayAudio();  // 12
            Transition1.SetActive(false);
            yield return new WaitForSeconds(AudioClips5_1[11].length);
            
            PlayAudio();  // 13
            LetsBeginToTeach.FadeText(0, durationOne);
            yield return new WaitForSeconds(durationHalf);
            TeachingOrderOfOperation.MoveToInitialPos(durationOne);
            yield return new WaitForSeconds(AudioClips5_1[12].length - 1);
                        
            //TaskNumberText.DOFade(1, durationHalf);
            yield return new WaitForSeconds(durationHalf);

            //Masala shartini ko'rsatish.
            PlayAudio();  // 14
            TaskNumberText.DOFade(1, durationHalf);
            yield return new WaitForSeconds(durationHalf);
            TaskTextImages[0].DOFade(0, durationOne);
            yield return new WaitForSeconds(4.5f * durationOne);
            TaskTextImages[1].DOFade(0, durationOne);
            TaskTextImages[2].DOFade(0, durationOne);
            yield return new WaitForSeconds(3.5f * durationOne);
            TaskTextImages[3].DOFade(0, durationOne);
            yield return new WaitForSeconds(3 * durationOne);
            TaskTextImages[4].DOFade(0, durationOne);
            yield return new WaitForSeconds(durationOne);
            yield return new WaitForSeconds(2);

            // Upper Rectangle
            BlackRectangleUpper.transform.DOScale(1, 1);
            yield return new WaitForSeconds(durationOne);
            BlackLineAmount1.DOFillAmount(1, durationHalf);
            yield return new WaitForSeconds(durationHalf);

            RectFadedImages[0].DOFade(1, 1);
            yield return new WaitForSeconds(durationOne);

            HandCursor.transform.DOScale(1, durationHalf);
            yield return new WaitForSeconds(durationHalf);
            yield return new WaitForSeconds(1);

            RectFadedTexts[0].DOFade(1, durationHalf);
            yield return new WaitForSeconds(durationHalf);
            RectFadedImages[1].DOFade(1, durationOne);
            yield return new WaitForSeconds(durationOne);
            RectFadedTexts[1].DOFade(1, durationHalf);
            yield return new WaitForSeconds(durationHalf);
            HandCursor.GetComponent<Image>().DOFade(0, durationHalf);
            yield return new WaitForSeconds(durationOne);
            BracketUpper.BracketFillAmount(1, durationOne);
            yield return new WaitForSeconds(durationOne);
            RectFadedTexts[2].DOFade(1, durationHalf);
            yield return new WaitForSeconds(durationOne);
            yield return new WaitForSeconds(1);

            BlueArrow.DOFade(1, durationHalf);
            yield return new WaitForSeconds(durationHalf);

            // Lower Rectangle
            BlackRectangleLower.transform.DOScale(1, 1);
            yield return new WaitForSeconds(durationOne);
            BlackLineAmount2.DOFillAmount(1, durationHalf);
            yield return new WaitForSeconds(durationHalf);
            RectFadedImages[2].DOFade(1, durationHalf);
            RectFadedImages[3].DOFade(1, durationHalf);
            RectFadedTexts[3].DOFade(1, durationHalf);
            RectFadedTexts[4].DOFade(1, durationHalf);
            yield return new WaitForSeconds(durationHalf);
            yield return new WaitForSeconds(2);

            BracketLower.BracketFillAmount(1, durationOne);
            yield return new WaitForSeconds(durationOne);
            RectFadedTexts[5].DOFade(1, durationHalf);
            yield return new WaitForSeconds(durationOne);
            SecondHandCursor.transform.DOScale(1, durationHalf);
            yield return new WaitForSeconds(3 * durationOne);
            SecondHandCursor.GetComponent<Image>().DOFade(0, durationOne);
            yield return new WaitForSeconds(3);


            for (int i = 0; i < MisolTexts_1.Length; i++)
            {
                MisolTexts_1[i].DOFade(1, durationHalf);
                yield return new WaitForSeconds(durationHalf);
            }
            yield return new WaitForSeconds(6.5f * durationOne);

            PlayAudio();  // 15      Ichida yozuvi bor kvadratni chizadi. 
            TextRectangleParent.transform.GetChild(0).GetComponent<TMP_Text>().DOFade(1, durationOne);
            for (int i = 1; i < TextRectangleParent.transform.childCount; i++)
            {
                TextRectangleParent.transform.GetChild(i).GetComponent<Image>().DOFillAmount(1, durationQuarter + i / 2 * durationQuarter);
                yield return new WaitForSeconds(durationQuarter + i/2 * durationQuarter);
            }
            yield return new WaitForSeconds(AudioClips5_1[14].length - 2 * durationOne);

            PlayAudio();  // 16
            UnderLine.DOFillAmount(1, durationSevenFive);
            yield return new WaitForSeconds(durationOne);
            for (int i = 0; i < MisolTexts_2.Length; i++)
            {
                MisolTexts_2[i].DOFade(1, durationHalf);
                yield return new WaitForSeconds(durationSevenFive);
            }

            yield return new WaitForSeconds(durationOne);

            for (int i = 0; i < MisolTexts_3.Length; i++)
            {
                MisolTexts_3[i].DOFade(1, durationHalf);
                yield return new WaitForSeconds(durationSevenFive);
            }
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

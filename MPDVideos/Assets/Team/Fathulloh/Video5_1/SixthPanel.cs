using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Math5_Lesson1
{
    public class SixthPanel : MonoBehaviour
    {
        [Header("Main variables")]
        public VideoManager VideoManager5_1;
        public GameObject TeachingOrderOfOperation;
        public Image WhitePanel;
        public GameObject TaskFour;

        [Header("Sixth parent")]
        public Image[] FadedImages;
        public BracketManager UpperBracket;
        public GameObject UpperRectModel;
        public GameObject LowerRectModel;
        public TMP_Text TotalNumberText;
        public Image[] FillAmaunts;
        public Image[] FadedColors;
        public TMP_Text[] FadedTexts;
        public Image BlueArrow;

        public GameObject FirstHandCursor;
        public GameObject SecondHandCursor;

        public TMP_Text[] MisolText1;
        public TMP_Text[] MisolText2;
        public TMP_Text[] MisolText3;

        public GameObject TextRectangleParent;
        public TMP_Text FinalAnswerText;

        readonly float durationOne = 1;
        readonly float durationSevenFive = 0.75f;
        readonly float durationHalf = 0.5f;
        readonly float durationQuarter = 0.25f;

        public UnityEvent NextAnimations;


        private void Awake()
        {
            TaskFour.SetActive(false);
        }


        public void VideoAnimationMethod()
        {
            StartCoroutine(SixthParentAnimation());
        }


        IEnumerator SixthParentAnimation()
        {
            yield return new WaitForSeconds(durationHalf);
            VideoManager5_1.PlayAudio();  //  27
            yield return new WaitForSeconds(durationHalf);
            TeachingOrderOfOperation.SetActive(true);
            WhitePanel.DOFade(1, 2 * durationOne);
            yield return new WaitForSeconds(3 * durationOne);
            TaskFour.SetActive(true);
            yield return new WaitForSeconds(durationOne);

            VideoManager5_1.PlayAudio();  //  28
            yield return new WaitForSeconds(durationHalf);
            FadedImages[0].DOFade(0, durationOne);
            yield return new WaitForSeconds(3 * durationOne + durationHalf);
            FadedImages[1].DOFade(0, durationOne);
            FadedImages[2].DOFade(0, durationOne);
            yield return new WaitForSeconds(6f * durationOne + durationSevenFive);
            FadedImages[3].DOFade(0, durationOne);
            yield return new WaitForSeconds(3 * durationOne);


            // First rect model.
            VideoManager5_1.PlayAudio();  //  29
            yield return new WaitForSeconds(2 * durationOne);
            UpperRectModel.transform.DOScale(1, durationOne);
            yield return new WaitForSeconds(durationOne);
            FillAmaunts[0].DOFillAmount(1, durationHalf);
            yield return new WaitForSeconds(durationOne);

            FadedColors[0].DOFade(1, durationHalf);
            yield return new WaitForSeconds(durationQuarter);
            FadedTexts[0].DOFade(1, durationHalf);
            yield return new WaitForSeconds(durationHalf);

            FadedColors[1].DOFade(1, durationHalf);
            yield return new WaitForSeconds(durationQuarter);
            FadedTexts[1].DOFade(1, durationHalf);
            yield return new WaitForSeconds(durationHalf);

            UpperBracket.BracketFillAmount(1, durationHalf);
            yield return new WaitForSeconds(durationOne);
                        
            TotalNumberText.DOFade(1, durationHalf);
            yield return new WaitForSeconds(1.5f * durationOne);
            FirstHandCursor.transform.DOScale(1, durationHalf);
            yield return new WaitForSeconds(2 * durationOne + durationHalf);            
            
            FirstHandCursor.GetComponent<Image>().DOFade(0, durationHalf);
            yield return new WaitForSeconds(durationHalf);

            BlueArrow.DOFade(1, durationHalf);
            yield return new WaitForSeconds(durationOne);

            // Second rect model.
            LowerRectModel.transform.DOScale(1, durationHalf);
            yield return new WaitForSeconds(durationOne);
            FillAmaunts[1].DOFillAmount(1, durationHalf);
            yield return new WaitForSeconds(durationOne);

            FadedColors[2].DOFade(1, durationHalf);
            FadedTexts[2].DOFade(1, durationHalf);            
            FadedColors[3].DOFade(1, durationHalf);
            FadedTexts[3].DOFade(1, durationHalf);
            yield return new WaitForSeconds(durationOne + durationHalf);

            yield return new WaitForSeconds(2 * durationOne);
            for (int i = 0; i < MisolText1.Length; i++)
            {
                MisolText1[i].DOFade(1, durationHalf);
                yield return new WaitForSeconds(durationHalf);
            }
            yield return new WaitForSeconds(2 * durationOne);
            SecondHandCursor.transform.DOScale(1, durationHalf);
            yield return new WaitForSeconds(3 * durationOne);
            SecondHandCursor.GetComponent<Image>().DOFade(0, durationHalf);
            yield return new WaitForSeconds(durationOne + durationHalf);

            VideoManager5_1.PlayAudio();  //  30
            yield return new WaitForSeconds(durationHalf);
            TextRectangleParent.transform.GetChild(0).GetComponent<TMP_Text>().DOFade(1, durationOne);
            for (int i = 1; i < TextRectangleParent.transform.childCount; i++)
            {
                TextRectangleParent.transform.GetChild(i).GetComponent<Image>().DOFillAmount(1, durationQuarter + i / 2 * durationQuarter);
                yield return new WaitForSeconds(durationQuarter + i / 2 * durationQuarter);
            }
            yield return new WaitForSeconds(VideoManager5_1.LengthOfAudioClip(29) - 2 * durationOne);


            VideoManager5_1.PlayAudio();  //  31
            yield return new WaitForSeconds(5 * durationOne);

            for (int i = 0; i < MisolText2.Length; i++)
                MisolText2[i].DOFade(1, durationHalf);
            yield return new WaitForSeconds(2 * durationOne);

            MisolText3[0].DOFade(1, durationHalf);
            MisolText3[1].DOFade(1, durationHalf);
            yield return new WaitForSeconds(2 * durationOne);

            FinalAnswerText.DOFade(1, durationOne);
            yield return new WaitForSeconds(VideoManager5_1.LengthOfAudioClip(30) - 8 * durationOne);

            VideoManager5_1.PlayAudio();  //  32
            yield return new WaitForSeconds(VideoManager5_1.LengthOfAudioClip(31) + durationHalf);
            VideoManager5_1.PlayAudio();  //  33
            yield return new WaitForSeconds(VideoManager5_1.LengthOfAudioClip(32) + durationHalf);
            

            NextAnimations.Invoke();
        }
    }
}

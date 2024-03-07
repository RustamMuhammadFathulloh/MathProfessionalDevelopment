using CommonFeatures;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Math5_Lesson1
{
    public class FourthPanel : MonoBehaviour
    {
        [Header("Main variables")]        
        public VideoManager VideoManager5_1;
        public GameObject TeachingOrderOfOperation;
        public Image WhitePanel;
        public GameObject TaskTwo;

        [Header("Fourth parent")]
        public Image[] FadedImages;
        public BracketManager UpperBracket;
        public GameObject UpperRectModel;
        public TMP_Text QuestionMark1;
        
        public Image[] FillAmounts;
        public Image[] FadedColors;
        public TMP_Text[] FadedTexts;

        public GameObject LowerRectModel;
        public Image BlueArrow;
        
        public GameObject FirstHandCursor;
        public GameObject SecondHandCursor;
        public GameObject ThirdHandCursor;
        public TMP_Text[] MisolText1;
        public TMP_Text[] MisolText2;
        public TMP_Text[] MisolText3;
        public GameObject TextRectangleParent;
        public Image UnderLine;
        public TMP_Text FinalAnswerText;

        readonly float durationOne = 1;
        readonly float durationHalf = 0.5f;
        readonly float durationQuarter = 0.25f;

        public UnityEvent NextAnimations;


        private void Awake()
        {
            TaskTwo.SetActive(false);
        }


        public void VideoAnimationMethod()
        {
            StartCoroutine(FourthParentAnimation());
        }


        IEnumerator FourthParentAnimation()
        {
            VideoManager5_1.PlayAudio();  //  17
            yield return new WaitForSeconds(durationHalf);
            TeachingOrderOfOperation.SetActive(true);
            WhitePanel.DOFade(1, durationOne);
            yield return new WaitForSeconds(durationOne);
            TaskTwo.SetActive(true);
            yield return new WaitForSeconds(durationOne);

            VideoManager5_1.PlayAudio();  //  18
            for (int i = 0; i < FadedImages.Length; i++)
            {
                FadedImages[i].DOFade(0, durationOne);
                yield return new WaitForSeconds(5 * durationOne);
            }

            //yield return new WaitForSeconds(3 * durationOne);
            UpperRectModel.transform.DOScale(1, durationOne);
            UpperBracket.BracketFillAmount(1, durationOne);
            yield return new WaitForSeconds(2 * durationOne);
            
            FillAmounts[0].DOFillAmount(1, durationHalf);
            yield return new WaitForSeconds(durationHalf);
            FillAmounts[1].DOFillAmount(1, durationHalf);
            yield return new WaitForSeconds(durationHalf);

            QuestionMark1.DOFade(1, durationOne);
            yield return new WaitForSeconds(durationOne);
            FirstHandCursor.transform.DOScale(1, durationHalf);
            yield return new WaitForSeconds(2 * durationOne);
            FirstHandCursor.GetComponent<Image>().DOFade(0, durationHalf);
            yield return new WaitForSeconds(durationOne);

            FadedColors[0].DOFade(1, durationHalf);
            FadedColors[1].DOFade(1, durationHalf);
            FadedColors[2].DOFade(1, durationHalf);
            yield return new WaitForSeconds(durationHalf);
            FadedTexts[0].DOFade(1, durationOne);
            FadedTexts[1].DOFade(1, durationOne);
            FadedTexts[2].DOFade(1, durationOne);
            yield return new WaitForSeconds(2 * durationOne + 0.25f);
            
            BlueArrow.DOFade(1, durationHalf);
            yield return new WaitForSeconds(durationOne);

            // Second rect model.
            LowerRectModel.transform.DOScale(1, durationHalf);
            yield return new WaitForSeconds(2 * durationOne);
            SecondHandCursor.transform.DOScale(1, durationHalf);
            yield return new WaitForSeconds(3 * durationOne + durationQuarter);
            SecondHandCursor.GetComponent<Image>().DOFade(0, durationHalf);

            FadedColors[3].DOFade(1, durationHalf);
            FadedColors[4].DOFade(1, durationHalf);
            yield return new WaitForSeconds(durationQuarter);
            FadedTexts[3].DOFade(1, durationHalf);
            FadedTexts[4].DOFade(1, durationHalf);
            yield return new WaitForSeconds(durationOne);

            yield return new WaitForSeconds(8.5f * durationOne);
            for (int i = 0; i < MisolText1.Length; i++)
            {
                MisolText1[i].DOFade(1, durationHalf);
                yield return new WaitForSeconds(durationHalf);
            }

            yield return new WaitForSeconds(2*durationOne);
            ThirdHandCursor.transform.DOScale(1, durationHalf);
            yield return new WaitForSeconds(durationOne);
            ThirdHandCursor.GetComponent<EachObject>().MoveByPixelsByX(120, 1);
            yield return new WaitForSeconds(3 * durationOne);
            ThirdHandCursor.GetComponent<Image>().DOFade(0, durationHalf);
            yield return new WaitForSeconds(durationOne + durationHalf);

            VideoManager5_1.PlayAudio();  //  19
            yield return new WaitForSeconds(durationHalf);
            TextRectangleParent.transform.GetChild(0).GetComponent<TMP_Text>().DOFade(1, durationOne);
            for (int i = 1; i < TextRectangleParent.transform.childCount; i++)
            {
                TextRectangleParent.transform.GetChild(i).GetComponent<Image>().DOFillAmount(1, durationQuarter + i / 2 * durationQuarter);
                yield return new WaitForSeconds(durationQuarter + i / 2 * durationQuarter);
            }
            yield return new WaitForSeconds(VideoManager5_1.LengthOfAudioClip(18) - 2);  // array nooldan boshlangani uchun

            
            VideoManager5_1.PlayAudio();  //  20
            yield return new WaitForSeconds(durationHalf);
            UnderLine.DOFillAmount(1, durationOne);
            yield return new WaitForSeconds(4 * durationOne);

            for (int i = 0; i < MisolText2.Length; i++)            
                MisolText2[i].DOFade(1, durationHalf);            
            yield return new WaitForSeconds(2 * durationOne);

            MisolText3[0].DOFade(1, durationHalf);
            MisolText3[1].DOFade(1, durationHalf);
            yield return new WaitForSeconds(2 * durationOne);

            FinalAnswerText.DOFade(1, durationOne);
            yield return new WaitForSeconds(VideoManager5_1.LengthOfAudioClip(18) - 7 * durationOne);

            NextAnimations.Invoke();
        }

        
    }
}

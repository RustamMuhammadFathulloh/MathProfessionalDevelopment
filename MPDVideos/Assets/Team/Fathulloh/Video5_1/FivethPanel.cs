using CommonFeatures;
using DG.Tweening;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Math5_Lesson1
{
    public class FivethPanel : MonoBehaviour
    {
        [Header("Main variables")]
        public VideoManager VideoManager5_1;
        public GameObject TeachingOrderOfOperation;
        public Image WhitePanel;
        public GameObject TaskThree;

        [Header("Fiveth parent")]
        public GameObject RectModel;
        public Image[] FadedImages;
        public Image[] FillAmounts;

        public Image[] FadedColorImages;
        public TMP_Text[] FadedTexts;

        public BracketManager UpperBracket;
        public BracketManager LowerBracket;

        public TMP_Text QuestionMark1;
        public TMP_Text QuestionMark2;
        public GameObject FirstHandCursor;
        public GameObject SecondHandCursor;
        public GameObject ThirdHandCursor;
        public TMP_Text[] MisolText1;
        public TMP_Text[] MisolText2;
        public TMP_Text[] MisolText3;

        public GameObject TextRectangleParent;
        public Image UnderLine;
        public TMP_Text FinalAnswerText;

        public TMP_Text[] ErrorMisolText1;
        public TMP_Text[] ErrorMisolText2;
        public TMP_Text[] ErrorMisolText3;
        public Image BlueUnderLine;
        public TMP_Text ErrorFinalAnswerText;
        public GameObject ErrorTextRectangleParent;

        readonly float durationOne = 1;
        readonly float durationHalf = 0.5f;
        readonly float durationQuarter = 0.25f;

        public UnityEvent NextAnimations;


        private void Awake()
        {
            TaskThree.SetActive(false);
        }


        public void VideoAnimationMethod()
        {
            StartCoroutine(FivethParentAnimation());
        }


        IEnumerator FivethParentAnimation()
        {
            VideoManager5_1.PlayAudio();  //  21
            yield return new WaitForSeconds(durationHalf);
            TeachingOrderOfOperation.SetActive(true);
            WhitePanel.DOFade(1, 2 * durationOne);
            yield return new WaitForSeconds(4 * durationOne);
            TaskThree.SetActive(true);
            yield return new WaitForSeconds(2 * durationOne);

            VideoManager5_1.PlayAudio();  //  22
            for (int i = 0; i < FadedImages.Length; i++)
            {
                FadedImages[i].DOFade(0, durationOne);
                yield return new WaitForSeconds(4 * durationOne + i * 1.5f);
            }
            yield return new WaitForSeconds(durationOne);

            // First rect model.
            RectModel.transform.DOScale(1, durationOne);
            yield return new WaitForSeconds(durationOne);

            for (int i = 0; i < FillAmounts.Length; i++)
            {
                FillAmounts[i].DOFillAmount(1, durationHalf);
                yield return new WaitForSeconds(durationHalf);
            }
            yield return new WaitForSeconds(durationHalf);

            for (int i = 0; i < FadedColorImages.Length; i++)
            {
                FadedColorImages[i].DOFade(1, durationHalf);
                FadedTexts[i].DOFade(1, durationHalf);                
            }
            QuestionMark1.DOFade(1, durationHalf);
            UpperBracket.BracketFillAmount(1, durationOne);
            yield return new WaitForSeconds(durationOne);

            FirstHandCursor.transform.DOScale(1, durationHalf);
            yield return new WaitForSeconds(3 * durationOne);
            FirstHandCursor.GetComponent<Image>().DOFade(0, durationHalf);
            yield return new WaitForSeconds(5 * durationOne);

            QuestionMark2.DOFade(1, durationHalf);
            LowerBracket.BracketFillAmount(1, durationOne);
            yield return new WaitForSeconds(2 * durationOne);
            SecondHandCursor.transform.DOScale(1, durationHalf);
            yield return new WaitForSeconds(3 * durationOne);
            SecondHandCursor.GetComponent<Image>().DOFade(0, durationHalf);
            yield return new WaitForSeconds(3.4f * durationOne);

            for (int i = 0; i < MisolText1.Length; i++)
            {
                MisolText1[i].DOFade(1, durationHalf - 0.1f);
                yield return new WaitForSeconds(durationHalf);
            }

            yield return new WaitForSeconds(2 * durationOne);
            ThirdHandCursor.transform.DOScale(1, durationHalf);
            yield return new WaitForSeconds(durationOne);
            ThirdHandCursor.GetComponent<EachObject>().MoveByPixelsByX(120, 1);
            yield return new WaitForSeconds(3 * durationOne);
            ThirdHandCursor.GetComponent<Image>().DOFade(0, durationHalf);
            yield return new WaitForSeconds(1.5f * durationOne);

            VideoManager5_1.PlayAudio();  //  23
            yield return new WaitForSeconds(durationHalf);
            TextRectangleParent.transform.GetChild(0).GetComponent<TMP_Text>().DOFade(1, durationOne);
            for (int i = 1; i < TextRectangleParent.transform.childCount; i++)
            {
                TextRectangleParent.transform.GetChild(i).GetComponent<Image>().DOFillAmount(1, durationQuarter + i / 2 * durationQuarter);
                yield return new WaitForSeconds(durationQuarter + i / 2 * durationQuarter);
            }
            yield return new WaitForSeconds(VideoManager5_1.LengthOfAudioClip(22) - 2 * durationOne);


            VideoManager5_1.PlayAudio();  //  24
            yield return new WaitForSeconds(durationHalf);
            UnderLine.DOFillAmount(1, durationOne);
            yield return new WaitForSeconds(6 * durationOne);

            for (int i = 0; i < MisolText2.Length; i++)
                MisolText2[i].DOFade(1, durationHalf);
            yield return new WaitForSeconds(3 * durationOne);

            MisolText3[0].DOFade(1, durationHalf);
            MisolText3[1].DOFade(1, durationHalf);
            yield return new WaitForSeconds(1.5f * durationOne);

            FinalAnswerText.DOFade(1, durationOne);
            yield return new WaitForSeconds(VideoManager5_1.LengthOfAudioClip(23) - 11 * durationOne);

            yield return new WaitForSeconds(durationOne);
            VideoManager5_1.PlayAudio();  //  25
            FinalAnswerText.DOFade(0, durationOne);
            MisolText3[0].DOFade(0, durationOne);
            MisolText3[1].DOFade(0, durationOne);
            UnderLine.DOFade(0, durationOne);

            for (int i = 0; i < MisolText2.Length; i++)
                MisolText2[i].DOFade(0, durationOne);

            for (int i = 0; i < MisolText1.Length; i++)
                MisolText1[i].DOFade(0, durationOne);

            TextRectangleParent.transform.GetChild(0).GetComponent<TMP_Text>().DOFade(0, durationOne);
            for (int i = 1; i < TextRectangleParent.transform.childCount; i++)            
                TextRectangleParent.transform.GetChild(i).GetComponent<Image>().DOFade(0, durationOne);
            yield return new WaitForSeconds(4 * durationOne);
            for (int i = 0; i < ErrorMisolText1.Length; i++)
                ErrorMisolText1[i].DOFade(1, durationHalf - 0.1f);
            yield return new WaitForSeconds(VideoManager5_1.LengthOfAudioClip(24) - 4 * durationOne);

            VideoManager5_1.PlayAudio();  // 26                        
            yield return new WaitForSeconds(4 * durationOne);
            BlueUnderLine.DOFillAmount(1, durationOne);
            yield return new WaitForSeconds(4 * durationOne);

            for (int i = 0; i < ErrorMisolText2.Length; i++)
                ErrorMisolText2[i].DOFade(1, durationHalf - 0.1f);
            yield return new WaitForSeconds(2 * durationHalf);

            for (int i = 0; i < ErrorMisolText3.Length; i++)
                ErrorMisolText3[i].DOFade(1, durationHalf - 0.1f);
            yield return new WaitForSeconds(2 * durationHalf);

            ErrorFinalAnswerText.DOFade(1, durationOne);
            yield return new WaitForSeconds(2 * durationHalf);

            ErrorTextRectangleParent.transform.GetChild(0).GetComponent<TMP_Text>().DOFade(1, durationOne);
            for (int i = 1; i < ErrorTextRectangleParent.transform.childCount; i++)
            {
                ErrorTextRectangleParent.transform.GetChild(i).GetComponent<Image>().DOFillAmount(1, durationQuarter + i / 2 * durationQuarter);
                yield return new WaitForSeconds(durationQuarter + i / 2 * durationQuarter);
            }

            yield return new WaitForSeconds(VideoManager5_1.LengthOfAudioClip(25) - 16 * durationHalf - 1);//4
            NextAnimations.Invoke();
        }


    }
}

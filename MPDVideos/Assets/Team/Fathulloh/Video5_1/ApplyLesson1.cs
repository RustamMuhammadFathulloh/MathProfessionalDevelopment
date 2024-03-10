using DG.Tweening;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Math5_Lesson1
{
    public class ApplyLesson1 : MonoBehaviour
    {
        [Header("Main variables")]
        public VideoManager VideoManager5_1;
        public TMP_Text ApplyText;
        public Image WhitePanel;        

        [Header("Sixth parent")]
        public TMP_Text[] FirstFadedTexts;
        public TMP_Text[] OtherFadedTexts;

        public Image FirstLine;
        public Image SecondLine;
        public Image ThirdLine;
        public Image FourthLine;

        public GameObject Transition1;

        readonly float durationOne = 1;
        readonly float durationSevenFive = 0.75f;
        readonly float durationHalf = 0.5f;
        readonly float durationQuarter = 0.25f;

        public UnityEvent NextAnimations;

                
        public void ApplyAnim()
        {
            Debug.Log("Ishladi");
            StartCoroutine(ApplyAnimation());
        }


        IEnumerator ApplyAnimation()
        {
            yield return new WaitForSeconds(durationHalf);
            VideoManager5_1.PlayAudio();  //  34
            WhitePanel.DOFade(1, durationHalf);
            yield return new WaitForSeconds(durationHalf);
            ApplyText.DOFade(1, durationHalf);
            yield return new WaitForSeconds(durationOne);

            for (int i = 0; i < FirstFadedTexts.Length; i++)
            {
                FirstFadedTexts[i].DOFade(1, durationHalf);
                yield return new WaitForSeconds(durationOne);
            }
            yield return new WaitForSeconds(VideoManager5_1.LengthOfAudioClip(33) - 3 * durationOne);


            VideoManager5_1.PlayAudio();  //  34
            yield return new WaitForSeconds(durationHalf);
            FirstLine.DOFillAmount(1, durationHalf);
            yield return new WaitForSeconds(durationHalf);
            SecondLine.DOFillAmount(1, durationHalf);

            // For Task 1
            OtherFadedTexts[0].DOFade(1, durationOne);
            OtherFadedTexts[1].DOFade(1, durationOne);
            yield return new WaitForSeconds(durationOne);
            OtherFadedTexts[2].DOFade(1, durationOne);
            OtherFadedTexts[3].DOFade(1, durationOne);
            yield return new WaitForSeconds(durationOne + durationHalf);

            // For Task 2
            ThirdLine.DOFillAmount(1, durationHalf);
            yield return new WaitForSeconds(durationOne);
            OtherFadedTexts[4].DOFade(1, durationOne);
            OtherFadedTexts[5].DOFade(1, durationOne);
            yield return new WaitForSeconds(durationOne);
            FourthLine.DOFillAmount(1, durationHalf);
            yield return new WaitForSeconds(durationOne);
            OtherFadedTexts[6].DOFade(1, durationOne);
            OtherFadedTexts[7].DOFade(1, durationOne);
            yield return new WaitForSeconds(durationOne);
            OtherFadedTexts[8].DOFade(1, durationOne);
            OtherFadedTexts[9].DOFade(1, durationOne);
            yield return new WaitForSeconds(durationOne + durationHalf);

            // For Task 3
            OtherFadedTexts[10].DOFade(1, durationOne);
            OtherFadedTexts[11].DOFade(1, durationOne);
            yield return new WaitForSeconds(durationOne + durationHalf);
            OtherFadedTexts[12].DOFade(1, durationOne);
            OtherFadedTexts[13].DOFade(1, durationOne);
            yield return new WaitForSeconds(durationOne + durationHalf);
            
            //Transition1.SetActive(true);
            yield return new WaitForSeconds(0.5f);

            NextAnimations.Invoke();
        }

    }
}

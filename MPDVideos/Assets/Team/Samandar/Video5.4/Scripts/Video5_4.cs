using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;
using TMPro.Examples;
using UnityEngine.Events;
namespace Samandar
{
    public class Video5_4 : Introduction
    {
        public GameObject transition_1;
        public GameObject transition_2;
        public GameObject Finish;
        public List<GameObject> Pages;
        //public List<float> PageTime;
        public List<GameObject> Page_2;
        public List<GameObject> Page_3;
        public List<GameObject> Page4_1;
        public List<GameObject> Page_5;
        public List<AudioSource> Audio;
        public UnityEvent PageEvent_1;
        public UnityEvent PageEvent_2;
        public UnityEvent PageEvent_3;

        private void Start()
        {
            ChallengePage_4();
        }
        public void ChallengePage_2()
        {
            StartCoroutine(PageController_2());
            StartCoroutine(AudioControllerPage_2());
        }
        public void ChallengePage_3()
        {
            StartCoroutine(PageController_3());
            StartCoroutine(AudioControllerPage_3());
        }
        public void ChallengePage_4()
        {
            StartCoroutine(PageController4_1());
            StartCoroutine(AudioControllerPage4_1());
        }
        public void ChallengePage_5()
        {
            StartCoroutine(PageController_5());
            StartCoroutine(AudioControllerPage_5());
        }
        IEnumerator AudioControllerPage_2()
        {
            yield return new WaitForSeconds(0.5f);
            Audio[0].Play();
            yield return new WaitForSeconds(6.2f);
            Audio[1].Play();
            yield return new WaitForSeconds(13.7f);
            Audio[2].Play();
            yield return new WaitForSeconds(10.4f);
            Audio[3].Play();
            yield return new WaitForSeconds(5.7f);
        }
        IEnumerator AudioControllerPage_3()
        {
            Audio[4].Play();
            yield return new WaitForSeconds(5.4f);
            Audio[5].Play();
            yield return new WaitForSeconds(15.4f);
        }
        IEnumerator AudioControllerPage4_1()
        {
            Audio[6].Play();
            yield return new WaitForSeconds(4);
            Audio[7].Play();
            yield return new WaitForSeconds(5.3f);
            Audio[8].Play();
            yield return new WaitForSeconds(6.5f);
            Audio[9].Play();
            yield return new WaitForSeconds(12.3f);
            Audio[10].Play();
            yield return new WaitForSeconds(11.5f);
            Audio[11].Play();
            yield return new WaitForSeconds(3.5f);
            Audio[12].Play();
            yield return new WaitForSeconds(7.2f);
            Audio[13].Play();
            yield return new WaitForSeconds(9.5f);
            //Pages[2].SetActive(false);
            //Finish.SetActive(true);
            //PageEvent_3.Invoke();
        }

        IEnumerator AudioControllerPage_5()
        {
            Audio[9].Play();
            yield return new WaitForSeconds(9.4f);
        }
        IEnumerator PageController_2()
        {
            Pages[0].SetActive(true);
            Page_2[0].SetActive(true);
            yield return new WaitForSeconds(7.5f);
            Page_2[1].SetActive(true);
            Page_2[1].GetComponent<Image>().DOFillAmount(1, 0.2f);
            yield return new WaitForSeconds(0.2f);
            Page_2[2].SetActive(true);
            Page_2[2].GetComponent<Image>().DOFillAmount(1, 0.6f);
            yield return new WaitForSeconds(0.6f);
            Page_2[3].SetActive(true);
            Page_2[3].GetComponent<Image>().DOFillAmount(1, 0.2f);
            yield return new WaitForSeconds(0.2f);
            Page_2[4].SetActive(true);
            Page_2[4].GetComponent<RectTransform>().DOScale(1, 0.5f);
            yield return new WaitForSeconds(4);
            Page_2[5].SetActive(true);
            Page_2[5].GetComponent<RectTransform>().DOScale(1, 0.5f);
            yield return new WaitForSeconds(8);
            Page_2[6].SetActive(true);
            Page_2[6].GetComponent<Image>().DOFillAmount(1, 0.5f);
            yield return new WaitForSeconds(0.5f);
            Page_2[7].SetActive(true);
            Page_2[7].GetComponent<Image>().DOFillAmount(1, 0.5f);
            yield return new WaitForSeconds(0.5f);
            Page_2[8].SetActive(true);
            Page_2[8].GetComponent<RectTransform>().DOScale(1, 0.5f);
            yield return new WaitForSeconds(3);
            Page_2[9].SetActive(true);
            Page_2[9].GetComponent<Image>().DOFillAmount(1, 0.2f);
            Page_2[10].SetActive(true);
            Page_2[10].GetComponent<Image>().DOFillAmount(1, 0.2f);
            yield return new WaitForSeconds(0.2f);
            Page_2[11].SetActive(true);
            Page_2[11].GetComponent<Image>().DOFillAmount(1, 0.6f);
            Page_2[12].SetActive(true);
            Page_2[12].GetComponent<Image>().DOFillAmount(1, 0.6f);
            yield return new WaitForSeconds(0.6f);
            Page_2[13].SetActive(true);
            Page_2[13].GetComponent<Image>().DOFillAmount(1, 0.2f);
            yield return new WaitForSeconds(0.2f);
            Page_2[14].SetActive(true);
            Page_2[14].GetComponent<RectTransform>().DOScale(1, 0.5f);
            yield return new WaitForSeconds(3);
            transition_1.SetActive(true);
            yield return new WaitForSeconds(1.5f);
            transition_1.SetActive(false);
            PageEvent_1.Invoke();
        }
        IEnumerator PageController_3()
        {
            Pages[1].SetActive(true);
            Page_3[0].SetActive(true);
            Page_3[1].SetActive(true);
            Page_3[0].GetComponent<RectTransform>().DOAnchorPosY(0, 0.5f);
            yield return new WaitForSeconds(0.5f);
            Page_3[1].SetActive(false);
            yield return new WaitForSeconds(4);
            Page_3[0].GetComponent<TMP_Text>().DOFade(0, 0.5f);
            yield return new WaitForSeconds(0.5f);
            Page_3[0].SetActive(false);
            Page_3[2].SetActive(true);
            Page_3[2].GetComponent<TMP_Text>().DOFade(1, 0.5f);
            yield return new WaitForSeconds(0.5f);
            Page_3[3].SetActive(true);
            Page_3[3].GetComponent<TMP_Text>().DOFade(1, 0.5f);
            Page_3[4].SetActive(true);
            Page_3[4].GetComponent<TMP_Text>().DOFade(1, 0.5f);
            Page_3[5].SetActive(true);
            Page_3[5].GetComponent<TMP_Text>().DOFade(1, 0.5f);
            Page_3[6].SetActive(true);
            Page_3[6].GetComponent<RectTransform>().DOScale(1, 0.5f);
            yield return new WaitForSeconds(3);
            Page_3[11].SetActive(true);
            Page_3[11].GetComponent<TMP_Text>().DOFade(1, 0.7f);
            Page_3[7].SetActive(true);
            Page_3[7].GetComponent<RectTransform>().DOScale(1, 0.7f);
            yield return new WaitForSeconds(0.2f);
            Page_3[8].SetActive(true);
            Page_3[8].GetComponent<RectTransform>().DOScale(1, 0.7f);
            yield return new WaitForSeconds(0.2f);
            Page_3[9].SetActive(true);
            Page_3[9].GetComponent<RectTransform>().DOScale(1, 0.7f);
            yield return new WaitForSeconds(0.2f);
            Page_3[10].SetActive(true);
            Page_3[10].GetComponent<RectTransform>().DOScale(1, 0.7f);
            yield return new WaitForSeconds(5);
            Page_3[12].SetActive(true);
            Page_3[12].GetComponent<Image>().DOFillAmount(1, 0.2f);
            Page_3[13].SetActive(true);
            Page_3[13].GetComponent<Image>().DOFillAmount(1, 0.2f);
            yield return new WaitForSeconds(0.2f);
            Page_3[14].SetActive(true);
            Page_3[14].GetComponent<Image>().DOFillAmount(1, 0.5f);
            Page_3[15].SetActive(true);
            Page_3[15].GetComponent<Image>().DOFillAmount(1, 0.5f);
            yield return new WaitForSeconds(0.5f);
            Page_3[16].SetActive(true);
            Page_3[16].GetComponent<Image>().DOFillAmount(1, 0.2f);
            yield return new WaitForSeconds(0.2f);
            Page_3[17].SetActive(true);
            Page_3[17].GetComponent<RectTransform>().DOScale(1, 0.5f);
            yield return new WaitForSeconds(0.5f);
            Page_3[18].SetActive(true);
            Page_3[18].GetComponent<TMP_Text>().DOFade(1, 0.5f);
            yield return new WaitForSeconds(0.5f);
            
            //transition_2.SetActive(true);
            //Pages[1].SetActive(false);
            //yield return new WaitForSeconds(1.5f);
            //transition_2.SetActive(false);
            PageEvent_2.Invoke();
        }
        IEnumerator PageController4_1()
        {
            Pages[2].SetActive(true);
            Page4_1[0].SetActive(true);
            Page4_1[1].SetActive(true);
            Page4_1[0].GetComponent<RectTransform>().DOAnchorPosY(0, 0.5f);
            yield return new WaitForSeconds(0.5f);
            Page4_1[1].SetActive(false);
            yield return new WaitForSeconds(3.5f);
            Page4_1[2].SetActive(true);
            Page4_1[0].GetComponent<TMP_Text>().DOFade(1, 0.5f);
            Page4_1[2].GetComponent<TMP_Text>().DOFade(1, 0.5f);
            yield return new WaitForSeconds(0.5f);
            Page4_1[0].SetActive(false);
            yield return new WaitForSeconds(4.5f);
            Page4_1[4].SetActive(true);
            Page4_1[3].SetActive(true);
            Page4_1[3].GetComponent<RectTransform>().DOAnchorPosY(240, 1);
            yield return new WaitForSeconds(3);
            Page4_1[4].SetActive(false);
            Page4_1[6].SetActive(true);
            Page4_1[5].SetActive(true);
            Page4_1[5].GetComponent<RectTransform>().DOAnchorPosY(182, 1);
            yield return new WaitForSeconds(4);
            Page4_1[6].SetActive(false);
            Page4_1[7].SetActive(true);
            Page4_1[7].GetComponent<RectTransform>().DOScale(1, 0.5f);           
            yield return new WaitForSeconds(1);
            Page4_1[8].SetActive(true);
            Page4_1[8].GetComponent<RectTransform>().DOScale(1, 0.5f);
            yield return new WaitForSeconds(0.3f);
            Page4_1[9].SetActive(true);
            Page4_1[9].GetComponent<RectTransform>().DOScale(1, 0.5f);
            yield return new WaitForSeconds(4);
            Page4_1[10].SetActive(true);
            Page4_1[10].GetComponent<RectTransform>().DOScale(1, 0.5f);
            yield return new WaitForSeconds(0.5f);
            Page4_1[11].SetActive(true);
            Page4_1[11].GetComponent<RectTransform>().DOScale(1, 0.5f);
            yield return new WaitForSeconds(7);
            Page4_1[7].SetActive(false);
            Page4_1[11].GetComponent<RectTransform>().DOScale(0.5f, 0.5f);
            Page4_1[11].GetComponent<RectTransform>().DOAnchorPos(new Vector2(410, -7), 0.5f);
            yield return new WaitForSeconds(0.5f);
            Page4_1[10].GetComponent<RectTransform>().DOScale(0.5f, 0.5f);
            Page4_1[10].GetComponent<RectTransform>().DOAnchorPos(new Vector2(510, -333), 0.5f);
            yield return new WaitForSeconds(7);
            Page4_1[12].SetActive(true);
            Page4_1[12].GetComponent<RectTransform>().DOScale(1, 1);
            yield return new WaitForSeconds(1);
            Page4_1[13].SetActive(true);
            Page4_1[13].GetComponent<RectTransform>().DOScale(1, 1);
            yield return new WaitForSeconds(7);
            Page4_1[14].SetActive(true);
            Page4_1[14].GetComponent<RectTransform>().DOScale(1, 1);
            yield return new WaitForSeconds(6);
            Page4_1[15].SetActive(true);
            Page4_1[15].GetComponent<RectTransform>().DOScale(1, 1);
            yield return new WaitForSeconds(1);
            Page4_1[16].SetActive(true);
            Page4_1[16].GetComponent<RectTransform>().DOScale(1, 1);
            yield return new WaitForSeconds(1);
            Page4_1[17].SetActive(true);
            Page4_1[17].GetComponent<RectTransform>().DOScale(1, 1);
            Page4_1[18].SetActive(true);
            Page4_1[18].GetComponent<RectTransform>().DOScale(1, 1);
            yield return new WaitForSeconds(3);
            Page4_1[19].SetActive(true);
            Page4_1[19].GetComponent<RectTransform>().DOScale(1, 1);
            yield return new WaitForSeconds(1);
            Page4_1[20].SetActive(true);
            Page4_1[20].GetComponent<RectTransform>().DOScale(1, 1);
            yield return new WaitForSeconds(1);
            Page4_1[21].SetActive(true);
            Page4_1[21].GetComponent<Image>().DOFillAmount(1, 1);
            yield return new WaitForSeconds(1);
            Page4_1[3].GetComponent<TMP_Text>().DOFade(0, 0.5f);
            Page4_1[5].GetComponent<TMP_Text>().DOFade(0, 0.5f);
            Page4_1[12].GetComponent<TMP_Text>().DOFade(0, 0.5f);
            Page4_1[15].GetComponent<TMP_Text>().DOFade(0, 0.5f);
            Page4_1[17].GetComponent<TMP_Text>().DOFade(0, 0.5f);
            Page4_1[19].GetComponent<TMP_Text>().DOFade(0, 0.5f);
            Page4_1[8].GetComponent<Image>().DOFade(0, 0.5f);
            Page4_1[9].GetComponent<Image>().DOFade(0, 0.5f);
            Page4_1[10].GetComponent<Image>().DOFade(0, 0.5f);
            Page4_1[11].GetComponent<Image>().DOFade(0, 0.5f);
            Page4_1[13].transform.GetChild(0).GetComponent<TMP_Text>().DOFade(0, 0.5f);
            Page4_1[13].transform.GetChild(1).GetComponent<Image>().DOFade(0, 0.5f);
            Page4_1[13].transform.GetChild(2).GetComponent<TMP_Text>().DOFade(0, 0.5f);
            Page4_1[14].transform.GetChild(0).GetComponent<TMP_Text>().DOFade(0, 0.5f);
            Page4_1[14].transform.GetChild(1).GetComponent<Image>().DOFade(0, 0.5f);
            Page4_1[14].transform.GetChild(2).GetComponent<TMP_Text>().DOFade(0, 0.5f);
        }
        IEnumerator PageController_5()
        {
            Pages[3].SetActive(true);

            Page_5[0].SetActive(true);
            Page_5[1].SetActive(true);
            Page_5[0].GetComponent<RectTransform>().DOAnchorPosY(-20, 0.5f);
            yield return new WaitForSeconds(4);
            Page_5[1].SetActive(false);
            Page_5[3].SetActive(true);
            Page_5[2].SetActive(true);
            Page_5[2].GetComponent<RectTransform>().DOAnchorPosY(-187, 0.5f);
            yield return new WaitForSeconds(4.5f);
            Page_5[3].SetActive(false);
            FinishTransition();
        }
    }
}

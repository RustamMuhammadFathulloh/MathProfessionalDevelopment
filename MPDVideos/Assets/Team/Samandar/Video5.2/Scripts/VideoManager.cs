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
   public class VideoManager : Introduction
    {
        public GameObject transition_1;
        public GameObject transition_2;
        public GameObject Finish;
        public List<GameObject> Pages;
        //public List<float> PageTime;
        public List<GameObject> Page_2;
        public List<GameObject> Page_3;
        public List<GameObject> Page_4;
        public List<GameObject> Page_5;
        public List<AudioSource> Audio;
        public UnityEvent PageEvent_1;
        public UnityEvent PageEvent_2;
        public UnityEvent PageEvent_3;
        
        private void Start()
        {
            
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
            StartCoroutine(PageController_4());
            StartCoroutine(AudioControllerPage_4());
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
            yield return new WaitForSeconds(19);
            Audio[1].Play();
            yield return new WaitForSeconds(6.4f);
            Audio[2].Play();
        }
        IEnumerator AudioControllerPage_3()
        {            
            Audio[3].Play();
            yield return new WaitForSeconds(16);
            Audio[4].Play();
            yield return new WaitForSeconds(12.5f);
            //Audio[5].Play();
            //yield return new WaitForSeconds(4.5f);
        }
        IEnumerator AudioControllerPage_4()
        {
            Audio[5].Play();
            yield return new WaitForSeconds(4.5f);
            Audio[6].Play();
            yield return new WaitForSeconds(3.7f);
            Audio[7].Play();
            yield return new WaitForSeconds(24);
            Audio[8].Play();
            yield return new WaitForSeconds(60);
            Finish.SetActive(true);
            Pages[2].SetActive(false);
            PageEvent_3.Invoke();
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
            yield return new WaitForSeconds(1.5f);
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
            yield return new WaitForSeconds(5);
            Page_2[5].SetActive(true);
            Page_2[5].GetComponent<Image>().DOFillAmount(1, 0.5f);
            yield return new WaitForSeconds(0.5f);
            Page_2[6].SetActive(true);
            Page_2[6].GetComponent<RectTransform>().DOScale(1, 0.5f);
            yield return new WaitForSeconds(1);
            Page_2[7].SetActive(true);
            Page_2[7].GetComponent<Image>().DOFillAmount(1, 0.6f);
            yield return new WaitForSeconds(0.6f);
            Page_2[8].SetActive(true);
            Page_2[8].GetComponent<Image>().DOFillAmount(1, 0.2f);
            yield return new WaitForSeconds(0.2f);
            Page_2[9].SetActive(true);
            Page_2[9].GetComponent<RectTransform>().DOScale(1, 0.5f);
            yield return new WaitForSeconds(2);
            Page_2[10].SetActive(true);
            Page_2[10].GetComponent<Image>().DOFillAmount(1, 0.2f);
            yield return new WaitForSeconds(0.2f);
            Page_2[11].SetActive(true);
            Page_2[11].GetComponent<RectTransform>().DOScale(1, 0.5f);
            yield return new WaitForSeconds(9);
            Page_2[12].SetActive(true);
            Page_2[12].GetComponent<Image>().DOFillAmount(1, 0.1f);
            yield return new WaitForSeconds(0.1f);
            Page_2[13].SetActive(true);
            Page_2[13].GetComponent<Image>().DOFillAmount(1, 0.6f);
            Page_2[14].SetActive(true);
            Page_2[14].GetComponent<Image>().DOFillAmount(1, 0.6f);
            Page_2[15].SetActive(true);
            Page_2[15].GetComponent<RectTransform>().DOScale(1, 0.6f);
            yield return new WaitForSeconds(0.6f);
            Page_2[16].SetActive(true);
            Page_2[16].GetComponent<Image>().DOFillAmount(1, 0.2f);
            Page_2[17].SetActive(true);
            Page_2[17].GetComponent<Image>().DOFillAmount(1, 0.2f);
            yield return new WaitForSeconds(2.5f);
            Page_2[19].SetActive(true);
            Page_2[18].SetActive(true);
            Page_2[18].GetComponent<Image>().DOFillAmount(1, 1);
            yield return new WaitForSeconds(1);
            Page_2[19].GetComponent<Image>().DOFillAmount(1, 0);
            Page_2[19].GetComponent<Image>().DOFillAmount(0, 0.1f);
            yield return new WaitForSeconds(7);
            transition_1.SetActive(true);
            Pages[0].SetActive(false);
            yield return new WaitForSeconds(1.5f);
            transition_1.SetActive(false);
            PageEvent_1.Invoke();
        }
        IEnumerator PageController_3()
        {            
            Pages[1].SetActive(true);
            Page_3[0].SetActive(true);
            yield return new WaitForSeconds(16);
            Page_3[1].SetActive(true);
            Page_3[1].GetComponent<RectTransform>().DOAnchorPosX(-578.8f, 1);
            Page_3[2].SetActive(true);
            Page_3[3].SetActive(true);
            yield return new WaitForSeconds(1.5f);
            Page_3[8].SetActive(true);
            Page_3[4].SetActive(true);
            Page_3[4].GetComponent<RectTransform>().DOScale(1,0.7f);
            yield return new WaitForSeconds(0.2f);
            Page_3[5].SetActive(true);
            Page_3[5].GetComponent<RectTransform>().DOScale(1, 0.7f);
            yield return new WaitForSeconds(0.2f);
            Page_3[6].SetActive(true);
            Page_3[6].GetComponent<RectTransform>().DOScale(1, 0.7f);
            yield return new WaitForSeconds(0.2f);
            Page_3[7].SetActive(true);
            Page_3[7].GetComponent<RectTransform>().DOScale(1, 0.7f);
            yield return new WaitForSeconds(1.2f);
            Page_3[9].SetActive(true);
            yield return new WaitForSeconds(6);
            Page_3[10].SetActive(true);
            Page_3[10].GetComponent<RectTransform>().DOScale(1, 0.7f);
            yield return new WaitForSeconds(0.7f);
            Page_3[14].SetActive(true);
            Page_3[11].SetActive(true);
            Page_3[11].GetComponent<Image>().DOFillAmount(1, 0.2f);
            yield return new WaitForSeconds(0.2f);
            Page_3[12].SetActive(true);
            Page_3[12].GetComponent<Image>().DOFillAmount(1, 0.5f);
            Page_3[13].SetActive(true);
            Page_3[13].GetComponent<Image>().DOFillAmount(1, 0.5f);
            yield return new WaitForSeconds(0.5f);
            Page_3[15].SetActive(true);
            Page_3[15].GetComponent<Image>().DOFillAmount(1, 0.2f);
            Page_3[16].SetActive(true);
            Page_3[16].GetComponent<Image>().DOFillAmount(1, 0.2f);
            yield return new WaitForSeconds(2);
            transition_2.SetActive(true);
            Pages[1].SetActive(false);            
            yield return new WaitForSeconds(1.5f);
            transition_2.SetActive(false);
            PageEvent_2.Invoke();
        }
        IEnumerator PageController_4()
        {
            Pages[2].SetActive(true);
            Page_4[0].SetActive(true);
            yield return new WaitForSeconds(4);
            Page_4[1].SetActive(true);
            Page_4[1].GetComponent<RectTransform>().DOAnchorPosX(-280, 1);
            yield return new WaitForSeconds(5);
            Page_4[2].SetActive(true);
            yield return new WaitForSeconds(3);
            Page_4[3].SetActive(true);
            yield return new WaitForSeconds(3);
            Page_4[4].SetActive(true);
            yield return new WaitForSeconds(3);
            Page_4[11].SetActive(true);
            Page_4[5].SetActive(true);
            Page_4[5].GetComponent<RectTransform>().DOAnchorPosY(60, 0.3f);
            yield return new WaitForSeconds(0.15f);
            Page_4[6].SetActive(true);
            Page_4[6].GetComponent<RectTransform>().DOAnchorPosY(60, 0.3f);
            yield return new WaitForSeconds(0.15f);
            Page_4[7].SetActive(true);
            Page_4[7].GetComponent<RectTransform>().DOAnchorPosY(60, 0.3f);
            yield return new WaitForSeconds(0.15f);
            Page_4[8].SetActive(true);
            Page_4[8].GetComponent<RectTransform>().DOAnchorPosY(60, 0.3f);
            yield return new WaitForSeconds(0.15f);
            Page_4[9].SetActive(true);
            Page_4[9].GetComponent<RectTransform>().DOAnchorPosY(60, 0.3f);
            yield return new WaitForSeconds(0.15f);
            Page_4[10].SetActive(true);
            Page_4[10].GetComponent<RectTransform>().DOAnchorPosY(60, 0.3f);
            yield return new WaitForSeconds(0.15f);
            Page_4[11].SetActive(false);
            yield return new WaitForSeconds(4);
            Page_4[18].SetActive(true);
            Page_4[12].SetActive(true);
            Page_4[12].GetComponent<RectTransform>().DOAnchorPosY(-19, 0.3f);
            yield return new WaitForSeconds(0.15f);
            Page_4[13].SetActive(true);
            Page_4[13].GetComponent<RectTransform>().DOAnchorPosY(-19, 0.3f);
            yield return new WaitForSeconds(0.15f);
            Page_4[14].SetActive(true);
            Page_4[14].GetComponent<RectTransform>().DOAnchorPosY(-19, 0.3f);
            yield return new WaitForSeconds(0.15f);
            Page_4[15].SetActive(true);
            Page_4[15].GetComponent<RectTransform>().DOAnchorPosY(-19, 0.3f);
            yield return new WaitForSeconds(0.15f);
            Page_4[16].SetActive(true);
            Page_4[16].GetComponent<RectTransform>().DOAnchorPosY(-19, 0.3f);
            yield return new WaitForSeconds(0.15f);
            Page_4[17].SetActive(true);
            Page_4[17].GetComponent<RectTransform>().DOAnchorPosY(-19, 0.3f);
            yield return new WaitForSeconds(0.15f);
            Page_4[18].SetActive(false);
            yield return new WaitForSeconds(6);
            Page_4[19].SetActive(true);
            yield return new WaitForSeconds(3);
            Page_4[20].SetActive(true);
            yield return new WaitForSeconds(3);
            Page_4[21].SetActive(true);
            yield return new WaitForSeconds(4);
            Page_4[22].SetActive(true);
            Page_4[22].GetComponent<RectTransform>().DOScale(1, 0.5f);
            yield return new WaitForSeconds(1);
            Page_4[22].GetComponent<RectTransform>().DOAnchorPosX(-430, 0.7f);
            yield return new WaitForSeconds(0.7f);
            Page_4[22].GetComponent<RectTransform>().DOAnchorPosX(-140, 0.7f);
            yield return new WaitForSeconds(0.7f);
            Page_4[22].GetComponent<RectTransform>().DOAnchorPosX(125, 0.8f);
            yield return new WaitForSeconds(0.8f);
            Page_4[22].GetComponent<RectTransform>().DOAnchorPosX(390, 0.8f);
            yield return new WaitForSeconds(0.8f);
            Page_4[22].GetComponent<RectTransform>().DOAnchorPosX(650, 0.8f);
            yield return new WaitForSeconds(0.8f);
            Page_4[22].GetComponent<RectTransform>().DOScale(0, 0.5f);
            yield return new WaitForSeconds(10);
            Page_4[12].GetComponent<RectTransform>().DORotate(new Vector3(0, 180, 0), 1);
            Page_4[13].GetComponent<RectTransform>().DOAnchorPosX(-540, 1);
            yield return new WaitForSeconds(1);
            Page_4[14].GetComponent<RectTransform>().DOAnchorPosX(-540, 1);
            Page_4[14].GetComponent<RectTransform>().DOAnchorPosY(-161.5f, 1);
            Page_4[14].GetComponent<RectTransform>().DORotate(new Vector3(0, 0, 180), 1);
            //yield return new WaitForSeconds(1);
            Page_4[14].GetComponent<RectTransform>().DORotate(new Vector3(0, 0, 270), 1);
            yield return new WaitForSeconds(1);
            Page_4[15].GetComponent<RectTransform>().DOAnchorPosX(-683, 1);
            Page_4[15].GetComponent<RectTransform>().DOAnchorPosY(-161.5f, 1);
            Page_4[15].GetComponent<RectTransform>().DORotate(new Vector3(0, 0, 180), 1);
            yield return new WaitForSeconds(1);
            Page_4[16].GetComponent<RectTransform>().DOAnchorPosX(-180, 1);
            Page_4[17].GetComponent<RectTransform>().DOAnchorPosX(-324, 1);
            Page_4[17].GetComponent<RectTransform>().DORotate(new Vector3(0, 180, 0), 1);
            yield return new WaitForSeconds(10);
            Page_4[23].SetActive(true);
            yield return new WaitForSeconds(1);
            Page_4[24].SetActive(true);
            yield return new WaitForSeconds(5);
            Page_4[25].GetComponent<RectTransform>().DOScale(0, 0.5f);
            yield return new WaitForSeconds(0.5f);
            Page_4[26].GetComponent<Help5_2>().FractionAnimate();
            
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
            yield return new WaitForSeconds(0.5f);
            Page_5[3].SetActive(false);
        }
    }
}

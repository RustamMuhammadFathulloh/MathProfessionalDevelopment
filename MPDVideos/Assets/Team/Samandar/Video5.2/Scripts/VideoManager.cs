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
        public List<GameObject> Pages;
        //public List<float> PageTime;
        public List<GameObject> Page_2;
        public GameObject transition;
        public List<AudioSource> Audio;
        public UnityEvent PageEvent_2;
        private void Start()
        {
            StartCoroutine(PageController_2());
            StartCoroutine(AudioController());
        }
        public void Challenge()
        {
            
        }
        public void Transition()
        {
            transition.SetActive(true);
        }
        IEnumerator AudioController() 
        {
            yield return new WaitForSeconds(0.5f);
            Audio[0].Play();
            yield return new WaitForSeconds(19);
            Audio[1].Play();
            yield return new WaitForSeconds(6.4f);
            Audio[2].Play();
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
            yield return new WaitForSeconds(0.9f);
            Page_2[19].GetComponent<Image>().DOFillAmount(1, 0);
            Page_2[19].GetComponent<Image>().DOFillAmount(0, 0.2f);
            yield return new WaitForSeconds(7);
            PageEvent_2.Invoke();
        }

   }
}

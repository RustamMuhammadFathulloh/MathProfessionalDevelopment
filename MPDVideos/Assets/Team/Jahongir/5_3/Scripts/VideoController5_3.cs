using CommonFeatures;
using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VideoController5_3 : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject Introduction;
    public GameObject StartFeature;
    public GameObject FinishFeatures;

    [Header("First Page")]
    public GameObject FirstPage;
    public GameObject TitleObject;
    public Image[] Lines;
    public GameObject LeftNodes;
    public GameObject RightNode;
    public GameObject OperationsEllips;

    [Header("Second Page")]
    public GameObject SecondPage;
    public GameObject TitleText;
    public GameObject Title2;
    public GameObject Fractions;
    public GameObject Rectangle;

    [Header("Third Page")]
    public GameObject ThirdPage;
    public GameObject Fractions1;
    public GameObject Fractions2;
    public GameObject Image3;
    public GameObject Strelka1;
    public GameObject Hand;
    public GameObject Hand2;
    public GameObject Half;
    public GameObject Quarter;
    public GameObject Quarter2;
    public GameObject Quarter3;
    public GameObject Parent1_2;
    public GameObject Parent1_8;
    public GameObject Texts;
    public GameObject Fractions3;
    public GameObject Personaj1;
    public GameObject Personaj2;
    public GameObject Personaj3;


    [Header("Fourth Page")]
    public GameObject FourPage;
    public GameObject Task1;
    public GameObject Task2;


    [Header("Common things")]
    public AudioClip[] AudioClips5_3;
    public GameObject Transition1;
    public GameObject Transition2;
    private AudioSource _audioSource;
    private int _audioIndex;

    private void Awake()
    {
        _audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void Anim5_3()
    {
        StartCoroutine(StartAnim5_3());
    }
    public IEnumerator StartAnim5_3()
    {
        yield return new WaitForSeconds(0.1f);
        TitleObject.GetComponent<EachObject>().FadeText(1, 0.5f);
        yield return new WaitForSeconds(0.5f);
        PlayAudio();  //4
        yield return new WaitForSeconds(0.5f);
        TitleObject.GetComponent<EachObject>().Movement(new Vector2(0, Screen.height / 4), 0.5f);
        yield return new WaitForSeconds(1);

        //Lines
        float duration0 = 0.5f;
        Lines[0].DOFillAmount(1, duration0);
        yield return new WaitForSeconds(duration0);
        Lines[1].DOFillAmount(1, duration0 * 2);
        yield return new WaitForSeconds(duration0 * 2);
        Lines[2].DOFillAmount(1, duration0);
        yield return new WaitForSeconds(2 * duration0);

        // LeftNode
        _audioSource.PlayOneShot(AudioClips5_3[3]);  // 4
        LeftNodes.transform.DOScale(1, duration0);
        yield return new WaitForSeconds(1.4f);
        //yield return new WaitForSeconds((float)AudioClips5_3[3].length / 2);

        
        Lines[3].DOFillAmount(1, duration0);
        yield return new WaitForSeconds(2);
        OperationsEllips.transform.DOScale(1, duration0);
        yield return new WaitForSeconds(duration0);

        
        float durQuarter = 0.25f;
        OperationsEllips.transform.DOScale(1, 1);
        yield return new WaitForSeconds(1 + durQuarter);

        
        Lines[4].DOFillAmount(1, 3 * duration0);
        yield return new WaitForSeconds(3 * duration0);
        Lines[5].DOFillAmount(1, duration0);
        yield return new WaitForSeconds(duration0);
        RightNode.transform.DOScale(1, duration0);
        yield return new WaitForSeconds(7);
        StartCoroutine(SecondPageAnim());

    }

    public IEnumerator SecondPageAnim()
    {
        yield return new WaitForSeconds(0.1f);
        Transition1.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        FirstPage.SetActive(false);
        SecondPage.SetActive(true);
        
        yield return new WaitForSeconds(0.5f);
        _audioSource.PlayOneShot(AudioClips5_3[4]);  // 5
        

        yield return new WaitForSeconds(1f);
        for (int i = 0; i < 3; i++)
        {
            TitleText.transform.GetChild(i).GetComponent<TMP_Text>().DOFade(1, 0.5f);
        }
        yield return new WaitForSeconds(6);
        for (int i = 0; i < 3; i++)
        {
            TitleText.transform.GetChild(i).GetComponent<TMP_Text>().DOFade(0, 0.5f);
        }
        yield return new WaitForSeconds(0.5f);

        //Title2
        _audioSource.PlayOneShot(AudioClips5_3[5]); //6
        Title2.transform.GetChild(0).GetComponent<TMP_Text>().DOFade(1, 0.5f);
        Title2.transform.GetChild(1).GetComponent<TMP_Text>().DOFade(1, 0.5f);
        yield return new WaitForSeconds(0.7f);
        Rectangle.transform.GetChild(0).GetComponent<TMP_Text>().DOFade(1, 0.5f);
        Rectangle.transform.GetChild(1).GetComponent<Image>().DOFillAmount(1, 1f);
        yield return new WaitForSeconds(1f);
        Rectangle.transform.GetChild(2).GetComponent<TMP_Text>().DOFade(1, 0.5f);
        yield return new WaitForSeconds(2f);
        Transition1.SetActive(false);
        Fractions.transform.GetChild(0).GetComponent<TMP_Text>().DOFade(1, 0.5f);
        yield return new WaitForSeconds(0.7f);
        Fractions.transform.GetChild(1).transform.DOScale(1.3f, 1f);
        yield return new WaitForSeconds(1f);
        Fractions.transform.GetChild(1).transform.DOScale(1.2f, 0.3f);
        yield return new WaitForSeconds(3f);
        StartCoroutine(ThirdPageAnim());

    }


    public IEnumerator ThirdPageAnim()
    {
        yield return new WaitForSeconds(0.1f);
        Transition1.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        SecondPage.SetActive(false);
        ThirdPage.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        _audioSource.PlayOneShot(AudioClips5_3[6]);  // 7
        ThirdPage.transform.GetChild(0).GetComponent<TMP_Text>().DOFade(1, 0.5f);
        yield return new WaitForSeconds(4);
        ThirdPage.transform.GetChild(0).GetComponent<TMP_Text>().DOFade(0, 0.5f);
        ThirdPage.transform.GetChild(1).GetComponent<TMP_Text>().DOFade(1, 0.5f);
        yield return new WaitForSeconds(0.5f);

        _audioSource.PlayOneShot(AudioClips5_3[7]);  // 8
        yield return new WaitForSeconds(0.8f);
        for (int i = 0; i < 3; i++)
        {
            Fractions1.transform.GetChild(i).transform.DOScale(1.2f, 0.8f);
            yield return new WaitForSeconds(0.8f);
            Fractions1.transform.GetChild(i).transform.DOScale(1f, 0.8f);
        }
        yield return new WaitForSeconds(1.5f);
        Image3.transform.GetComponent<Image>().DOFillAmount(1, 1.5f);
        yield return new WaitForSeconds(1.5f);
        Strelka1.transform.GetComponent<Image>().DOFillAmount(1, 0.8f);
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < 3; i++)
        {
            Fractions2.transform.GetChild(i).transform.DOScale(1.2f, 0.8f);
            yield return new WaitForSeconds(0.8f);
            Fractions2.transform.GetChild(i).transform.DOScale(1f, 0.8f);
        }
        yield return new WaitForSeconds(6.5f);
        Hand.transform.DOScale(0.9f, 0.8f);
        yield return new WaitForSeconds(0.8f);
        Hand.transform.DOScale(0.7f, 0.8f);
        yield return new WaitForSeconds(0.8f);
        Hand.transform.GetComponent<Image>().DOFade(0, 1);

        yield return new WaitForSeconds(3f);
        Parent1_2.transform.GetComponent<Image>().DOFillAmount(1, 1.5f);
        yield return new WaitForSeconds(2f);
        Half.transform.DOScale(1f, 0f);
        yield return new WaitForSeconds(1.5f);
        _audioSource.PlayOneShot(AudioClips5_3[8]);  // 9

        yield return new WaitForSeconds(3f);
        Hand2.transform.DOScale(0.9f, 0.8f);
        yield return new WaitForSeconds(0.8f);
        Hand2.transform.DOScale(0.7f, 0.8f);
        yield return new WaitForSeconds(0.8f);
        Hand2.transform.GetComponent<Image>().DOFade(0, 1);

        yield return new WaitForSeconds(2f);
        for (int i = 0; i < 3; i++)
        {
            Parent1_8.transform.GetChild(i).GetComponent<Image>().DOFillAmount(1, 1.5f);
            yield return new WaitForSeconds(1f);
        }
        
        yield return new WaitForSeconds(5f);
        Quarter.transform.DOScale(1f, 0f);
        Hand2.transform.GetComponent<RectTransform>().DOLocalMove(new Vector3(-250, 110, 0), 0);
        yield return new WaitForSeconds(1f);
        Hand2.transform.GetComponent<Image>().DOFade(1, 1);
        yield return new WaitForSeconds(2.5f);
        Hand2.transform.GetComponent<Image>().DOFade(0, 1);
        yield return new WaitForSeconds(4f);

        _audioSource.PlayOneShot(AudioClips5_3[9]);  // 10
        yield return new WaitForSeconds(4f);
        Texts.transform.GetChild(0).GetComponent<TMP_Text>().DOFade(1, 1f);
        yield return new WaitForSeconds(1f);
        Texts.transform.GetChild(1).GetComponent<Image>().DOFillAmount(1, 1.5f);
        yield return new WaitForSeconds(1f);
        Texts.transform.GetChild(2).GetComponent<TMP_Text>().DOFade(1, 1f);
        yield return new WaitForSeconds(5f);
        for (int i = 0; i < 5; i++)
        {
            Fractions3.transform.GetChild(i).transform.DOScale(1.2f, 0.8f);
            yield return new WaitForSeconds(0.8f);
            Fractions3.transform.GetChild(i).transform.DOScale(1f, 0.8f);
        }
        yield return new WaitForSeconds(4f);
        Personaj1.SetActive(false);

        for (int i = 0; i < 3; i++)
        {
            Personaj2.transform.GetChild(0).transform.GetChild(i).transform.DOScale(1.2f, 0.8f);
            yield return new WaitForSeconds(0.8f);
            Personaj2.transform.GetChild(0).transform.GetChild(i).transform.DOScale(1f, 0.8f);
        }
        Personaj2.transform.GetChild(1).GetComponent<Image>().DOFillAmount(1, 1f);
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < 3; i++)
        {
            Personaj2.transform.GetChild(2).transform.GetChild(i).transform.DOScale(1.2f, 0.8f);
            yield return new WaitForSeconds(0.8f);
            Personaj2.transform.GetChild(2).transform.GetChild(i).transform.DOScale(1f, 0.8f);
        }
        yield return new WaitForSeconds(3f);
        _audioSource.PlayOneShot(AudioClips5_3[10]);  // 11
        yield return new WaitForSeconds(10f);
        Quarter2.transform.DOScale(1f, 0f); 
        yield return new WaitForSeconds(6f);
        Personaj2.transform.GetChild(3).transform.GetChild(0).GetComponent<TMP_Text>().DOFade(1, 1f);
        yield return new WaitForSeconds(1f);
        Personaj2.transform.GetChild(3).transform.GetChild(1).GetComponent<Image>().DOFillAmount(1, 1.5f);
        yield return new WaitForSeconds(1f);
        Personaj2.transform.GetChild(3).transform.GetChild(2).GetComponent<TMP_Text>().DOFade(1, 1f);

        yield return new WaitForSeconds(4f);

        for (int i = 0; i < 5; i++)
        {
            Personaj2.transform.GetChild(4).transform.GetChild(i).transform.DOScale(1.2f, 0.8f);
            yield return new WaitForSeconds(0.8f);
            Personaj2.transform.GetChild(4).transform.GetChild(i).transform.DOScale(1f, 0.8f);
        }

        //Personaj3
        yield return new WaitForSeconds(2f);
        Personaj2.SetActive(false);
        _audioSource.PlayOneShot(AudioClips5_3[11]);  // 12
        yield return new WaitForSeconds(1f);
        for (int i = 0; i < 3; i++)
        {
            Personaj3.transform.GetChild(0).transform.GetChild(i).transform.DOScale(1.2f, 1f);
            yield return new WaitForSeconds(1f);
            Personaj3.transform.GetChild(0).transform.GetChild(i).transform.DOScale(1f, 1f);
        }
        Personaj3.transform.GetChild(1).GetComponent<Image>().DOFillAmount(1, 1f);
        yield return new WaitForSeconds(3f);
        for (int i = 0; i < 3; i++)
        {
            Personaj3.transform.GetChild(2).transform.GetChild(i).transform.DOScale(1.2f, 1f);
            yield return new WaitForSeconds(1f);
            Personaj3.transform.GetChild(2).transform.GetChild(i).transform.DOScale(1f, 1f);
        }
        yield return new WaitForSeconds(3f);
        
        yield return new WaitForSeconds(12f);
        Quarter3.transform.DOScale(1f, 0f);
        yield return new WaitForSeconds(1f);
        Personaj3.transform.GetChild(3).transform.GetChild(0).GetComponent<TMP_Text>().DOFade(1, 1f);
        yield return new WaitForSeconds(1f);
        Personaj3.transform.GetChild(3).transform.GetChild(1).GetComponent<Image>().DOFillAmount(1, 1.5f);
        yield return new WaitForSeconds(1f);
        Personaj3.transform.GetChild(3).transform.GetChild(2).GetComponent<TMP_Text>().DOFade(1, 1f);

        yield return new WaitForSeconds(2.5f);
        _audioSource.PlayOneShot(AudioClips5_3[12]);  // 13
        yield return new WaitForSeconds(2f);

        for (int i = 0; i < 5; i++)
        {
            Personaj3.transform.GetChild(4).transform.GetChild(i).transform.DOScale(1.2f, 0.8f);
            yield return new WaitForSeconds(0.8f);
            Personaj3.transform.GetChild(4).transform.GetChild(i).transform.DOScale(1f, 0.8f);
        }
        yield return new WaitForSeconds(2f);
        StartCoroutine(FourPageAnim());
    }


    public IEnumerator FourPageAnim()
    {
        yield return new WaitForSeconds(0.25f);
        ThirdPage.SetActive(false);
        FourPage.SetActive(true);
        _audioSource.PlayOneShot(AudioClips5_3[13]);  // 14
        yield return new WaitForSeconds(1);
        for (int i = 0; i < 5; i++)
        {
            FourPage.transform.GetChild(1).GetChild(0).GetChild(i).DOScale(1.2f, 0.5f);
            FourPage.transform.GetChild(1).GetChild(1).GetChild(i).DOScale(1.2f, 0.5f);
            FourPage.transform.GetChild(1).GetChild(2).GetChild(i).DOScale(1.2f, 0.5F);
            yield return new WaitForSeconds(0.5f);
            FourPage.transform.GetChild(1).GetChild(0).GetChild(i).DOScale(1f, 0.5f);
            FourPage.transform.GetChild(1).GetChild(1).GetChild(i).DOScale(1f, 0.5f);
            FourPage.transform.GetChild(1).GetChild(2).GetChild(i).DOScale(1f, 0.5f);
            yield return new WaitForSeconds(0.5f);
        }
        yield return new WaitForSeconds(2);
        FourPage.transform.GetChild(2).GetChild(0).DOScale(1f, 1f);
        yield return new WaitForSeconds(2.5f);
        for (int i = 0; i < 5; i++)
        {
            FourPage.transform.GetChild(2).GetChild(1).GetChild(i).DOScale(1.2f, 0.5f);
            FourPage.transform.GetChild(2).GetChild(2).GetChild(i).DOScale(1.2f, 0.5f);
            FourPage.transform.GetChild(2).GetChild(3).GetChild(i).DOScale(1.2f, 0.5f);
            yield return new WaitForSeconds(0.5f);
            FourPage.transform.GetChild(2).GetChild(1).GetChild(i).DOScale(1f, 0.5f);
            FourPage.transform.GetChild(2).GetChild(2).GetChild(i).DOScale(1f, 0.5f);
            FourPage.transform.GetChild(2).GetChild(3).GetChild(i).DOScale(1f, 0.5f);
            yield return new WaitForSeconds(0.5f);
        }
        yield return new WaitForSeconds(7f);
        _audioSource.PlayOneShot(AudioClips5_3[14]);  // 15
        FourPage.transform.GetChild(4).DOScale(1.2f, 0.5f);
        yield return new WaitForSeconds(0.5f);
        FourPage.transform.GetChild(4).DOScale(1f, 0.5f);
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < 4; i++)
        { 
            FourPage.transform.GetChild(4).GetChild(i).DOScale(1.2f, 0.5f);
            yield return new WaitForSeconds(0.5f);
            FourPage.transform.GetChild(4).GetChild(i).DOScale(1f, 0.5f);
        }
        yield return new WaitForSeconds(1.5f);
        for (int i = 0; i < 7; i++)
        {
            FourPage.transform.GetChild(4).GetChild(4).GetChild(i).DOScale(1.2f, 0.5f);
            yield return new WaitForSeconds(0.5f);
            FourPage.transform.GetChild(4).GetChild(4).GetChild(i).DOScale(1f, 0.5f);
        }
        yield return new WaitForSeconds(2f);

        _audioSource.PlayOneShot(AudioClips5_3[15]);  // 16
        yield return new WaitForSeconds(1f);
        FourPage.transform.GetChild(3).GetChild(0).DOScale(1.2f, 0.5f);
        yield return new WaitForSeconds(0.5f);
        FourPage.transform.GetChild(3).GetChild(0).DOScale(1f, 0.5f);
        yield return new WaitForSeconds(1.5f);
        for (int i = 0; i < 5; i++)
        {
            FourPage.transform.GetChild(3).GetChild(1).GetChild(i).transform.DOScale(1.2f, 0.8f);
            yield return new WaitForSeconds(0.8f);
            FourPage.transform.GetChild(3).GetChild(1).GetChild(i).transform.DOScale(1f, 0.8f);
            yield return new WaitForSeconds(0.5f);
        }
        yield return new WaitForSeconds(3f);
        for (int i = 0; i < 2; i++)
        {
            FourPage.transform.GetChild(3).GetChild(2).GetChild(i).transform.DOScale(1.2f, 0.8f);
            yield return new WaitForSeconds(0.8f);
            FourPage.transform.GetChild(3).GetChild(2).GetChild(i).transform.DOScale(1f, 0.8f);
        }
        yield return new WaitForSeconds(2f);

        _audioSource.PlayOneShot(AudioClips5_3[16]);  // 17
        yield return new WaitForSeconds(1.5f);
        
        for (int i = 0; i < 5; i++)
        {
            FourPage.transform.GetChild(3).GetChild(3).GetChild(i).transform.DOScale(1.2f, 0.8f);
            yield return new WaitForSeconds(0.8f);
            FourPage.transform.GetChild(3).GetChild(3).GetChild(i).transform.DOScale(1f, 0.8f);
            yield return new WaitForSeconds(0.5f);
        }
        yield return new WaitForSeconds(4f);
        for (int i = 0; i < 2; i++)
        {
            FourPage.transform.GetChild(3).GetChild(4).GetChild(i).transform.DOScale(1.2f, 0.8f);
            yield return new WaitForSeconds(0.8f);
            FourPage.transform.GetChild(3).GetChild(4).GetChild(i).transform.DOScale(1f, 0.8f);
        }
        yield return new WaitForSeconds(2f);
        _audioSource.PlayOneShot(AudioClips5_3[17]);  // 18
        yield return new WaitForSeconds(4f);
        FourPage.transform.GetChild(5).transform.DOScale(1f, 0.8f);
        yield return new WaitForSeconds(0.8f);
        FourPage.transform.GetChild(5).transform.DOScale(1f, 0.8f);


        yield return new WaitForSeconds(5f);
        FinishFeatures.GetComponent<FinishFeatures>().FinishAnimation();

    }

    public void LastAnim()
    {
        Task1.transform.DOScale(1.4f, 1);
        Task2.transform.DOScale(1.4f, 1);
    }
    public void PlayAudio()
    {
        _audioSource.PlayOneShot(AudioClips5_3[_audioIndex]);
        Debug.Log(_audioIndex + 1 + "  =  " + AudioClips5_3[_audioIndex].length + "  =  " + DateTime.Now);
        _audioIndex++;
    }

}

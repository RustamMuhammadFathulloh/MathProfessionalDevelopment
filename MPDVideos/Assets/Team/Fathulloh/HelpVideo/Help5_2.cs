using DG.Tweening;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Help5_2 : MonoBehaviour
{
    public Image KasrImage;
    public Image BracketLeft;
    public Image BracketRight;

    public int CirclePartsY;
    public Image[] CircleParts;

    [TextAreaAttribute]
    public string ReGrouptext;

    public GameObject ReGroupObject;
    private GameObject _reGroupText;

    public GameObject HalfCircle;
    public GameObject FullCircle;
    public Image ArrowImage;


    void Start()
    {
        InitialTasksSet();
    }


    /// <summary>
    /// Shu criptni kerakli joyda chaqirib ishlating. 
    /// </summary>
    public void FractionAnimate()
    {
        StartCoroutine(FractionAnimating());
    }


    IEnumerator FractionAnimating()
    {
        yield return new WaitForSeconds(1.5f);
        KasrImage.DOFade(1, 0.5f);

        float duration1 = 0.75f;
        yield return new WaitForSeconds(duration1);
        BracketLeft.DOFillAmount(1, duration1);
        BracketRight.DOFillAmount(1, duration1);

        yield return new WaitForSeconds(duration1);
        for (int i = 0; i < CircleParts.Length; i++)
        {
            CircleParts[i].DOFade(1, duration1);
            CircleParts[i].gameObject.GetComponent<RectTransform>().DOAnchorPosY(CirclePartsY, duration1);
            yield return new WaitForSeconds(0.5f);
        }
        yield return new WaitForSeconds(duration1);

        ReGroupObject.GetComponent<Image>().DOFade(1, duration1);
        _reGroupText.GetComponent<TMP_Text>().DOFade(1, duration1);

        yield return new WaitForSeconds(2);
        ArrowImage.DOFade(1, duration1);

        for (int i = 0; i < FullCircle.transform.childCount; i++)
        {
            FullCircle.transform.GetChild(i).GetComponent<Image>().DOFade(1, duration1);
        }

        for (int i = 0; i < HalfCircle.transform.childCount; i++)
        {
            HalfCircle.transform.GetChild(i).GetComponent<Image>().DOFade(1, duration1);
        }


        yield return new WaitForSeconds(duration1);
        yield return new WaitForSeconds(duration1);
        yield return new WaitForSeconds(duration1);
        yield return new WaitForSeconds(duration1);

    }


    void InitialTasksSet()
    {
        KasrImage.DOFade(0, 0);
        BracketLeft.DOFillAmount(0, 0);
        BracketRight.DOFillAmount(0, 0);

        for (int i = 0; i < CircleParts.Length; i++)
        {
            CircleParts[i].DOFade(0, 0);
        }

        ReGroupObject.GetComponent<Image>().DOFade(0, 0);
        _reGroupText = ReGroupObject.transform.GetChild(0).gameObject;
        _reGroupText.GetComponent<TMP_Text>().DOFade(0, 0);
        _reGroupText.GetComponent<TMP_Text>().text = ReGrouptext;

        for (int i = 0; i < FullCircle.transform.childCount; i++)
        {
            FullCircle.transform.GetChild(i).GetComponent<Image>().DOFade(0, 0);
        }

        for (int i = 0; i < HalfCircle.transform.childCount; i++)
        {
            HalfCircle.transform.GetChild(i).GetComponent<Image>().DOFade(0, 0);
        }

        ArrowImage.DOFade(0, 0);

    }


}

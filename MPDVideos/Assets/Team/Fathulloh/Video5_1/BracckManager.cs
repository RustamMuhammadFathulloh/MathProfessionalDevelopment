using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BracckManager : MonoBehaviour
{
    public Image LeftBracket;
    public Image RightBracket;

    private void Awake()
    {
        BracketFillAmount(0, 0);
    }

    public void BracketFillAmount(float fillAmount, float duration)
    {
        LeftBracket.DOFillAmount(fillAmount, duration);
        RightBracket.DOFillAmount(fillAmount, duration);
    }
}

using CommonFeatures;
using System.Collections;
using TMPro;
using UnityEngine;

public class LessonTitleTop : MonoBehaviour
{
    [Header("Texts")]
    public string Understanding;
    public string Demonstration;
    public string Summary;
    public string Practice;

    [HideInInspector] public float UnderstandingTime;
    [HideInInspector] public float DemonstrationTime;
    [HideInInspector] public float SummaryTime;
    [HideInInspector] public float PracticeTime;

    public EachObject RightObject;
    //public TMP_Text timerText;
    private float currentTime = 0f;
    private bool timerActive = false;

    private bool _isUnderstanding = true;
    private bool _isDemonstration = true;
    private bool _isSummary = true;
    private bool _isPractice = true;


    void Start()
    {
        currentTime = 0f;
        timerActive = true;
    }


    void Update()
    {
        if (timerActive)
        {
            currentTime += Time.deltaTime;

            if (currentTime >= PracticeTime && _isPractice)
            {
                _isPractice = false;
                RightObject.FadeText(0, 0.5f);
                StartCoroutine(WriteTextRightObject(Practice));
            }
            else if (currentTime >= SummaryTime && _isSummary)
            {
                _isSummary = false;
                RightObject.FadeText(0, 0.5f);
                StartCoroutine(WriteTextRightObject(Summary));
                //Debug.Log("currentTime = " + currentTime);
            }
            else if (currentTime >= DemonstrationTime && _isDemonstration)
            {
                _isDemonstration = false;
                RightObject.FadeText(0, 0.5f);
                StartCoroutine(WriteTextRightObject(Demonstration));
                //Debug.Log("currentTime = " + currentTime);
            }
            else if (currentTime >= UnderstandingTime && _isUnderstanding)
            {
                _isUnderstanding = false;
                RightObject.FadeText(0, 0.5f);
                StartCoroutine(WriteTextRightObject(Understanding));
                //Debug.Log("currentTime = " + currentTime);
            }
        }
    }


    IEnumerator WriteTextRightObject(string str)
    {
        yield return new WaitForSeconds(0.5f);
        RightObject.MoveOutTop(0);
        yield return new WaitForSeconds(0.1f);
        RightObject.WriteText(str);
        RightObject.FadeText(1, 0);
        yield return new WaitForSeconds(0.1f);
        RightObject.MoveToInitialPos(0.5f);
    }

}

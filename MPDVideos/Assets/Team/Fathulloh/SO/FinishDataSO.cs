using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FinishData", menuName = "ScriptableObjects/FinishData")]
public class FinishDataSO : ScriptableObject
{
    public enum MathGrade { None, Grade5, Grade6 };
    public MathGrade CurrentGrade;

    public AudioClip LetsSummarizeClip;
    public AudioClip ForYourPracticeClip;

    [TextAreaAttribute]
    public string ForYourPractiseText;

    [TextAreaAttribute]
    public string SummarizeText1;
    [TextAreaAttribute]
    public string SummarizeText2;
    [TextAreaAttribute]
    public string SummarizeText3;
    [TextAreaAttribute]
    public string SummarizeText4;
    [TextAreaAttribute]
    public string SummarizeText5;

    public AudioClip[] SummarizeClips;
    public GameObject[] SummarizePrefabs;

    public float DistanceSummarize;

}

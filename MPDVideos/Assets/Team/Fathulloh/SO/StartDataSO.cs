using UnityEngine;

[CreateAssetMenu(fileName = "StartData", menuName = "ScriptableObjects/StartData")]
public class StartDataSO : ScriptableObject
{
    public enum MathGrade { None, Grade5, Grade6};
    public MathGrade CurrentGrade;

    [Range(1, 21)]
    public int LessonOrder;

    [TextAreaAttribute]
    public string LessonTitle;
    [TextAreaAttribute]
    public string InThisLesson;

    [TextAreaAttribute]
    public string LetsLookAtThe_1;
    [TextAreaAttribute]
    public string LetsLookAtThe_2;

    [Header("Audio clips")]
    public AudioClip AudioInThisLesson;
    public AudioClip AudioLetsLookAtThe;

    public float UnderstandingTime;
    public float DemonstrationTime;
    public float SummaryTime;
    public float PracticeTime;
}

using UnityEngine;

[CreateAssetMenu(fileName = "StartTexts", menuName = "ScriptableObjects/StartTexts")]
public class StartTextSO : ScriptableObject
{
    public enum MathGrade { None, Grade5, Grade6};
    public MathGrade CurrentGrade;

    [Range(1, 21)]
    public int LessonOrder;
    public string LessonTitle;
    public string InThisLesson;

    [TextAreaAttribute]
    public string LetsLookAtThe_1;
    [TextAreaAttribute]
    public string LetsLookAtThe_2;

}

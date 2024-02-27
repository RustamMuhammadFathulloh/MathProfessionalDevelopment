using ScriptableObjectArchitecture;
using System.Collections;
using TMPro;
using UnityEngine;

namespace CommonFeatures
{
    public class StartFeature : MonoBehaviour
    {
        [Header("Intro Panel")]
        public GameObject IntroPanel;
        public GameObject IntroPanelText1;
        public GameObject IntroPanelText2;
        public GameObject IntroPanelText3;
        public GameObject BottomTitlePanel;

        [Header("In this lesson parent")]
        public EachObject ColorPanel;
        public EachObject InThisLessonBoard;
        public EachObject InThisLessonBoardText;
        public EachObject ExplainBoard;
        public EachObject ExplainText;

        [Header("Transitions")]
        public EachObject LeftFirstTransition;
        public EachObject LeftSecondTransition;

        public EachObject TopWhiteTransition;
        public EachObject BottomWhiteTransition;

        public EachObject LetsLookAtTheText_1;
        public EachObject LetsLookAtTheText_2;        
        //public EachObject LessonTitleText;
         

        [Header("Scriptable Objects")]
        public BoolVariable StartAnim;
        [HideInInspector] private StartTextSO _startTexts;

        [Header("Top title panel")]
        public GameObject TopTitlePrefab;
        //private GameObject _topTitleObject;
        [HideInInspector] public EachObject TopTitlePanel;


        void Start()
        {
            GameObject _topTitleObject = Instantiate(TopTitlePrefab);
            _topTitleObject.transform.SetParent(GameObject.Find("Canvas").transform, false);
            TopTitlePanel = _topTitleObject.GetComponent<EachObject>();
            TopTitlePanel.transform.GetChild(0).GetComponent<EachObject>().WriteText(_startTexts.LessonTitle);

            StartCoroutine(Animations());
        }

                
        IEnumerator Animations()
        {
            //IntroPanel.GetComponent<EachObject>().MoveOutLeft(0);
            yield return new WaitForSeconds(0.5f);
            IntroPanel.GetComponent<EachObject>().MoveToInitialPos(2f);
            yield return new WaitForSeconds(1f);
            IntroPanelText1.GetComponent<EachObject>().FadeText(1f, 0.75f);
            yield return new WaitForSeconds(0.75f);
            IntroPanelText2.GetComponent<EachObject>().SmallMove(0.5f);
            IntroPanelText2.GetComponent<EachObject>().FadeText(1f, 0.5f);                       
            yield return new WaitForSeconds(1f);
            IntroPanelText3.GetComponent<EachObject>().FadeText(1f, 0.5f);
            yield return new WaitForSeconds(0.75f);
            BottomTitlePanel.GetComponent<EachObject>().MoveToInitialPos(0.5f);

            yield return new WaitForSeconds(1f);
            ColorPanel.FadeImage(1, 0.5f);
            yield return new WaitForSeconds(1f);
            InThisLessonBoard.MoveToInitialPos(0.5f);
            yield return new WaitForSeconds(0.75f);
            InThisLessonBoardText.MoveToInitialPos(0.5f);
            yield return new WaitForSeconds(0.75f);
            ExplainText.MoveToInitialPos(0.5f);
            yield return new WaitForSeconds(2.5f);

            //Transitions
            LeftFirstTransition.MoveAgainstPosition(1.6f);
            yield return new WaitForSeconds(0.35f);
            LeftSecondTransition.MoveAgainstPosition(1.5f);
            InThisLessonBoard.MoveOutTop(0);
            ExplainBoard.MoveOutTop(0);
            yield return new WaitForSeconds(0.5f);            
            yield return new WaitForSeconds(1f);

            TopWhiteTransition.MoveToInitialPos(1);
            BottomWhiteTransition.MoveToInitialPos(1);
            yield return new WaitForSeconds(0.7f);
            TopTitlePanel.MoveToInitialPos(0.5f);
            LetsLookAtTheText_1.MoveToInitialPos(0.5f);
            yield return new WaitForSeconds(1.3f);

            if (LetsLookAtTheText_2.GetComponent<TMP_Text>().text != null)
            {
                LetsLookAtTheText_1.MoveToInitialPos(0.5f);
                yield return new WaitForSeconds(1.3f);
            }

            LetsLookAtTheText_1.FadeText(0, 1);
            yield return new WaitForSeconds(1.5f);
            //LessonTitleText.FadeText(1, 1);
            
            StartAnim.Value = true;
        }


        public void SetInitialTexts(StartTextSO videoStartTexts)
        {
            _startTexts = videoStartTexts;

            BottomTitlePanel.transform.GetChild(0).GetComponent<EachObject>().WriteText(_startTexts.LessonTitle);
            //TopWhiteTransition.transform.GetChild(0).transform.GetChild(0).GetComponent<EachObject>().WriteText(_startTexts.LessonTitle);
            //TopTitlePanel.WriteText(_startTexts.LessonTitle);
            ExplainText.WriteText(_startTexts.InThisLesson);

            LetsLookAtTheText_1.WriteText(_startTexts.LetsLookAtThe_1);
            LetsLookAtTheText_2.WriteText(_startTexts.LetsLookAtThe_2);
        }


    }
}

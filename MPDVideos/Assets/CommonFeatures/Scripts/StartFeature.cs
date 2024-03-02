using ScriptableObjectArchitecture;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace CommonFeatures
{
    public class StartFeature : MonoBehaviour
    {
        [Header("Introduction Panel")]
        public GameObject IntroductionPage;
        //private GameObject IntroductionPage;

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
        //[HideInInspector] private StartDataSO _startTexts;

        [Header("Top title panel")]
        public GameObject TopTitlePrefab;
        [HideInInspector] public EachObject TopTitlePanel;


        [Header("Scriptable Object")]
        public StartDataSO StartData;
        private AudioSource audioSource;

        public UnityEvent StartEvent;


        private void Awake()
        {
            //IntroductionPage = Instantiate(IntroductionPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            //IntroductionPage.transform.SetParent(GameObject.Find("Canvas").transform, false);

            GameObject _topTitleObject = Instantiate(TopTitlePrefab);
            _topTitleObject.transform.SetParent(GameObject.Find("Canvas").transform, false);
            TopTitlePanel = _topTitleObject.GetComponent<EachObject>();
            TopTitlePanel.transform.GetChild(0).GetComponent<EachObject>().WriteText(StartData.LessonTitle);

            SetInitialTexts();
        }


        void Start()
        {
            audioSource = gameObject.GetComponent<AudioSource>();            

            StartCoroutine(Animations());
        }

                
        IEnumerator Animations()
        {
            //IntroPanel.GetComponent<EachObject>().MoveOutLeft(0);
            yield return new WaitForSeconds(2.5f);
            IntroductionPage.GetComponent<IntroController>().FadeControl();

            yield return new WaitForSeconds(1f);
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
            audioSource.PlayOneShot(StartData.AudioInThisLesson);
            //Debug.Log("   " + StartData.AudioInThisLesson.length);
            ExplainText.MoveToInitialPos(0.5f);
            yield return new WaitForSeconds(StartData.AudioInThisLesson.length);

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

            yield return new WaitForSeconds(0.1f);           
            if (LetsLookAtTheText_2.GetComponent<TMP_Text>().text.Length > 1)
            {
                LetsLookAtTheText_2.MoveToInitialPos(0.5f);                
                //Debug.Log("If work");
            }
            yield return new WaitForSeconds(0.4f);

            audioSource.PlayOneShot(StartData.AudioLetsLookAtThe);            
            yield return new WaitForSeconds(StartData.AudioLetsLookAtThe.length + 0.1f);

            LetsLookAtTheText_1.FadeText(0, 1);
            LetsLookAtTheText_2.FadeText(0, 1);
            yield return new WaitForSeconds(1.5f);
            //LessonTitleText.FadeText(1, 1);

            
            StartEvent.Invoke();
        }


        public void SetInitialTexts()
        {
            BottomTitlePanel.transform.GetChild(0).GetComponent<EachObject>().WriteText(StartData.LessonTitle);
            //TopWhiteTransition.transform.GetChild(0).transform.GetChild(0).GetComponent<EachObject>().WriteText(_startTexts.LessonTitle);
            //TopTitlePanel.WriteText(_startTexts.LessonTitle);
            ExplainText.WriteText(StartData.InThisLesson);

            LetsLookAtTheText_1.WriteText(StartData.LetsLookAtThe_1);
            LetsLookAtTheText_2.WriteText(StartData.LetsLookAtThe_2);

            TopTitlePanel.GetComponent<LessonTitleTop>().UnderstandingTime = StartData.UnderstandingTime;
            TopTitlePanel.GetComponent<LessonTitleTop>().DemonstrationTime = StartData.DemonstrationTime;
            TopTitlePanel.GetComponent<LessonTitleTop>().SummaryTime = StartData.SummaryTime;
        }


    }
}

using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace CommonFeatures
{
    public class FinishFeatures : MonoBehaviour
    {
        public EachObject LeftFirstTransition;
        public EachObject LeftSecondTransition;

        public EachObject TopWhiteTransition;
        public EachObject BottomWhiteTransition;

        [Header("Summarize")]
        public GameObject SummarizeText;
        public GameObject ParentOfSummarizes;
        //public AudioClip[] SummarizeClips;
        //public GameObject[] SummarizePrefabs;

        public GameObject ForYourPractice;
        public GameObject ForYourPractiseExplain;

        [HideInInspector] public List<GameObject> SummarizeObjects;
        [HideInInspector] public List<string> SummarizeStrings;

        public FinishDataSO FinishDataSo;
        public UnityEvent FinishEvent;

        private AudioSource CurrentAudioSource;


        void Start()
        {
            CurrentAudioSource = gameObject.GetComponent<AudioSource>();

            SummarizeStrings.Add(FinishDataSo.SummarizeText1);
            SummarizeStrings.Add(FinishDataSo.SummarizeText2);
            SummarizeStrings.Add(FinishDataSo.SummarizeText3);
            SummarizeStrings.Add(FinishDataSo.SummarizeText4);
            SummarizeStrings.Add(FinishDataSo.SummarizeText5);

            if (FinishDataSo.ForYourPractiseText != null)
            {
                ForYourPractiseExplain.transform.GetChild(0).GetComponent<EachObject>().WriteText(FinishDataSo.ForYourPractiseText);
            }
            
        }

        
        public void FinishAnimation()
        {
            StartCoroutine(Summarize());
        }


        IEnumerator Summarize()
        {
            // Transitions
            yield return new WaitForSeconds(1);
            LeftFirstTransition.MoveAgainstPosition(1.6f);
            yield return new WaitForSeconds(0.35f);
            LeftSecondTransition.MoveAgainstPosition(1.5f);
            yield return new WaitForSeconds(0.2f);
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            yield return new WaitForSeconds(1f);
            TopWhiteTransition.MoveToInitialPos(1);
            BottomWhiteTransition.MoveToInitialPos(1);
            yield return new WaitForSeconds(0.7f);

            SummarizeText.GetComponent<EachObject>().FadeText(1, 0.5f);
            yield return new WaitForSeconds(0.5f);
            CurrentAudioSource.PlayOneShot(FinishDataSo.LetsSummarizeClip);
            yield return new WaitForSeconds(FinishDataSo.LetsSummarizeClip.length);

            
            Vector2 newPos = new(0, 3 * Screen.height / 10);
            SummarizeText.GetComponent<EachObject>().Movement(newPos, 0.5f);
            yield return new WaitForSeconds(1f);


            for (int i = 0; i < FinishDataSo.SummarizePrefabs.Length; i++)
            {
                GameObject newObj = Instantiate(FinishDataSo.SummarizePrefabs[i], new Vector3(0, 0, 0), Quaternion.identity);
                newObj.transform.SetParent(ParentOfSummarizes.transform/*GameObject.Find("Canvas").transform*/, false);

                if (i == 0)                
                    newObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, MakeLocation(newObj, SummarizeText));                
                else                
                    newObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, MakeLocation(newObj, SummarizeObjects[i-1]));
                
                newObj.transform.GetChild(0).transform.GetChild(0).GetComponent<EachObject>().WriteText((i + 1).ToString());
                newObj.transform.GetChild(0).transform.GetChild(1).GetComponent<EachObject>().WriteText(SummarizeStrings[i]);
                newObj.transform.GetChild(0).GetComponent<EachObject>().MoveToCenter(0.5f);                
                SummarizeObjects.Add(newObj);

                CurrentAudioSource.PlayOneShot(FinishDataSo.SummarizeClips[i]);
                yield return new WaitForSeconds(FinishDataSo.SummarizeClips[i].length + 1.5f);
            }

            // second transition
            LeftFirstTransition.MoveToInitialPos(0);
            LeftSecondTransition.MoveToInitialPos(0);
            yield return new WaitForSeconds(1);
            LeftFirstTransition.MoveAgainstPosition(1.6f);
            yield return new WaitForSeconds(0.35f);
            LeftSecondTransition.MoveAgainstPosition(1.5f);
            yield return new WaitForSeconds(0.2f);

            for (int i = 0; i < SummarizeObjects.Count; i++)
            {
                SummarizeObjects[i].SetActive(false);
            }
            SummarizeText.SetActive(false);

            TopWhiteTransition.MoveOutTop(0);
            BottomWhiteTransition.MoveOutBottom(0);

            yield return new WaitForSeconds(1);
            TopWhiteTransition.MoveToInitialPos(1);
            BottomWhiteTransition.MoveToInitialPos(1);
            yield return new WaitForSeconds(0.7f);

            ForYourPractice.transform.GetChild(0).GetComponent<EachObject>().FadeText(1, 0.5f);
            yield return new WaitForSeconds(0.5f);
            CurrentAudioSource.PlayOneShot(FinishDataSo.ForYourPracticeClip);
            yield return new WaitForSeconds(1.5f);

            ForYourPractice.GetComponent<RectTransform>().DOAnchorPosY(MakeLocationToUpper(ForYourPractice, ForYourPractiseExplain), 0.75f);
            //ForYourPractiseExplain.transform.GetChild(0).GetComponent<EachObject>().MoveToInitialPos(0.75f);
            ForYourPractiseExplain.transform.GetChild(0).GetComponent<EachObject>().MoveToCenter(0.75f);
            yield return new WaitForSeconds(FinishDataSo.ForYourPracticeClip.length);

            
            float posY1 = ForYourPractice.GetComponent<RectTransform>().anchoredPosition.y;
            float posY2 = ForYourPractiseExplain.GetComponent<RectTransform>().anchoredPosition.y;
            ForYourPractice.GetComponent<RectTransform>().DOAnchorPosY(posY1 + 100, 0.5f);
            ForYourPractiseExplain.GetComponent<RectTransform>().DOAnchorPosY(posY2 + 100, 0.5f);
            yield return new WaitForSeconds(1f);

            FinishEvent.Invoke();

            //GameObject finishWhitePanel = Instantiate(FinishWhitePanel, new Vector3(0, 0, 0), Quaternion.identity);
            //finishWhitePanel.transform.SetParent(GameObject.Find("Canvas").transform, false);
            //finishWhitePanel.GetComponent<Image>().DOFade(1, 1);
        }
        

        float MakeLocation(GameObject obj, GameObject lastObj)
        {            
            float lastObjHeight = lastObj.GetComponent<RectTransform>().rect.height;
            float lastObjPosY = lastObj.GetComponent<RectTransform>().anchoredPosition.y;
            float objHeight = obj.GetComponent<RectTransform>().rect.height;
            float newY = lastObjPosY - FinishDataSo.DistanceSummarize - lastObjHeight / 2 - objHeight / 2;
            return newY;
        }


        float MakeLocationToUpper(GameObject obj, GameObject beforeObj)
        {
            float lastObjHeight = beforeObj.GetComponent<RectTransform>().rect.height;
            float lastObjPosY = beforeObj.GetComponent<RectTransform>().anchoredPosition.y;
            float objHeight = obj.GetComponent<RectTransform>().rect.height;
            float newY = lastObjPosY + lastObjHeight / 2 + objHeight / 2;
            return newY;
        }


    }
}

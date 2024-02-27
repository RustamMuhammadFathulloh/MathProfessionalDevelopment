using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Introduction : MonoBehaviour
{
    public StartTextSO StartTexts;
    public GameObject StartFeatures;
    public GameObject FinishFeatures;

    public GameObject FinishWhitePanel;

    //private GameObject _startParent;
    //private GameObject _finishParent;


    //public void VideoOpening()
    //{
    //    _startParent = Instantiate(StartFeatures, new Vector3(0, 0, 0), Quaternion.identity);
    //    _startParent.transform.SetParent(GameObject.Find("Canvas").transform, false);
    //    _finishParent = Instantiate(FinishFeatures, new Vector3(0, 0, 0), Quaternion.identity);
    //    _finishParent.transform.SetParent(GameObject.Find("Canvas").transform, false);
    //}


    //public void RemoveIntroduction()
    //{
    //    Destroy(_startParent);
    //    Destroy(_finishParent);
    //}


    public void StartFeatureSwitch(bool isTrue)
    {
        StartFeatures.SetActive(isTrue);
    }


    public void FinishFeatureSwitch(bool isTrue)
    {
        FinishFeatures.SetActive(isTrue);
    }


    public void FinishTransition()
    {
        GameObject finishWhitePanel = Instantiate(FinishWhitePanel, new Vector3(0, 0, 0), Quaternion.identity);
        finishWhitePanel.transform.SetParent(GameObject.Find("Canvas").transform, false);
        finishWhitePanel.GetComponent<Image>().DOFade(1, 1);
    }

}

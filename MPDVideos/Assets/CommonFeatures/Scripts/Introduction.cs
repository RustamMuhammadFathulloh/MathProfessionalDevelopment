using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Introduction : MonoBehaviour
{
    public GameObject StartFeatures;
    public GameObject FinishFeatures;

    public GameObject FinishWhitePanel;
    

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

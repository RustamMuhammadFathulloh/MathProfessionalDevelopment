using UnityEngine;

public class Introduction : MonoBehaviour
{
    public StartTextSO StartTexts;
    public GameObject StartFeatures;
    public GameObject FinishFeatures;

    private GameObject _startParent;
    private GameObject _finishParent;

        
    public void VideoOpening()
    {
        _startParent = Instantiate(StartFeatures, new Vector3(0, 0, 0), Quaternion.identity);
        _startParent.transform.SetParent(GameObject.Find("Canvas").transform, false);        

        _finishParent = Instantiate(FinishFeatures, new Vector3(0, 0, 0), Quaternion.identity);
        _finishParent.transform.SetParent(GameObject.Find("Canvas").transform, false);
    }


    public void RemoveIntroduction()
    {
        Destroy(_startParent);
        //Destroy(_finishParent);
    }


}

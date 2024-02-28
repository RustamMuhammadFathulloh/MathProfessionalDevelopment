using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IntroController : MonoBehaviour
{
    [Header("Headline")]
    public string Headline;
    public string By;

    [Header("Details")]
    public string Level;
    public string Subject;
    public string Series;
    public string Duration;

    [Header("Order of Operation")]
    public string Description;
    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = Headline;
        transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = By;

        transform.GetChild(2).GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = Level;
        transform.GetChild(2).GetChild(2).GetChild(1).GetComponent<TMP_Text>().text = Subject;
        transform.GetChild(2).GetChild(3).GetChild(1).GetComponent<TMP_Text>().text = Series;
        transform.GetChild(2).GetChild(4).GetChild(1).GetComponent<TMP_Text>().text = Duration;

        transform.GetChild(3).GetChild(1).GetComponent<TMP_Text>().text = Description;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

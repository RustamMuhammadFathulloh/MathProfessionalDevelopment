using System.Collections;
using UnityEngine;
using UnityEngine.Playables;

namespace TestTimeLine
{
    public class TimeLineManager : MonoBehaviour
    {
        public GameObject FirstObject;
        public GameObject SecondObject;

        public PlayableDirector FirstTimeLine;

        //public TimeLine FirstMinute;

        void Start()
        {

        }


        public void VideoAnimationMethod()
        {
            Debug.Log("== == ==");

            StartCoroutine(Animating());
        }



        IEnumerator Animating()
        {
            yield return new WaitForSeconds(1);
            FirstTimeLine.Play();


        }

        
    }
}

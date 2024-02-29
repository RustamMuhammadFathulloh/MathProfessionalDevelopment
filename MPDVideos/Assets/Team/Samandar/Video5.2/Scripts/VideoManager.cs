using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace Samandar
{
   public class VideoManager : MonoBehaviour
   {
        public List<GameObject> Page;
        public List<float> PageTime;

        private void Start()
        {
            StartCoroutine(PageController());
        }
        IEnumerator PageController()
        {
            
            yield return new WaitForSeconds(PageTime[0]);
            Page[0].SetActive(false);
        }
   }
}

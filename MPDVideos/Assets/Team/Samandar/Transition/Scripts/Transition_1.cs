using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
namespace Samandar
{
    public class Transition_1 : MonoBehaviour
    {
        [Header("Transitions")]
        public RectTransform LeftFirstTransition;
        public RectTransform LeftSecondTransition;
        public RectTransform LeftThirdTransition;
        public RectTransform TopRectangleTransition;
        //public GameObject BottomWhiteTransition;

        void Start()
        {

        }
        void OnEnable()
        {
            StartCoroutine(Animations());
        }
        private void OnDisable()
        {
            TopRectangleTransition.DOAnchorPosY(47.5f, 0);
        }
        IEnumerator Animations()
        {
            //Transitions            
            LeftThirdTransition.DOScaleY(1, 0.5f);
            LeftThirdTransition.DOAnchorPosX(-1920, 0);
            LeftFirstTransition.DOAnchorPosX(0, 0.5f);
            yield return new WaitForSeconds(0.25f);
            LeftSecondTransition.DOAnchorPosX(0, 0.5f);
            yield return new WaitForSeconds(0.25f);
            LeftThirdTransition.DOAnchorPosX(0, 0.5f);
            yield return new WaitForSeconds(0.6f);
            TopRectangleTransition.DOAnchorPosY(-47.5f, 0.5f);
            LeftFirstTransition.DOAnchorPosX(-1920, 0);
            LeftSecondTransition.DOAnchorPosX(-1920, 0);
            LeftThirdTransition.DOScaleY(0, 0.5f);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}

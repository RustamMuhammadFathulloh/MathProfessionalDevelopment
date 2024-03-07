using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace CommonFeatures
{
    public class EachObject : MonoBehaviour
    {
        public enum Locations { None,Left, Right, Top, Bottom };
        public Locations StartLocation;

        public RectTransform CurrentRectTrans;
        public Image CurrentImage;
        public TMP_Text CurrentText;        
        public bool IsTextFaded;
        public bool IsImageFaded;
        public bool IsMinimized;
        public bool IsImageFillAmount;

        private Vector2 _initialPos;


        public void Awake()
        {
            if (CurrentImage != null && IsImageFaded)            
                CurrentImage.DOFade(0, 0);

            if (CurrentImage != null && IsImageFillAmount)
                CurrentImage.DOFillAmount(0, 0);

            if (CurrentText != null && IsTextFaded)            
                CurrentText.DOFade(0, 0);

            if (IsMinimized)
            {
                ChangeObjectScale(0, 0);
            }

            if (CurrentRectTrans != null)
            {
                GetInitialData();
            }
            
        }


        void GetInitialData()
        {
            _initialPos = CurrentRectTrans.anchoredPosition;

            switch (StartLocation)
            {
                case Locations.None:                    
                    break;
                case Locations.Left:
                    MoveOutLeft(0);
                    break;
                case Locations.Right:
                    MoveOutRight(0);
                    break;
                case Locations.Top:
                    MoveOutTop(0);
                    break;
                case Locations.Bottom:
                    MoveOutBottom(0);
                    break;
                default:
                    break;
            }
        }


        public void FadeImage(float fadeNumber, float duration)
        {            
            if (CurrentImage != null)
            {
                CurrentImage.DOFade(fadeNumber, duration);
            }
        }


        public void FadeText(float fadeNumber, float duration)
        {
            if (CurrentText != null)
            {
                CurrentText.DOFade(fadeNumber, duration);
            }
        }


        public void ChangeObjectScale(float scaleNumber, float duration)
        {
            gameObject.transform.DOScale(scaleNumber, duration);
        }


        public void MoveOutLeft(float duration)
        {
            //CurrentRectTrans.anchoredPosition = new Vector2(-CurrentRectTrans.sizeDelta.x, duration);
            CurrentRectTrans.DOAnchorPosX(-CurrentRectTrans.sizeDelta.x, duration);
        }


        public void MoveOutRight(float duration)
        {
            //CurrentRectTrans.anchoredPosition = new Vector2(CurrentRectTrans.sizeDelta.x, duration);
            CurrentRectTrans.DOAnchorPosX(CurrentRectTrans.sizeDelta.x, duration);
        }


        public void MoveOutTop(float duration)
        {
            CurrentRectTrans.DOAnchorPosY(CurrentRectTrans.sizeDelta.y / 2, duration);
        }

        public void MoveToCenter(float duration)
        {
            CurrentRectTrans.DOAnchorPos(new Vector2(0, 0), duration);
        }

        public void MoveOutBottom(float duration)
        {            
            CurrentRectTrans.DOAnchorPosY(-CurrentRectTrans.sizeDelta.y / 2, duration);
        }


        public void MoveToInitialPos(float duration)
        {
            CurrentRectTrans.DOAnchorPos(_initialPos, duration);
        }


        public void SmallMove(float duration)
        {
            CurrentRectTrans.DOAnchorPosY((_initialPos.y + 40), 0);
            CurrentRectTrans.DOAnchorPosY((_initialPos.y - 20), duration);
        }


        public void MoveAgainstPosition(float duration)
        {
            Vector2 currentPos = CurrentRectTrans.anchoredPosition;
            CurrentRectTrans.DOAnchorPos(-currentPos, duration);
        }


        public void MoveByPixelsByX(float pixels, float duration)
        {
            CurrentRectTrans.DOAnchorPosX(_initialPos.x + pixels, duration);
        }


        public void Movement(Vector2 newPos, float duration)
        {
            //Debug.Log(CurrentRectTrans.position);
            //Debug.Log(CurrentRectTrans.transform.position);
            //Debug.Log(CurrentRectTrans.localPosition);
            //Debug.Log(CurrentRectTrans.rect);
            //Debug.Log(CurrentRectTrans.rect.position); // -960, -60
            //Debug.Log(CurrentRectTrans.sizeDelta);     // 1920, 120
            //Debug.Log(CurrentRectTrans.anchoredPosition);
            //Debug.Log("Screen.width = " + Screen.width + " Screen.height = " + Screen.height);
            //CurrentRectTrans.localPosition = newPos;
            CurrentRectTrans.DOAnchorPos(newPos, duration);
            //Debug.Log("newPos = " + newPos);
        }


        public void WriteText(string newText)
        {
            if (CurrentText != null)
            {
                CurrentText.text = newText;
            }
        }

    }
}

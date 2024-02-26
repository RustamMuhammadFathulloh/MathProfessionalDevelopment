using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommonFeatures
{
    public class LineDrawer : MonoBehaviour
    {
        private LineRenderer _lineRenderer;
        public List<Vector2> Points;


        void Start()
        {
            _lineRenderer = gameObject.GetComponent<LineRenderer>();
            DrawLine();
        }

        
        void DrawLine()
        {
            StartCoroutine(DrawingLine());
        }

        
        IEnumerator DrawingLine()
        {
            _lineRenderer.positionCount = 2;
            _lineRenderer.SetPosition(0, Points[0]);
            _lineRenderer.SetPosition(1, Points[0]);

            Vector2[] vectorTwoArray = GeneratePoints(Points[0], Points[1], 10);
            StartCoroutine(DrawLineAnimation(vectorTwoArray, 0, 1, 0.2f));
            yield return new WaitForSeconds(1);
        }


        IEnumerator DrawLineAnimation(Vector2[] vectorTwoArray, int startPointIndex, int endPointIndex, float duration)
        {
            int lengthOfArray = vectorTwoArray.Length;

            _lineRenderer.SetPosition(startPointIndex, vectorTwoArray[0]);

            for (int i = 0; i < lengthOfArray; i++)
            {
                _lineRenderer.SetPosition(endPointIndex, vectorTwoArray[i]);
                float time = (i + 1) * (float)(duration / lengthOfArray);
                yield return new WaitForSeconds(time);
            }
        }


        public Vector2[] GeneratePoints(Vector2 startPoint, Vector2 endPoint, int k)
        {
            // Ensure k is at least 2 to include start and end points
            if (k < 2)
            {
                Debug.LogError("Value of k must be at least 2.");
                return null;
            }

            Vector2[] points = new Vector2[k];

            // Calculate step size for linear interpolation
            float step = 1f / (k - 1);

            // Generate intermediate points
            for (int i = 0; i < k; i++)
            {
                points[i] = Vector2.Lerp(startPoint, endPoint, i * step);
            }

            return points;
        }


    }
}

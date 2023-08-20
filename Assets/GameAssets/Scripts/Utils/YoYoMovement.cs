using DG.Tweening;
using UnityEngine;

namespace GameAssets.Scripts.Utils
{
    public class YoYoMovement : MonoBehaviour
    {
        public Vector3 maxPosition = new Vector3(0f, 5f, 0f);
        public float yoyoDuration = 1f;
        public Ease easeType = Ease.Linear;

        private Vector3 originalPosition;

        private void Start()
        {
            // Store the original position of the GameObject
            originalPosition = transform.position;

            // Start the yo-yo animation
            StartYoYoAnimation();
        }

        private void StartYoYoAnimation()
        {
            // Create a sequence with DoTween
            Sequence yoYoSequence = DOTween.Sequence();

            // Add a move to the maxPosition
            yoYoSequence.Append(transform.DOMove(maxPosition, yoyoDuration).SetEase(easeType));

            // Add a move back to the original position
            yoYoSequence.Append(transform.DOMove(originalPosition, yoyoDuration).SetEase(easeType));

            // Set the loop type to YoYo
            yoYoSequence.SetLoops(-1, LoopType.Yoyo);

            // Play the sequence
            yoYoSequence.Play();
        }
    }
}
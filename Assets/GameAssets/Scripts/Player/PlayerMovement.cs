using UnityEngine;

namespace GameAssets.Scripts.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        private readonly int SpeedHash = Animator.StringToHash("Speed");
        private readonly int IdleHash = Animator.StringToHash("Rogue_idle_01");
        private readonly int RunHash = Animator.StringToHash("Rogue_run_01");

        [Header("References")]
        [SerializeField] private Animator animator;
        [SerializeField] private Rigidbody2D rb;

        [Header("Settings")]
        [SerializeField] private float moveSpeed = 5f;
        [SerializeField] private float crossFadeDuration = 0f;

        private void Update()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector2 movementDirection = new Vector2(horizontalInput, verticalInput).normalized;
            float currentSpeed = CalculateSpeed(movementDirection);
            SetAnimatorParameters(currentSpeed);
            SetMovementVelocity(movementDirection);
            FlipCharacterSprite(horizontalInput);
            DetermineAnimationToPlay(currentSpeed);
        }

        private float CalculateSpeed(Vector2 direction)
        {
            return direction.magnitude;
        }

        private void SetAnimatorParameters(float speed)
        {
            animator.SetFloat(SpeedHash, speed);
        }

        private void SetMovementVelocity(Vector2 direction)
        {
            Vector2 movementVelocity = direction * moveSpeed;
            rb.velocity = movementVelocity;
        }

        private void FlipCharacterSprite(float horizontalInput)
        {
            Vector3 newScale = transform.localScale;
            newScale.x = Mathf.Abs(newScale.x) * Mathf.Sign(horizontalInput);
            transform.localScale = newScale;
        }

        private void DetermineAnimationToPlay(float speed)
        {
            int animationToPlay = speed > 0 ? RunHash : IdleHash;
            animator.CrossFade(animationToPlay, crossFadeDuration, 0);
        }
    }
}

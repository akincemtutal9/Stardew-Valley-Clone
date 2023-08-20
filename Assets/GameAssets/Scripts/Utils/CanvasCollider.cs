using UnityEngine;

namespace GameAssets.Scripts.Utils
{
    public class CanvasCollider : MonoBehaviour
    {
        private const string Player = nameof(Player);
        [SerializeField] private GameObject canvas;
        private void Start()
        {
            canvas.SetActive(false);
        }
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag(Player))
            {
                canvas.SetActive(true);
            }
        }
        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.gameObject.CompareTag(Player))
            {
                canvas.SetActive(false);
            }
        }
    }
}

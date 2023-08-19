using UnityEngine;

namespace GameAssets.Scripts.Dialogue
{
    public class DialogueCollider : MonoBehaviour
    {
        private const string Player = nameof(Player);
        [SerializeField] private GameObject dialogCanvas;
        private void Start()
        {
            dialogCanvas.SetActive(false);
        }
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag(Player))
            {
                dialogCanvas.SetActive(true);
            }
        }
        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.gameObject.CompareTag(Player))
            {
                dialogCanvas.SetActive(false);
            }
        }
    }
}

using UnityEngine;

namespace GameAssets.Scripts.Dialogue
{
    public class DialogueTrigger : MonoBehaviour
    {
        private const string Player = nameof(Player);
        public Dialogue dialogue;
        public GameObject dialogCanvas; 
        public void TriggerDialogue ()
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag(Player))
            {
                dialogCanvas.SetActive(true);
                TriggerDialogue();
            }    
        }
        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag(Player))
            {
                dialogCanvas.SetActive(false);
            }
        }
    }
}

using UnityEngine;

namespace GameAssets.Scripts.Dialogue
{
    public class DialogueTrigger : MonoBehaviour
    {
        public Dialogue dialogue;
        public void TriggerDialogue ()
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
    }
}

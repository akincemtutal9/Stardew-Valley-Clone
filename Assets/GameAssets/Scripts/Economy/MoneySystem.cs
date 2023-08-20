using UnityEngine;

namespace GameAssets.Scripts.Economy
{
    public class MoneySystem : MonoBehaviour
    {
        public static MoneySystem instance; // Public instance for easy access
        public int balance = 0;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void AddMoney(int amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Debug.Log($"Added {amount} to the balance. New balance: {balance}");
            }
            else
            {
                Debug.LogError("Amount to add must be greater than 0.");
            }
        }

        public void SubtractMoney(int amount)
        {
            if (amount > 0)
            {
                if (balance >= amount)
                {
                    balance -= amount;
                    Debug.Log($"Subtracted {amount} from the balance. New balance: {balance}");
                }
                else
                {
                    Debug.LogError("Insufficient funds.");
                }
            }
            else
            {
                Debug.LogError("Amount to subtract must be greater than 0.");
            }
        }
    }
}
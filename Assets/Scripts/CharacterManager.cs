using UnityEngine;

namespace DefaultNamespace
{
    public class CharacterManager : MonoBehaviour
    {
        public static CharacterManager Instance { get; private set; }
        public PlayerCharacterController Player { get; private set; }
        public BotCaracterController Bots { get; private set; }

        private void Awake()
        {
            Player = FindObjectOfType<PlayerCharacterController>();
            Bots = FindObjectOfType<BotCaracterController>();

            if (Instance != null)
            {
                Destroy(gameObject);
            }
            else
            {
                Instance = this;
            }
        }
    }
}
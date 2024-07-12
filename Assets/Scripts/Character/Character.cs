using UnityEngine;

namespace Assets.Scripts.Character
{
    internal class Character : MonoBehaviour
    {
        [SerializeField] private EndGame _endGame;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            _endGame.GameOver();
        }
    }
}

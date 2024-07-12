using Assets.Scripts.Car;
using UnityEngine;

public class Resources : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Car>())
        {
            int coins = PlayerPrefs.GetInt(GlobalVariables.CoinKey);
            PlayerPrefs.SetInt(GlobalVariables.CoinKey, coins += 1);

            Destroy(this.gameObject);
        }
    }
}

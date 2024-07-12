using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI_Buttons__other_
{
    internal class ScoresText : MonoBehaviour
    {
        [SerializeField] private Text _distance;
        [SerializeField] private Text _coins;

        private int _previusDistance;
        private int _previusCoins;

        private void Start()
        {
            _previusDistance = PlayerPrefs.GetInt(GlobalVariables.DistanceKey);
            _previusCoins = PlayerPrefs.GetInt(GlobalVariables.CoinKey);

            _distance.text = _previusDistance.ToString();

            StartCoroutine(DistanceCount());
            StartCoroutine(CoinsCount());
        }

        private IEnumerator DistanceCount()
        {
            while (true)
            {
                int distance = PlayerPrefs.GetInt(GlobalVariables.DistanceKey);
                if(distance != _previusDistance)
                {
                    _previusDistance = distance;
                    _distance.text = distance.ToString();
                }
                yield return new WaitForSeconds(0.3f);
            }
        }

        private IEnumerator CoinsCount()
        {
            while (true)
            {
                int coins = PlayerPrefs.GetInt(GlobalVariables.CoinKey);
                if(coins != _previusCoins)
                {
                    _previusCoins = coins;
                    _coins.text = coins.ToString();
                }
                yield return new WaitForSeconds(0.3f);
            }
        }

    }
}

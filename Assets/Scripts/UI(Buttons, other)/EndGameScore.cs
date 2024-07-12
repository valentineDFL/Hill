using UnityEngine;
using UnityEngine.UI;

public class EndGameScore : MonoBehaviour
{
    [SerializeField] private Text _distanceCount;
    [SerializeField] private Text _coinsCount;

    private void OnEnable()
    {
        _distanceCount.text = PlayerPrefs.GetInt(GlobalVariables.DistanceKey).ToString();
        _coinsCount.text = PlayerPrefs.GetInt(GlobalVariables.CoinKey).ToString();
    }
}

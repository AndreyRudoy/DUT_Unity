using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPicker : MonoBehaviour
{

    [SerializeField] private int manyCoins;
    [SerializeField] private TMP_Text mashCoin;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<Player_controller>()._coinScore += manyCoins;
        Destroy(gameObject);
        mashCoin.text = "X" + collision.gameObject.GetComponent<Player_controller>()._coinScore;
    }
}

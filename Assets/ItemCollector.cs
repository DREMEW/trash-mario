using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class ItemCollector : MonoBehaviour
{
    [SerializeField]private int coins = 0;

    [SerializeField] private TextMeshProUGUI coinsText;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("coin"))
        {
           
            Destroy(collision.gameObject);
            coins++;
         
            coinsText.text = "coins: " + coins;
        }
    }
}
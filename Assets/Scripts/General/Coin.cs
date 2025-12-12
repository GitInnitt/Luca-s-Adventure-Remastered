using UnityEngine;

public class Coin : MonoBehaviour
{

    [SerializeField] private int Coins;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Assuming there's a GameManager script that handles the player's coin count
            Coins = +1;
            Destroy(gameObject);
        }
    }
}
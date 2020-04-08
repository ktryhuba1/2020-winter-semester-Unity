using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D colliderObj)
    {
        //if we had a gamestate obj we would increase score here
        //now we play a sound

        GameObject soundHub = GameObject.Find("SoundHub");

        soundHub.GetComponent<SoundHub>().PlayCoinSound();

        Destroy(gameObject);
    }
}

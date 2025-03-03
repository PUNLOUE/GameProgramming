using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene loading

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float gameOverThreshold = -5f; // Y-position where the game ends

    void Update()
    {
        // Player movement using arrow keys or WASD
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        transform.position += new Vector3(moveX, moveY, 0) * speed * Time.deltaTime;
        
        // Check if the player falls below the gameOverThreshold
        if (transform.position.y < gameOverThreshold)
        {
            SceneManager.LoadScene("GameOverScene"); // Load Game Over Scene
        }
    }
}

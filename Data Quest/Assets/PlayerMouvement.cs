using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Vitesse de déplacement du joueur
    private SpriteRenderer spriteRenderer; // Référence au SpriteRenderer
    private Rigidbody2D rb; // Référence au Rigidbody2D
    private Vector3 movement;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>(); // Récupérer le Rigidbody2D
    }

    void Update()
    {
        // Déplacement horizontal
        float horizontalInput = Input.GetAxis("Horizontal");

        // Déplacement vertical
        float verticalInput = Input.GetAxis("Vertical");

        // Calcul du vecteur de déplacement
        movement = new Vector3(horizontalInput, verticalInput, 0f) * speed * Time.deltaTime;

        // Application du déplacement
        transform.Translate(movement);

        // Mise à jour de la direction du sprite en fonction de l'entrée utilisateur
        if (horizontalInput < 0)
        {
            spriteRenderer.flipX = false; // Tourner vers la gauche
        }
        else if (horizontalInput > 0)
        {
            spriteRenderer.flipX = true; // Tourner vers la droite
        }
    }
}

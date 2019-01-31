using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;

    void Start()
    {
        // Получаем компонент RigidBody у объекта Player
        rb = GetComponent<Rigidbody>();    
    }

    void FixedUpdate()
    {
        // Получаем данные с клавиатуры
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Создаем вектор направления
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Перемещаем Player-a
        rb.AddForce(movement * speed);
    }
}

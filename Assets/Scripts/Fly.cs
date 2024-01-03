using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Fly : MonoBehaviour
{


  [SerializeField] private float vel = 3.0f;
  [SerializeField] private float rotationSpeed = 10f;

  private Rigidbody2D rb;

   private void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

   private void Update(){

        if (Mouse.current.leftButton.wasPressedThisFrame){

            rb.velocity = Vector2.up * vel;

        }
        
    }

    private void FixedUpdate(){

        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * rotationSpeed);

    }



}

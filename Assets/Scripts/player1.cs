using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Variables gravity strength and dirdction "x, y ,z cord"
  private Vector3 direction;
  public float gravity = -9.8f;
  public float str = 3f;
    // Update is called once per frame
    private void Update()
    {
        //Space and mouse input
        if(Input.GetKeyDown(KeyCode.Space)|| Input.GetMouseButtonDown(0)){
            direction = Vector3.up * str;
        }
        // check if button "Space" or mouse is pressed
        if(Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);
        
        if(touch.phase == TouchPhase.Began){
            direction = Vector3.up * str;
        }
      }
      direction.y += gravity * Time.deltaTime;
      transform.position += direction * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Obstacle"){
            FindObjectOfType<GameManager>().GameOver();
        }else if(other.gameObject.tag == "Scoring"){
            FindObjectOfType<GameManager>().IncreaseScore();
        }
    }
}

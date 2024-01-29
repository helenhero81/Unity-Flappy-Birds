using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Variables, Spawnrate and Height Variables
  public GameObject perfab;
  public float Rate = 1f;
  public float minHeight = -1f;
  public float maxHeight = 1f;
  
  private void OnDisble (){
    CancelInvoke(nameof(Spawn));
  }
  private void OnEnable (){
    InvokeRepeating(nameof(Spawn),Rate, Rate);
    
  }
  private void Spawn(){
    GameObject Obstacle= Instantiate(perfab,transform.position, Quaternion.identity);
    Obstacle.transform.position+= Vector3.up* Random.Range(minHeight,maxHeight);
    
  }

}

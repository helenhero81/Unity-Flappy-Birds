using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : MonoBehaviour
{
    public float speed = 3f;
    private float LeftEdge; 
    // Start is called before the first frame update
    void Start()
    {
     LeftEdge = Camera . main . ScreenToWorldPoint(Vector3.zero).x -1f;
    }

    // Update is called once per frame
    void Update()
    {
      transform.position+= Vector3.left* speed * Time. deltaTime;
      if (transform. position.x< LeftEdge){
         Destroy( gameObject);
      }
    }
    
}

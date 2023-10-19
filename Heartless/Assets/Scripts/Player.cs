using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Player : MonoBehaviour
{


    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    private RaycastHit2D hit;

    // Start is called before the first frame update
    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
       

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        
        //reset MoveDelta
        moveDelta = new Vector3(x,y,0);

        //swap sprite direction, wether you're going right or left 
        if (moveDelta.x > 0)
            transform.localScale = new Vector3(1,1,1);
        else if (moveDelta.x < 0)
            transform.localScale = new Vector3(-1,1,1);
        // make sure we can move in this diretion , by casting a box there first, if the box returns null, we're free to move
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime),LayerMask.GetMask("Actor","Blocking")) ;
        if (hit.collider == null) 
        {
            //Make this thing move
             transform.Translate(0,moveDelta.y * Time.deltaTime,0) ;
        }

        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2( moveDelta.x,0), Mathf.Abs(moveDelta.x * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        if (hit.collider == null)
        {
            //Make this thing move
            transform.Translate( moveDelta.x * Time.deltaTime, 0,0);
        }
        //--05450



        //Debug.Log(x);
        //Debug.Log(y);
    }
}

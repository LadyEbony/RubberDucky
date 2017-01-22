using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{

    // Use this for initialization
    Rigidbody2D RB;
    public float DuckWeight = 1;
    public string[] CollisionTag; //Tags of gameobjects it can collide with
    public string[] IgnoreTag; // List of gameobjects to ignore collision
    public LayerMask[] CollisionLayers; //Layer collision
    public string[] IgnoranceLayers; //Ignore these layers
    bool isdead;
    public string DuckID;
    
    Animator anim;
    [SerializeField] string DeathAnime;
    [SerializeField ]GameController GM;
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        RB.gravityScale = 0;
        RB.mass = DuckWeight;
        isdead = false;
        anim = this.GetComponentInChildren<Animator>();        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Hit");
        foreach (string ignore in IgnoreTag)
        {
            if (col.gameObject.tag == ignore)
            {
                Physics2D.IgnoreCollision(col.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
                //Debug.Log("Ignoring  " + col.gameObject.tag + " " + ignore);
                //Debug.Break();
            }
        }
        foreach (string Lay in IgnoranceLayers)
        {
            Physics2D.IgnoreLayerCollision(this.gameObject.layer, LayerMask.NameToLayer(Lay));
            Debug.Log("Ignoring  " + col.gameObject.tag + " " + Lay);
            //Debug.Break();
        }
        foreach (string hit in CollisionTag)
        {
            if(col.gameObject.tag == hit)
            {
                col.gameObject.GetComponent<Duck>().StartCoroutine(Death());
                
                if (GM != null)
                {
                    GM.CurrentStage.DucksKilled++;
                }
                
            }
        }
    }
    public IEnumerator Death()
    {
        anim.SetBool(DeathAnime, true);
        yield return new WaitForSeconds(0.5f);
        this.gameObject.SetActive(false);
       
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Permet de gèrer les scènes 

public class TeleportBullet : MonoBehaviour
{
    public GameObject player; // public pour être dispo pour d'autres classes
   void OnCollisionEnter(Collision collision) 
   {
       //Debug.Log("HEADSHOT!");
       if(!collision.collider.CompareTag("Bounce"))
       {
            Destroy(gameObject); // gameObject c'est pour détruire le gameObject qui possède ce script   
       }
           
       //SceneManager.LoadScene("WinScene"); fait le chargement de scène, ici "Win" / Pas nécessaire pour l'instant
       //Debug.Log("Point de contact: " + collision.GetContact(0));

       if(collision.collider.CompareTag("Teleport"))
       {
        player.transform.position = collision.GetContact(0).point;
       }

        
   }
}

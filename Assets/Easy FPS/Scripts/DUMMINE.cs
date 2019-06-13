using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DUMMINE : MonoBehaviour
{
    
    public GameObject DM; 
    
    
    // Start is called before the first frame update
    
        
    void Start()
    {  
        DM = GameObject.FindWithTag("Dummie");
         
    }
    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("blood") != null)
        {  
           int x=Random.Range(-15,15);
           int z=Random.Range(-25,15);
           int y=Random.Range(5,15);
           Vector3 position=new Vector3(x,y,z);
           GameObject newGo=Instantiate(DM,position,transform.rotation);
            Destroy(this.gameObject);
        }
    }

}

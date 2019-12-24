using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{
    public float id;
    // Start is called before the first frame update
    void Start()
    {

    	
       int num = UnityEngine.Random.Range(1,4);

       
        if ( num == 1)
        {
        	 gameObject.GetComponent<Renderer>().material.color = Color.red;
        	 id=1;
        }
         if ( num == 2)
        {
        	 gameObject.GetComponent<Renderer>().material.color = Color.blue;
        	 id=2;
        }
         if ( num == 3)
        {
        	gameObject.GetComponent<Renderer>().material.color = Color.green;
        	id=3;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter(Collider other)
    {

			if(other.gameObject.tag =="Verde" && id==3)
    		gameObject.GetComponent<Renderer>().material.color = Color.white;    				
    		if(other.gameObject.tag =="Azul" && id==2)
    		gameObject.GetComponent<Renderer>().material.color = Color.white;
    		if(other.gameObject.tag == "Rojo" && id==1)
    		gameObject.GetComponent<Renderer>().material.color = Color.white;

    		if(other.gameObject.tag =="Verde" && id!=3)
    		Destroy(gameObject) ;
    		if(other.gameObject.tag =="Azul" && id!=2)
    		Destroy(gameObject);
    		if(other.gameObject.tag == "Rojo" && id!=1)
    		Destroy(gameObject);
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neco : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        int reference = new int(8);
		reference = 8; 
		int hodnota = 4;

		int A = reference;
		int B = hodnota;

		print("1)"+reference +" "+ hodnota+"/"+A+" "+B);

		reference++; 
		hodnota++;

		print("2)"+reference +" "+ hodnota+"/"+A+" "+B);

		A++;
		B++;

		print("3)"+reference +" "+ hodnota+"/"+A+" "+B);
		
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

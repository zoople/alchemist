using UnityEngine;
using System.Collections;

public class Swapper : MonoBehaviour {

    public GameObject inventory;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    private void OnMouseDown()
    {
        Debug.Log("HIT");

        ArrayList a = new ArrayList();
        ArrayList b = new ArrayList();

        a.Add("GREEN");
        a.Add("BLUE");

        b.Add("RED");

        inventory.GetComponent<inventoryListDisplay>().purchaseRequest(a,b);

    }
}

using UnityEngine;
using System.Collections;

public class inventoryListDisplay : MonoBehaviour {

    public Sprite rune_red;
    public Sprite rune_green;
    public Sprite rune_blue;

    public GameObject runePrefab;

    public ArrayList inventory = new ArrayList();
    public ArrayList text_inventory = new ArrayList();


    public  bool purchaseRequest(ArrayList price, ArrayList goods)
    {

        Debug.Log("Request");
        bool successful = true;
        int find;

        foreach (string rune in price)
        {
            Debug.Log(rune);
            find = text_inventory.IndexOf(rune);
            if (find < 0) { successful = false; break; }
           
        }

        foreach (string rune in price)
        {
            find = text_inventory.IndexOf(rune);
            text_inventory.RemoveAt(find);
            
        }

        if (successful == false) return false;

        
        foreach (string rune in goods)
        {
            text_inventory.Add(rune);
        }

        if (successful == true) UpdateInventory();
            return successful;
    }

    private void UpdateInventory()
    {

        int numRunes = 0;
        Sprite curRune = rune_red;

        foreach (GameObject del in inventory) Destroy(del);

        foreach (string rune in text_inventory)
        {
            Debug.Log(rune);
            if (rune == "RED") curRune = rune_red;
            if (rune == "GREEN") curRune = rune_green;
            if (rune == "BLUE") curRune = rune_blue;


            runePrefab.GetComponent<SpriteRenderer>().sprite = curRune;
            inventory.Add(Instantiate(runePrefab, new Vector2(this.transform.position.x + ((runePrefab.transform.localScale.x * 3 )* numRunes), this.transform.position.y), Quaternion.identity));

            numRunes++;

        }
    }


    // Use this for initialization
    void Start () {

        text_inventory.Add("GREEN");
        text_inventory.Add("RED");
        text_inventory.Add("BLUE");

        UpdateInventory();



    }



    // Update is called once per frame
    void Update () {


	
	}
}

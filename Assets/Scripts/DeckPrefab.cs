using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckPrefab : MonoBehaviour
{

    public GameObject CardPrefab;
    public Sprite kingOfHearts;
    //download it here https://opengameart.org/sites/default/files/styles/medium/public/king_of_hearts2.png
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {         
            GameObject cardInstance = Instantiate(CardPrefab, this.transform);
            //Debug.Log(cardInstance.GetComponent<Card>().suit);
            
            cardInstance.GetComponent<SpriteRenderer>().sprite = kingOfHearts;
            cardInstance.transform.position = new Vector3(2 * i - 8, 0f, 0f);
            Debug.Log("Created Instance " + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

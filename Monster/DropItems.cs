using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItems : MonoBehaviour
{
    [SerializeField]
    private GameObject[] itemList;
    private int itemNum;
    private int randNum;
    private Transform Epos;
    public Vector3 offset;
    public bool check = true;
    
    // Start is called before the first frame update
    void Start()
    {
        Epos = GetComponent<Transform>();
        Debug.Log(itemList);
        
    }

    // Update is called once per frame
    void Update()
    {
        randNum = Random.Range(0, 101);
        
        if (randNum>=80&check)
        {
            check= false;
            itemNum = 1;
            Instantiate(itemList[itemNum], Epos.position+offset, Quaternion.identity);
            Scoring.totalScore += 5;
            Debug.Log(message: Scoring.totalScore);
            StartCoroutine(WaitForIt());
        }

        if (randNum >= 60 & randNum<80 & check)
        {
            check = false;
            itemNum = 2;
            Instantiate(itemList[itemNum], Epos.position + offset, Quaternion.identity);
            Scoring.totalScore += 5;
            Debug.Log(message: Scoring.totalScore);
            StartCoroutine(WaitForIt());
        }
        if (randNum >= 40 & randNum < 60 & check)
        {
            check = false;
            itemNum = 3;
            Instantiate(itemList[itemNum], Epos.position + offset, Quaternion.identity);
            Scoring.totalScore += 5;
            Debug.Log(message: Scoring.totalScore);
            StartCoroutine(WaitForIt());
        }
        if (randNum >= 20 & randNum < 40 & check)
        {
            check = false;
            itemNum = 4;
            Instantiate(itemList[itemNum], Epos.position + offset, Quaternion.identity);
            Scoring.totalScore += 5;
            Debug.Log(message: Scoring.totalScore);
            StartCoroutine(WaitForIt());
        }
        
        if (randNum >= 0 & randNum < 20 & check)
        {
            check = false;
            itemNum = 5;
            Instantiate(itemList[itemNum], Epos.position + offset, Quaternion.identity);
            Scoring.totalScore += 1;
            Debug.Log(message: Scoring.totalScore);
            StartCoroutine(WaitForIt());
        }

    }

    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(2.0f);
        check= true;
    }
}

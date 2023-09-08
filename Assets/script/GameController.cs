using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    
    private List<GameObject> _latas;
    private int _score=0;
public TextMeshProUGUI scoreTest;
    void Start()
    {
        scoreTest=GameObject.Find("Textscore").GetComponent<TextMeshProUGUI>();
   
        _latas=new List<GameObject>(GameObject.FindGameObjectsWithTag("latas"));
    }



   public void targetHit(GameObject go){
        if (_latas.Contains(go))
        {
            _score +=10;  
            _latas.Remove(go);       

            Debug.Log("score: " + _score); 
            scoreTest.text="score: " + _score;
        }

        
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour {

    public GameObject dotA;
    public GameObject dotB;
    public GameObject player;
    
    private float speed = 1.5f;
    private GameObject selectedDot;

    // Start is called before the first frame update
    void Start() {
        selectedDot = dotA;
    }

    // Update is called once per frame
    void Update() {
        foreach (Touch touch in Input.touches) {
            if(touch.phase == TouchPhase.Began) Debug.Log("123");
        }
        movePlayerToDots();
    }

    private void movePlayerToDots() {
        var dotPosition = selectedDot.transform.position; 
        var playerPosition = player.transform.position; 
        player.transform.position = Vector3.MoveTowards (playerPosition, dotPosition, Time.deltaTime * speed); 
        
        if (playerPosition == dotPosition) {
            changeSelectedDot();
        }
    }

    private void changeSelectedDot() {
        if (selectedDot == dotA) {
            selectedDot = dotB;
        } else if (selectedDot == dotB) {
            selectedDot = dotA;
        }
    }
}

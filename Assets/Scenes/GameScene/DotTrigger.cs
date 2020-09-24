using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        var enemy: GameObject = GameObject.Find("dot");
        if (collider.gameObject.name == "player") {
            SpawnCube();
        }
    }
}

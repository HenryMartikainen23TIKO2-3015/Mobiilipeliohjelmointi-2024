using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Example {

    //changes the colour of the sprite

    public class NewBehaviourScript : MonoBehaviour
    {
        private SpriteRenderer _SpriteRenderer;
        // Start is called before the first frame update
        void Start()
        {
            _SpriteRenderer = GetComponent<SpriteRenderer>();
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}


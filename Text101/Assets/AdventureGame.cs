﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text storyText;
    [SerializeField] State startingState;

    State state;
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        storyText.text = startingState.getStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;   

[RequireComponent(typeof(Deck))]                                             
[RequireComponent(typeof(JsonParseLayout))]
public class Golf : MonoBehaviour
{
    private static Golf S;
    [Header("Dynamic")]
    public List<CardProspector> drawPile;

    public List<CardProspector> discardPile;
    public List<CardProspector> mine;
    public CardProspector target;

    private Transform layoutAnchor;

    private Deck deck;
    private JsonLayout jsonLayout;

    private Dictionary<int, CardProspector> mineIdToCardDict;
    
}
using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EventItem", menuName = "ScriptableObjects/EventItem", order = 1)]
public class EventItem : Item
{
    public List<Card> EventCards;
    public List<int> CardAmounts;
}

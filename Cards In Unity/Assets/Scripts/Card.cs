using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NewCard",menuName ="Card")]
public class Card : ScriptableObject {

    public new string name;
    public string disc;

    public Sprite img;

    public int ad;
    public int hp;
    public int mana;

	
}

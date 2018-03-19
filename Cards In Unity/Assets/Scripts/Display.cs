using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour {

    public Card card;

    public Image img;
    public new Text name;
    public Text disc;

    public Text mana;
    public Text hp;
    public Text ad;

    private void Start()
    {
        img.sprite = card.img ;

        name.text = card.name ;
        disc.text = card.disc ;

        mana.text = card.mana + "" ;
        hp.text = card.hp + "" ;
        ad.text = card.ad + "" ;

    }
}

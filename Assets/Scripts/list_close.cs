using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class list_close : MonoBehaviour
{
        public TextMeshProUGUI money_meseeage;    
    public void LoadClose500(){
        money_meseeage.text = "레시피를 구매하시겠습니까? 가격은 500원입니다.";
    }

    public void LoadClose1000(){
        money_meseeage.text = "레시피를 구매하시겠습니까? 가격은 1000원입니다.";
    }

    public void LoadClose1500(){
        money_meseeage.text = "레시피를 구매하시겠습니까? 가격은 1500원입니다.";
    }

    public void LoadClose2000(){
        money_meseeage.text = "레시피를 구매하시겠습니까? 가격은 2000원입니다.";
    }

    public void LoadClose5000(){
        money_meseeage.text = "레시피를 구매하시겠습니까? 가격은 5000원입니다.";
    }
}

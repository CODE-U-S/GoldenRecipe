using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using EasyUI.Toast;
using System;
using UnityEngine.SceneManagement;

public class list_close : MonoBehaviour
{
    public TextMeshProUGUI money_meseeage;
    int money_bar;
    int recipe_money;
    int[] list_check = new int[4];
    private void Start()
    {
        money_bar = 3000;
        recipe_money = PlayerPrefs.GetInt("recipe");
        list_check[0] =  PlayerPrefs.GetInt("list_check0");
        list_check[1] =  PlayerPrefs.GetInt("list_check1");
        list_check[2] =  PlayerPrefs.GetInt("list_check2");
        list_check[3] =  PlayerPrefs.GetInt("list_check3");
        money_meseeage.text = "레시피를 구매하시겠습니까? 가격은 " +
        recipe_money + "원입니다.";
    }
    public void yesbutton(){
        //돈이 있으면 차감. "없으면 돈이 부족합니다" 출력
        if(money_bar >= recipe_money){ 
            money_bar -= recipe_money;
            IndexCheck();
            PlayerPrefs.SetInt("Money", money_bar);
            SavedData();
            SceneManager.LoadScene("List");
        } else {
            Toast.Show("돈이 부족합니다.", 2f, new Color(8f, 0.7f, 0.0f));
        }
    }
    public void IndexCheck(){
        if(recipe_money == 500){
            list_check[0] = 1;
        }
        else if(recipe_money == 1000){
            list_check[1] = 1;
        }
        else if(recipe_money == 1500){
            list_check[2] = 1;
        }
        else if(recipe_money == 2000){
            list_check[3] = 1;
        }
        PlayerPrefs.SetInt("list_check0", list_check[0]);
        PlayerPrefs.SetInt("list_check1", list_check[1]);
        PlayerPrefs.SetInt("list_check2", list_check[2]);
        PlayerPrefs.SetInt("list_check3", list_check[3]);
        SavedData();
    }

    public void LoadLevel6Yes(){
        if(recipe_money <= money_bar){
            money_bar -= 5000;
            PlayerPrefs.SetInt("Money", money_bar);
            SceneManager.LoadScene("Ending2");
        } else {
            Toast.Show("돈이 부족합니다.", 2f, new Color(8f, 0.7f, 0.0f));
        }
    }
    public void SavedData(){
        PlayerPrefs.Save();
    }
}

using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
public class List : MonoBehaviour
{
    int recipe_money;
    int[] list_check = new int[4];
    private void Start()
    {
        recipe_money = PlayerPrefs.GetInt("recipe");
        list_check[0] = PlayerPrefs.GetInt("list_check0");
        list_check[1] = PlayerPrefs.GetInt("list_check1");
        list_check[2] = PlayerPrefs.GetInt("list_check2");
        list_check[3] = PlayerPrefs.GetInt("list_check3");
    }
    
    public void MoveLevel1()
    {
        SceneManager.LoadScene("level1");
    }
    public void MoveLevel2()
    {
        Debug.Log("list"+list_check[0]);
        if(list_check[0] == 1){
            LoadClose();
            SceneManager.LoadScene("level2");
        } else {
            recipe_money = 500;
            LoadClose();
            Debug.Log("51");
            list_check[0] = PlayerPrefs.GetInt("list_check0");
            Debug.Log("53"+list_check[0]);
        }
    }
    public void MoveLevel3()
    {
        if(list_check[1] == 1){
            LoadClose();
            SceneManager.LoadScene("level3");
        } else {
            recipe_money = 1000;
            LoadClose();
            list_check[1] = PlayerPrefs.GetInt("list_check1");
        }
    }
    public void MoveLevel4()
    {
        if(list_check[2] == 1){
            SceneManager.LoadScene("level4");
        } else {
            recipe_money = 1500;
            LoadClose();
            list_check[2] = PlayerPrefs.GetInt("list_check2");
        }
    }
    public void MoveLevel5()
    {
        if(list_check[3] == 1){
            SceneManager.LoadScene("level5");
        } else {
            recipe_money = 2000;
            LoadClose();
            list_check[3] = PlayerPrefs.GetInt("list_check3");
        }
    }
    public void MoveLevel6(){
        SceneManager.LoadScene("level6", LoadSceneMode.Additive);
    }
    public void LoadClose()
    {
        //초기화용
        //reset_list();
        PlayerPrefs.SetInt("recipe", recipe_money);
        PlayerPrefs.Save();
        SceneManager.LoadScene("close", LoadSceneMode.Additive);
    }
    public void reset_list(){
        for(int i = 0; i < list_check.Length; i++){
            list_check[i] = 0;
        }
        PlayerPrefs.SetInt("list_check0", list_check[0]);
        PlayerPrefs.SetInt("list_check1", list_check[1]);
        PlayerPrefs.SetInt("list_check2", list_check[2]);
        PlayerPrefs.SetInt("list_check3", list_check[3]);
    }

}
//open 지운거
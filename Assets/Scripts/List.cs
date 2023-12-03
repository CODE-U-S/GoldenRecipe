using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
public class List : MonoBehaviour
{
    int recipe_money;
    public GameObject Level2Open;
    public GameObject Level3Open;
    public GameObject Level4Open;
    public GameObject Level5Open;
    int[] list_check = new int[4];
    int[] opens = new int[4];
    private void Start()
    {
        recipe_money = PlayerPrefs.GetInt("recipe");
        list_check[0] = PlayerPrefs.GetInt("list_check0");
        list_check[1] = PlayerPrefs.GetInt("list_check1");
        list_check[2] = PlayerPrefs.GetInt("list_check2");
        list_check[3] = PlayerPrefs.GetInt("list_check3");

        opens[0] = PlayerPrefs.GetInt("open0");
        opens[1] = PlayerPrefs.GetInt("open1");
        opens[2] = PlayerPrefs.GetInt("open2");
        opens[3] = PlayerPrefs.GetInt("open3");

        
        
    }
    public void OpenImage(){
        Debug.Log("30"+opens[0]);
        if(opens[0] == 1)Level2Open.SetActive(true);
        if(opens[1] == 1)Level3Open.SetActive(true);
        if(opens[2] == 1)Level4Open.SetActive(true);
        if(opens[3] == 1)Level5Open.SetActive(true);
    }
    public void MoveLevel1()
    {
        SceneManager.LoadScene("level1");
    }
    public void MoveLevel2()
    {
        Debug.Log("list"+list_check[0]);
        if(list_check[0] == 1){
            opens[0] = 1;
            Debug.Log("45" + opens[0]);
            LoadClose();
            SceneManager.LoadScene("level2");
        } else {
            recipe_money = 500;
            LoadClose();
            Debug.Log("51");
            list_check[0] = PlayerPrefs.GetInt("list_check0");
            Debug.Log("53"+list_check[0]);
            if(list_check[0] == 1){
                Debug.Log("55");
                OpenImage();
            }
        }
    }
    public void MoveLevel3()
    {
        if(list_check[1] == 1){
            opens[1] = 1;
            LoadClose();
            SceneManager.LoadScene("level3");
        } else {
            recipe_money = 1000;
            LoadClose();
            list_check[1] = PlayerPrefs.GetInt("list_check1");
            if(list_check[1] == 1){
                OpenImage();
            }
        }
    }
    public void MoveLevel4()
    {
        if(list_check[2] == 1){
            opens[2] = 1;
            SceneManager.LoadScene("level4");
        } else {
            recipe_money = 1500;
            LoadClose();
            list_check[2] = PlayerPrefs.GetInt("list_check2");
            if(list_check[2] == 1){
                OpenImage();
            }
        }
    }
    public void MoveLevel5()
    {
        if(list_check[3] == 1){
            opens[3] = 1;
            SceneManager.LoadScene("level5");
        } else {
            recipe_money = 2000;
            LoadClose();
            list_check[3] = PlayerPrefs.GetInt("list_check3");
            if(list_check[3] == 1){
                OpenImage();
            }
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
        PlayerPrefs.SetInt("open0", opens[0]);
        PlayerPrefs.SetInt("open1", opens[1]);
        PlayerPrefs.SetInt("open2", opens[2]);
        PlayerPrefs.SetInt("open3", opens[3]);
        PlayerPrefs.Save();
        SceneManager.LoadScene("close", LoadSceneMode.Additive);
    }
    public void reset_list(){
        for(int i = 0; i < list_check.Length; i++){
            list_check[i] = 0;
            opens[i] = 0;
        }
        PlayerPrefs.SetInt("list_check0", list_check[0]);
        PlayerPrefs.SetInt("list_check1", list_check[1]);
        PlayerPrefs.SetInt("list_check2", list_check[2]);
        PlayerPrefs.SetInt("list_check3", list_check[3]);
        PlayerPrefs.SetInt("open0", opens[0]);
        PlayerPrefs.SetInt("open1", opens[1]);
        PlayerPrefs.SetInt("open2", opens[2]);
        PlayerPrefs.SetInt("open3", opens[3]);
    }

}
//오픈이 저장이 안됨.
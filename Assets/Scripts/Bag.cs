using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyUI.Toast;
public class Bag : MonoBehaviour
{
    // Start is called before the first frame update
    public void b1(){
        Toast.Show("토끼가 먹다 토낀 당근", 2f, new Color(8f, 0.7f, 0.0f));
    }

    public void b2(){
        Toast.Show("푸른 파는 호랑이가 쑥으로 착각할 정도로 푸르다.", 2f, new Color(8f, 0.7f, 0.0f));
    }
    public void b3(){
        Toast.Show("할머니가 생각나는 따끈따끈한 밥 한 공기", 2f, new Color(8f, 0.7f, 0.0f));
    }

    public void b4(){
        Toast.Show("고래싸움에 등터진 새우는 머리까지 잃어버렸다...", 2f, new Color(8f, 0.7f, 0.0f));
    }

    public void b5(){
        Toast.Show("감자 같은 네 얼굴~", 2f, new Color(8f, 0.7f, 0.0f));
    }

    public void b6(){
        Toast.Show("그거 아시나요? 흑마늘은 종이 아니라 홍삼 같은 요리방법이랍니다.", 2f, new Color(8f, 0.7f, 0.0f));
    }
    public void b7(){
        Toast.Show("모든 것을 싹수가 누렇게 만들어 버리겠다.", 2f, new Color(8f, 0.7f, 0.0f));
    }
    public void b8(){
        Toast.Show("물병은 삼.다.수❤", 2f, new Color(8f, 0.7f, 0.0f));
    }
    public void hide(){
        Toast.Show("곧 공개 예정~ >ㅡ<", 2f, new Color(8f, 0.7f, 0.0f));
    }
}

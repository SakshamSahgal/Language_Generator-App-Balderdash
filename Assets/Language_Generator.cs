using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Language_Generator : MonoBehaviour
{
    public GameObject Back_button;
    public GameObject Scene_Transition_image; 
    public Button [] Characters; // array that stores character buttons
    public int[] character_button_index_array; //array that keeps track of character button index
    public Text Character_String;
    public GameObject Character_Panel;
    public GameObject Cross_Button; 
    public int N,Character_Button_Index,done=0; // N is used to tell which alphabet is selected // Character_Button_Index is used to tell which character is selected //done is used to check if all selections are done or not
    public static char[] Encrypted_Array = { 'Ф', 'Д', 'Վ', 'Ձ', 'չ', 'Դ', 'Б', 'ц', 'ɣ', 'Γ', 'Σ', 'ж', 'л', 'ө', 'Ю', 'ғ', 'э', 'ә', 'ф', 'Ъ', 'ў', 'Ш', 'Ь', 'ё', 'Æ', 'Ի' }; //is used to know which letter corresponds to which character
    public Text[] Selected_Text;  //array that stores text selected boxes
    public GameObject Warning;
    public Animator scene_transition;
    // Start is called before the first frame update
    void Start()
    {
        Scene_Transition_image.gameObject.SetActive(false);
        //DontDestroyOnLoad(transform.gameObject);
        Array.Resize<char>(ref Encrypted_Array,26);
        Array.Resize<Button>(ref Characters, 52);
        Array.Resize<Text>(ref Selected_Text, 26);
        Array.Resize<int>(ref character_button_index_array, 52);
        for(int i=0;i<52;i++)
        {
            character_button_index_array[i] = -1;
        }
        N = 1;
    }
    public void go_back() //function that lets your go from scene 1 to main scene
    {
        StartCoroutine("go_back_from_scecne1_to_main_scene");
    }
    public void Bipass() 
    {
        SceneManager.LoadScene(sceneName: "Encrypt_Scene");
    }
    public void Cross() //closes the character panel
    {
        Back_button.gameObject.SetActive(true);
        Character_Button_Index = 0;
        Character_Panel.gameObject.SetActive(false);
    }
    public void Character_Pannel() 
    {
        Back_button.gameObject.SetActive(false);
        Character_Panel.gameObject.SetActive(true);
        if (N == 0) 
        {
            Character_String.text = "A";
        }
        else if (N == 1) 
        {
            Character_String.text = "B";
        }
        else if (N == 2)
        {
            Character_String.text = "C";
        }
        else if (N == 3)
        {
            Character_String.text = "D";
        }
        else if (N == 4)
        {
            Character_String.text = "E";
        }
        else if (N == 5)
        {
            Character_String.text = "F";
        }
        else if (N == 6)
        {
            Character_String.text = "G";
        }
        else if (N == 7)
        {
            Character_String.text = "H";
        }
        else if (N == 8)
        {
            Character_String.text = "I";
        }
        else if (N == 9)
        {
            Character_String.text = "J";
        }
        else if (N == 10)
        {
            Character_String.text = "K";
        }
        else if (N == 11)
        {
            Character_String.text = "L";
        }
        else if (N == 12)
        {
            Character_String.text = "M";
        }
        else if (N == 13)
        {
            Character_String.text = "N";
        }
        else if (N == 14)
        {
            Character_String.text = "O";
        }
        else if (N == 15)
        {
            Character_String.text = "P";
        }
        else if (N == 16)
        {
            Character_String.text = "Q";
        }
        else if (N == 17)
        {
            Character_String.text = "R";
        }
        else if (N == 18)
        {
            Character_String.text = "S";
        }
        else if (N == 19)
        {
            Character_String.text = "T";
        }
        else if (N == 20)
        {
            Character_String.text = "U";
        }
        else if (N == 21)
        {
            Character_String.text = "V";
        }
        else if (N == 22)
        {
            Character_String.text = "W";
        }
        else if (N == 23)
        {
            Character_String.text = "X";
        }
        else if (N == 24)
        {
            Character_String.text = "Y";
        }
        else if (N == 25)
        {
            Character_String.text = "Z";
        }
    } //tells for which alphabet the chartacter panel is selected
    // Update is called once per frame
    void Update()
    {
        //Already_Selected_function();
    }

    public void Already_Selected_function() 
    {
       for (int i=0;i<26;i++) 
        {
            if (character_button_index_array[i] != -1)
            {
                Debug.Log("button to be disabled is at index " + character_button_index_array[i]);
                Characters[character_button_index_array[i]].GetComponent<Button>().interactable = false;
            }
        }
    }


    public void all_enable() 
    {
        for (int i = 0; i < 52; i++)
        {
            if (Characters[i].GetComponent<Button>().interactable == false) 
            {
                Characters[i].GetComponent<Button>().interactable = true;
            }
           
        }
    }
    public void A_Selection_Button_0() 
    {
        N = 0;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
        
    }
    public void A_Selection_Button_1()
    {
        N = 1;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
    }
    public void A_Selection_Button_2()
    {
        N = 2;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
    }
    public void A_Selection_Button_3()
    {
        N = 3;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
    }
    public void A_Selection_Button_4()
    {
            N = 4;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
    }

    public void A_Selection_Button_5()
    {
        N = 5;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
    }
    public void A_Selection_Button_6()
    {
        N = 6;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
    }
    public void A_Selection_Button_7()
    {
        N = 7;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
    }
    public void A_Selection_Button_8()
    {
        N = 8;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
    }
    public void A_Selection_Button_9()
    {
        N = 9;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
    }
    public void A_Selection_Button_10()
    {
        N = 10;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
    }
    public void A_Selection_Button_11()
    {
        N = 11;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
    }
    public void A_Selection_Button_12()
    {
        N = 12;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
    }
    public void A_Selection_Button_13()
    {
        N = 13;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
    }
    public void A_Selection_Button_14()
    {
        N = 14;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
    }
    public void A_Selection_Button_15()
    {
        N = 15;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
    }
    public void A_Selection_Button_16()
    {
        N = 16;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
    }
    public void A_Selection_Button_17()
    {
        N = 17;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
    }
    public void A_Selection_Button_18()
    {
        N = 18;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
    }
    public void A_Selection_Button_19()
    {
        N = 19;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
    }
    public void A_Selection_Button_20()
    {
        N = 20;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
    }
    public void A_Selection_Button_21()
    {
        N = 21;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
    }
    public void A_Selection_Button_22()
    {
        N = 22;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
    }
    public void A_Selection_Button_23()
    {
        N = 23;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
    }
    public void A_Selection_Button_24()
    {
        N = 24;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
    }
    public void A_Selection_Button_25()
    {
        N = 25;
        Character_Pannel();
        all_enable();
        Already_Selected_function();
    }

    public void Symbol_0() 
    {
        Selected_Text[N].text = "Ф";
        Character_Button_Index = 0;
        Encrypted_Array[N] = 'Ф';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();

    }
    public void Symbol_1()
    {
        Selected_Text[N].text = "Д";
        Character_Button_Index = 1;
        Encrypted_Array[N] = 'Д';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }

    public void Symbol_2()
    {
        Selected_Text[N].text = "Վ";
        Character_Button_Index = 2;
        Encrypted_Array[N] = 'Վ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }
    public void Symbol_3()
    {
        Selected_Text[N].text = "Ձ";
        Character_Button_Index = 3;
        Encrypted_Array[N] = 'Ձ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }
    public void Symbol_4()
    {
        Selected_Text[N].text = "չ";
        Character_Button_Index = 4;
        Encrypted_Array[N] = 'չ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }
    public void Symbol_5()
    {
        Selected_Text[N].text = "Դ";
        Character_Button_Index = 5;
        Encrypted_Array[N] = 'Դ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }

    public void Symbol_6()
    {
        Selected_Text[N].text = "Б";
        Character_Button_Index = 6;
        Encrypted_Array[N] = 'Б';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }

    public void Symbol_7()
    {
        Selected_Text[N].text = "ц";
        Character_Button_Index = 7;
        Encrypted_Array[N] = 'ц';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }


    public void Symbol_8()
    {
        Selected_Text[N].text = "ɣ";
        Character_Button_Index = 8;
        Encrypted_Array[N] = 'ɣ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }

    public void Symbol_9()
    {
        Selected_Text[N].text = "Γ";
        Character_Button_Index = 9;
        Encrypted_Array[N] = 'Γ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }

    public void Symbol_10()
    {
        Selected_Text[N].text = "Σ";
        Character_Button_Index = 10;
        Encrypted_Array[N] = 'Σ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }

    public void Symbol_11()
    {
        Selected_Text[N].text = "ж";
        Character_Button_Index = 11;
        Encrypted_Array[N] = 'ж';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }

    public void Symbol_12()
    {
        Selected_Text[N].text = "л";
        Character_Button_Index = 12;
        Encrypted_Array[N] = 'л';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }


    public void Symbol_13()
    {
        Selected_Text[N].text = "ө";
        Character_Button_Index = 13;
        Encrypted_Array[N] = 'ө';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }


    public void Symbol_14()
    {
        Selected_Text[N].text = "Ю";
        Character_Button_Index = 14;
        Encrypted_Array[N] = 'Ю';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }

    public void Symbol_15()
    {
        Selected_Text[N].text = "ғ";
        Character_Button_Index = 15;
        Encrypted_Array[N] = 'ғ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }


    public void Symbol_16()
    {
        Selected_Text[N].text = "э";
        Character_Button_Index = 16;
        Encrypted_Array[N] = 'э';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }


    public void Symbol_17()
    {
        Selected_Text[N].text = "ә";
        Character_Button_Index = 17;
        Encrypted_Array[N] = 'ә';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }

    public void Symbol_18()
    {
        Selected_Text[N].text = "ф";
        Character_Button_Index = 18;
        Encrypted_Array[N] = 'ф';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }


    public void Symbol_19()
    {
        Selected_Text[N].text = "Ъ";
        Character_Button_Index = 19;
        Encrypted_Array[N] = 'Ъ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }

    public void Symbol_20()
    {
        Selected_Text[N].text = "ў";
        Character_Button_Index = 20;
        Encrypted_Array[N] = 'ў';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }

    public void Symbol_21()
    {
        Selected_Text[N].text = "Ш";
        Character_Button_Index = 21;
        Encrypted_Array[N] = 'Ш';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }

    public void Symbol_22()
    {
        Selected_Text[N].text = "Ь";
        Character_Button_Index = 22;
        Encrypted_Array[N] = 'Ь';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }


    public void Symbol_23()
    {
        Selected_Text[N].text = "ё";
        Character_Button_Index = 23;
        Encrypted_Array[N] = 'ё';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }

    public void Symbol_24()
    {
        Selected_Text[N].text = "Æ";
        Character_Button_Index = 24;
        Encrypted_Array[N] = 'Æ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }

    public void Symbol_25()
    {
        Selected_Text[N].text = "Ի";
        Character_Button_Index = 25;
        Encrypted_Array[N] = 'Ի';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }

    public void Symbol_26()
    {
        Selected_Text[N].text = "ձ";
        Character_Button_Index = 26;
        Encrypted_Array[N] = 'ձ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }

    public void Symbol_27()
    {
        Selected_Text[N].text = "Շ";
        Character_Button_Index = 27;
        Encrypted_Array[N] = 'Շ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }

    public void Symbol_28()
    {
        Selected_Text[N].text = "Պ";
        Character_Button_Index = 28;
        Encrypted_Array[N] = 'Պ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }

    public void Symbol_29()
    {
        Selected_Text[N].text = "ռ";
        Character_Button_Index = 29;
        Encrypted_Array[N] = 'ռ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }

    public void Symbol_30()
    {
        Selected_Text[N].text = "ք";
        Character_Button_Index = 30;
        Encrypted_Array[N] = 'ք';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }

    public void Symbol_31()
    {
        Selected_Text[N].text = "խ";
        Character_Button_Index = 31;
        Encrypted_Array[N] = 'խ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }

    public void Symbol_32()
    {
        Selected_Text[N].text = "Я";
        Character_Button_Index = 32;
        Encrypted_Array[N] = 'Я';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }

    public void Symbol_33()
    {
        Selected_Text[N].text = "ь";
        Character_Button_Index = 33;
        Encrypted_Array[N] = 'ь';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }
    public void Symbol_34()
    {
        Selected_Text[N].text = "й";
        Character_Button_Index = 34;
        Encrypted_Array[N] = 'й';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }
    public void Symbol_35()
    {
        Selected_Text[N].text = "Ǧ";
        Character_Button_Index = 35;
        Encrypted_Array[N] = 'Ǧ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }
    public void Symbol_36()
    {
        Selected_Text[N].text = "ҙ";
        Character_Button_Index = 36;
        Encrypted_Array[N] = 'ҙ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }
    public void Symbol_37()
    {
        Selected_Text[N].text = "Œ";
        Character_Button_Index = 37;
        Encrypted_Array[N] = 'Œ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }
    public void Symbol_38()
    {
        Selected_Text[N].text = "ø";
        Character_Button_Index = 38;
        Encrypted_Array[N] = 'ø';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }
    public void Symbol_39()
    {
        Selected_Text[N].text = "п";
        Character_Button_Index = 39;
        Encrypted_Array[N] = 'п';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }
    public void Symbol_40()
    {
        Selected_Text[N].text = "ɒ";
        Character_Button_Index = 40;
        Encrypted_Array[N] = 'ɒ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }
    public void Symbol_41()
    {
        Selected_Text[N].text = "ʃ";
        Character_Button_Index = 41;
        Encrypted_Array[N] = 'ʃ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }
    public void Symbol_42()
    {
        Selected_Text[N].text = "ʂ";
        Character_Button_Index = 42;
        Encrypted_Array[N] = 'ʂ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }
    public void Symbol_43()
    {
        Selected_Text[N].text = "ɟ";
        Character_Button_Index = 43;
        Encrypted_Array[N] = 'ɟ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }
    public void Symbol_44()
    {
        Selected_Text[N].text = "ʔ";
        Character_Button_Index = 44;
        Encrypted_Array[N] = 'ʔ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }
    public void Symbol_45()
    {
        Selected_Text[N].text = "ʎ";
        Character_Button_Index = 45;
        Encrypted_Array[N] = 'ʎ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }
    public void Symbol_46()
    {
        Selected_Text[N].text = "ʘ";
        Character_Button_Index = 46;
        Encrypted_Array[N] = 'ʘ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }
    public void Symbol_47()
    {
        Selected_Text[N].text = "ʁ";
        Character_Button_Index = 47;
        Encrypted_Array[N] = 'ʁ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }
    public void Symbol_48()
    {
        Selected_Text[N].text = "ɰ";
        Character_Button_Index = 48;
        Encrypted_Array[N] = 'ɰ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }
    public void Symbol_49()
    {
        Selected_Text[N].text = "ɞ";
        Character_Button_Index = 49;
        Encrypted_Array[N] = 'ɞ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }
    public void Symbol_50()
    {
        Selected_Text[N].text = "ʊ";
        Character_Button_Index = 50;
        Encrypted_Array[N] = 'ʊ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }
    public void Symbol_51()
    {
        Selected_Text[N].text = "ʉ";
        Character_Button_Index = 51;
        Encrypted_Array[N] = 'ʉ';
        character_button_index_array[N] = Character_Button_Index;
        Debug.Log(Encrypted_Array[N]);
        Cross();
    }
    /*  public void Other_Character_Button_enable() 
      {
             for (int i = 0; i < 29; i++)
          {
              if (Characters[i].interactable == false && i != Character_Button_Index && i != sercher(i))
              {
                  Characters[i].interactable = true;
              }
          }
      }

      public int sercher(int index_to_be_searched) 
      {
          for (int i = 0; i < 26; i++)
          {
              if (character_button_index_array[i] != -1) 
              {
                  if (character_button_index_array[i] == index_to_be_searched)
                  {
                      return 1;
                  }
              }

          }
          return 0;
      } */
    public void clear_current_selection() 
    {
        Array.Clear(Encrypted_Array,N,N);
        Characters[Character_Button_Index].interactable = true;
    }

    public void Encrypt()
    {
        done = 1;
        for (int i=0;i<26;i++) 
        {
            if (Selected_Text[i].text == "Select")
            {
                StartCoroutine("Warning_enable");
                Debug.Log("abhi baki h mere dost \n ");
                done = 0;
            }
        
        }

        if (done == 1) 
        {
            StartCoroutine("scene_transition_from_scene_1_to_encrypted_scene");      
        }
    }

    IEnumerator Warning_enable() 
    {
        
        Warning.SetActive(true);
        yield return new WaitForSeconds(2f);
        Warning.SetActive(false);

    }

    IEnumerator scene_transition_from_scene_1_to_encrypted_scene()
    {

        Scene_Transition_image.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName: "Encrypt_Scene");

    }

    IEnumerator go_back_from_scecne1_to_main_scene()
    {
        Scene_Transition_image.gameObject.SetActive(true);
        scene_transition.Play("Fade_In");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Main");

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Translator_Script : MonoBehaviour
{
    public Animator scene_transition;
    public GameObject Scene_Transition_image;
    public InputField Inputter;
    public InputField outputter;
    public Text Text_1; //heading 1
    public Text Text_2; //heading 2
    public string str; //string that is storing inputed text
    bool switcher = false;
    public Text [] Keyboard_Layout; //array that store keyboard translated layout textboxes
    public GameObject Keyboard_Layout_Panel;
    public GameObject Everything_Else; //literally everything else other than the keyboard layout panel and its children 
    public char[] Key = { '0', '/', '0', '*', '0', '*', '0', '#', '0', '#', '0', '#', '0', '/', '0', '*', '0', '*', '0', '#', '0', '#', '0', '#', '0', '/', '0', '*', '0', '*', '0', '#', '0', '#', '0', '#', '0', '/', '0','*','0','*','0','#','0','#','0','#','0','/','0' };
    public InputField Your_Key;
    public GameObject Key_Panel;
    // Start is called before the first frame update
    void Start()
    {
        Scene_Transition_image.gameObject.SetActive(false);
        Array.Resize<Text>(ref Keyboard_Layout, 26);
        Array.Resize<char>(ref Key, 51);
        for (int i=0;i<Key.Length;i++)
        {
            Debug.Log(Key[i]);
        }
        //Debug.Log(Key);
    }

    public void Cross() 
    {
        Everything_Else.gameObject.SetActive(true);
        Keyboard_Layout_Panel.gameObject.SetActive(false);
    }

    public void Cut() 
    {
        Key_Panel.gameObject.SetActive(false);
    }
    public void Layout_Assign()  //assigns symbols in keyboard layouts
    {
        Keyboard_Layout_Panel.gameObject.SetActive(true);
        Everything_Else.gameObject.SetActive(false);
        for (int i=0;i<26;i++) 
        {
            Keyboard_Layout[i].text = Language_Generator.Encrypted_Array[i].ToString();
        }
    }
 
    public void Key_Generator() 
    {
        Debug.Log("aaiya 1");
        // Key = { '0', '/', '0', '*', '0', '*', '0', '#', '0', '#', '0', '#', '0', '/', '0', '*', '0', '*', '0', '#', '0', '#', '0', '#', '0', '/', '0', '*', '0', '*', '0', '#', '0', '#', '0', '#', '0', '/', '0','*','0','*','0','#','0','#','0','#','0','/','0' };
        int counter = 0;
        for (int i=0;i<Key.Length;i++)
        {
            if (Key[i] == '0') 
            {
                Key[i] = Language_Generator.Encrypted_Array[counter];
                counter++;
            }
                
        }

        Key_Panel.gameObject.SetActive(true);

        for (int i = 0; i < Key.Length; i++) 
        {
            Your_Key.text += Key[i];
        }  
    }


    public void Translator()
    {
        if (switcher == false)
        {
            outputter.text = null;
            str = Inputter.text;
            for (int i = 0; i < str.Length; i++)
            {
                outputter.text += translate_it(str[i]);
            }
        }

        else if (switcher == true) 
        {
            outputter.text = null;
            str = Inputter.text;
            for (int i=0;i<str.Length;i++) 
            {
                outputter.text += De_encrypt_it(str[i]);
            }

        }
        
    }
    public char translate_it (char checkit)
    {
        
        if ( (checkit == 'A') || (checkit == 'a') )
        {
            return Language_Generator.Encrypted_Array[0];
        }
        else if ((checkit == 'B') || (checkit == 'b'))
        {
            return Language_Generator.Encrypted_Array[1];
        }
        else if ((checkit == 'C') || (checkit == 'c'))
        {
            return Language_Generator.Encrypted_Array[2];
        }
        else if ((checkit == 'D') || (checkit == 'd'))
        {
            return Language_Generator.Encrypted_Array[3];
        }
        else if ((checkit == 'E') || (checkit == 'e'))
        {
            return Language_Generator.Encrypted_Array[4];
        }
        else if ((checkit == 'F') || (checkit == 'f'))
        {
            return Language_Generator.Encrypted_Array[5];
        }
        else if ((checkit == 'G') || (checkit == 'g'))
        {
            return Language_Generator.Encrypted_Array[6];
        }
        else if ((checkit == 'H') || (checkit == 'h'))
        {
            return Language_Generator.Encrypted_Array[7];
        }
        else if ((checkit == 'I') || (checkit == 'i'))
        {
            return Language_Generator.Encrypted_Array[8];
        }
        else if ((checkit == 'J') || (checkit == 'j'))
        {
            return Language_Generator.Encrypted_Array[9];
        }
        else if ((checkit == 'K') || (checkit == 'k'))
        {
            return Language_Generator.Encrypted_Array[10];
        }
        else if ((checkit == 'L') || (checkit == 'l'))
        {
            return Language_Generator.Encrypted_Array[11];
        }
        else if ((checkit == 'M') || (checkit == 'm'))
        {
            return Language_Generator.Encrypted_Array[12];
        }
        else if ((checkit == 'N') || (checkit == 'n'))
        {
            return Language_Generator.Encrypted_Array[13];
        }
        else if ((checkit == 'O') || (checkit == 'o'))
        {
            return Language_Generator.Encrypted_Array[14];
        }
        else if ((checkit == 'P') || (checkit == 'p'))
        {
            return Language_Generator.Encrypted_Array[15];
        }
        else if ((checkit == 'Q') || (checkit == 'q'))
        {
            return Language_Generator.Encrypted_Array[16];
        }
        else if ((checkit == 'R') || (checkit == 'r'))
        {
            return Language_Generator.Encrypted_Array[17];
        }
        else if ((checkit == 'S') || (checkit == 's'))
        {
            return Language_Generator.Encrypted_Array[18];
        }
        else if ((checkit == 'T') || (checkit == 't'))
        {
            return Language_Generator.Encrypted_Array[19];
        }
        else if ((checkit == 'U') || (checkit == 'u'))
        {
            return Language_Generator.Encrypted_Array[20];
        }
        else if ((checkit == 'V') || (checkit == 'v'))
        {
            return Language_Generator.Encrypted_Array[21];
        }
        else if ((checkit == 'W') || (checkit == 'w') )
        {
            return Language_Generator.Encrypted_Array[22];
        }
        else if ((checkit == 'X') || (checkit == 'x'))
        {
            return Language_Generator.Encrypted_Array[23];
        }
        else if ((checkit == 'Y') || (checkit == 'y'))
        {
            return Language_Generator.Encrypted_Array[24];
        }
        else if ((checkit == 'Z') || (checkit == 'z'))
        {
            return Language_Generator.Encrypted_Array[25];
        }


        return checkit;
    }


    public char De_encrypt_it(char inputted) 
    {
        if (inputted == Language_Generator.Encrypted_Array[0])
        {
            return 'a';
        }
        else if (inputted == Language_Generator.Encrypted_Array[1])
        {
            return 'b';
        }
        else if (inputted == Language_Generator.Encrypted_Array[2])
        {
            return 'c';
        }
        else if (inputted == Language_Generator.Encrypted_Array[3])
        {
            return 'd';
        }
        else if (inputted == Language_Generator.Encrypted_Array[4])
        {
            return 'e';
        }
        else if (inputted == Language_Generator.Encrypted_Array[5])
        {
            return 'f';
        }
        else if (inputted == Language_Generator.Encrypted_Array[6])
        {
            return 'g';
        }
        else if (inputted == Language_Generator.Encrypted_Array[7])
        {
            return 'h';
        }
        else if (inputted == Language_Generator.Encrypted_Array[8])
        {
            return 'i';
        }
        else if (inputted == Language_Generator.Encrypted_Array[9])
        {
            return 'j';
        }
        else if (inputted == Language_Generator.Encrypted_Array[10])
        {
            return 'k';
        }
        else if (inputted == Language_Generator.Encrypted_Array[11])
        {
            return 'l';
        }
        else if (inputted == Language_Generator.Encrypted_Array[12])
        {
            return 'm';
        }
        else if (inputted == Language_Generator.Encrypted_Array[13])
        {
            return 'n';
        }
        else if (inputted == Language_Generator.Encrypted_Array[14])
        {
            return 'o';
        }
        else if (inputted == Language_Generator.Encrypted_Array[15])
        {
            return 'p';
        }
        else if (inputted == Language_Generator.Encrypted_Array[16])
        {
            return 'q';
        }
        else if (inputted == Language_Generator.Encrypted_Array[17])
        {
            return 'r';
        }
        else if (inputted == Language_Generator.Encrypted_Array[18])
        {
            return 's';
        }
        else if (inputted == Language_Generator.Encrypted_Array[19])
        {
            return 't';
        }
        else if (inputted == Language_Generator.Encrypted_Array[20])
        {
            return 'u';
        }
        else if (inputted == Language_Generator.Encrypted_Array[21])
        {
            return 'v';
        }
        else if (inputted == Language_Generator.Encrypted_Array[22])
        {
            return 'w';
        }
        else if (inputted == Language_Generator.Encrypted_Array[23])
        {
            return 'x';
        }
        else if (inputted == Language_Generator.Encrypted_Array[24])
        {
            return 'y';
        }
        else if (inputted == Language_Generator.Encrypted_Array[25])
        {
            return 'z';
        }
        else 
        {
            return inputted;
        }
      
    }
    
    public void Text_swap(float values) 
    {
        outputter.text = null;
        Inputter.text = null;
        if (values == 1) 
        {
            switcher = true;
            Text_1.text = "Your Encrypted language -";
            Text_2.text = "Is De-encrypted in english to -";
        }
        if (values == 0) 
        {
            switcher = false;
            Text_1.text = "Your Text In English -";
            Text_2.text = "Is Encrypted to -";
        }
    }

    public void Reset_it() 
    {
        StartCoroutine("tansition_from_encrypted_scene_to_scene1");
        
    }

    IEnumerator tansition_from_encrypted_scene_to_scene1() 
    {
        Scene_Transition_image.gameObject.SetActive(true);
        scene_transition.Play("Fade_In");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName: "Scene1");

    }
}

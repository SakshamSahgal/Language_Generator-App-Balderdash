using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System;
public class First_Page : MonoBehaviour
{
    public Text warningtext;
    public Button Translate_button;
    public GameObject Scene_Transition_image;
    public Animator scene_transition;
    public GameObject Home_Screen_Buttons;
    public GameObject Enter_Key_Panel;
    public InputField Key_Input; //input field of the key checker panel
    public char[] characters_in_key; //character array that has the character extracted from the key
    public string input_string_key; //string that stores the input of the inputfield of key checker panel
    // Start is called before the first frame update
    void Start()
    {
        scene_transition.gameObject.SetActive(false);
        Array.Resize<char>(ref characters_in_key, 26);
    }

    public void Create_Your_Own_Language() 
    {
        StartCoroutine("Scene_transition_to_scene_1");
    }
    public void Enter_key() 
    {
        Home_Screen_Buttons.gameObject.SetActive(false);
        warningtext.gameObject.SetActive(false);
        Enter_Key_Panel.gameObject.SetActive(true);
    }

    public void cross_key_pannel() 
    {
        Enter_Key_Panel.gameObject.SetActive(false);
        Home_Screen_Buttons.gameObject.SetActive(true);
    }
    


    public void translate_key_check()  //this function checks whether the inputted translation key is correct or not 
    {
        input_string_key = Key_Input.text.ToString();
        // Debug.Log(all_character_Distinct_checker());

        if (input_string_key.Length == 51)
        {

            if (all_character_Distinct_checker() == 1)
            {

                bool indentation = true;

                for (int i = 0; i <= 50; i++)
                {
                    if (((i == 1) || (i == 13) || (i == 25) || (i == 37) || (i == 49)) && input_string_key[i] != '/')
                    {
                        indentation = false;
                        break;
                    }

                    if (((i == 3) || (i == 5) || (i == 15) || (i == 17) || (i == 27) || (i == 29) || (i == 39) || (i == 41)) && input_string_key[i] != '*')
                    {
                        indentation = false;
                        break;
                    }

                    if (((i == 7) || (i == 9) || (i == 11) || (i == 19) || (i == 21) || (i == 23) || (i == 31) || (i == 33) || (i == 35) || (i == 43) || (i == 45) || (i == 47)) && input_string_key[i] != '#')
                    {
                        indentation = false;
                        break;
                    }
                }


                if (indentation == true)
                {
                    bool character_not_found_in_palet = false;
                    for (uint i = 0; i < 26; i++)
                    {
                        if (character_pallet(characters_in_key[i]) == 0)
                        {
                            character_not_found_in_palet = true;
                        }
                    }

                    if (character_not_found_in_palet == true)
                    {
                        Debug.Log("character is not found in pallet");
                    }
                    else
                    {
                        Debug.Log("everything is correct");
                        warningtext.gameObject.SetActive(true);
                        warningtext.text = "Success";
                        for (int i = 0; i < 26; i++)
                            Language_Generator.Encrypted_Array[i] = characters_in_key[i];

                        StartCoroutine("Scene_transition_from_first_page_to_Encrypted_scene");               
                        //Translate_button.GetComponent<Image>().color = new Color(225,105,106);
                    }

                }

                else
                {
                    Debug.Log("indentation is false");
                    warningtext.gameObject.SetActive(true);
                    warningtext.text = "indentation is false";
                }
            }
            else
            {
                Debug.Log("All character are not distinct");
                warningtext.gameObject.SetActive(true);
                warningtext.text = "All character are not distinct";
            }
        }

        else 
        {
            Debug.Log("key not complete");
            warningtext.gameObject.SetActive(true);
            warningtext.text = "key invalid or not complete";
        }

    }

    public int all_character_Distinct_checker() //this function checks whether the inputed key has all distinct characters or not
    {
        input_string_key = Key_Input.text.ToString();
        for (int i = 0; i <= 50; i++)
        {
            if (i % 2 == 0)
                characters_in_key[i/2] = input_string_key[i];
        }

        bool checker = false;
        //all distinct checking 
        for (int i = 0; i <26; i++) 
        {
            for (int j=0;j<i;j++) 
            {
                if (characters_in_key[i] == characters_in_key[j]) 
                {
                    checker = true;
                }
            }           

        }

        if (checker == true)
            return 0;
        else 
            return 1;
    }

    public int character_pallet(char ch) //this function checks if the selected character is a valid character from the character pallet
    {
        if ((ch == 'Ф') || (ch == 'Д') || (ch == 'Վ') || (ch == 'Ձ') || (ch == 'չ') || (ch == 'Դ') || (ch == 'Б') || (ch == 'ц') || (ch == 'ɣ') || (ch == 'Γ') || (ch == 'Σ') || (ch == 'ж') || (ch == 'л') || (ch == 'ө') || (ch == 'Ю') || (ch == 'ғ') || (ch == 'э') || (ch == 'ә') || (ch == 'ф') || (ch == 'Ъ') || (ch == 'ў') || (ch == 'Ш') || (ch == 'Ь') || (ch == 'ё') || (ch == 'Æ') || (ch == 'Ի') || (ch == 'ձ') || (ch == 'Շ') || (ch == 'Պ') || (ch == 'ռ') || (ch == 'ք') || (ch == 'խ') || (ch == 'Я') || (ch == 'ь') || (ch == 'й') || (ch == 'Ǧ') || (ch == 'ҙ') || (ch == 'Œ') || (ch == 'ø') || (ch == 'п') || (ch == 'ɒ') || (ch == 'ʃ') || (ch == 'ʂ') || (ch == 'ɟ') || (ch == 'ʔ') || (ch == 'ʎ') || (ch == 'ʘ') || (ch == 'ʁ') || (ch == 'ɰ') || (ch == 'ɞ') || (ch == 'ʊ') || (ch == 'ʉ'))
            return 1;
        else
            return 0;
    
    }
    IEnumerator Scene_transition_to_scene_1() 
    {
        Scene_Transition_image.gameObject.SetActive(true);
        scene_transition.Play("Fade_In");
        yield return new WaitForSeconds(1f);
;        SceneManager.LoadScene("Scene1");

    }
    IEnumerator Scene_transition_from_first_page_to_Encrypted_scene()
    {
        Scene_Transition_image.gameObject.SetActive(true);
        scene_transition.Play("Fade_In");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Encrypt_Scene");

    }
}

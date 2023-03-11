using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueScript : MonoBehaviour
{
    private bool two;
    private bool three;
    private bool four;
    private bool five;
    private bool six;
    private bool seven;
    private bool eight;
    private bool nine;
    private string tekst;
    private string txt;
    private bool anotherBool = false;
    private bool someBool = false;
    public bool yeeeee;
    public TextMeshProUGUI textComponent;
    public float textSpeed;
    private string text;
    private string something;
    // Start is called before the first frame update
    void Start()
    {
        tekst = null;
        yeeeee = false;
        something = null;
        textComponent.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A)) { something = null; someBool = true;
            three = false;
            four = false;
            five = false;
            six = false;
            seven = false;
            eight = false;
            nine = false;
            if (two == true)
            {
                something = ("#");
            }
            else
            {
                something = ("");
            }
            something += ("2");
            two = true;
            anotherBool = false;
            text += something;
            txt = ("A");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.B)) { something = null; someBool = true;
            three = false;
            four = false;
            five = false;
            six = false;
            seven = false;
            eight = false;
            nine = false;
            if (two == true)
            {
                something = ("#");
            }
            else
            {
                something = ("");
            }
            something += ("22");
            two = true;
            anotherBool = false;
            text += something;
            txt = ("B");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.C)) { something = null; someBool = true;
            three = false;
            four = false;
            five = false;
            six = false;
            seven = false;
            eight = false;
            nine = false;
            if (two == true)
            {
                something = ("#");
            }
            else
            {
                something = ("");
            }
            something += ("222");
            two = true;
            anotherBool = false;
            text += something;
            txt = ("C");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.D)) { something = null; someBool = true;
            two = false;
            four = false;
            five = false;
            six = false;
            seven = false;
            eight = false;
            nine = false;
            if (three == true)
            {
                something = ("#");
            }
            else
            {
                something = ("");
            }
            something += ("3");
            three = true;
            anotherBool = false;
            text += something;
            txt = ("D");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.E)) { something = null; someBool = true;
            two = false;
            four = false;
            five = false;
            six = false;
            seven = false;
            eight = false;
            nine = false;
            if (three == true)
            {
                something = ("#");
            }
            else
            {
                something = ("");
            }
            something += ("33");
            three = true;
            anotherBool = false;
            text += something;
            txt = ("E");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.F)) { something = null; someBool = true;
            two = false;
            four = false;
            five = false;
            six = false;
            seven = false;
            eight = false;
            nine = false;
            if (three == true)
            {
                something = ("#");
            }
            else
            {
                something = ("");
            }
            something += ("333");
            three = true;
            anotherBool = false;
            text += something;
            txt = ("F");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.G)) { something = null; someBool = true;
            two = false;
            three = false;
            five = false;
            six = false;
            seven = false;
            eight = false;
            nine = false;
            if (four == true)
            {
                something = ("#");
            }
            else
            {
                something = ("");
            }
            something += ("4");
            four = true;
            anotherBool = false;
            text += something;
            txt = ("G");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.H)) { something = null; someBool = true;
            two = false;
            three = false;
            five = false;
            six = false;
            seven = false;
            eight = false;
            nine = false;
            if (four == true)
            {
                something = ("#");
            }
            else
            {
                something = ("");
            }
            something += ("44");
            four = true;
            anotherBool = false;
            text += something;
            txt = ("H");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.I)) { something = null; someBool = true;
            two = false;
            three = false;
            five = false;
            six = false;
            seven = false;
            eight = false;
            nine = false;
            if (four == true)
            {
                something = ("#");
            }
            else
            {
                something = ("");
            }
            something += ("444");
            four = true;
            anotherBool = false;
            text += something;
            txt = ("I");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.J)) { something = null; someBool = true;
            two = false;
            three = false;
            four = false;
            six = false;
            seven = false;
            eight = false;
            nine = false;
            if (five == true)
            {
                something = ("#");
            }
            else
            {
                something = ("");
            }
            something += ("5");
            five = true;
            anotherBool = false;
            text += something;
            txt = ("J");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.K)) { something = null; someBool = true;
            two = false;
            three = false;
            four = false;
            six = false;
            seven = false;
            eight = false;
            nine = false;
            if (five == true)
            {
                something = ("#");
            }
            else
            {
                something = ("");
            }
            something += ("55");
            five = true;
            anotherBool = false;
            text += something;
            txt = ("K");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.L)) { something = null; someBool = true;
            two = false;
            three = false;
            four = false;
            six = false;
            seven = false;
            eight = false;
            nine = false;
            if (five == true)
            {
                something = ("#");
            }
            else
            {
                something = ("");
            }
            something += ("555");
            five = true;
            anotherBool = false;
            text += something;
            txt = ("L");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.M)) { something = null; someBool = true;
            two = false;
            three = false;
            four = false;
            five = false;
            seven = false;
            eight = false;
            nine = false;
            if (six == true)
            {
                something = ("#");
            }
            else
            {
                something = ("");
            }
            something += ("6");
            six = true;
            anotherBool = false;
            text += something;
            txt = ("M");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.N)) { something = null; someBool = true;
            two = false;
            three = false;
            four = false;
            five = false;
            seven = false;
            eight = false;
            nine = false;
            if (six == true)
            {
                something = ("#");
            }
            else
            {
                something = ("");
            }
            something += ("66");
            six = true;
            anotherBool = false;
            text += something;
            txt = ("N");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.O)) { something = null; someBool = true;
            two = false;
            three = false;
            four = false;
            five = false;
            seven = false;
            eight = false;
            nine = false;
            if (six == true)
            {
                something = ("#");
            }
            else
            {
                something = ("");
            }
            something += ("666");
            six = true;
            anotherBool = false;
            text += something;
            txt = ("O");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.P)) { something = null; someBool = true;
            two = false;
            three = false;
            four = false;
            five = false;
            six = false;
            eight = false;
            nine = false;
            if (seven == true)
            {
                something = ("#");
            }
            else
            {
                something = ("");
            }
            something += ("7");
            seven = true;
            anotherBool = false;
            text += something;
            txt = ("P");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.Q)) { something = null; someBool = true;
            two = false;
            three = false;
            four = false;
            five = false;
            six = false;
            eight = false;
            nine = false;
            if (seven == true)
            {
                something = ("#");
            }
            else
            {
                something = ("");
            }
            something += ("77");
            seven = true;
            anotherBool = false;
            text += something;
            txt = ("Q");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.R)) { something = null; someBool = true;
            two = false;
            three = false;
            four = false;
            five = false;
            six = false;
            eight = false;
            nine = false;
            if (seven == true)
            {
                something = ("#");
            }
            else
            {
                something = ("");
            }
            seven = true;
            something += ("777");
            anotherBool = false;
            text += something;
            txt = ("R");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.S)) { something = null;  someBool = true;
            two = false;
            three = false;
            four = false;
            five = false;
            six = false;
            eight = false;
            nine = false;
            if (seven == true)
            {
                something = ("#");
            }else
            {
                something = ("");
            }
            seven = true;
            something += ("7777");
            anotherBool = false;
            text += something; 
            txt = ("S");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.T)) { something = null;  someBool = true;
            two = false;
            three = false;
            four = false;
            five = false;
            six = false;
            seven = false;
            nine = false;
            if (eight == true)
            {
                something = ("#");
            }
            else
            {
                something = ("");
            }
            eight = true;
            something += ("8");
            anotherBool = false;
            text += something;
            txt = ("T");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.U)) { something = null;  someBool = true;
            two = false;
            three = false;
            four = false;
            five = false;
            six = false;
            seven = false;
            nine = false;
            if (eight == true)
            {
                something = ("#");
            }
            else
            {
                something = ("");
            }
            eight = true;
            something += ("88");
            anotherBool = false;
            text += something;
            txt = ("U");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.V)) { something = null;  someBool = true;
            two = false;
            three = false;
            four = false;
            five = false;
            six = false;
            seven = false;
            nine = false;
            if (eight == true)
            {
                something = ("#");
            }
            else
            {
                something = ("");
            }
            eight = true;
            something += ("888");
            anotherBool = false;
            text += something;
            txt = ("V");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.W)) { something = null;  someBool = true;
            two = false;
            three = false;
            four = false;
            five = false;
            six = false;
            seven = false;
            eight = false;
            if (nine == true)
            {
                something = ("#");
            }
            else
            {
                something = ("");
            }
            nine = true;
            something += ("9");
            anotherBool = false;
            text += something;
            txt = ("W");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.X)) { something = null; someBool = true;
            two = false;
            three = false;
            four = false;
            five = false;
            six = false;
            seven = false;
            eight = false;
            if (nine == true)
            {
                something = ("#");
            }
            else
            {
                something = ("");
            }
            nine = true;
            something += ("99");
            anotherBool = false;
            text += something;
            txt = ("X");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.Y)) { something = null; someBool = true;
            two = false;
            three = false;
            four = false;
            five = false;
            six = false;
            seven = false;
            eight = false;
            if (nine == true)
            {
                something = ("#");
            }
            else
            {
                something = ("");
            }
            nine = true;
            something += ("999");
            anotherBool = false;
            text += something;
            txt = ("Y");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.Z)) { something = null; someBool = true;
            two = false;
            three = false;
            four = false;
            five = false;
            six = false;
            seven = false;
            eight = false;
            if (nine == true)
            {
                something = ("#");
            }
            else
            {
                something = ("");
            }
            nine = true;
            something += ("9999");
            anotherBool = false;
            text += something;
            txt = ("Z");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            something = null; something = ("0"); someBool = true;
            anotherBool = false;
            text += something;
            txt = (" ");
            tekst += txt;
            StartDialogue();
        }
        else if (Input.GetKeyUp(KeyCode.Backspace))
        {
            yeeeee = true;
            StartDialogue();
        }

    }

    void StartDialogue()
    {  
        if (yeeeee == false)
        {
            someBool = false;
            textComponent.text = text + ("/") + tekst;
        }
        else
        {
            yeeeee = false;
            textComponent.text = null;
            text = null;
            tekst = null;
        }
    }
}

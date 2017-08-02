using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text text;

    private enum States { cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, cell_brokenmirror, cell_open, right_path, left_path, cafe, yard, death, freedom };
    private States myState;

    // Use this for initialization
    void Start()
    {
        myState = States.cell;
    }

    // Update is called once per frame
    void Update()
    {
        print(myState);
        if (myState == States.cell)
        {
            State_cell();
        }
        else if (myState == States.sheets_0)
        {
            State_sheets_0();
        }
        else if (myState == States.lock_0)
        {
            State_lock_0();
        }
        else if (myState == States.mirror)
        {
            State_mirror();
        }
        else if (myState == States.cell_mirror)
        {
            State_cell_mirror();
        }
        else if (myState == States.lock_1)
        {
            State_lock_1();
        }
        else if (myState == States.sheets_1)
        {
            State_sheets_1();
        }
        else if (myState == States.cell_brokenmirror)
        {
            State_cell_brokenmirror();
        }
        else if (myState == States.cell_open)
        {
            State_cell_open();
        }
        else if (myState == States.left_path)
        {
            State_left_path();
        }
        else if (myState == States.right_path)
        {
            State_right_path();
        }
        else if (myState == States.cafe)
        {
            State_cafe();
        }
        else if (myState == States.yard)
        {
            State_yard();
        }
        else if (myState == States.death)
        {
            State_death();
        }
        else if (myState == States.freedom)
        {
            State_freedom();
        }
    }

    void State_cell()
    {
        text.text = "You are in a prison cell, and you want to escape. There are " +
                    "some dirty sheets on the bed, a mirror on the wall, and the door " +
                    "is locked from the outside.\n\n" +
                    "Press S to View Sheets, M to look at Mirror and L to look at Lock";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_0;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_0;
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.mirror;
        }

    }

    void State_sheets_0()
    {
        text.text = "I can't believe I've had to sleep on these, " +
                    "the feeling of a clean bed will be a great feeling.\n\n" +
                    "Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }

    }
    void State_lock_0()
    {
        text.text = "The lock looks like I might be able to pick it, " +
                    "if only I could get my hands onto something more narrow?\n\n" +
                    "Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }

    }

    void State_mirror()
    {
        text.text = "Hm, " +
                    "if I break this mirror I might be able to use " +
                    "a peice of the glass to get the hell out of here " +
                    "but I have to protect myself from the glass? \n\n" +
                    "Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }

    }

    void State_cell_mirror()
    {
        text.text = "I might have figured out a way to escape, " +
                    "but I'm still at a loss on " +
                    "how I'm going to break this mirror? " +
                    "There has got to be a way!\n\n" +
                    "Press S to View Sheets, and L to look at Lock";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_1;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_1;
        }

    }

    void State_lock_1()
    {
        text.text = "The lock looks like I might be able to pick it, " +
                    "if only I could get my hands onto something more narrow?\n\n" +
                    "Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }

    }
    void State_sheets_1()
    {
        text.text = "I could us this to wrap around my hand  " +
                    "to protect myself, I just gotta make sure I hit it just right\n\n" +
                    "Press P to pick up your sheet and bash the mirror";

        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.cell_brokenmirror;
        }

    }

    void State_cell_brokenmirror()
    {
        text.text = "That glass was tougher than I thought  " +
                    "good thing I used the sheet. " +
                    "Now I just gotta pick this lock! \n\n" +
                    "Press P to pick up the small shard to pick the door";

        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.cell_open;
        }

    }

    void State_cell_open()
    {
        text.text = "The noise from the glass alerted the guards " +
                    "I gotta make a mad dash out of here!\n\n " +
                    "Press L to Exit Left, and R to Exit Right";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.right_path;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.left_path;
        }

    }

    void State_left_path()
    {
        text.text = "'Guard: And where do you think you’re going!\n\n' " +
                    "The moment I turned left it was over, " +
                    "The guards were all over me I couldn't " +
                    "even make an attempt to run. I was tased on the spot. " +
                    "Maximum security is where I'm headed maybe I'll get " +
                    "my shot again some day....maybe\n\n" +
                    "Game over, press R to retry and escape the Prison " +
                    "If you dare.";


        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }

    }
    void State_right_path()
    {
        text.text = "Guard: He's getting away!\n\n " +
                    "Oh man I'm glad I went right those guards would " +
                    "have been all over me if I would have gone left! " +
                    "Now I just got to make my way outside. " +
                    "I overheard some guards talking about a hole " +
                    "under the fence that happened after the flood " +
                    "Last week, I hope I can find it and fast\n\n " +
                    "Press C to take the patch into the Cafe, " +
                    "Press Y to go into the Yard.";


        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.cafe;
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            myState = States.yard;
        }

    }

    void State_cafe()
    {
        text.text = "The doors to the cafe are lock! " +
                    "This is gonna set me back big time " +
                    "I hope they haven't put the whole place " +
                    "on lock down yet!\n\n" +
                    "Press R to return back to the hallway";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.right_path;
        }
    }

    void State_yard()
    {
        text.text = "Well thankfully the door to the yard was " +
                    "unlocked, I wonder if those guys over there " +
                    "have any idea about this hole in the fence? " +
                    "They look mean as hell, I know most of them " +
                    "are in for murder. It might cut down time " +
                    "but also be a death sentance.\n\n " +
                    "Press W to walk up the gang memeber, Press R to run over to the fence. ";

        if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.death;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.freedom;
        }
    }

    void State_death()
    {
        text.text = "After walking up to the group of guys " +
                    "I realized that the group was the same " +
                    "group I got into a fight with the first day " +
                    "I got into jail. Well they remembered next thing " +
                    "I knew I was getting stabbed and dropped to the floor. " +
                    "I woke up in the ICU cuffed and a officer in the room, " + 
                    "I was caught and on my death bed now I'll never " +
                    "get out.\n\n " +
                    "Game over, press R to retry and escape the Prison " +
                    "If you dare.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void State_freedom()
    {
        text.text = "I made it under the fence just before " +
                    "they seen me. I can't believe I made " +
                    "out of that hell hole but I'm not fully out " +
                    "yet...\n\n " +
                    "To be Continued.\n\n " +
                    "Press R to replay the adventure";
                   

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }

    }
}
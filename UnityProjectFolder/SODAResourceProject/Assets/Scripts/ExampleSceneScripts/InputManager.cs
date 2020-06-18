using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{

    //Parameterized Event Setup
    #region 

    [System.Serializable]
    public class NumericalInputEvent : UnityEvent<float> { } //Create new Parameterized Unity Event type

    [SerializeField]
    public NumericalInputEvent UserInput = new NumericalInputEvent (); //Create new Parameterized Unity Event

    #endregion

    //Non Parameterized Event Setup
    #region 

    [SerializeField]
    UnityEvent killCubes = new UnityEvent (); //New Unity Event to raise when player pressed space key

    [SerializeField]
    UnityEvent respawnCubes = new UnityEvent (); //New Unity Event to raise when player pressed R Key

    #endregion

    // Update is called once per frame
    void Update ()
    {

        //Reading input from numerical keys and invoking our parameterized event with the corresponding value
        #region 

        //Each individual Number Key is being read.... this is just a demo, let me chill lol
        if (Input.GetKeyDown (KeyCode.Alpha1))
        {
            UserInput.Invoke (1f);
        }
        else if (Input.GetKeyDown (KeyCode.Alpha2))
        {
            UserInput.Invoke (2f);
        }
        else if (Input.GetKeyDown (KeyCode.Alpha3))
        {
            UserInput.Invoke (3f);
        }
        else if (Input.GetKeyDown (KeyCode.Alpha4))
        {
            UserInput.Invoke (4f);
        }
        else if (Input.GetKeyDown (KeyCode.Alpha5))
        {
            UserInput.Invoke (5f);
        }
        else if (Input.GetKeyDown (KeyCode.Alpha6))
        {
            UserInput.Invoke (6f);
        }
        else if (Input.GetKeyDown (KeyCode.Alpha7))
        {
            UserInput.Invoke (7f);
        }
        else if (Input.GetKeyDown (KeyCode.Alpha8))
        {
            UserInput.Invoke (8f);
        }
        else if (Input.GetKeyDown (KeyCode.Alpha9))
        {
            UserInput.Invoke (9f);
        }

        #endregion

        //Reading input from space bar & R key and invoking non parameterized event on button down
        #region 

        //If spacebar pressed
        if (Input.GetKeyDown (KeyCode.Space))
        {

            //Raises event
            killCubes.Invoke ();
        }
        else if (Input.GetKeyDown (KeyCode.R))
        {
            Debug.Log ("R pressed");
            respawnCubes.Invoke ();
        }

        #endregion
    }
}
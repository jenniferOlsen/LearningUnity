using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour
{

	public Text text;
	private enum States
	{
		cell,
		mirror,
		sheets_0,
		lock_0,
		cell_mirror,
		sheets_1,
		lock_1,
		freedom}
	;
	private States myState;

	// Use this for initialization
	void Start ()
	{
		myState = States.cell;
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (myState == States.cell) {
			state_cell ();
		} else if (myState == States.sheets_0) {
			state_sheets_0 ();
		} else if (myState == States.mirror) {
			state_mirror ();
		} else if (myState == States.lock_0) {
			state_lock_0 ();
		} else if (myState == States.cell_mirror) {
			state_cell_mirror ();
		} else if (myState == States.lock_1) {
			state_lock_1 ();
		} else if (myState == States.freedom) {
			state_freedom ();
		} else if (myState == States.sheets_1) {
			state_sheets_1 ();
		}
	}
	
	void state_cell ()
	{
		text.text = "You are in a prision cell, and you want to escape. There are  " +
			"some dirty sheets on the bed, a mirror on the wall, and the door " +
			"is locked from the outside.\n\n" +
			"Press S to view Sheets, M to view Mirror, or L to view Lock";
		
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_0;
		}
		if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.mirror;
		}	
		if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.lock_0;
		}			
	}
	
	void state_sheets_0 ()
	{
		text.text = "These sheets are filthy...and useless. \n\n Press R to return to roaming your cell.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}
	}
	
	void state_sheets_1 ()
	{
		text.text = "The mirror doesn't make the sheets look any better. You set it down. \n\n Press R to return to roaming your cell.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}
	}
	
	void state_mirror ()
	{
		text.text = "You admire yourself in the mirror. \n\n Press T to take the mirror. \n\n Press R to return to roaming your cell.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.cell_mirror;
		}
	}
	
	void state_lock_0 ()
	{
		text.text = "Stupid lock. \n\n Press R to return to roaming your cell.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}
	}
	
	void state_lock_1 ()
	{
		text.text = "Hey, if you turn the mirror just so, you can see the combination! \n\n Press O to open the door. \n\n Press R to return to your cell.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		} else if (Input.GetKeyDown (KeyCode.O)) {
			myState = States.freedom;
		}
	}
	
	void state_cell_mirror ()
	{
		text.text = "You've taken the mirror, now what? \n\n Press S to look at the sheets. \n\n Press L to check out the lock.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_1;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.lock_1;
		}
	}
	
	void state_freedom ()
	{
		text.text = "You are FREE!!!. \n\n Press P to play again.";
		if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.cell;
		}
	}
}

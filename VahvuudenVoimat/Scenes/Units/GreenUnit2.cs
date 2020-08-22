using Godot;
using System;

public class GreenUnit2 : Node2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	
	bool selected = false;
	string previousText = "derp";

	// Called when the node enters the scene tree for the first time.

	public override void _Ready()
	{
		GetNode<Button>("Button").Connect("pressed", this, nameof(_OnButtonPressed));
		previousText = GetNode<Label>("Label").Text;
	}

	public void _OnButtonPressed()
	{
		selected = !selected;
		if (selected)
		{

			GetNode<Label>("Label").Text = "selected!";
            GetNode<Sprite>("GreenSprite").Visible = false;
            GetNode<Sprite>("YellowSprite").Visible = true;
        }
		else
		{
            GetNode<Label>("Label").Text = previousText;
            GetNode<Sprite>("GreenSprite").Visible = true;
            GetNode<Sprite>("YellowSprite").Visible = false;
		}

		
	}


//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}

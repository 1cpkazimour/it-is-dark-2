using Godot;
using System;

public partial class TitleScreen : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(Input.IsActionJustPressed("esc"))
		{
			GetTree().Quit();
		}
	}
	
	private void _on_play_pressed()
	{
		GetTree().ChangeSceneToFile("Levels/Test/TestLevel.tscn");
	}


	private void _on_levels_pressed()
	{
		GetTree().ChangeSceneToFile("Menus/Levels.tscn");
	}

}

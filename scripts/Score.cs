using Godot;
using System;

public partial class Score : Control
{
	Label scoreLabel;
	Singleton singleton;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		scoreLabel = GetNode<Label>("Label");
		singleton = GetNode<Singleton>("/root/Singleton");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		scoreLabel.Text = singleton.score.ToString();
	}
}

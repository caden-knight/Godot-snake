using Godot;
using System;

public partial class Apple : Area2D
{
	private Singleton singleton;
	// private Resource cloneScene = ResourceLoader.Load();


	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		singleton = GetNode<Singleton>("/root/Singleton");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}

	private void OnBodyEntered(Node2D body)
	{
		QueueFree();
		singleton.appleCollected = true;
		singleton.createSnakeTail = true;
		singleton.score++;
		singleton.scoreLabel.Text = singleton.score.ToString();
	}
}

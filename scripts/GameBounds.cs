using Godot;
using System;

public partial class GameBounds : Area2D
{
	public Singleton singleton;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		singleton = GetNode<Singleton>("/root/Singleton");
	}

	private void OnBodyEntered(Node2D body)
	{
		body.Position = new Vector2(200, 50);
		singleton.currentDirection = Singleton.Direction.DOWN;
		singleton.score = 0;
	}
}

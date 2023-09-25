using Godot;
using System;

public partial class Apple : Area2D
{
	Singleton singleton;

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
		this.QueueFree();
		singleton.appleCollected = true;
	}
}

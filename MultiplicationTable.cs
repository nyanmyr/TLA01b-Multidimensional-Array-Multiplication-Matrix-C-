using Godot;
using System;

public partial class NewScript : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

		int[ , ] table = new int [10, 10];

		for (int x = 0; x < 10; x++) {
			
			String line = "";
			
			for (int y = 0; y < 10; y++) {
				
				table[x, y] = (x + 1) * (y + 1);
				line = line + (x + 1) + " x " + (y + 1) + " = " + table[x, y].ToString() + "\t";

			}
			
			GD.Print(line);
			GD.Print("");
			
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}
}

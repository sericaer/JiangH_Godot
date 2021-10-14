using Godot;
using JiangHKernels;
using JiangHKernels.Interfaces;
using JiangHGodot.Global;
using JiangHGodot.Mod;
using System;

public class InnerScene : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.

    Facade facade;
    int a = 0;
    public override void _Ready()
    {
        var modMgr = new ModMgr(GlobalPath.mod);

        var mainScene = modMgr.native.LoadScene("Main.tscn").Instance();


        facade = new Facade();
        GetNode("../Global").Call("set_game_object", facade);

        mainScene.Call("set_game_object", facade);

        this.AddChild(mainScene);
    }

    public override void _Process(float delta)
    {
        a++;

        GD.Print(a);
        if (a == 500)
        {
            facade.Changed();
        }

        base._Process(delta);
    }
}



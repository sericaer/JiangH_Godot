using Godot;
using JiangHGodot.Global;
using JiangHGodot.Mod;
using System;

public class InnerScene : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        var modMgr = new ModMgr(GlobalPath.mod);

        var mainScene = modMgr.native.LoadScene("Main.tscn").Instance();

        var tran = new TranObj();
        tran.str = "success2!";
        mainScene.Call("set_label", tran);

        this.AddChild(mainScene);
    }

    public class TranObj : Godot.Object
    {
        public string str;
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}



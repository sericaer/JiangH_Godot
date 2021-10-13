extends Node2D

var gmData
# Declare member variables here. Examples:
# var a = 2
# var b = "text"


# Called when the node enters the scene tree for the first time.
func _ready():
	pass

func set_game_object(gm : Object):
	gmData = gm
	$Player.text = gm.player.name
# Called every frame. 'delta' is the elapsed time since the previous frame.
#func _process(delta):
#	pass

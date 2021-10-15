extends Node

var gmData : Object

var player : GMPlayer setget ,gm_player_get
# Declare member variables here. Examples:
# var a = 2
# var b = "text"

func gm_player_get():
	return gmData.player
	
# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.

func set_game_object(gm : Object):
	gmData = gm
	
# Called every frame. 'delta' is the elapsed time since the previous frame.
#func _process(delta):
#	pass

class GMPlayer:
	var full_name : String
	
	func get_businesses()->Array:
		return []
	


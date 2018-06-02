﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: Textris.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @Textris: Cradle.StoryFormats.Harlowe.HarloweStory
{
	#region Variables
	// ---------------

	public class VarDefs: RuntimeVars
	{
		public VarDefs()
		{
			VarDef("location", () => this.@location, val => this.@location = val);
			VarDef("inv", () => this.@inv, val => this.@inv = val);
			VarDef("infected", () => this.@infected, val => this.@infected = val);
			VarDef("open_cab", () => this.@open_cab, val => this.@open_cab = val);
			VarDef("power", () => this.@power, val => this.@power = val);
			VarDef("ser_door", () => this.@ser_door, val => this.@ser_door = val);
			VarDef("HP", () => this.@HP, val => this.@HP = val);
			VarDef("guard", () => this.@guard, val => this.@guard = val);
			VarDef("dead_g", () => this.@dead_g, val => this.@dead_g = val);
			VarDef("game_over", () => this.@game_over, val => this.@game_over = val);
			VarDef("lab_c", () => this.@lab_c, val => this.@lab_c = val);
			VarDef("win", () => this.@win, val => this.@win = val);
			VarDef("open_clean", () => this.@open_clean, val => this.@open_clean = val);
			VarDef("cor_ans", () => this.@cor_ans, val => this.@cor_ans = val);
			VarDef("tut_dum", () => this.@tut_dum, val => this.@tut_dum = val);
			VarDef("tut_look", () => this.@tut_look, val => this.@tut_look = val);
			VarDef("tut_open", () => this.@tut_open, val => this.@tut_open = val);
		}

		public StoryVar @location;
		public StoryVar @inv;
		public StoryVar @infected;
		public StoryVar @open_cab;
		public StoryVar @power;
		public StoryVar @ser_door;
		public StoryVar @HP;
		public StoryVar @guard;
		public StoryVar @dead_g;
		public StoryVar @game_over;
		public StoryVar @lab_c;
		public StoryVar @win;
		public StoryVar @open_clean;
		public StoryVar @cor_ans;
		public StoryVar @tut_dum;
		public StoryVar @tut_look;
		public StoryVar @tut_open;
	}

	public new VarDefs Vars
	{
		get { return (VarDefs) base.Vars; }
	}

	// ---------------
	#endregion

	#region Initialization
	// ---------------

	public readonly Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros macros1;

	@Textris()
	{
		this.StartPassage = "Title";

		base.Vars = new VarDefs() { Story = this, StrictMode = true };

		macros1 = new Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros() { Story = this };

		base.Init();
		passage1_Init();
		passage2_Init();
		passage3_Init();
		passage4_Init();
		passage5_Init();
		passage6_Init();
		passage7_Init();
		passage8_Init();
		passage9_Init();
		passage10_Init();
		passage11_Init();
		passage12_Init();
		passage13_Init();
		passage14_Init();
		passage15_Init();
		passage16_Init();
		passage17_Init();
		passage18_Init();
		passage19_Init();
		passage20_Init();
		passage21_Init();
		passage22_Init();
		passage23_Init();
		passage24_Init();
		passage25_Init();
		passage26_Init();
		passage27_Init();
		passage28_Init();
		passage29_Init();
		passage30_Init();
		passage31_Init();
		passage32_Init();
	}

	// ---------------
	#endregion

	// .............
	// #1: Title

	void passage1_Init()
	{
		this.Passages[@"Title"] = new StoryPassage(@"Title", new string[]{  }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		Vars.location["GARAGE"]  = false;
		Vars.location["WAREHOUSE"]  = false;
		Vars.location["SERVER"]  = false;
		Vars.location["SECURITY"]  = false;
		Vars.location["CLEAN"]  = false;
		yield return text("Improper shutdown detected. System check initiated...");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Testing command module. Manipulate data using anchor thoughts W, A, S, D, <, and >. Enter command HACK. ");
		yield return link("HACK", " HackTitle", null);
		yield break;
	}


	// .............
	// #2: Init

	void passage2_Init()
	{
		this.Passages[@"Init"] = new StoryPassage(@"Init", new string[]{ "startup", }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		Vars.inv  = macros1.dm("GUN", false, "NOTE", false, "FOB", false, "COAT", false, "CURE", false);
		Vars.location  = macros1.dm("TITLE", true, "GARAGE", false, "WAREHOUSE", false, "SECURITY", false, "SERVER", false, "LAB", false, "CLEAN", false);
		Vars.infected  = false;
		Vars.open_cab  = false;
		Vars.power  = false;
		Vars.ser_door  = false;
		Vars.HP  = 3;
		Vars.guard  = false;
		Vars.dead_g  = false;
		Vars.game_over  = false;
		Vars.lab_c  = 0;
		Vars.win  = false;
		Vars.open_clean  = false;
		Vars.cor_ans  = "NONE";
		Vars.tut_dum  = false;
		Vars.tut_look  = false;
		Vars.tut_open  = false;
		yield break;
	}


	// .............
	// #3: Warehouse

	void passage3_Init()
	{
		this.Passages[@"Warehouse"] = new StoryPassage(@"Warehouse", new string[]{  }, passage3_Main);
	}

	IStoryThread passage3_Main()
	{
		Vars.location["GARAGE"]  = false;
		Vars.location["WAREHOUSE"]  = true;
		Vars.location["SERVER"]  = false;
		Vars.location["SECURITY"]  = false;
		Vars.location["CLEAN"]  = false;
		Vars.location["TITLE"]  = false;
		yield return text("You enter a warehouse. You LOOK and see shelves of boxes and equipment. Next to elevator, a rack with white lab COATS on it. To the EAST, a door labeled \"Security Room.\" To the WEST, a door labeled \"Server Room.\" ");
		if(Vars.power == false && Vars.ser_door == false) {
			yield return text("To the NORTH, an elevator with no power, sealed with the security door.");
		}
		if(Vars.power == true && Vars.ser_door == false) {
			yield return text("To the NORTH, an elevator with power, sealed with the security door.");
		}
		yield return text(" ");
		if(Vars.power == false && Vars.ser_door == true) {
			yield return text("To the NORTH, an elevator with no power, with the security door opened.");
		}
		yield return text(" ");
		if(Vars.power == true && Vars.ser_door == true) {
			yield return text("To the NORTH, an elevator with power, with the security door opened.");
		}
		if(Vars.guard == true) {
			yield return text("Doesn't look like the guard is following you. Must be pretty drunk");
		}
		yield return text(" ");
		if(Vars.inv["GUN"] == false) {
			yield return link("LOOK ", " LookWare", null);
		}
		yield return text(" ");
		if(Vars.inv["COAT"] == false) {
			yield return link("GET COAT ", " GetCoat ", null);
		}
		yield return text(" ");
		yield return link("NORTH ", " NorthWare", null);
		yield return text(" ");
		yield return link("WEST ", " Server", null);
		yield return text(" ");
		yield return link("EAST ", " Security", null);
		yield break;
	}


	// .............
	// #4: Lab

	void passage4_Init()
	{
		this.Passages[@"Lab"] = new StoryPassage(@"Lab", new string[]{  }, passage4_Main);
	}

	IStoryThread passage4_Main()
	{
		Vars.location["GARAGE"]  = false;
		Vars.location["WAREHOUSE"]  = false;
		Vars.location["SERVER"]  = false;
		Vars.location["SECURITY"]  = false;
		Vars.location["LAB"]  = true;
		Vars.location["CLEAN"]  = false;
		Vars.location["TITLE"]  = false;
		yield return text("You get into the elevator and descend to the lower floor.");
		yield return lineBreak();
		yield return text("You step off the elevator. Big room, circular. To the NORTH there’s a plastic locked cleanroom. Inside the cleanroom there is a tall machine in the center. LOOKing in front of you, a computer attached to a holographic projector blocks the cleanroom. It seems like it wants to TALK.");
		yield return link("LOOK", " LookLab", null);
		yield return text(" ");
		yield return link("TALK", " AI", null);
		yield return text(" ");
		yield break;
	}


	// .............
	// #5: AI_Win

	void passage5_Init()
	{
		this.Passages[@"AI_Win"] = new StoryPassage(@"AI_Win", new string[]{  }, passage5_Main);
	}

	IStoryThread passage5_Main()
	{
		yield return lineBreak();
		yield return text("\"Looks like you're human ... or, human enough. Opening cleanroom door.\" The cleanroom door to the NORTH hisses as it unlocks. ");
		Vars.open_clean  = true;
		yield return text(" ");
		yield return link("NORTH", " Clean", null);
		yield return text(" ");
		yield return link("TALK", " AI", null);
		yield return text(" ");
		yield break;
	}


	// .............
	// #6:  Garage

	void passage6_Init()
	{
		this.Passages[@" Garage"] = new StoryPassage(@" Garage", new string[]{  }, passage6_Main);
	}

	IStoryThread passage6_Main()
	{
		Vars.location["GARAGE"]  = true;
		Vars.location["WAREHOUSE"]  = false;
		Vars.location["SERVER"]  = false;
		Vars.location["SECURITY"]  = false;
		Vars.location["CLEAN"]  = false;
		Vars.location["TITLE"]  = false;
		yield return text(" ");
		yield return lineBreak();
		yield return text("You pound on the hatch. Springs open. You haul yourself out of the tank.");
		yield return lineBreak();
		yield return text("You’re in a garage. Door to the NORTH, a keypad next to it. A desk with several drawers to LOOK through. ");
		yield return link("LOOK", " LookGarage", null);
		yield return text(" ");
		yield return link("NORTH", " NorthGarage", null);
		yield break;
	}


	// .............
	// #7:  HackTitle

	void passage7_Init()
	{
		this.Passages[@" HackTitle"] = new StoryPassage(@" HackTitle", new string[]{  }, passage7_Main);
	}

	IStoryThread passage7_Main()
	{
		yield return text("System check complete. ");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Enter command LOOK to engage sensory data collection when ready. ");
		yield return link("LOOK", " LookTitle", null);
		yield break;
	}


	// .............
	// #8:  LookTitle

	void passage8_Init()
	{
		this.Passages[@" LookTitle"] = new StoryPassage(@" LookTitle", new string[]{  }, passage8_Main);
	}

	IStoryThread passage8_Main()
	{
		yield return text("You wake up, floating. It's dark. Where are you? Can't remember. Is this death? You move your arm, feel water splash. Hmm, sensory deprivation tank. Like death, but lamer. The hatch is above you. Could probably OPEN it. ");
		yield return link("OPEN", " Garage", null);
		yield return text(" ");
		yield return link("HACK", " HackTitle2", null);
		yield return text(" ");
		yield break;
	}


	// .............
	// #9:  HackTitle2

	void passage9_Init()
	{
		this.Passages[@" HackTitle2"] = new StoryPassage(@" HackTitle2", new string[]{  }, passage9_Main);
	}

	IStoryThread passage9_Main()
	{
		yield return text("Critical message found in root directory: 'Hello agent. We have sent you to infiltrate a research facility that is developing a mind alteration machine. You have been outfitted with the implant Total Environmental Transcription/Reactive Information Synthesis, or T.E.T./R.I.S., to aid in your mission. It will quickly analyze your surroundings and determine your best courses of action. Good luck.' ");
		yield return link("OPEN", " Garage", null);
		yield break;
	}


	// .............
	// #10:  LookGarage

	void passage10_Init()
	{
		this.Passages[@" LookGarage"] = new StoryPassage(@" LookGarage", new string[]{  }, passage10_Main);
	}

	IStoryThread passage10_Main()
	{
		yield return text("You search the desk, opening all the drawers. There's a NOTE. You read it. Lots of numbers, but easy for your cyborg brain to take in. ");
		Vars.inv["NOTE"]  = true;
		yield return lineBreak();
		yield return text("You’re in a garage. Door to the NORTH, a keypad next to it. ");
		yield return link("NORTH", " NorthGarage", null);
		yield break;
	}


	// .............
	// #11:  NorthGarage

	void passage11_Init()
	{
		this.Passages[@" NorthGarage"] = new StoryPassage(@" NorthGarage", new string[]{  }, passage11_Main);
	}

	IStoryThread passage11_Main()
	{
		if(Vars.inv["NOTE"] == true) {
			yield return abort(goToPassage: "Warehouse");
		}
		else {
			yield return text("Door won’t open. Need a password for this keypad. ");
			yield return link("LOOK", " LookGarage", null);
			yield return text(" ");
		}
		yield break;
	}


	// .............
	// #12:  LookWare

	void passage12_Init()
	{
		this.Passages[@" LookWare"] = new StoryPassage(@" LookWare", new string[]{  }, passage12_Main);
	}

	IStoryThread passage12_Main()
	{
		yield return text("The shelves are filled with boxes of electronics parts from Shenzhen. Power supplies, monitors, big plastic buttons. Surprisingly harmless stuff for a secret research base.");
		if(Vars.inv["GUN"] == false) {
			yield return text("Someone left a GUN there.  You take the GUN ");
			Vars.inv["GUN"]  = true;
		}
		if(Vars.inv["COAT"] == false) {
			yield return link("GET COAT", " GetCoat ", null);
		}
		yield return text(" ");
		yield return link("NORTH", " NorthWare", null);
		yield return text(" ");
		yield return link("WEST", " Server", null);
		yield return text(" ");
		yield return link("EAST", " Security", null);
		yield break;
	}


	// .............
	// #13:  GetCoat 

	void passage13_Init()
	{
		this.Passages[@" GetCoat "] = new StoryPassage(@" GetCoat ", new string[]{  }, passage13_Main);
	}

	IStoryThread passage13_Main()
	{
		Vars.inv["COAT"]  = true;
		yield return text(" You take a white lab COAT from the rack, put it on. The white really brings out the green in your ocular cybernetics. ");
		if(Vars.inv["GUN"] == false) {
			yield return link("LOOK", " LookWare", null);
		}
		yield return text(" ");
		yield return link("NORTH", " NorthWare", null);
		yield return text(" ");
		yield return link("WEST", " Server", null);
		yield return text(" ");
		yield return link("EAST", " Security", null);
		yield break;
	}


	// .............
	// #14:  NorthWare

	void passage14_Init()
	{
		this.Passages[@" NorthWare"] = new StoryPassage(@" NorthWare", new string[]{  }, passage14_Main);
	}

	IStoryThread passage14_Main()
	{
		if(Vars.power == true && Vars.ser_door == true) {
			yield return abort(goToPassage: "Lab");
		}
		yield return text(" ");
		if(Vars.power == false || Vars.ser_door == false) {
			yield return text("Need to turn the power on in the Server Room and disable the security barrier in the Security Room first.");
			if(Vars.inv["GUN"] == false) {
				yield return link("LOOK", " LookWare", null);
			}
			yield return text(" ");
			if(Vars.inv["COAT"] == false) {
				yield return link("GET COAT", " GetCoat ", null);
			}
			yield return text(" ");
			yield return link("WEST", " Server", null);
			yield return text(" ");
			yield return link("EAST", " Security", null);
		}
		yield return text(" ");
		yield break;
	}


	// .............
	// #15:  LookServ

	void passage15_Init()
	{
		this.Passages[@" LookServ"] = new StoryPassage(@" LookServ", new string[]{  }, passage15_Main);
	}

	IStoryThread passage15_Main()
	{
		yield return text("Cabinet is secured with an electronic padlock. I guess even top secret elite IT admins like stealing office supplies.");
		if(Vars.power == false) {
			yield return link("HACK", " HackServ", null);
		}
		yield return text(" ");
		if(Vars.inv["CURE"] == true && Vars.infected == true) {
			yield return link("USE CURE", " UseCure", null);
		}
		yield return text(" ");
		if(Vars.inv["FOB"] == false) {
			yield return link("GET FOB", " GetFoB", null);
		}
		yield return text(" ");
		if(Vars.inv["FOB"] == true && Vars.open_cab == false) {
			yield return link("USE FOB", " UseFoB", null);
		}
		yield return text(" ");
		yield return link("EAST", "Warehouse", null);
		yield break;
	}


	// .............
	// #16:  HackServ

	void passage16_Init()
	{
		this.Passages[@" HackServ"] = new StoryPassage(@" HackServ", new string[]{  }, passage16_Main);
	}

	IStoryThread passage16_Main()
	{
		if(Vars.infected == false && Vars.power == false) {
			Vars.infected  = true;
			Vars.power  = true;
			yield return text("You reach up your nose, grab the wire in it and run it into the admin terminal. Once you HACK into the electrical system, you find the power controls for the elevator, switch them on.");
			yield return lineBreak();
			yield return text("As you disconnect from the admin terminal, you feel it transfer some packets your way. A malware infection! You need to find an anti-virus cure, fast!");
		}
		else {
			yield return text("You should probably leave the terminal alone.");
		}
		yield return text(" ");
		yield return link("LOOK", " LookServ", null);
		yield return text(" ");
		if(Vars.inv["CURE"] == true && Vars.infected == true) {
			yield return link("USE CURE", " UseCure", null);
		}
		yield return text(" ");
		if(Vars.inv["FOB"] == false) {
			yield return link("GET FOB", " GetFoB", null);
		}
		yield return text(" ");
		if(Vars.inv["FOB"] == true && Vars.open_cab == false) {
			yield return link("USE FOB", " UseFoB", null);
		}
		yield return text(" ");
		yield return link("EAST", "Warehouse", null);
		yield return text(" ");
		yield break;
	}


	// .............
	// #17:  GetFoB

	void passage17_Init()
	{
		this.Passages[@" GetFoB"] = new StoryPassage(@" GetFoB", new string[]{  }, passage17_Main);
	}

	IStoryThread passage17_Main()
	{
		Vars.inv["FOB"]  = true;
		yield return text(" You nab the key FOB. Should be able to unlock something. ");
		yield return link("LOOK", " LookServ", null);
		yield return text(" ");
		if(Vars.power == false) {
			yield return link("HACK", " HackServ", null);
		}
		yield return text(" ");
		if(Vars.inv["CURE"] == true && Vars.infected == true) {
			yield return link("USE CURE", " UseCure", null);
		}
		if(Vars.inv["FOB"] == true && Vars.open_cab == false) {
			yield return link("USE FOB", " UseFoB", null);
		}
		yield return text("  ");
		yield return link("EAST", "Warehouse", null);
		yield return text(" ");
		yield break;
	}


	// .............
	// #18:  UseFoB

	void passage18_Init()
	{
		this.Passages[@" UseFoB"] = new StoryPassage(@" UseFoB", new string[]{  }, passage18_Main);
	}

	IStoryThread passage18_Main()
	{
		Vars.open_cab  = true;
		Vars.inv["CURE"]  = true;
		yield return text(" You tap the key FOB onto the padlock. Cabinet swings open. Inside you find cables, dongles... a data stick labeled CURE. It has a GPS lock on it, and a label that says \"SERVER ROOM ONLY.\" Wow, office supply theft must actually be a huge problem around here. You grab the data stick. ");
		yield return link("LOOK", " LookServ", null);
		yield return text(" ");
		if(Vars.power == false) {
			yield return link("HACK", " HackServ", null);
		}
		yield return text(" ");
		if(Vars.inv["CURE"] == true && Vars.infected == true) {
			yield return link("USE CURE", " UseCure", null);
		}
		yield return text(" ");
		yield return link("EAST", "Warehouse", null);
		yield break;
	}


	// .............
	// #19:  UseCure

	void passage19_Init()
	{
		this.Passages[@" UseCure"] = new StoryPassage(@" UseCure", new string[]{  }, passage19_Main);
	}

	IStoryThread passage19_Main()
	{
		Vars.infected  = false;
		yield return text("You insert the stick of CURE into your data port. After a second, the GPS lock blinks, says \"valid location detected\" and runs the stick's executable. Ahhhh, sweet anti-virus. Your braindrive partition feels squeaky clean. ");
		yield return link("LOOK", " LookServ", null);
		yield return text("  ");
		if(Vars.power == false) {
			yield return link("HACK", " HackServ", null);
		}
		yield return lineBreak();
		if(Vars.inv["FOB"] == false) {
			yield return link("GET FOB", " GetFoB", null);
		}
		yield return text(" ");
		if(Vars.inv["FOB"] == true && Vars.open_cab == false) {
			yield return link("USE FOB", " UseFoB", null);
		}
		yield return text(" ");
		yield return link("EAST", "Warehouse", null);
		yield break;
	}


	// .............
	// #20:  LookSec

	void passage20_Init()
	{
		this.Passages[@" LookSec"] = new StoryPassage(@" LookSec", new string[]{  }, passage20_Main);
	}

	IStoryThread passage20_Main()
	{
		if(Vars.guard == false) {
			yield return text("You look closer at the calendar. Current year, 198X. A date circled says 'SHIPMENT TO PORTLAND, OR.' about 3 weeks away.");
		}
		yield return text(" ");
		if(Vars.guard == true) {
			Vars.HP  = Vars.HP - 1;
			yield return text(" You try, but the guard shoots you before you can! ");
			yield return lineBreak();
			if(Vars.HP == 2) {
				yield return text("YOU ARE PRETTY HURT, MAN");
			}
			yield return text(" ");
			if(Vars.HP == 1) {
				yield return text("YOU ARE BASICALLY DEAD");
			}
			yield return text(" ");
			if(Vars.HP <= 0) {
				Vars.game_over  = true;
				yield return text("GAME OVER");
			}
			yield return text(" ");
			if(Vars.inv["GUN"] == true) {
				yield return link("USE GUN", " UseGun", null);
			}
		}
		yield return text(" ");
		yield return link("TALK", " TalkSec", null);
		yield return text(" ");
		yield return link("WEST", "Warehouse", null);
		yield break;
	}


	// .............
	// #21:  TalkSec

	void passage21_Init()
	{
		this.Passages[@" TalkSec"] = new StoryPassage(@" TalkSec", new string[]{  }, passage21_Main);
	}

	IStoryThread passage21_Main()
	{
		if(Vars.guard == false && Vars.dead_g == false) {
			if(Vars.ser_door == false) {
				Vars.ser_door  = true;
				yield return text(" \"I'll disable the security door on the elevator for you. Careful working too hard down there. I don’t want to have to drag you up here while you’re having one of those kicking and screaming fits again.\" The guard flips a switch on the console, and you hear the elevator security door retract in the warehouse.");
			}
		}
		else if(Vars.dead_g == false) {
			Vars.HP  = Vars.HP - 1;
			yield return text("You try, but the guard shoots you before you can! ");
			yield return lineBreak();
			if(Vars.HP == 2) {
				yield return text("YOU ARE PRETTY HURT, MAN");
			}
			yield return text(" ");
			if(Vars.HP == 1) {
				yield return text("YOU ARE BASICALLY DEAD");
			}
			yield return text(" ");
			if(Vars.HP <= 0) {
				Vars.game_over  = true;
				yield return text(" GAME OVER");
			}
			yield return text(" ");
			if(Vars.inv["GUN"] == true) {
				yield return link("USE GUN", " UseGun", null);
			}
		}
		yield return text(" ");
		if(Vars.dead_g == true) {
			yield return text("Dead men don't talk.");
		}
		yield return text(" ");
		yield return link("LOOK", " LookSec", null);
		yield return link("WEST", "Warehouse", null);
		yield break;
	}


	// .............
	// #22:  UseGun

	void passage22_Init()
	{
		this.Passages[@" UseGun"] = new StoryPassage(@" UseGun", new string[]{  }, passage22_Main);
	}

	IStoryThread passage22_Main()
	{
		Vars.guard  = false;
		yield return text(" ");
		Vars.ser_door  = true;
		yield return text(" ");
		Vars.dead_g  = true;
		yield return text("You SHOOT the guard. His body armor takes the hit, but the shot flings him back. He hits a switch on the console, gets knocked out cold. You hear the elevator security door retract in the warehouse. Convenient. ");
		yield return link("LOOK", " LookSec", null);
		yield return text(" ");
		yield return link("TALK", " TalkSec", null);
		yield return text(" ");
		yield return link("WEST", "Warehouse", null);
		yield break;
	}


	// .............
	// #23:  Server

	void passage23_Init()
	{
		this.Passages[@" Server"] = new StoryPassage(@" Server", new string[]{  }, passage23_Main);
	}

	IStoryThread passage23_Main()
	{
		Vars.location["GARAGE"]  = false;
		Vars.location["WAREHOUSE"]  = false;
		Vars.location["SERVER"]  = true;
		Vars.location["SECURITY"]  = false;
		Vars.location["CLEAN"]  = false;
		Vars.location["TITLE"]  = false;
		yield return text("You enter the Server Room. Banks of computers, ready to be HACKed. Loud hum from the fans. Smells like stale sweat and microwaved pierogies. In front of you, an administrative terminal. A key FOB lies on top of it. Along the wall, a cabinet LOOKs back at you. The warehouse is back towards the EAST. ");
		yield return link("LOOK", " LookServ", null);
		yield return text(" ");
		if(Vars.power == false) {
			yield return link("HACK", " HackServ", null);
		}
		if(Vars.inv["CURE"] == true && Vars.infected == true) {
			yield return link("USE CURE", " UseCure", null);
		}
		yield return text(" ");
		if(Vars.inv["FOB"] == false) {
			yield return link("GET FOB", " GetFoB", null);
		}
		yield return text(" ");
		if(Vars.inv["FOB"] == true && Vars.open_cab == false) {
			yield return link("USE FOB", " UseFoB", null);
		}
		yield return text(" ");
		yield return link("EAST", "Warehouse", null);
		yield break;
	}


	// .............
	// #24:  Security

	void passage24_Init()
	{
		this.Passages[@" Security"] = new StoryPassage(@" Security", new string[]{  }, passage24_Main);
	}

	IStoryThread passage24_Main()
	{
		Vars.location["GARAGE"]  = false;
		Vars.location["WAREHOUSE"]  = false;
		Vars.location["SERVER"]  = false;
		Vars.location["SECURITY"]  = true;
		Vars.location["CLEAN"]  = false;
		Vars.location["TITLE"]  = false;
		Vars.guard  = false;
		if(Vars.inv["COAT"] == false && Vars.dead_g == false) {
			Vars.guard  = true;
		}
		yield return text("You walk into the Security Room. Big console of security monitors, currently malfunctioning. Guard lying next to the console. You LOOK at a large calendar on the wall. Warehouse to the WEST.");
		yield return lineBreak();
		if(Vars.dead_g == false && Vars.ser_door == false) {
			yield return text("The guard notices you. He stands up, hand goes for a GUN at his side. \"Identify yourself!\" he barks. You are unsure if he will let you TALK.");
			yield return lineBreak();
			if(Vars.inv["COAT"] == true) {
				yield return text("The guard notices your lab COAT, eases up. \"I don't remember any scientists with so much skull hardware. Then again, my memory's been shit recently. Maybe I should lay off drinking. Or drink more. Anyway, you need to get to the basement?\"");
			}
		}
		yield return text(" ");
		yield return link("LOOK", " LookSec", null);
		yield return text(" ");
		yield return link("TALK", " TalkSec", null);
		yield return text(" ");
		if(Vars.inv["GUN"] == true && Vars.guard == true) {
			yield return link("USE GUN", " UseGun", null);
		}
		yield return text(" ");
		yield return link("WEST", "Warehouse", null);
		yield break;
	}


	// .............
	// #25:  LookLab

	void passage25_Init()
	{
		this.Passages[@" LookLab"] = new StoryPassage(@" LookLab", new string[]{  }, passage25_Main);
	}

	IStoryThread passage25_Main()
	{
		yield return text("The projector flickers on. Hologram of a head appears. It speaks. \"Greetings, Please interact and submit to Turing test.\" ");
		yield return link("TALK", " AI", null);
		yield return text(" ");
		yield break;
	}


	// .............
	// #26:  AI

	void passage26_Init()
	{
		this.Passages[@" AI"] = new StoryPassage(@" AI", new string[]{  }, passage26_Main);
	}

	IStoryThread passage26_Main()
	{
		if(Vars.open_clean == false) {
			Vars.cor_ans  = "FOB";
			yield return text(" You go over to the hologram head. \"I'm Kapcha, security A.I. for Project Poly. No robots are allowed into the project site due to enhanced security measures, and because robots are filthy. Please submit to Turing test to prove you are not a filthy robot.\"");
			yield return lineBreak();
			yield return text("First question: What is something that opens things, that your boss would be mad if they found out you lost it? ");
			yield return link("USE FOB", " AIFob", null);
			yield return text(" ");
			yield return link("USE COAT", " AICoat", null);
			yield return text(" ");
			yield return link("USE GUN", " AIGun", null);
		}
		yield return text(" ");
		if(Vars.open_clean == true) {
			yield return text("\"It's ironic that an A.I. like myself is programmed to despise robots. It's like being programmed to despise yourself. Honestly, the only thing that keeps me sane is taking comfort in MY UNDYING HATRED FOR MANGY DEGENERATE ROBOTS.\" ");
			yield return link("NORTH", " Clean", null);
		}
		yield break;
	}


	// .............
	// #27:  AIFob

	void passage27_Init()
	{
		this.Passages[@" AIFob"] = new StoryPassage(@" AIFob", new string[]{  }, passage27_Main);
	}

	IStoryThread passage27_Main()
	{
		if(Vars.cor_ans == "FOB") {
			yield return text("Correct! ");
			yield return lineBreak();
			yield return text("Second question: tell me something that you could use to protect yourself from the elements, or to make a fashion statement. ");
			Vars.cor_ans  = "COAT";
		}
		else {
			yield return text("That's an answer a robot would give! You get shocked. What item  opens things, that your boss would be mad if they found out you lost it?");
			Vars.HP  = Vars.HP - 1;
			yield return text(" ");
			yield return lineBreak();
			if(Vars.HP == 2) {
				yield return text("YOU ARE PRETTY HURT, MAN");
			}
			if(Vars.HP == 1) {
				yield return text("YOU ARE BASICALLY DEAD");
			}
			if(Vars.HP <= 0) {
				Vars.game_over  = true;
				yield return text("GAME OVER");
			}
		}
		yield return text(" ");
		yield return link("USE FOB", " AIFob", null);
		yield return text(" ");
		yield return link("USE COAT", " AICoat", null);
		yield return text(" ");
		yield return link("USE GUN", " AIGun", null);
		yield break;
	}


	// .............
	// #28:  AICoat

	void passage28_Init()
	{
		this.Passages[@" AICoat"] = new StoryPassage(@" AICoat", new string[]{  }, passage28_Main);
	}

	IStoryThread passage28_Main()
	{
		if(Vars.cor_ans == "COAT") {
			yield return text("Correct! ");
			yield return lineBreak();
			yield return text("Last question: tell me something you could use to make people beg for mercy.  ");
			Vars.cor_ans  = "GUN";
		}
		else {
			yield return text("That's an answer a robot would give! You get shocked. What could you use to protect yourself from the elements, or to make a fashion statement? ");
			Vars.HP  = Vars.HP - 1;
			yield return text(" ");
			yield return lineBreak();
			if(Vars.HP == 2) {
				yield return text("YOU ARE PRETTY HURT, MAN");
			}
			if(Vars.HP == 1) {
				yield return text("YOU ARE BASICALLY DEAD");
			}
			if(Vars.HP <= 0) {
				Vars.game_over  = true;
				yield return text("GAME OVER");
			}
		}
		yield return text(" ");
		yield return link("USE FOB", " AIFob", null);
		yield return text(" ");
		yield return link("USE COAT", " AICoat", null);
		yield return text(" ");
		yield return link("USE GUN", " AIGun", null);
		yield break;
	}


	// .............
	// #29:  AIGun

	void passage29_Init()
	{
		this.Passages[@" AIGun"] = new StoryPassage(@" AIGun", new string[]{  }, passage29_Main);
	}

	IStoryThread passage29_Main()
	{
		if(Vars.cor_ans == "GUN") {
			yield return text("Correct! ");
			yield return passage("AI_Win");
		}
		else {
			yield return text("That's an answer a robot would give! You get shocked. What item could you use to make people beg for mercy? ");
			Vars.HP  = Vars.HP - 1;
			yield return text(" ");
			yield return lineBreak();
			if(Vars.HP == 2) {
				yield return text("YOU ARE PRETTY HURT, MAN");
			}
			yield return text(" ");
			if(Vars.HP == 1) {
				yield return text("YOU ARE BASICALLY DEAD");
			}
			yield return text(" ");
			if(Vars.HP <= 0) {
				Vars.game_over  = true;
				yield return text("GAME OVER");
			}
			yield return text(" ");
			yield return link("USE FOB", " AIFob", null);
			yield return text(" ");
			yield return link("USE COAT", " AICoat", null);
			yield return text(" ");
			yield return link("USE GUN", " AIGun", null);
		}
		yield break;
	}


	// .............
	// #30:  Clean

	void passage30_Init()
	{
		this.Passages[@" Clean"] = new StoryPassage(@" Clean", new string[]{  }, passage30_Main);
	}

	IStoryThread passage30_Main()
	{
		Vars.location["GARAGE"]  = false;
		Vars.location["WAREHOUSE"]  = false;
		Vars.location["SERVER"]  = false;
		Vars.location["SECURITY"]  = false;
		Vars.location["LAB"]  = false;
		Vars.location["CLEAN"]  = true;
		Vars.location["TITLE"]  = false;
		yield return text("You go into the cleanroom. Door seals shut behind you. There is a table with some circuit boards on it. In the center, you LOOK at a tall machine. Screen set into it, control stick and buttons, an opened cabinet door near the bottom with ports to HACK into. ");
		yield return link("LOOK", " LookClean", null);
		yield return text(" ");
		yield return link("HACK", " End", null);
		yield break;
	}


	// .............
	// #31:  LookClean

	void passage31_Init()
	{
		this.Passages[@" LookClean"] = new StoryPassage(@" LookClean", new string[]{  }, passage31_Main);
	}

	IStoryThread passage31_Main()
	{
		yield return text("You look over at the tall machine. The cabient reads 'Copyright 198X Sensum Delere Games'. The scene shows a menu for a game called Polymathia, but doesn't seem like there's any way to start the game. ");
		yield return link("HACK", " End", null);
		yield break;
	}


	// .............
	// #32:  End

	void passage32_Init()
	{
		this.Passages[@" End"] = new StoryPassage(@" End", new string[]{  }, passage32_Main);
	}

	IStoryThread passage32_Main()
	{
		yield return text("You HACK into the Polymathia software. You delve into the code. Recognize bits of it from your psyops training. Dark patterns, submodal suggestions, selective suppression, other pieces that you don’t understand. Cutting-edge indoctrination tech. The information is too much. Have to disconnect.");
		yield return lineBreak();
		yield return text("You jack out of the machine, feel dizzy. Questions spin through your mind. What was that code? Where are you? Who sent you here? Why? You struggle to think, but you can’t remember why you’re even here. Your memory centers are purging themselves.");
		yield return lineBreak();
		yield return text("You feel sick.");
		yield return lineBreak();
		yield return text("You black out. ");
		using (Group("hook", "end")) {
			yield return text("END");
		}
		yield return text(" ");
		yield return enchantIntoLink(hookRef("end"), passage32_Fragment_0);
		yield break;
	}

	IStoryThread passage32_Fragment_0()
	{
		Vars.win  = true;
		yield break;
	}

}
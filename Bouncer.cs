using Godot;
using System;
using System.Collections.Generic;
public class Bouncer : KinematicBody2D
{
    private List<NPCDialogue> npcDialogue;
    private string npcName;
    public override void _Ready()
    {
        npcName="Bouncer";
        // InterfaceSelectionObject obj = new InterfaceSelectionObject(1,"Welcome");
        // InterfaceSelectionObject obj2= new InterfaceSelectionObject(2,"Hello");
        // InterfaceSelectionObject obj3= new InterfaceSelectionObject(-1,"What is gucci fam");
        // npcDialogue=new List<NPCDialogue>{
        //     new NPCDialogue(new List<InterfaceSelectionObject>{obj, obj2}, "#relatable",0),
        //     new NPCDialogue(new List<InterfaceSelectionObject>{obj2,obj3}, "your welcome",1),
        //     new NPCDialogue(new List<InterfaceSelectionObject>{obj3}, "hello epic gamer",2),
        //     };
        InterfaceSelectionObject obj=new InterfaceSelectionObject(1,"Hello");
        InterfaceSelectionObject obj2=new InterfaceSelectionObject(2,"Nice to meet");
        InterfaceSelectionObject obj3=new InterfaceSelectionObject(3,"that ifs cool");
        InterfaceSelectionObject obj4=new InterfaceSelectionObject(-1,"children");
        npcDialogue=new List<NPCDialogue>{
            new NPCDialogue(new List<InterfaceSelectionObject>{obj}, "Hello",0),
            new NPCDialogue(new List<InterfaceSelectionObject>{obj2}, "hi",1),
            new NPCDialogue(new List<InterfaceSelectionObject>{obj3}, "Hello3",2),
            new NPCDialogue(new List<InterfaceSelectionObject>{obj4}, "Hello4",3),

        };


        //the player would have the choice to say either obj or obj2, since #relatable is the first in the list, if they say welcome, npc would response with your welcome
       
    }


    public void setNPCDialogue(){
        Interface.dialogueManager.npcDialogue=npcDialogue;
        Interface.dialogueManager.dialogueHeader=npcName;
    }
}
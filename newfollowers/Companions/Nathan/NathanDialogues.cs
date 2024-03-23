using Terraria;
using terraguardians;
using System.Collections.Generic;

namespace newfollowers.Companions.Nathan
{
    //Contains the dialogues of the companion. Must extend CompanionDialogueContainer.
    public class NathanDialogues : CompanionDialogueContainer //Must be assigned on the companion base file, setting it as the value of "GetDialogueContainer" overrideable method.
    {
        public override string GreetMessages(Companion companion) //Messages for when you just met the companion.
        {
            return "Thanks for getting me out of that bag.";
        }

        public override string NormalMessages(Companion companion) //Normal chitchat. If you want to get player reference, use MainMod.GetLocalPlayer.
        {
            List<string> Mes = new List<string>();
            Mes.Add("Might you have some more potions? I like really need them and stuff");
            Mes.Add("Can I have all your gear? It'd be way more useful on me.");
            Mes.Add("So once I ended up in a dimension with a Z-axis... The people still looked like they do here though.");
            Mes.Add("You should join the adventure squad... oh wait it ain't coded yet and probably never will be.");
            Mes.Add("I got a cat named Boy Cat. He is my pride and joy.");
            if (!Main.dayTime)
            {
                if (Main.bloodMoon)
                {
                    Mes.Add("Hmm the moon tonight seems to make the monster outside swarm. I sure hope a zerg rush ain't on the way.");
                    Mes.Add("In another dimension I've been in a moon like this would make all the creatures come back too life.");
                    Mes.Add("Ah, this night reminds me of a the time I was in that Z-axis dimension. It seemed to make the normally peaceful creatures hostile.");
                }
                else
                {
                    Mes.Add("I love the night it's nice and cool.");
					Mes.Add("Did you know the moon phase affects your fishing luck? The fuller the moon the better.");
                }
            }
            else
            {
                if (Main.eclipse)
                {
                    Mes.Add("Day ruined.");
                    Mes.Add("If we're lucky, well get those creatures rare drops.");
                }
                else
                {
                    Mes.Add("I wish the sun would stop blinding me well I'm in my office.");
                    Mes.Add("Morning I'd offer you a bacon, but I've just eaten the last one.");
                }
            }
            if (Main.raining && !Main.eclipse && !Main.bloodMoon)
            {
                Mes.Add("Ah rain, oh how much I hate you.");
                Mes.Add("Water does not compute with my gadgets");
            }
            if (Main.hardMode)
            {
                Mes.Add("We should go grind for hours in the hollow for that funny teleport wand thing.");
            }
            if (NPC.AnyNPCs(Terraria.ID.NPCID.Merchant))
            {
                Mes.Add("[nn:" + Terraria.ID.NPCID.Merchant + "] storage items must have tapped into my travel mechanisms. Either that or they're magic.");
            }

            if (WorldMod.GetTerraGuardiansCount > 0)
            {
                Mes.Add("Those guardian guys are just the greatest. They're very friendly, nice, and most importantly furry all over!");
                Mes.Add("Them guardians are a bit intimidating but they seem nice.");
            }
			else
            {
				Mes.Add("So I've read about these strange creatures that live around these parts call TerraGuardians think we'll find one soon?");
				Mes.Add("I hear there is a mystical setting hidden inside the fabric of this world that removes all TerraGuardians from existence. surely you haven't done such a thing... right?");
			}

            if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Rococo)) //Checks if there's a npc of this companion ID spawned in the world. Add ModName as an argument after the ID to get another mod companion instead.
            {
                //[gn:id:modid] gets the name of the companion whose ID and ModID are supplied. Leaving without mod id will make the mod automatically get a TerraGuardian mod companion.
                Mes.Add("[gn:" + 0 + "] is such a bonehead, however I hear he was the start to all of this.");
            }
            if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Blue))
            {
                Mes.Add("[gn:" + terraguardians.CompanionDB.Blue + "] is nice and all, but I hear she does unfathomable things with poisons");
            }
            if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Sardine) || WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Bree))
            {
                Mes.Add("So I guess guardians can be small like use too, and they're cats too... hope they love a good pet.");
            }
            if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Zacks))
            {
                Mes.Add("Wow you got a zombie on your team? You must be some kind of necromancer or something.");
            }
			if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Michelle))
            {
                Mes.Add("[gn:" + terraguardians.CompanionDB.Michelle + "] is always asking me if she can join the adventure squad, but I don't know, she seems kinda weak.");
            }
			if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Alex))
            {
                Mes.Add("For the most part I hate dogs, but [gn:" + terraguardians.CompanionDB.Alex + "] might just be an exception.");
            }
			if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Domino))
            {
                Mes.Add("That shady dog and I are becomeing best friends. I hop through dimensions stealing stuff for his store, and he gives me a nice cut.");
				Mes.Add("I used to do similar work for [gn:" + terraguardians.CompanionDB.Domino + "] in a different dimension except instead of a dog it was 4 cats.");
            }
			if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Leopold))
            {
                Mes.Add("In that Z-Axis dimensions there where a lot of creatures that looked similar to [gn:" + terraguardians.CompanionDB.Leopold + "] some even walked on four legs and attacked people!");
            }
			if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Luna))
            {
                Mes.Add("At one point I messed with [gn:" + terraguardians.CompanionDB.Luna + "]s brain to make her say a little more for her tips.. If she asks where I am tell her I'm at the moon.");
            }
			if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Mabel))
            {
                Mes.Add("Once I witnessed [gn:" + terraguardians.CompanionDB.Mabel + "] destroying the fabric of reality when she hit the ground. Maybe she has atomic powers?");
            }
            if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Celeste))
            {
                Mes.Add("[gn:" + terraguardians.CompanionDB.Celeste + "] talks about the god Raye Filos all the time, but I hear that theres a god above him too and their name might be Douglas.");
            }
            return Mes[Terraria.Main.rand.Next(Mes.Count)];
        }

        public override string TalkMessages(Companion companion) //This message only appears if you speak with a companion whose friendship exp increases.
        {
            List<string> Mes = new List<string>();
            Mes.Add("Thanks for being nice to me and stuff.");
            return Mes[Terraria.Main.rand.Next(Mes.Count)];
        }

        public override string RequestMessages(Companion companion, RequestContext context) //Messages regarding requests. The contexts are used to let you know which cases the message will use.
        {
            switch(context)
            {
                case RequestContext.NoRequest:
                    {
                        List<string> Mes = new List<string>();
                        Mes.Add("Nah I'm good.");
                        return Mes[Terraria.Main.rand.Next(Mes.Count)];
                    }
                case RequestContext.HasRequest:
                    {
                        List<string> Mes = new List<string>();
                        Mes.Add("Good timing, I need you to [objective], can you do that?");
                        return Mes[Main.rand.Next(Mes.Count)];
                    }
                case RequestContext.Completed:
                    {
                        List<string> Mes = new List<string>();
                        Mes.Add("Thanks, here, take this junk");
                        return Mes[Terraria.Main.rand.Next(Mes.Count)];
                    }
                case RequestContext.Accepted:
                    return "Cool just come tell me when you're done.";
                case RequestContext.TooManyRequests:
                    return "You got too many things to do right now.";
                case RequestContext.Rejected:
                    return "That's fine, I made it up anyways.";
                case RequestContext.PostponeRequest:
                    return "Another time then?";
                case RequestContext.Failed:
                    return "Well don't worry, I don't think the FBI is in this world yet.";
                case RequestContext.AskIfRequestIsCompleted:
                    return "You did that thing I asked?";
                case RequestContext.RemindObjective:
                    return "You just gotta [objective].";
            }
            return base.RequestMessages(companion, context);
        }

        public override string AskCompanionToMoveInMessage(Companion companion, MoveInContext context)
        {
            switch(context)
            {
                case MoveInContext.Success:
                    return "Sure, I'll get my trash.";
                case MoveInContext.Fail:
                    return "Nah I'm good.";
                case MoveInContext.NotFriendsEnough:
                    return "I don't know...";
            }
            return base.AskCompanionToMoveInMessage(companion, context);
        }

        public override string AskCompanionToMoveOutMessage(Companion companion, MoveOutContext context)
        {
            switch(context)
            {
                case MoveOutContext.Success:
                    return "Alright my cat needs me anyways.";
                case MoveOutContext.Fail:
                    return "Not right now sorry";
                case MoveOutContext.NoAuthorityTo:
                    return "Uh I don't know you.";
            }
            return base.AskCompanionToMoveOutMessage(companion, context);
        }

        public override string JoinGroupMessages(Companion companion, JoinMessageContext context)
        {
            switch(context)
            {
                case JoinMessageContext.Success:
                    return "Sure I'll tag along";
                case JoinMessageContext.FullParty:
                    return "Sorry, but your party is too full right now.";
                case JoinMessageContext.Fail:
                    return "Not at the moment.";
            }
            return base.JoinGroupMessages(companion, context);
        }

        public override string LeaveGroupMessages(Companion companion, LeaveMessageContext context)
        {
            switch(context)
            {
                case LeaveMessageContext.Success:
                    return "Alright I'll be heading home then.";
                case LeaveMessageContext.Fail:
                    return "Not right now.";
                case LeaveMessageContext.AskIfSure:
                    return "I think I'd rather stay, but it's your call I guess.";
                case LeaveMessageContext.DangerousPlaceYesAnswer:
                    return "Alright guess I'll find my way home then.";
                case LeaveMessageContext.DangerousPlaceNoAnswer:
                    return "Good choice.";
            }
            return base.LeaveGroupMessages(companion, context);
        }

        public override string OnToggleShareBedsMessage(Companion companion, bool Share)
        {
            if (Share) return "I guess, but I sleep better alone.";
            return "As long as I get a bed I'm cool.";
        }

        public override string TacticChangeMessage(Companion companion, TacticsChangeContext context) //For when talking about changing their combat behavior.
        {
            switch(context)
            {
                case TacticsChangeContext.OnAskToChangeTactic:
                    return "What? Is my current style just not doing it for ya?";
                case TacticsChangeContext.ChangeToCloseRange:
                    return "Well I guess I can keep close to them.";
                case TacticsChangeContext.ChangeToMidRanged:
                    return "Ya that sounds fine.";
                case TacticsChangeContext.ChangeToLongRanged:
                    return "Cool I'll be way back here.";
                case TacticsChangeContext.Nevermind:
                    return "So it was fine.";
            }
            return base.TacticChangeMessage(companion, context);
        }

        public override string TalkAboutOtherTopicsMessage(Companion companion, TalkAboutOtherTopicsContext context) //FOr when going to speak about other things.
        {
            switch(context)
            {
                case TalkAboutOtherTopicsContext.FirstTimeInThisDialogue:
                    return "Anything else you want to talk about?";
                case TalkAboutOtherTopicsContext.AfterFirstTime:
                    return "Anything else?";
                case TalkAboutOtherTopicsContext.Nevermind:
                    return "Alright.";
            }
            return base.TalkAboutOtherTopicsMessage(companion, context);
        }
		
		public override string SleepingMessage(Companion companion, SleepingMessageContext context)
        {
            switch(context)
            {
                case SleepingMessageContext.WhenSleeping:
                    {
                        List<string> Mes = new List<string>();
                        Mes.Add("(Nothing)");
						Mes.Add("(Nothing at all)");
                        return Mes[Main.rand.Next(Mes.Count)];
                    }
                case SleepingMessageContext.OnWokeUp:
                    switch (Main.rand.Next(2))
                    {
                        default:
                            return "Come on dude can't I just sleep for a little longer?";
                        case 1:
                            return "So why did you wake me up?";
                    }
                case SleepingMessageContext.OnWokeUpWithRequestActive:
                    switch (Main.rand.Next(2))
                    {
                        default:
                            return "Why did you wake me up? Did you do my request?";
                        case 1:
                            return "Let me guess you did that thing I asked?";
                    }
            }
            return base.SleepingMessage(companion, context);
        }

        public override string InteractionMessages(Companion companion, InteractionMessageContext context)
        {
            switch(context)
            {
                case InteractionMessageContext.OnAskForFavor:
                    return "Just say the word and i'll do it.";
                case InteractionMessageContext.Accepts:
                    return "On it!";
                case InteractionMessageContext.Rejects:
                    return "No way!";
                case InteractionMessageContext.Nevermind:
                    return "What? I thought you needed my help!";
            }
            return base.InteractionMessages(companion, context);
        }

        public override string BuddiesModeMessage(Companion companion, BuddiesModeContext context)
        {
            switch(context)
            {
                case BuddiesModeContext.Failed:
                    return "Sorry, but I'm not a Guardian.";
                case BuddiesModeContext.AlreadyHasBuddy:
                    return "I couldn't do it anyways, but you already have a buddy.";
            }
            return base.BuddiesModeMessage(companion, context);
        }

        public override string InviteMessages(Companion companion, InviteContext context)
        {
            switch(context)
            {
                case InviteContext.Success:
                    return "Sure I'll be over in a bit.";
                case InviteContext.SuccessNotInTime:
                    return "Tomorrow I'll be there.";
                case InviteContext.Failed:
                    return "Sorry, but I'm playing Guild Managment Game right now. Call some other time.";
                case InviteContext.CancelInvite:
                    return "You don't need my help anymore then?";
                case InviteContext.ArrivalMessage:
                    return "Made it!";
            }
            return "";
        }

        public override string ReviveMessages(Companion companion, Player target, ReviveContext context)
        {
            switch(context)
            {
                case ReviveContext.HelpCallReceived:
                    return "Please get up soon.";
                case ReviveContext.RevivingMessage:
                    {
                        List<string> Mes = new List<string>();
                        if (!(target is Companion))
                        {
                            Mes.Add("I'll get you back up.");
                            Mes.Add("Tis but a scratch!");
                        }
                        else
                        {
                            Mes.Add("Hopefully I'm doing this right");
                            Mes.Add("You alright?");
                        }
                        return Mes[Main.rand.Next(Mes.Count)];
                    }
                case ReviveContext.OnComingForFallenAllyNearbyMessage:
                    return "I'm on my way!";
                case ReviveContext.ReachedFallenAllyMessage:
                    return "Alright made it.";
                case ReviveContext.RevivedByItself:
                    return "Well I'm alive.. No thanks to you.";
                case ReviveContext.ReviveWithOthersHelp:
                    return "Thanks guys!";
            }
            return base.ReviveMessages(companion, target, context);
        }

        public override string GetOtherMessage(Companion companion, string Context)
        {
            switch(Context)
            {
                case MessageIDs.LeopoldEscapedMessage:
                    return "Kinda suprised you didn't just shoot him or something.";
                case MessageIDs.VladimirRecruitPlayerGetsHugged:
                    return "So that just happend.";
            }
            return base.GetOtherMessage(companion, Context);
        }
    }
}
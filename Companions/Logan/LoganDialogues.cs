using Terraria;
using terraguardians;
using System.Collections.Generic;

namespace newfollowers.Companions.Logan
{
    //Contains the dialogues of the companion. Must extend CompanionDialogueContainer.
    public class LoganDialogues : CompanionDialogueContainer //Must be assigned on the companion base file, setting it as the value of "GetDialogueContainer" overrideable method.
    {
        public override string GreetMessages(Companion companion) //Messages for when you just met the companion.
        {
            return "Thanks! I thought I was going to die in that bag.";
        }

        public override string NormalMessages(Companion companion) //Normal chitchat. If you want to get player reference, use MainMod.GetLocalPlayer.
        {
            List<string> Mes = new List<string>();
            Mes.Add("So how you been?");
            Mes.Add("My friends are dimension hoppers. Me I like to take things easy.");
            Mes.Add("Ya know what Chikipi is? I hear they're a special form of a chicken that can fight!");
			Mes.Add("I'm more of fist fighter, but I guess they don't that in this world.");
            Mes.Add("Ya know where to get a bite to eat around here?");
            Mes.Add("Ever wondered why we don't need bathrooms here?");
			Mes.Add("Do you actually like mining for stuff? I'd help dig, but I think I'm missing the brains to dig.");
            if (!Main.dayTime)
            {
                if (Main.bloodMoon)
                {
                    Mes.Add("So many things to kill tonight. Let's tally and see whose better.");
                }
                else
                {
					Mes.Add("Wonder if those stars form constellations");
					Mes.Add("I've always wondered what's out there. In space I mean.");
                }
            }
            else
            {
                if (Main.eclipse)
                {
                    Mes.Add("The sun sure looks wicked right now.");
                    Mes.Add("I call dibs on mothron loot.");
                }
                else
                {
                    Mes.Add("Today is nice day for some adventure");
                }
            }
            if (Main.raining && !Main.eclipse && !Main.bloodMoon)
            {
                Mes.Add("Rain reminds me when I looked up at sky just before it started raining and got drenched right as I looked up!");
            }
            if (Main.hardMode)
            {
                Mes.Add("We should kill that flesh wall thing some more. I like it's loot.");
            }
            if (NPC.AnyNPCs(Terraria.ID.NPCID.Merchant))
            {
                Mes.Add("[nn:" + Terraria.ID.NPCID.Merchant + "] potions aren't very strong, but they do get the job done.");
            }
			if (WorldMod.GetTerraGuardiansCount > 0)
            {
                Mes.Add("You sure those animal creatures aren't plotting to kill us?");
                Mes.Add("So you say those creatures aren't furries? I don't know about that.");
            }
            if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Rococo)) //Checks if there's a npc of this companion ID spawned in the world. Add ModName as an argument after the ID to get another mod companion instead.
            {
                //[gn:id:modid] gets the name of the companion whose ID and ModID are supplied. Leaving without mod id will make the mod automatically get a TerraGuardian mod companion.
                Mes.Add("[gn:" + 0 + "] is cool, he helps keep my room clean by eating all the garbage.");
            }
            if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Blue))
            {
                Mes.Add("Someday, I just know [gn:" + terraguardians.CompanionDB.Blue + "] is going to try and get me in my sleep.");
            }
            if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Sardine) || WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Bree))
            {
                Mes.Add("Cats make for the best companions. Glad we found some.");
            }
            if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Zacks))
            {
                Mes.Add("I feel like I'm about to become zombie chow...");
            }
			if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Michelle))
            {
                Mes.Add("Would you please tell [gn:" + terraguardians.CompanionDB.Michelle + "] to leave me alone. I can't even think straight when she's around.");
            }
			if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Alex))
            {
                Mes.Add("My sister has a dog that's kinda like [gn:" + terraguardians.CompanionDB.Alex + "] but much smaller.");
            }
			if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Domino))
            {
                Mes.Add("Good thing I got a surplus of bones from my last trip underground [gn:" + terraguardians.CompanionDB.Domino + "] just loves them.");
            }
			if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Leopold))
            {
                Mes.Add("[gn:" + terraguardians.CompanionDB.Leopold + "] books make my head hurt. Think he cursed them first when I asked to borrow them?");
            }
			if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Luna))
            {
                Mes.Add("[gn:" + terraguardians.CompanionDB.Luna + "] is nice and all, but I still can't wrap my head around her.. words!");
            }
            return Mes[Terraria.Main.rand.Next(Mes.Count)];
        }

        public override string TalkMessages(Companion companion) //This message only appears if you speak with a companion whose friendship exp increases.
        {
            List<string> Mes = new List<string>();
            Mes.Add("Thanks again for all the help.");
            return Mes[Terraria.Main.rand.Next(Mes.Count)];
        }

        public override string RequestMessages(Companion companion, RequestContext context) //Messages regarding requests. The contexts are used to let you know which cases the message will use.
        {
            switch(context)
            {
                case RequestContext.NoRequest:
                    {
                        List<string> Mes = new List<string>();
                        Mes.Add("I'm alright, but thanks for asking.");
                        return Mes[Terraria.Main.rand.Next(Mes.Count)];
                    }
                case RequestContext.HasRequest:
                    {
                        List<string> Mes = new List<string>();
                        Mes.Add("Ya, I would like it if you could [objective].");
                        return Mes[Main.rand.Next(Mes.Count)];
                    }
                case RequestContext.Completed:
                    {
                        List<string> Mes = new List<string>();
                        Mes.Add("Thanks, here, take this junk");
						Mes.Add("You the best, dude.");
                        return Mes[Terraria.Main.rand.Next(Mes.Count)];
                    }
                case RequestContext.Accepted:
                    return "I'll be waiting.";
                case RequestContext.TooManyRequests:
                    return "Don't overload yourself, it can wait.";
                case RequestContext.Rejected:
                    return "Alright, no biggy.";
                case RequestContext.PostponeRequest:
                    return "It can wait I don't mind.";
                case RequestContext.Failed:
                    return "Well hopefully you at least tried";
                case RequestContext.AskIfRequestIsCompleted:
                    return "No way you did what I asked?";
                case RequestContext.RemindObjective:
                    return "Forgot? well I need you to [objective].";
            }
            return base.RequestMessages(companion, context);
        }

        public override string AskCompanionToMoveInMessage(Companion companion, MoveInContext context)
        {
            switch(context)
            {
                case MoveInContext.Success:
                    return "I can move in.";
                case MoveInContext.Fail:
                    return "I'm fine right now thanks.";
                case MoveInContext.NotFriendsEnough:
                    return "Maybe if we know each other more I'll move in.";
            }
            return base.AskCompanionToMoveInMessage(companion, context);
        }

        public override string AskCompanionToMoveOutMessage(Companion companion, MoveOutContext context)
        {
            switch(context)
            {
                case MoveOutContext.Success:
                    return "Well alright see you some other time.";
                case MoveOutContext.Fail:
                    return "I think I'll stay longer.";
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
                    return "Ya, I'm ready for a good fight.";
                case JoinMessageContext.FullParty:
                    return "Clean up your crew a bit so I can fit.";
                case JoinMessageContext.Fail:
                    return "Not right now, sorry.";
            }
            return base.JoinGroupMessages(companion, context);
        }

        public override string LeaveGroupMessages(Companion companion, LeaveMessageContext context)
        {
            switch(context)
            {
                case LeaveMessageContext.Success:
                    return "Guess I'll head back home then.";
                case LeaveMessageContext.Fail:
                    return "Uh not right now sorry.";
                case LeaveMessageContext.AskIfSure:
                    return "Can't you wait tell we're back at town first?";
                case LeaveMessageContext.DangerousPlaceYesAnswer:
                    return "Well this kinda sucks, but I'll try and make it home.";
                case LeaveMessageContext.DangerousPlaceNoAnswer:
                    return "Good choice.";
            }
            return base.LeaveGroupMessages(companion, context);
        }

        public override string OnToggleShareBedsMessage(Companion companion, bool Share)
        {
            if (Share) return "Odd, but alright.";
            return "Hopefully there's a bed for me.";
        }

        public override string TacticChangeMessage(Companion companion, TacticsChangeContext context) //For when talking about changing their combat behavior.
        {
            switch(context)
            {
                case TacticsChangeContext.OnAskToChangeTactic:
                    return "Different Tactic you say? Alright what should I do?";
                case TacticsChangeContext.ChangeToCloseRange:
                    return "Alright! That's what I live for!";
                case TacticsChangeContext.ChangeToMidRanged:
                    return "Alright I'll be in the middle";
                case TacticsChangeContext.ChangeToLongRanged:
                    return "Uh ok I'll be back here then.";
                case TacticsChangeContext.Nevermind:
                    return "No change then?";
            }
            return base.TacticChangeMessage(companion, context);
        }

        public override string TalkAboutOtherTopicsMessage(Companion companion, TalkAboutOtherTopicsContext context) //FOr when going to speak about other things.
        {
            switch(context)
            {
                case TalkAboutOtherTopicsContext.FirstTimeInThisDialogue:
                    return "Anything else or are you good?";
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
                        Mes.Add("Sleep messages are overrated");
						Mes.Add("Ayo");
                        return Mes[Main.rand.Next(Mes.Count)];
                    }
                case SleepingMessageContext.OnWokeUp:
                    switch (Main.rand.Next(2))
                    {
                        default:
                            return "What's up?";
                        case 1:
                            return "Need my help with anything?";
                    }
                case SleepingMessageContext.OnWokeUpWithRequestActive:
                    switch (Main.rand.Next(2))
                    {
                        default:
                            return "I'm guessing you got me up because you finished my request.";
                        case 1:
                            return "Oh you got the thing I asked done?";
                    }
            }
            return base.SleepingMessage(companion, context);
        }

        public override string InteractionMessages(Companion companion, InteractionMessageContext context)
        {
            switch(context)
            {
                case InteractionMessageContext.OnAskForFavor:
                    return "What do you need?";
                case InteractionMessageContext.Accepts:
                    return "Sure";
                case InteractionMessageContext.Rejects:
                    return "Nope";
                case InteractionMessageContext.Nevermind:
                    return "So nothing then?";
            }
            return base.InteractionMessages(companion, context);
        }

        public override string BuddiesModeMessage(Companion companion, BuddiesModeContext context)
        {
            switch(context)
            {
                case BuddiesModeContext.Failed:
                    return "Pretty sure we can't do that.";
                case BuddiesModeContext.AlreadyHasBuddy:
                    return "You already have a buddie.";
            }
            return base.BuddiesModeMessage(companion, context);
        }

        public override string InviteMessages(Companion companion, InviteContext context)
        {
            switch(context)
            {
                case InviteContext.Success:
                    return "On my way!";
                case InviteContext.SuccessNotInTime:
                    return "It'll need to wait tell tomorrow.";
                case InviteContext.Failed:
                    return "Can't come over right now, sorry.";
                case InviteContext.CancelInvite:
                    return "Oh you good then?";
                case InviteContext.ArrivalMessage:
                    return "I'm here [nickname]";
            }
            return "";
        }

        public override string ReviveMessages(Companion companion, Player target, ReviveContext context)
        {
            switch(context)
            {
                case ReviveContext.HelpCallReceived:
                    return "How long are you gonna lay there?";
                case ReviveContext.RevivingMessage:
                    {
                        List<string> Mes = new List<string>();
                        if (!(target is Companion))
                        {
                            Mes.Add("I gotcha!");
                            Mes.Add("Let me help you [nickname]");
                        }
                        else
                        {
                            Mes.Add("Doctor time!");
                            Mes.Add("I'll patch those wounds.");
                        }
                        return Mes[Main.rand.Next(Mes.Count)];
                    }
                case ReviveContext.OnComingForFallenAllyNearbyMessage:
                    return "Coming as fast as I can!";
                case ReviveContext.ReachedFallenAllyMessage:
                    return "Alright I gotcha.";
                case ReviveContext.RevivedByItself:
                    return "Some help would have been nice";
                case ReviveContext.ReviveWithOthersHelp:
                    return "Thanks for the helping hand!";
            }
            return base.ReviveMessages(companion, target, context);
        }

        public override string GetOtherMessage(Companion companion, string Context)
        {
            switch(Context)
            {
                case MessageIDs.LeopoldEscapedMessage:
                    return "I guess you must be way scarier than I think.";
                case MessageIDs.VladimirRecruitPlayerGetsHugged:
                    return "...";
            }
            return base.GetOtherMessage(companion, Context);
        }
    }
}
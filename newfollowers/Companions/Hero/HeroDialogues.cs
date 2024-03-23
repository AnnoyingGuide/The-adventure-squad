using Terraria;
using terraguardians;
using System.Collections.Generic;

namespace newfollowers.Companions.Hero
{
    //Contains the dialogues of the companion. Must extend CompanionDialogueContainer.
    public class HeroDialogues : CompanionDialogueContainer //Must be assigned on the companion base file, setting it as the value of "GetDialogueContainer" overrideable method.
    {
        public override string GreetMessages(Companion companion) //Messages for when you just met the companion.
        {
            return "Alright freedom out of the bag! Thanks a lot.";
        }

        public override string NormalMessages(Companion companion) //Normal chitchat. If you want to get player reference, use MainMod.GetLocalPlayer.
        {
            List<string> Mes = new List<string>();
            Mes.Add("Say you got any sandwich places around here? I could really go for a hero sub right now.");
            Mes.Add("I ended up here by an accident in my lab back in my world at least you guys are cool so it's not too bad.");
            Mes.Add("If we every get back to my world I'll have to introduce you to my friends.");
			Mes.Add("I've always been a good cook, but I ended up pursuing medical stuff instead.");
            if (!Main.dayTime)
            {
                if (Main.bloodMoon)
                {
                    Mes.Add("Is it just me or did the woman around here get much more agressive right around now?");
					Mes.Add("Those monsters might make us rich if we keep killing them.");
                }
                else
                {
					Mes.Add("This world seems to have many different moon forms at least from world to world they seem different.");
                }
            }
            else
            {
                if (Main.eclipse)
                {
                    Mes.Add("I remember watching movies with my friends that had these creatures in them. They're even scarier up close, especially The Possessed");
                    Mes.Add("Wow the items these creatures drop are very powerful. Maybe there is a way to cause an eclipse ourselves?");
                }
                else
                {
                    Mes.Add("Hey [nickname] want to go on an adventure today? Who knows what we will find out there.");
                }
            }
            if (Main.raining && !Main.eclipse && !Main.bloodMoon)
            {
                Mes.Add("I used to have a lot of fun in the rain with my friends. I sure hope I'll get too see them again soon.");
            }
            if (NPC.AnyNPCs(Terraria.ID.NPCID.Nurse))
            {
                Mes.Add("[nn:" + Terraria.ID.NPCID.Nurse+ "] has been training my medical knowledge, soon I may become a combat medic.");
            }

            if (WorldMod.GetTerraGuardiansCount > 0)
            {
                Mes.Add("I feel a bond between the Terraguardians and myself, Surely they are good people.");
                Mes.Add("How on earth do the guardians talk with us? It seems like I just hear their words in my head.");
				Mes.Add("The guardians help keep us safe and sound. Perhaps we should give thanks by doing their requests?");
            }
            if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Blue))
            {
                Mes.Add("[gn:" + terraguardians.CompanionDB.Blue + "] just might be my favorite of the bunch. She's blue and I love all things blue.");
            }
            if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Zacks))
            {
                Mes.Add("[gn:" + terraguardians.CompanionDB.Zacks + "] may look scary, but he's generally pretty nice to me.");
            }
			if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Alex))
            {
                Mes.Add("[gn:" + terraguardians.CompanionDB.Alex + "] is a good boy who deserves all the pets in the world.");
            }
			if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Domino))
            {
                Mes.Add("Personally I think letting a smuggler live here will surely end up bad for us in the future.");
            }
			if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Leopold))
            {
                Mes.Add("I got a friend that would surely like to get her hands on [gn:" + terraguardians.CompanionDB.Leopold + "] I don't think we'd ever see him again if that happend.");
            }
			if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Luna))
            {
                Mes.Add("[gn:" + terraguardians.CompanionDB.Luna + "] might be my new teacher as I love learning about the new things about the TerraGuardians. You should talk to her if you need advice.");
            }
            return Mes[Terraria.Main.rand.Next(Mes.Count)];
        }

        public override string TalkMessages(Companion companion) //This message only appears if you speak with a companion whose friendship exp increases.
        {
            List<string> Mes = new List<string>();
            Mes.Add("You remind me of my brother. He's always ready to help, and so are you. Thank you.");
            return Mes[Terraria.Main.rand.Next(Mes.Count)];
        }

        public override string RequestMessages(Companion companion, RequestContext context) //Messages regarding requests. The contexts are used to let you know which cases the message will use.
        {
            switch(context)
            {
                case RequestContext.NoRequest:
                    {
                        List<string> Mes = new List<string>();
                        Mes.Add("I'm fine right now, but thanks for asking.");
						Mes.Add("I'm good [nickname].");
                        return Mes[Terraria.Main.rand.Next(Mes.Count)];
                    }
                case RequestContext.HasRequest:
                    {
                        List<string> Mes = new List<string>();
                        Mes.Add("I do, could you [objective] for me? Thanks in advance.");
                        return Mes[Main.rand.Next(Mes.Count)];
                    }
                case RequestContext.Completed:
                    {
                        List<string> Mes = new List<string>();
                        Mes.Add("Thank you very much [nickname].");
						Mes.Add("Thanks [nickname]. Here you can have some of my loot.");
                        return Mes[Terraria.Main.rand.Next(Mes.Count)];
                    }
                case RequestContext.Accepted:
                    return "Thanks [nickname] I can always count on you.";
                case RequestContext.TooManyRequests:
                    return "Sorry [nickname], but I think you have too much to do right now.";
                case RequestContext.Rejected:
                    return "I'll get to this myself later then.";
                case RequestContext.PostponeRequest:
                    return "I'll keep it here then.";
                case RequestContext.Failed:
                    return "Thanks for the attempt at least.";
                case RequestContext.AskIfRequestIsCompleted:
                    return "Did you finish my request?";
                case RequestContext.RemindObjective:
                    return "Oh, well I need you to [objective].";
            }
            return base.RequestMessages(companion, context);
        }

        public override string AskCompanionToMoveInMessage(Companion companion, MoveInContext context)
        {
            switch(context)
            {
                case MoveInContext.Success:
                    return "Sure I'll stick with you at your town.";
                case MoveInContext.Fail:
                    return "Sorry [nickname], I got stuff to do.";
                case MoveInContext.NotFriendsEnough:
                    return "Sorry, but I think we should get to know each other a bit more before I move in.";
            }
            return base.AskCompanionToMoveInMessage(companion, context);
        }

        public override string AskCompanionToMoveOutMessage(Companion companion, MoveOutContext context)
        {
            switch(context)
            {
                case MoveOutContext.Success:
                    return "Alright, I got places I can hang out at so it's not that bad.";
                case MoveOutContext.Fail:
                    return "I feel like it would be better If I stayed her longer.";
                case MoveOutContext.NoAuthorityTo:
                    return "Uh you weren't the one to give me this house.";
            }
            return base.AskCompanionToMoveOutMessage(companion, context);
        }

        public override string JoinGroupMessages(Companion companion, JoinMessageContext context)
        {
            switch(context)
            {
                case JoinMessageContext.Success:
                    return "Sure [nickname], I'll be right behind you.";
                case JoinMessageContext.FullParty:
                    return "Sorry [nickname], but you got too many people in your squad right now.";
                case JoinMessageContext.Fail:
                    return "Sorry [nickname], but I can't join you right now.";
            }
            return base.JoinGroupMessages(companion, context);
        }

        public override string LeaveGroupMessages(Companion companion, LeaveMessageContext context)
        {
            switch(context)
            {
                case LeaveMessageContext.Success:
                    return "Alright, see you later then.";
                case LeaveMessageContext.Fail:
                    return "Not right now [nickname].";
                case LeaveMessageContext.AskIfSure:
                    return "But [nickname], shouldn't we wait tell we're back at town first?";
                case LeaveMessageContext.DangerousPlaceYesAnswer:
                    return "Well alright, hopefully I'll make it home in one piece.";
                case LeaveMessageContext.DangerousPlaceNoAnswer:
                    return "Thank you.";
            }
            return base.LeaveGroupMessages(companion, context);
        }

        public override string OnToggleShareBedsMessage(Companion companion, bool Share)
        {
            if (Share) return "Alright as long as I have some room to myself.";
            return "Make sure I got my own bed please.";
        }

        public override string TacticChangeMessage(Companion companion, TacticsChangeContext context) //For when talking about changing their combat behavior.
        {
            switch(context)
            {
                case TacticsChangeContext.OnAskToChangeTactic:
                    return "Want me to change up my fighting style?";
                case TacticsChangeContext.ChangeToCloseRange:
                    return "I guess I can do that.";
                case TacticsChangeContext.ChangeToMidRanged:
                    return "My perfect spot.";
                case TacticsChangeContext.ChangeToLongRanged:
                    return "I'll be back here then.";
                case TacticsChangeContext.Nevermind:
                    return "So my style is fine then?";
            }
            return base.TacticChangeMessage(companion, context);
        }

        public override string TalkAboutOtherTopicsMessage(Companion companion, TalkAboutOtherTopicsContext context) //FOr when going to speak about other things.
        {
            switch(context)
            {
                case TalkAboutOtherTopicsContext.FirstTimeInThisDialogue:
                    return "Anything else [nickname]?";
                case TalkAboutOtherTopicsContext.AfterFirstTime:
                    return "Anything else?";
                case TalkAboutOtherTopicsContext.Nevermind:
                    return "Ok then.";
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
                        Mes.Add("Zzzzzz.. KEL.. Zzzzzz.");
						Mes.Add("Zzzzzz.. AUBREY.. Zzzzzz.");
                        return Mes[Main.rand.Next(Mes.Count)];
                    }
                case SleepingMessageContext.OnWokeUp:
                    switch (Main.rand.Next(2))
                    {
                        default:
                            return "Oh, what's up [nickname]?";
                        case 1:
                            return "Need my help with anything?";
                    }
                case SleepingMessageContext.OnWokeUpWithRequestActive:
                    switch (Main.rand.Next(2))
                    {
                        default:
                            return "Oh hi [nickname] did you do my request.";
                        case 1:
                            return "I'm hopping you woke me up because you did my request.";
                    }
            }
            return base.SleepingMessage(companion, context);
        }

        public override string InteractionMessages(Companion companion, InteractionMessageContext context)
        {
            switch(context)
            {
                case InteractionMessageContext.OnAskForFavor:
                    return "What do you need my help with?";
                case InteractionMessageContext.Accepts:
                    return "I can do that.";
                case InteractionMessageContext.Rejects:
                    return "Sorry [nickname], but I can't do that.";
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
                    return "Sorry [nickname], but we can't be buddies. Thats a TerraGuardians thing.";
                case BuddiesModeContext.AlreadyHasBuddy:
                    return "But you already have one.";
            }
            return base.BuddiesModeMessage(companion, context);
        }

        public override string InviteMessages(Companion companion, InviteContext context)
        {
            switch(context)
            {
                case InviteContext.Success:
                    return "I'm on my way [nickname]";
                case InviteContext.SuccessNotInTime:
                    return "Tomorrow I'll be there!";
                case InviteContext.Failed:
                    return "Sorry [nickname], but I can't right now.";
                case InviteContext.CancelInvite:
                    return "Alright guess I won't be coming over then.";
                case InviteContext.ArrivalMessage:
                    return "I've made it [nickname]";
            }
            return "";
        }

        public override string ReviveMessages(Companion companion, Player target, ReviveContext context)
        {
            switch(context)
            {
                case ReviveContext.HelpCallReceived:
                    return "You'll be alright I'm sure of it.";
                case ReviveContext.RevivingMessage:
                    {
                        List<string> Mes = new List<string>();
                        if (!(target is Companion))
                        {
                            Mes.Add("I got you [nickname]");
                            Mes.Add("My medical training will come in handy for this.");
                        }
                        else
                        {
                            Mes.Add("I'll help you don't worry.");
                            Mes.Add("My medical training will come in handy.");
                        }
                        return Mes[Main.rand.Next(Mes.Count)];
                    }
                case ReviveContext.OnComingForFallenAllyNearbyMessage:
                    return "I'm on my way!";
                case ReviveContext.ReachedFallenAllyMessage:
                    return "Let's get you some place safe.";
                case ReviveContext.RevivedByItself:
                    return "I'm alright, but some help would have been nice.";
                case ReviveContext.ReviveWithOthersHelp:
                    return "Thanks for the help everyone!";
            }
            return base.ReviveMessages(companion, target, context);
        }

        public override string GetOtherMessage(Companion companion, string Context)
        {
            switch(Context)
            {
                case MessageIDs.LeopoldEscapedMessage:
                    return "Maybe you should have tried to talk to them?";
                case MessageIDs.VladimirRecruitPlayerGetsHugged:
                    return "I used to give hugs like that to my friends. Well maybe not as big.";
            }
            return base.GetOtherMessage(companion, Context);
        }
    }
}
using Terraria;
using terraguardians;
using System.Collections.Generic;

namespace newfollowers.Companions.Shiro
{
    //Contains the dialogues of the companion. Must extend CompanionDialogueContainer.
    public class ShiroDialogues : CompanionDialogueContainer //Must be assigned on the companion base file, setting it as the value of "GetDialogueContainer" overrideable method.
    {
        public override string GreetMessages(Companion companion) //Messages for when you just met the companion.
        {
            return "Oh uh hello there, I'm Shiro. Thanks for letting me out of that bag I guess.";
        }

        public override string NormalMessages(Companion companion) //Normal chitchat. If you want to get player reference, use MainMod.GetLocalPlayer.
        {
            List<string> Mes = new List<string>();
            Mes.Add("So uh you're going to protect me out there right?");
            Mes.Add("Is Nago around? I get antsy without him...");
            Mes.Add("Oh yeah I ended up joining the adventure squad as Nago wanted too. I'm not really much of a fighter though...");
            Mes.Add("Say do you have any idea why Nago and I turned into Terrarians? It's not too bad I suppose.");
            Mes.Add("I used to live on a star called dream land. The locals are just as bloodthristy as they are here.");
			Mes.Add("So do I have fur or not? I can't really decide");
			Mes.Add("Say do you know who Pick is by chance? She's a good friend of mine a Hamster too.");
			Mes.Add("MEOW! oh sorry sometimes I get excited and just have to let it go :3");
			Mes.Add("Mrrp Mrrp Meow :3");
            if (!Main.dayTime)
            {
                if (Main.bloodMoon)
                {
                    Mes.Add("HISS!");
                    Mes.Add("What the hell do you want on a night like this!?");
                    Mes.Add("Where's Nago at? I think it's high time he get's what he deserves.");
					Mes.Add("The moon has got my blood boiling, please show me some creatures I can kill.");
                }
                else
                {
                    Mes.Add("Such a romantic night. Say where's Nago?");
					Mes.Add("Nathan told me something about a fuller moon means easier fishing. Now I'm hungry.");
					Mes.Add("Sometimes on nights like these Hero tells me about the lose of someone he was very close with.");
                }
            }
            else
            {
                if (Main.eclipse)
                {
                    Mes.Add("By chance do you have a litter box I could borrow. These monsters are gonna make me wet myself.");
                    Mes.Add("Howabout you guys handle this. I'm off to the little kittens room.");
                }
                else
                {
                    Mes.Add("Being all white has it's perks. The sun ain't so harsh on my fur.");
                    Mes.Add("I'm not really a day person I prefer to stay inside and sleep");
                }
            }
            if (Main.raining && !Main.eclipse && !Main.bloodMoon)
            {
                Mes.Add("I could not even begin to describe how much I hate water to you");
            }
            if (NPC.AnyNPCs(Terraria.ID.NPCID.Merchant))
            {
                Mes.Add("[nn:" + Terraria.ID.NPCID.Merchant + "] sells some basic supplies. Say could you buy me some marshmellows? He only sells them in the tundra ya know.");
            }

            if (WorldMod.GetTerraGuardiansCount > 0)
            {
                Mes.Add("The Guardians kinda remind me of myself. Well when I was cat still.");
            }
            if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Blue))
            {
                Mes.Add("Did you know my name stands for white in Japanese? Blue's name in Japanese would be Ao which kinda sounds painful.");
            }
            if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Sardine) || WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Bree))
            {
                Mes.Add("Oh how nice it is to with another cat. They're even small like us too!");
            }
			if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Alex))
            {
                Mes.Add("A dog? Really...");
            }
			if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Domino))
            {
                Mes.Add("I'm having a hard time trusting Domino. and not just because he's a dog. I think Brutus was right about him.");
            }
			if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Leopold))
            {
                Mes.Add("Personally I found it hilarious when Leopold ran away like he did.");
            }
			if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Luna))
            {
                Mes.Add("Luna is just so knowledgeable, sometimes I feel like she knows more about me then I know.");
            }
			if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Mabel))
            {
                Mes.Add("If you see Nago tell him to stop thirsting over that moose!");
            }
            return Mes[Terraria.Main.rand.Next(Mes.Count)];
        }

        public override string TalkMessages(Companion companion) //This message only appears if you speak with a companion whose friendship exp increases.
        {
            List<string> Mes = new List<string>();
            Mes.Add("Ya know I feel like we're becoming fast friends. Thanks for everything :3");
            return Mes[Terraria.Main.rand.Next(Mes.Count)];
        }

        public override string RequestMessages(Companion companion, RequestContext context) //Messages regarding requests. The contexts are used to let you know which cases the message will use.
        {
            switch(context)
            {
                case RequestContext.NoRequest:
                    {
                        List<string> Mes = new List<string>();
                        Mes.Add("Uh nope no requests here, but thanks for asking.");
                        return Mes[Terraria.Main.rand.Next(Mes.Count)];
                    }
                case RequestContext.HasRequest:
                    {
                        List<string> Mes = new List<string>();
                        Mes.Add("Oh actually I do, can you [objective] for me?");
                        return Mes[Main.rand.Next(Mes.Count)];
                    }
                case RequestContext.Completed:
                    {
                        List<string> Mes = new List<string>();
                        Mes.Add("Thank you, I hope these item's suffice");
                        return Mes[Terraria.Main.rand.Next(Mes.Count)];
                    }
                case RequestContext.Accepted:
                    return "Thank you, just let me know when you finish it.";
                case RequestContext.TooManyRequests:
                    return "You seem a bit overloaded on jobs right now. Let me know when you have space.";
                case RequestContext.Rejected:
                    return "Oh, well I bet Nago could take care of it.";
                case RequestContext.PostponeRequest:
                    return "Uhm yeah sure, just try not to forget.";
                case RequestContext.Failed:
                    return "Well guess that didn't work out then. I'd give you a spankin, but knowing you, you'd like that wouldn't you?";
                case RequestContext.AskIfRequestIsCompleted:
                    return "Oh did you finish the request?";
                case RequestContext.RemindObjective:
                    return "Oh you just need too [objective].";
            }
            return base.RequestMessages(companion, context);
        }

        public override string AskCompanionToMoveInMessage(Companion companion, MoveInContext context)
        {
            switch(context)
            {
                case MoveInContext.Success:
                    return "Oh how nice. I'll move in sure.";
                case MoveInContext.Fail:
                    return "I'd rather not right now.";
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
                    return "Oh well hopefully I can move back into the king's castle.";
                case MoveOutContext.Fail:
                    return "Sorry, but I can't leave just yet ya know.";
                case MoveOutContext.NoAuthorityTo:
                    return "Sorry, but I can't leave just yet ya know.";
            }
            return base.AskCompanionToMoveOutMessage(companion, context);
        }

        public override string JoinGroupMessages(Companion companion, JoinMessageContext context)
        {
            switch(context)
            {
                case JoinMessageContext.Success:
                    return "As long as you protect me I'll join.";
                case JoinMessageContext.FullParty:
                    return "Do you really need more than 5 followers at once?";
                case JoinMessageContext.Fail:
                    return "Sorry, can't right now.";
            }
            return base.JoinGroupMessages(companion, context);
        }

        public override string LeaveGroupMessages(Companion companion, LeaveMessageContext context)
        {
            switch(context)
            {
                case LeaveMessageContext.Success:
                    return "Oh finally, I thought I was gonna die with you.";
                case LeaveMessageContext.Fail:
                    return "Can't leave right now sorry.";
                case LeaveMessageContext.AskIfSure:
                    return "No wait, if you leave me here I'm probably gonna die.";
                case LeaveMessageContext.DangerousPlaceYesAnswer:
                    return "If I die you're paying for the funeral";
                case LeaveMessageContext.DangerousPlaceNoAnswer:
                    return "Thank you for seeing reason.";
            }
            return base.LeaveGroupMessages(companion, context);
        }

        public override string OnToggleShareBedsMessage(Companion companion, bool Share)
        {
            if (Share) return "Alright, but don't get any idea's.";
            return "That's probably for the best.";
        }

        public override string TacticChangeMessage(Companion companion, TacticsChangeContext context) //For when talking about changing their combat behavior.
        {
            switch(context)
            {
                case TacticsChangeContext.OnAskToChangeTactic:
                    return "Hmm alright sure how should I fight?";
                case TacticsChangeContext.ChangeToCloseRange:
                    return "Uh ya sure? just be sure I have good armor then.";
                case TacticsChangeContext.ChangeToMidRanged:
                    return "Alright I'll fight in the middle then.";
                case TacticsChangeContext.ChangeToLongRanged:
                    return "Oh that's better, I'll be back here.";
                case TacticsChangeContext.Nevermind:
                    return "Uh alright I'll stay as I was.";
            }
            return base.TacticChangeMessage(companion, context);
        }

        public override string TalkAboutOtherTopicsMessage(Companion companion, TalkAboutOtherTopicsContext context) //FOr when going to speak about other things.
        {
            switch(context)
            {
                case TalkAboutOtherTopicsContext.FirstTimeInThisDialogue:
                    return "So uh anything else?";
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
                        Mes.Add("Mmm... Nago...");
						Mes.Add("(She peaks at you)");
                        return Mes[Main.rand.Next(Mes.Count)];
                    }
                case SleepingMessageContext.OnWokeUp:
                    switch (Main.rand.Next(2))
                    {
                        default:
                            return "Hehe I knew you were there. So what's up?";
                        case 1:
                            return "Oh hello, waking me up from my daily catnap now are ya.";
                    }
                case SleepingMessageContext.OnWokeUpWithRequestActive:
                    switch (Main.rand.Next(2))
                    {
                        default:
                            return "Ah hello, I'm guessing you did my request?";
                        case 1:
                            return "Ooh I sensed you coming, You did my request right?";
                    }
            }
            return base.SleepingMessage(companion, context);
        }

        public override string InteractionMessages(Companion companion, InteractionMessageContext context)
        {
            switch(context)
            {
                case InteractionMessageContext.OnAskForFavor:
                    return "Uh sure, what do you need from me?";
                case InteractionMessageContext.Accepts:
                    return "Yeah I can do that.";
                case InteractionMessageContext.Rejects:
                    return "Uh sorry can't do that...";
                case InteractionMessageContext.Nevermind:
                    return "It's fine.";
            }
            return base.InteractionMessages(companion, context);
        }

        public override string BuddiesModeMessage(Companion companion, BuddiesModeContext context)
        {
            switch(context)
            {
                case BuddiesModeContext.Failed:
                    return "Sadly that's out of the question for now.";
                case BuddiesModeContext.AlreadyHasBuddy:
                    return "You already have a buddy.";
            }
            return base.BuddiesModeMessage(companion, context);
        }

        public override string InviteMessages(Companion companion, InviteContext context)
        {
            switch(context)
            {
                case InviteContext.Success:
                    return "Oh yeah I'll be over soon.";
                case InviteContext.SuccessNotInTime:
                    return "Sorry a bit busy cleaning the liter box hehe, I'll be over tomorrow though.";
                case InviteContext.Failed:
                    return "Can't come over at the moment sorry.";
                case InviteContext.CancelInvite:
                    return "Oh alright, I'll head back then.";
                case InviteContext.ArrivalMessage:
                    return "I'm here.";
            }
            return "";
        }

        public override string ReviveMessages(Companion companion, Player target, ReviveContext context)
        {
            switch(context)
            {
                case ReviveContext.HelpCallReceived:
                    return "I'm on my way";
                case ReviveContext.RevivingMessage:
                    {
                        List<string> Mes = new List<string>();
                        if (!(target is Companion))
                        {
                            Mes.Add("Oh please don't die...");
                        }
                        else
                        {
                            Mes.Add("You alright?");
                        }
                        return Mes[Main.rand.Next(Mes.Count)];
                    }
                case ReviveContext.OnComingForFallenAllyNearbyMessage:
                    return "I'm coming!";
                case ReviveContext.ReachedFallenAllyMessage:
                    return "Alright let's handle this.";
                case ReviveContext.RevivedByItself:
                    return "Wow I healed myself how cool.";
                case ReviveContext.ReviveWithOthersHelp:
                    return "Thanks Everyone :3";
            }
            return base.ReviveMessages(companion, target, context);
        }

        public override string GetOtherMessage(Companion companion, string Context)
        {
            switch(Context)
            {
                case MessageIDs.LeopoldEscapedMessage:
                    return "Hehe he ran.";
                case MessageIDs.VladimirRecruitPlayerGetsHugged:
                    return "Aww...";
            }
            return base.GetOtherMessage(companion, Context);
        }
    }
}
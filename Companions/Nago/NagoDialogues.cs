using Terraria;
using terraguardians;
using System.Collections.Generic;

namespace newfollowers.Companions.Nago
{
    //Contains the dialogues of the companion. Must extend CompanionDialogueContainer.
    public class NagoDialogues : CompanionDialogueContainer //Must be assigned on the companion base file, setting it as the value of "GetDialogueContainer" overrideable method.
    {
        public override string GreetMessages(Companion companion) //Messages for when you just met the companion.
        {
            return "Nago the cat at your service meow.";
        }

        public override string NormalMessages(Companion companion) //Normal chitchat. If you want to get player reference, use MainMod.GetLocalPlayer.
        {
            List<string> Mes = new List<string>();
            Mes.Add("Uh so why am I human now?");
            Mes.Add("Too bad my copy abilities don't work here. These cool weapons do make up for it though.");
            Mes.Add("Guess I'm part of the adventure squad now, Why? I don't know.");
            Mes.Add("Ah Shiro how I wish you weren't so cruel sometimes.");
			Mes.Add("By chance do you know Rick? a good friend of mine... Well mostly heh.");
			Mes.Add("How come Shiro got to keep her hair. Being bald ain't that fun.");
			Mes.Add("There are some rodents that terrorize Dream Land with their treasure hunting habbits. If they attack you, try throwing cheese at em.");
			Mes.Add("Don't you dare try petting me.");
			Mes.Add("Another one of my friends is a fish called Kine. As you would expect water is a non-issue to him.");
			Mes.Add("Pitch the bird is another one of my friends. He doesn't have anything he's really good at, but he doesn't have any weaknesses either.");
			Mes.Add("Coo the owl another friend of mine can handle the skies like they're nothing.");
			Mes.Add("Rick the hamster is the master of land. He can wall climb and doesn't slip on ice either.");
			Mes.Add("ChuChu the octopus... she... uh... ya know I don't really know what she's good at.");
			Mes.Add("When I was a cat I had a cool triple jump ability. Sadly I seem to have lost it here.");
            Mes.Add("Mrow :3");
            if (!Main.dayTime)
            {
                if (Main.bloodMoon)
                {
                    Mes.Add("Hey if Shiro asks where I am, tell her I'm tied up at the bottom of the ocean.");
                    Mes.Add("I've been itching to show these monsters the way of the claw. don't ask what that means.");
                }
                else
                {
                    Mes.Add("Me and Shiro are more nightly folks. also please don't go snooping around in our rooms at night.");
					Mes.Add("Ah the night, my time to shine!");
                }
            }
            else
            {
                if (Main.eclipse)
                {
                    Mes.Add("Never seen something like this before. lots of cranky monsters too");
                    Mes.Add("Say, you'll protect us right?");
                }
                else
                {
                    Mes.Add("Ya know what I hate? Sunlight!");
                    Mes.Add("I'm not typically up right now, so hurry up with what you need to say.");
                }
            }
            if (Main.raining && !Main.eclipse && !Main.bloodMoon)
            {
                Mes.Add("Cats and rain don't mix ya know?");
            }
            if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Sardine) || WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Bree))
            {
                Mes.Add("Oh how awesome more cats to hang out with.");
            }
			if (WorldMod.HasCompanionNPCSpawned(terraguardians.CompanionDB.Michelle))
            {
                Mes.Add("Michelle sometimes tries to pet me. Would it be weird to say I enjoy it?");
            }
            return Mes[Terraria.Main.rand.Next(Mes.Count)];
        }

        public override string TalkMessages(Companion companion) //This message only appears if you speak with a companion whose friendship exp increases.
        {
            List<string> Mes = new List<string>();
            Mes.Add("Thanks for help mrow!");
            return Mes[Terraria.Main.rand.Next(Mes.Count)];
        }

        public override string RequestMessages(Companion companion, RequestContext context) //Messages regarding requests. The contexts are used to let you know which cases the message will use.
        {
            switch(context)
            {
                case RequestContext.NoRequest:
                    {
                        List<string> Mes = new List<string>();
                        Mes.Add("Oh I'm fine, Thanks for asking though.");
                        return Mes[Terraria.Main.rand.Next(Mes.Count)];
                    }
                case RequestContext.HasRequest:
                    {
                        List<string> Mes = new List<string>();
                        Mes.Add("Yeah actually could you [objective] for me?");
                        return Mes[Main.rand.Next(Mes.Count)];
                    }
                case RequestContext.Completed:
                    {
                        List<string> Mes = new List<string>();
                        Mes.Add("Ah thanks for the help. Here take this.");
                        return Mes[Terraria.Main.rand.Next(Mes.Count)];
                    }
                case RequestContext.Accepted:
                    return "Mrow! just come back to me when you finish it.";
                case RequestContext.TooManyRequests:
                    return "You seem a bit overloaded, Maybe come back latter.";
                case RequestContext.Rejected:
                    return "Well that's alright I guess.";
                case RequestContext.PostponeRequest:
                    return "Just give me meow when you're ready.";
                case RequestContext.Failed:
                    return "Well crap.";
                case RequestContext.AskIfRequestIsCompleted:
                    return "Oh you did the thing I asked?";
                case RequestContext.RemindObjective:
                    return "Oh you need to [objective].";
            }
            return base.RequestMessages(companion, context);
        }

        public override string AskCompanionToMoveInMessage(Companion companion, MoveInContext context)
        {
            switch(context)
            {
                case MoveInContext.Success:
                    return "Yeah I'm down.";
                case MoveInContext.Fail:
                    return "Sorry can't come over at the moment.";
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
                    return "Well ok, guess I'm out then";
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
                    return "Oh nice, let's go!";
                case JoinMessageContext.FullParty:
                    return "You got way too many members right now.";
                case JoinMessageContext.Fail:
                    return "Sorry, can't join right now.";
            }
            return base.JoinGroupMessages(companion, context);
        }

        public override string LeaveGroupMessages(Companion companion, LeaveMessageContext context)
        {
            switch(context)
            {
                case LeaveMessageContext.Success:
                    return "Alrighty, I'm heading back home now.";
                case LeaveMessageContext.Fail:
                    return "Sorry, can't leave right now hehe.";
                case LeaveMessageContext.AskIfSure:
                    return "Uh seems pretty dangerous right now, You sure I should go?";
                case LeaveMessageContext.DangerousPlaceYesAnswer:
                    return "Well I think I can fight my way through this. See you soon I hope.";
                case LeaveMessageContext.DangerousPlaceNoAnswer:
                    return "Heh thanks for keeping me :3";
            }
            return base.LeaveGroupMessages(companion, context);
        }

        public override string OnToggleShareBedsMessage(Companion companion, bool Share)
        {
            if (Share) return "Well alright, but no funny business.";
            return "I'll sleep on the floor then.";
        }

        public override string TacticChangeMessage(Companion companion, TacticsChangeContext context) //For when talking about changing their combat behavior.
        {
            switch(context)
            {
                case TacticsChangeContext.OnAskToChangeTactic:
                    return "Oh alright, What should I do?";
                case TacticsChangeContext.ChangeToCloseRange:
                    return "Hmm that works for me. I'll fight up close then.";
                case TacticsChangeContext.ChangeToMidRanged:
                    return "Mid-range huh? Sure that works.";
                case TacticsChangeContext.ChangeToLongRanged:
                    return "Alright I'll fight back here then.";
                case TacticsChangeContext.Nevermind:
                    return "Oh alright I'll stay on my current fighting style then.";
            }
            return base.TacticChangeMessage(companion, context);
        }

        public override string TalkAboutOtherTopicsMessage(Companion companion, TalkAboutOtherTopicsContext context) //FOr when going to speak about other things.
        {
            switch(context)
            {
                case TalkAboutOtherTopicsContext.FirstTimeInThisDialogue:
                    return "Anything else meow?";
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
                        Mes.Add("Zzzzz");
						Mes.Add("Zzzzz meow");
                        return Mes[Main.rand.Next(Mes.Count)];
                    }
                case SleepingMessageContext.OnWokeUp:
                    switch (Main.rand.Next(2))
                    {
                        default:
                            return "Oh hello, Waking me up from my catnap I see.";
                        case 1:
                            return "Oh good morning to you.?";
                    }
                case SleepingMessageContext.OnWokeUpWithRequestActive:
                    switch (Main.rand.Next(2))
                    {
                        default:
                            return "Oh hello, did you do that thing I asked?";
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
                    return "Sure, what do you need help with?";
                case InteractionMessageContext.Accepts:
                    return "Sure one moment.";
                case InteractionMessageContext.Rejects:
                    return "Sorry, that's out of my reach.";
                case InteractionMessageContext.Nevermind:
                    return "Oh alright.";
            }
            return base.InteractionMessages(companion, context);
        }

        public override string BuddiesModeMessage(Companion companion, BuddiesModeContext context)
        {
            switch(context)
            {
                case BuddiesModeContext.Failed:
                    return "Uh nope";
                case BuddiesModeContext.AlreadyHasBuddy:
                    return "It's a bit mean to ask me when you already have one.";
            }
            return base.BuddiesModeMessage(companion, context);
        }

        public override string InviteMessages(Companion companion, InviteContext context)
        {
            switch(context)
            {
                case InviteContext.Success:
                    return "Sure, bring me some fish too hehe.";
                case InviteContext.SuccessNotInTime:
                    return "It'll have to wait tell tommrow. Rick and I are having a chat.";
                case InviteContext.Failed:
                    return "Currently I can't come over, Kirby is just too nice.";
                case InviteContext.CancelInvite:
                    return "Oh alright, I still want that fish though.";
                case InviteContext.ArrivalMessage:
                    return "I'm here, do you have the fish?";
            }
            return "";
        }

        public override string ReviveMessages(Companion companion, Player target, ReviveContext context)
        {
            switch(context)
            {
                case ReviveContext.HelpCallReceived:
                    return "Please just hold on a little longer.";
                case ReviveContext.RevivingMessage:
                    {
                        List<string> Mes = new List<string>();
                        if (!(target is Companion))
                        {
                            Mes.Add("I think I know a healing spell or two.");
                        }
                        else
                        {
                            Mes.Add("Hopefully I'm doing this right");
                        }
                        return Mes[Main.rand.Next(Mes.Count)];
                    }
                case ReviveContext.OnComingForFallenAllyNearbyMessage:
                    return "Coming!";
                case ReviveContext.ReachedFallenAllyMessage:
                    return "Ok lets start.";
                case ReviveContext.RevivedByItself:
                    return "Looks like my spells work on me as well.";
                case ReviveContext.ReviveWithOthersHelp:
                    return "Ah thanks everyone.";
            }
            return base.ReviveMessages(companion, target, context);
        }

        public override string GetOtherMessage(Companion companion, string Context)
        {
            switch(Context)
            {
                case MessageIDs.LeopoldEscapedMessage:
                    return "Hmm why did you let him get away?";
                case MessageIDs.VladimirRecruitPlayerGetsHugged:
                    return "I do something similar to a pink friend of mine.";
            }
            return base.GetOtherMessage(companion, Context);
        }
    }
}
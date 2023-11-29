using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoolestRPG.GameLogic.Story
{
    internal class Story
    {

        private string[] story = new string[MAX_STRINGS];
        private uint currentStory = 0;
        private uint currentStoryString = 0;
        private const uint MAX_STRINGS = 10;

        public string GetCurrentStoryText()
        {
            return Path(currentStory)[currentStoryString];
        }

        public void ProgressStory()
        {
            currentStoryString++;
        }

        // Initializes and Stores various lines of dialogue in logic

            // Finds the array currently being accessed
            public string[] Path(uint currentStory)
            {
                switch (currentStory)
                {
                    case 0:
                        story = GetStoryOrigin();
                        return story;
                    case 1:
                        story = GetStoryApproach();
                        return story;
                    case 2:
                        story = GetStoryAvoid();
                        return story;
                    case 3:
                        story = GetStoryCheckFamiliarity();
                        return story;
                    case 4:
                        story = GetStoryCheckBluff();
                        return story;
                    case 5:
                        story = GetStoryRecognize();
                        return story;
                default:
                        story = GetCurrentStoryError();
                        return story;
                }
            }

        // Arrays containing portions of dialogue
        private string[] GetStoryOrigin() 
        { 
            story = new string[MAX_STRINGS];
            story[0] = "You still exist, don't think too hard about it.";
            story[1] = "Anyway, with nothing better to do, you start wandering around.";
            story[2] = "Off in the distance, you spot a body of water, approach it?";

            // Approach, Avoid, CheckFamiliarity

            return story;
        }

        private string[] GetStoryApproach() 
        {
            story = new string[MAX_STRINGS];
            story[0] = "You approach the lake and notice corpses floating on the surface.";
            story[1] = "While mostly decayed, identifiable features are still intact.";
            story[2] = "We would like to know, do you recognize the bodies in the water?";

            // Yes or No(CheckBluff)
            // |
            // You were, in fact, dead, albiet not for long.

            return story;
        }

        private string[] GetStoryAvoid() 
        {
            story = new string[MAX_STRINGS];
            story[0] = "Through either knowledge or gut feeling, you choose to avoid the lake.";
            story[1] = "You continue to wander this vast forest with nowhere to go...";
            story[2] = "And no one to return to.";

            return story;
        }

        private string[] GetStoryCheckFamiliarity()
        {
            story = new string[MAX_STRINGS];
            // If pass wisdom check
            story[0] = "You recall a website that discusses phenomenon similar to this.";
            story[1] = "The site refers to this as SCP-2316.";
            story[2] = "Approach?";
            // If fail wisdom check
            story[3] = "You have no recollection as to what this is, but you know it has some form of personal significance.";
            story[4] = "Approach?";

            return story;
        }

        private string[] GetStoryCheckBluff() 
        {
            story = new string[MAX_STRINGS];
            // If personal bluff succeeds and lake entertains you
            story[0] = "You convince yourself that you have no relation to the bodies.";
            story[1] = "The lake, in spite of recent events, entertains you, and gives you no trouble.";
            story[2] = "Ending: Denial";
            // If personal bluff succeeds and lake refuses to entertains you
            story[3] = "You do not recognize the bodies in the water...";
            story[4] = "but they sure as hell recognize you."; // Triggers combat
            // If personal bluff fails
            story[5] = "You cannot help but recognize the bodies in the water...";
            story[6] = "And the lake simply cannot let you leave."; // Triggers combat

            return story;
        }

        private string[] GetStoryRecognize()
        {
            story = new string[MAX_STRINGS];

            story[0] = "You recognize the bodies in the water...";
            story[1] = "And the lake simply cannot let you leave."; // Triggers combat

            return story;
        }

        private string[] GetCurrentStoryError()
        {
            story = new string[MAX_STRINGS];
            story[0] = "currentStory has exceeded boundaries";
            return story;
        }
    }
}

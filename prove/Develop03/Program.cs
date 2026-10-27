using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();
        scriptures.Add(new Scripture(new Reference("Mosiah",3,19),"For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father."));
        scriptures.Add(new Scripture(new Reference("Ether",12,6),"And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith."));
        scriptures.Add(new Scripture(new Reference("Matthew",11,28,30),"28 ¶ Come unto me, all ye that labour and are heavy laden, and I will give you rest. 29 Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. 30 For my yoke is easy, and my burden is light."));

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(0,scriptures.Count)];
        string userInput;

        do
        {
            Console.Clear();
            scripture.Display();
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();
            if(userInput == "quit" || scripture.completelyHidden())
            {
                break;
            }
            scripture.setHiddenWords();
        }
        while(true);
    }
}
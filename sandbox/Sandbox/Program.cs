using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
// Created a menu of options to exceed the requirements, in order to help the user to repeat the excercise on the scripture or change for different ones.
    static void Main(string[] args)
    {
        var allScriptures = GenerateScriptures();
        var random = new Random();
        var randomIndex = random.Next(allScriptures.Count);
        var currentScripture = allScriptures[randomIndex];
        var wordsToHide = currentScripture.GetWords().Where(word => !word.IsHidden()).ToList();

        while (true)
        {
            DisplayScripture(currentScripture);

            Console.WriteLine("\nChoose one of the options bellow and hit 'Enter' to continue:");
            Console.ForegroundColor = ConsoleColor.Blue; //Set menu color for blue
            Console.WriteLine("\n---------------------------OPTIONS---------------------------");
            Console.WriteLine("\n1. Hide a word. ");
            Console.WriteLine("2. Display the entire scripture again. ");
            Console.WriteLine("3. Display a new random scripture. ");
            Console.WriteLine("4. Quit.");

            Console.Write("\nEnter your choice: ");
            Console.ResetColor(); // Reset text color to default
            Console.ForegroundColor = ConsoleColor.Red; // Set text color to red for user input
            string input = Console.ReadLine();
            Console.ResetColor(); // Reset text color to default

            switch (input)
            {
                case "1":
                    currentScripture.HideRandomWord();
                    break;
                case "2":
                    currentScripture.RevealAllWords();
                    DisplayScripture(currentScripture);
                    break;
                case "3":
                    randomIndex = random.Next(allScriptures.Count);
                    currentScripture = allScriptures[randomIndex];
                    break;
                case "4":
                    Console.WriteLine("Exiting program.");
                    return;
                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }

// Created a small list of some of the seminary scriptures to exceed requirements, combining it with the options' menu
    static List<Scripture> GenerateScriptures()
    {
        return new List<Scripture>()
        {
            new Scripture("John", 3, 16, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture("Moses", 1, 39, "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man."),
            new Scripture("Matthew", 5, 14-16, "Ye are the light of the world. A city that is set on an hill cannot be hid. Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house. Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven."),
            new Scripture("1 Nephi", 3, 7, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
            new Scripture("Joseph Smith–History", 1, 15-20, "I saw two Personages, whose brightness and glory defy all description, standing above me in the air. One of them spake unto me, calling me by name and said, pointing to the other—This is My Beloved Son. Hear Him!"),
            new Scripture("Moses", 7, 18, "And the Lord called his people Zion, because they were of one heart and one mind, and dwelt in righteousness; and there was no poor among them."),
            new Scripture("Matthew", 11, 28-30, "Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light."),
            new Scripture("2 Nephi", 2, 25, "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture("Doctrine and Covenants", 1, 37-38, "Search these commandments, for they are true and faithful, and the prophecies and promises which are in them shall all be fulfilled. What I the Lord have spoken, I have spoken, and I excuse not myself; and though the heavens and the earth pass away, my word shall not pass away, but shall all be fulfilled, whether by mine own voice or by the voice of my servants, it is the same."),
            new Scripture("Abraham", 3, 22-23, "Now the Lord had shown unto me, Abraham, the intelligences that were organized before the world was; and among all these there were many of the noble and great ones; And God saw these souls that they were good, and he stood in the midst of them, and he said: These I will make my rulers; for he stood among those that were spirits, and he saw that they were good; and he said unto me: Abraham, thou art one of them; thou wast chosen before thou wast born."),
            new Scripture("Matthew", 16, 15-19, "He saith unto them, But whom say ye that I am? And Simon Peter answered and said, Thou art the Christ, the Son of the living God. And Jesus answered and said unto him, Blessed art thou, Simon Bar-jona: for flesh and blood hath not revealed it unto thee, but my Father which is in heaven. And I say also unto thee, That thou art Peter, and upon this rock I will build my church; and the gates of hell shall not prevail against it. And I will give unto thee the keys of the kingdom of heaven: and whatsoever thou shalt bind on earth shall be bound in heaven: and whatsoever thou shalt loose on earth shall be loosed in heaven."),
            new Scripture("2 Nephi", 2, 27, "Wherefore, men are free according to the flesh; and all things are given them which are expedient unto man. And they are free to choose liberty and eternal life, through the great Mediator of all men, or to choose captivity and death, according to the captivity and power of the devil; for he seeketh that all men might be miserable like unto himself."),
            new Scripture("Doctrine and Covenants", 6, 36, "Look unto me in every thought; doubt not, fear not."),
            new Scripture("Genesis", 1, 26-27, "And God said, Let us make man in our image, after our likeness: and let them have dominion over the fish of the sea, and over the fowl of the air, and over the cattle, and over all the earth, and over every creeping thing that creepeth upon the earth. So God created man in his own image, in the image of God created he him; male and female created he them."),
            new Scripture("Matthew", 22, 36-39, "Master, which is the great commandment in the law? Jesus said unto him, Thou shalt love the Lord thy God with all thy heart, and with all thy soul, and with all thy mind. This is the first and great commandment. And the second is like unto it, Thou shalt love thy neighbour as thyself."),
            new Scripture("2 Nephi", 9, 28-29, "O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they know of themselves, wherefore, their wisdom is foolishness and it profiteth them not. And they shall perish. But to be learned is good if they hearken unto the counsels of God."),
            new Scripture("Doctrine and Covenants", 8, 2-3, "Yea, behold, I will tell you in your mind and in your heart, by the Holy Ghost, which shall come upon you and which shall dwell in your heart. Now, behold, this is the spirit of revelation; behold, this is the spirit by which Moses brought the children of Israel through the Red Sea on dry ground."),
            new Scripture("Genesis", 39, 9, "There is none greater in this house than I; neither hath he kept back any thing from me but thee, because thou art his wife: how then can I do this great wickedness, and sin against God?"),
            new Scripture("Luke", 24, 36-39, "And as they thus spake, Jesus himself stood in the midst of them, and saith unto them, Peace be unto you. But they were terrified and affrighted, and supposed that they had seen a spirit. And he said unto them, Why are ye troubled? and why do thoughts arise in your hearts? Behold my hands and my feet, that it is I myself: handle me, and see; for a spirit hath not flesh and bones, as ye see me have."),
            new Scripture("2 Nephi", 28, 7-9, "Yea, and there shall be many which shall say: Eat, drink, and be merry, for tomorrow we die; and it shall be well with us. And there shall also be many which shall say: Eat, drink, and be merry; nevertheless, fear God—he will justify in committing a little sin; yea, lie a little, take the advantage of one because of his words, dig a pit for thy neighbor; there is no harm in this; and do all these things, for tomorrow we die; and if it so be that we are guilty, God will beat us with a few stripes, and at last we shall be saved in the kingdom of God. Yea, and there shall be many which shall teach after this manner, false and vain and foolish doctrines, and shall be puffed up in their hearts, and shall seek deep to hide their counsels from the Lord; and their works shall be in the dark."),
            new Scripture("Doctrine and Covenants", 13, 1, "Upon you my fellow servants, in the name of Messiah I confer the Priesthood of Aaron, which holds the keys of the ministering of angels, and of the gospel of repentance, and of baptism by immersion for the remission of sins; and this shall never be taken again from the earth until the sons of Levi do offer again an offering unto the Lord in righteousness."),
            new Scripture("Exodus", 19, 5-6, "Now therefore, if ye will obey my voice indeed, and keep my covenant, then ye shall be a peculiar treasure unto me above all people: for all the earth is mine: And ye shall be unto me a kingdom of priests, and an holy nation. These are the words which thou shalt speak unto the children of Israel."),
            new Scripture("John", 3, 5, "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God."),
            new Scripture("2 Nephi", 31, 19-20, "And now, my beloved brethren, after ye have gotten into this strait and narrow path, I would ask if all is done? Behold, I say unto you, Nay; for ye have not come thus far save it were by the word of Christ with unshaken faith in him, relying wholly upon the merits of him who is mighty to save. Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life."),
            new Scripture("Doctrine and Covenants", 18, 10-11, "Remember the worth of souls is great in the sight of God; For, behold, the Lord your Redeemer suffered death in the flesh; wherefore he suffered the pain of all men, that all men might repent and come unto him."),
            new Scripture("Exodus", 20, 3-17, "Thou shalt have no other gods before me. Thou shalt not make unto thee any graven image, or any likeness of any thing that is in heaven above, or that is in the earth beneath, or that is in the water under the earth. Thou shalt not bow down thyself to them, nor serve them: for I the Lord thy God am a jealous God, visiting the iniquity of the fathers upon the children unto the third and fourth generation of them that hate me; And shewing mercy unto thousands of them that love me, and keep my commandments. Thou shalt not take the name of the Lord thy God in vain; for the Lord will not hold him guiltless that taketh his name in vain. Remember the sabbath day, to keep it holy. Six days shalt thou labour, and do all thy work: But the seventh day is the sabbath of the Lord thy God: in it thou shalt not do any work, thou, nor thy son, nor thy daughter, thy manservant, nor thy maidservant, nor thy cattle, nor thy stranger that is within thy gates: For in six days the Lord made heaven and earth, the sea, and all that in them is, and rested the seventh day: wherefore the Lord blessed the sabbath day, and hallowed it. Honour thy father and thy mother: that thy days may be long upon the land which the Lord thy God giveth thee. Thou shalt not kill. Thou shalt not commit adultery. Thou shalt not steal. Thou shalt not bear false witness against thy neighbour. Thou shalt not covet thy neighbour's house, thou shalt not covet thy neighbour's wife, nor his manservant, nor his maidservant, nor his ox, nor his ass, nor any thing that is thy neighbour's."),
            new Scripture("John", 14, 6, "Jesus saith unto him, I am the way, the truth, and the life: no man cometh unto the Father, but by me."),
            new Scripture("2 Nephi", 32, 3, "Angels speak by the power of the Holy Ghost; wherefore, they speak the words of Christ. Wherefore, I said unto you, feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do."),
            new Scripture("Doctrine and Covenants", 19, 16-19, "And now, verily, verily, I say unto thee, put your trust in that Spirit which leadeth to do good—yea, to do justly, to walk humbly, to judge righteously; and this is my Spirit. Verily, verily, I say unto you, I will impart unto you of my Spirit, which shall enlighten your mind, which shall fill your soul with joy; And then shall ye know, or by this shall you know, all things whatsoever you desire of me, which are pertaining unto things of righteousness, in faith believing in me that you shall receive."),
            new Scripture("Genesis", 2, 24, "Therefore shall a man leave his father and his mother, and shall cleave unto his wife: and they shall be one flesh."),
            new Scripture("Matthew", 28, 19-20, "Go ye therefore, and teach all nations, baptizing them in the name of the Father, and of the Son, and of the Holy Ghost: Teaching them to observe all things whatsoever I have commanded you: and, lo, I am with you alway, even unto the end of the world. Amen."),
            new Scripture("2 Nephi", 25, 23-26, "For we labor diligently to write, to persuade our children, and also our brethren, to believe in Christ, and to be reconciled to God; for we know that it is by grace that we are saved, after all we can do. And we talk of Christ, we rejoice in Christ, we preach of Christ, we prophesy of Christ, and we write according to our prophecies, that our children may know to what source they may look for a remission of their sins."),
            new Scripture("Doctrine and Covenants", 10, 5, "Pray always, that you may come off conqueror; yea, that you may conquer Satan, and that you may escape the hands of the servants of Satan that do uphold his work."),
        };
    }

    static void DisplayScripture(Scripture scripture)
    {
        Console.Clear();
    
        // Display scripture reference in default color
         Console.WriteLine(scripture.GetReference().GetDisplayText());
    
        // Set text color to green for scripture words
        Console.ForegroundColor = ConsoleColor.Green;
        foreach (var word in scripture.GetWords())
        {
            foreach (char c in word.GetDisplayText())
            {
                if (c == '_')
                {
                    // Set text color to white for underscores
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(c);
                    // Reset text color to green for scripture words
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.Write(c);
                }
            }
            Console.Write(" "); // Add a space between words
        }
    
        // Reset text color to default
        Console.ResetColor();
    
        Console.WriteLine(); // Add a newline for better formatting
    }
}
// All member variables are private and adhere to the principles of encapsulation and single responsibility.
class Reference
{
    private readonly string book;
    private readonly int chapter;
    private readonly int verseStart;
    private readonly int? verseEnd;

    public Reference(string book, int chapter, int verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verse;
        this.verseEnd = null;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verseStart;
        this.verseEnd = verseEnd;
    }

    public string GetDisplayText()
    {
        return verseEnd.HasValue ? $"{book} {chapter}:{verseStart}-{verseEnd}" : $"{book} {chapter}:{verseStart}";
    }
}

class Word
{
    private readonly string text;
    private bool hidden;

    public Word(string text)
    {
        this.text = text;
        hidden = false;
    }

    public string GetDisplayText()
    {
        return hidden ? "___" : text;
    }

    public void Hide()
    {
        hidden = true;
    }

    public bool IsHidden()
    {
        return hidden;
    }

    public void Reveal()
    {
        hidden = false;
    }
}

class Scripture
{    private readonly Reference reference;
    private readonly List<Word> words;
    private readonly List<Word> originalWords;

    public Scripture(string book, int chapter, int verse, string text)
    {
        reference = new Reference(book, chapter, verse);
        originalWords = text.Split(' ').Select(word => new Word(word)).ToList();
        words = new List<Word>(originalWords);
    }

    // Constructor for single verse or verse range
    public Scripture(string book, int chapter, int verseStart, int verseEnd, string text)
    {
        reference = new Reference(book, chapter, verseStart, verseEnd);
        originalWords = text.Split(' ').Select(word => new Word(word)).ToList();
        words = new List<Word>(originalWords);
    }

    public Reference GetReference()
    {
        return reference;
    }

    public IEnumerable<Word> GetWords()
    {
        return words;
    }

    public void HideRandomWord()
    {
        var visibleWords = words.Where(word => !word.IsHidden()).ToList();
        if (visibleWords.Any())
        {
            var randomWord = visibleWords[new Random().Next(visibleWords.Count)];
            randomWord.Hide();
        }
        else
        {
            Console.WriteLine("No more words to hide!");
        }
    }

    public void RevealAllWords()
    {
        foreach (var word in words)
        {
            word.Reveal();
        }
    }
}
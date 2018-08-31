using System;
using System.Collections;
using System.Collections.Generic;

namespace BugFixing
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var eightBall = new MagicEightBall();
            while(true){
                Console.WriteLine("What do you ask of the mighty eight ball? [Hit enter to quit]");
                var question = Console.ReadLine();
                var answer = eightBall.ShouldI(question);
                Console.WriteLine(answer + '\n');
            }
            
        }
    }

    public class MagicEightBall{
        private IList<string> answers;
        private Random rand;

        public MagicEightBall(){
            rand = new Random();
            answers = new List<string>(){
                "It is certain.",
                "It is decidedly so.",
                "Without a doubt.",
                "Yes - definitely.",
                "You may rely on it.",
                "As I see it, yes.",
                "Most likely.",
                "Outlook good.",
                "Yes.",
                "Signs point to yes.",
                "Reply hazy, try again",
                "Ask again later.",
                "Better not tell you now.",
                "Cannot predict now.",
                "Concentrate and ask again.",
                "Don't count on it.",
                "My reply is no.",
                "My sources say no",
                "Outlook not so good.",
                "Very doubtful"
            };
        }

        public string ShouldI(string doTheThing){
            return answers[rand.Next(21)];
        }
    }
}

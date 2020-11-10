using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class QuizService
    {
        private static readonly List<QuizItem> Quiz;

        static QuizService()
        {
            Quiz = new List<QuizItem>{
                new QuizItem
                {
                    Question = "HTML are web pages read and rendered by",
                    Choices = new List<string> { "Web Browser", "Interpreter", "Server", "Compiler"},
                    AnswerIndex = 0,
                    Score = 3
                },
                new QuizItem
                {
                    Question = "What tag is used to display a picture in a HTML page?",
                    Choices = new List<string> { "Src", "Image", "Img","Picture"},
                    AnswerIndex = 2,
                    Score = 3
                },
                new QuizItem
                {
                    Question = "What should be the first tag in any HTML Document?",
                    Choices = new List<string> {"<title>", "<!dooctype html>", "<head>", "<html>"},
                    AnswerIndex = 1,
                    Score = 5
                },
                new QuizItem
                {
                    Question = "What type of a language is HTML?",
                    Choices = new List<string> {"Programming Language", "Mark up Language", "Network Protocol","Scripting Language"},
                    AnswerIndex = 1,
                    Score = 2
                }
            };            
        }
        public Task<List<QuizItem>> GetQuizAsync()
        {
            return Task.FromResult(Quiz);
        }
    }
}

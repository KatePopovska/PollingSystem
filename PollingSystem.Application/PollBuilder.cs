using PollingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class PollBuilder
    {
        private readonly string _questionText;
        private readonly List<PollAnswer> _answers = new();

        public PollBuilder(string questionText)
        {
            _questionText = questionText;
        }

        public PollBuilder AddAnswer(Guid id, string title)
        {
            _answers.Add(new PollAnswer(id, title));
            return this;
        }
        
        public Poll Build()
        {
            return new Poll(_questionText, _answers);
        }

        public PollResults GetResult(Poll poll) => new(poll);
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PollingSystem.Entities.Base;

namespace PollingSystem.Entities
{
    public class Poll : Identity
    {
        public Poll(string questionText, List<PollAnswer> answers) : this(questionText)
        { 
            QuestionText = questionText;
            Answers = answers;
        }
        private Poll(string questionText)
        {
            QuestionText = questionText;
        }
        public string QuestionText { get; init; }
        public List<PollAnswer> Answers { get; }

        public void VoteTo(Guid id, int value = 1)
        {
            var item = Answers?.SingleOrDefault(x=> x.Id == id);
            if(item == null)
            {
                return;
            }
            item.Votes += value;
            var totalVotes = Answers?.Sum(x => x.Votes) ?? 0;
            Answers?.ForEach(x => x.SetPercents(totalVotes));
        }
    }
}

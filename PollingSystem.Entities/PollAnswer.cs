using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PollingSystem.Entities.Base;

namespace PollingSystem.Entities
{
    public class PollAnswer : Identity
    {
        public string Title { get; init; } = null!;
        public int Votes { get; set; }
        public double Percents { get; set; }
        public PollAnswer(Guid id, string title)
        {
            Id = id;
            Title = title;
        }

        public void SetPercents(int totalVotes)
        {
            if (totalVotes > 0)
            {
                Percents = Votes * 100d / totalVotes;
            }
        }
        public override string ToString()
        {
            return $"{Title} ({Votes} ({Percents:F}%))";
        }
    }
}

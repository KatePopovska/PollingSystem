using PollingSystem.Application;
using PollingSystem.Entities;
class Program
{
    static void Main(string[] args)
    {
        var builder = new PollBuilder("What's your hobby?");
        builder.AddAnswer(Guid.Parse("00BB15E6-0775-4F92-B6B4-E5DE7E470A21"), "Volleyboll");
        builder.AddAnswer(Guid.Parse("FC4C71B6-C26D-480D-8236-735C40D483FB"), "Footboll");
        builder.AddAnswer(Guid.Parse("893DA313-5FD1-461C-8FAA-21009D200388"), "Guitar");

        var poll = builder.Build();

        /*poll.VoteTo(1);
        poll.VoteTo(2);
        poll.VoteTo(3);
        poll.VoteTo(1);
        poll.VoteTo(2, 10);

        using (var context = new ApplicationDbContext())
        {

        }*/
        var results = builder.GetResult(poll);

        Console.WriteLine(results.GetView());
    }
}


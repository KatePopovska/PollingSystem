using PollingSystem.Application;
using PollingSystem.Entities;
class Program
{
    static void Main(string[] args)
    {
        var builder = new PollBuilder("What is your favorite option?")
     .AddAnswer(Guid.Parse("51611623-e72f-0488-4011-be4f13c8e936"), "Normal")
     .AddAnswer(Guid.Parse("b253b82c-90a1-2183-4053-48f910a49247"), "Not bad")
     .AddAnswer(Guid.Parse("50f0b6ee-ba6e-f988-4f3b-79c85308ed25"), "Awful")
     .AddAnswer(Guid.Parse("9ebb2234-75cb-eeb2-4fed-1774318d9ce8"), "Super")
     .AddAnswer(Guid.Parse("51611623-e72f-0488-4011-be4f13c8e936"), "Very cool!");

        var poll = builder.Build();

        poll.VoteTo(Guid.Parse("50f0b6ee-ba6e-f988-4f3b-79c85308ed25"));
        poll.VoteTo(Guid.Parse("50f0b6ee-ba6e-f988-4f3b-79c85308ed25"));
        poll.VoteTo(Guid.Parse("b253b82c-90a1-2183-4053-48f910a49247"));
        poll.VoteTo(Guid.Parse("b253b82c-90a1-2183-4053-48f910a49247"));
        poll.VoteTo(Guid.Parse("51611623-e72f-0488-4011-be4f13c8e936"));
        poll.VoteTo(Guid.Parse("51611623-e72f-0488-4011-be4f13c8e936"));
        poll.VoteTo(Guid.Parse("b253b82c-90a1-2183-4053-48f910a49247"));
        poll.VoteTo(Guid.Parse("9ebb2234-75cb-eeb2-4fed-1774318d9ce8"));
        poll.VoteTo(Guid.Parse("9ebb2234-75cb-eeb2-4fed-1774318d9ce8"));
        poll.VoteTo(Guid.Parse("9ebb2234-75cb-eeb2-4fed-1774318d9ce8"));
        poll.VoteTo(Guid.Parse("9ebb2234-75cb-eeb2-4fed-1774318d9ce8"), 10);


        var result = builder.GetResult(poll);

        Console.WriteLine(result.GetView());
    }
}


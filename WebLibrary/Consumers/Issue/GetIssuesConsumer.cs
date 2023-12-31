﻿using MassTransit;
using ServiceModels.Requests.Issue;
using ServiceModels.Responses.Issue;
using WebLibrary.Commands.Issue.Interfaces;

namespace WebLibrary.Consumers.Issue;

public class GetIssuesConsumer : IConsumer<GetIssuesRequest>
{
    private readonly IReadIssueCommand _command;

    public GetIssuesConsumer(IReadIssueCommand command)
    {
        _command = command;
    }

    public async Task Consume(ConsumeContext<GetIssuesRequest> context)
    {
        GetIssuesResponse actionResult =  _command.Get();

        await context.RespondAsync(actionResult);
    }
}
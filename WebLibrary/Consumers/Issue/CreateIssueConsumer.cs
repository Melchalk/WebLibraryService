﻿using MassTransit;
using ServiceModels.Requests.Issue;
using ServiceModels.Responses.Issue;
using WebLibrary.Commands.Issue.Interfaces;

namespace WebLibrary.Consumers.Issue;

public class CreateIssueConsumer : IConsumer<CreateIssueRequest>
{
    private readonly ICreateIssueCommand _command;

    public CreateIssueConsumer(ICreateIssueCommand command)
    {
        _command = command;
    }

    public async Task Consume(ConsumeContext<CreateIssueRequest> context)
    {
        CreateIssueResponse actionResult = await _command.CreateAsync(context.Message);

        await context.RespondAsync(actionResult);
    }
}
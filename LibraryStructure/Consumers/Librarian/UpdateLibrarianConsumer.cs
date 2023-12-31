﻿using LibraryStructure.Commands.Librarian.Interfaces;
using MassTransit;
using ServiceModels.Requests.Librarian;
using ServiceModels.Responses.Librarian;

namespace LibraryStructure.Consumers.Librarian;

public class UpdateLibrarianConsumer : IConsumer<UpdateLibrarianRequest>
{
    private readonly IUpdaterLibrarian _command;

    public UpdateLibrarianConsumer(IUpdaterLibrarian command)
    {
        _command = command;
    }

    public async Task Consume(ConsumeContext<UpdateLibrarianRequest> context)
    {
        UpdateLibrarianResponse actionResult = await _command.UpdateAsync(context.Message);

        await context.RespondAsync(actionResult);
    }
}
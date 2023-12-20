﻿using MassTransit;
using ServiceModels.Requests.Reader;
using ServiceModels.Responses.Reader;
using WebLibrary.Commands.Reader.Interfaces;

namespace WebLibrary.Consumers.Reader;

public class DeleteReaderConsumer : IConsumer<DeleteReaderRequest>
{
    private readonly IDeleteReaderCommand _command;

    public DeleteReaderConsumer(IDeleteReaderCommand command)
    {
        _command = command;
    }

    public async Task Consume(ConsumeContext<DeleteReaderRequest> context)
    {
        DeleteReaderResponse actionResult = await _command.DeleteAsync(context.Message);

        await context.RespondAsync(actionResult);
    }
}
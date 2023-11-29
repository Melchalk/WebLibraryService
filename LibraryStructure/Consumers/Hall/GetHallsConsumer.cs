﻿using MassTransit;
using ServiceModels.Requests.Hall;
using ServiceModels.Responses.Hall;
using WebLibrary.Commands.Hall.Interfaces;

namespace LibraryStructure.Consumers.Hall;

public class GetHallsConsumer : IConsumer<GetHallsRequest>
{
    private readonly IReaderHall _command;

    public GetHallsConsumer(IReaderHall command)
    {
        _command = command;
    }

    public async Task Consume(ConsumeContext<GetHallsRequest> context)
    {
        GetHallsResponse actionResult =  _command.Get();

        await context.RespondAsync(actionResult);
    }
}
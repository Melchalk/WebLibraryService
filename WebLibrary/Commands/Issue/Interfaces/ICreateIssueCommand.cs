﻿using ServiceModels.Requests.Issue;
using ServiceModels.Responses.Issue;
using WebLibrary.Commands.Common_interfaces;

namespace WebLibrary.Commands.Issue.Interfaces;

public interface ICreateIssueCommand : ICreateCommand<CreateIssueRequest, CreateIssueResponse>
{
}
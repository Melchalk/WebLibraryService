﻿using ServiceModels.Requests.Issue;
using ServiceModels.Responses.Issue;
using WebLibrary.Commands.Common_interfaces;

namespace WebLibrary.Commands.Issue.Interfaces;

public interface IUpdaterIssue : IUpdater<UpdateIssueRequest, UpdateIssueResponse>
{
}
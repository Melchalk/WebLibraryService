﻿namespace ServiceModels.Requests.Issue;

public class CreateIssueRequest
{
    public Guid ReaderId { get; set; }
    public DateTime DateIssue { get; set; }
    public int Period { get; set; }

    public List<Guid> BooksId { get; set; }
}
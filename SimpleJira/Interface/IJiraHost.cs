﻿using SimpleJira.Interface.ObjectModel;

namespace SimpleJira.Interface
{
    public interface IJiraHost
    {
        JiraQueryResponse Query(JiraQuery query);
        string CreateIssue(object fields);
        void UpdateIssue(string issueKey, object fields);
        JiraComment[] GetComments(string key);
        void AddComment(string key, JiraComment comment);
    }
}
﻿using System;

namespace AwesomeBlazor.Models
{
    public class AwesomeResource
    {
        public Guid Id { get; } = Guid.NewGuid();

        public bool Visible { get; set; } = true;

        public string Title { get; }

        public string ResourceUrl { get; }

        public string GitHubStarsUrl { get; }

        public string LastCommitUrl { get; }

        public string DescriptionText { get; set; }

        public string DescriptionHtml { get; set; }

        public AwesomeResource(string title, string resourceUrl, string gitHubStarsUrl, string lastCommitUrl, string descriptionText, string descriptionHtml)
        {
            Title = title;
            ResourceUrl = resourceUrl;
            GitHubStarsUrl = gitHubStarsUrl;
            LastCommitUrl = lastCommitUrl;
            DescriptionText = descriptionText;
            DescriptionHtml = descriptionHtml;
        }

        public override string ToString()
        {
            return $"{Title}";
        }
    }
}
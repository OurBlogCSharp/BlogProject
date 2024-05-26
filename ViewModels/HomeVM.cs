﻿using Blog.Models;
using X.PagedList;

namespace Blog.ViewModels
{
    public class HomeVM
    {
        public string? Title { get; set; }
        public string? ShortDescription { get; set; }
        public string? PhotoUrl { get; set; }
        public IPagedList<Post>? Posts { get; set; }
    }
}

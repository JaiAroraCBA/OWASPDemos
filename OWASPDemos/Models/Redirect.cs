﻿using System;
using System.Collections.Generic;


namespace OWASPDemos.Models
{

    public class Redirect
    {
        public int Id { get; set; }
        public string Uri { get; set; }
    }

    public class RedirectsContext : IDisposable
    {
        private static List<Redirect> _redirects =
            new List<Redirect>
            {
                new Redirect { Id = 1, Uri = "https://www.idunno.org/" },
                new Redirect { Id = 2, Uri = "https://www.bing.com/" }
            };

        public IList<Redirect> Redirects
        {
            get { return _redirects; }
        }

        public void Dispose()
        {
            ;
        }
    }
}
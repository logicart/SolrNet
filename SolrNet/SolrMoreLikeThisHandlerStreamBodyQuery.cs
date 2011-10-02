﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolrNet
{
    public class SolrMoreLikeThisHandlerStreamBodyQuery : ISolrMoreLikeThisHandlerQuery
    {
        private readonly string _query;

        public SolrMoreLikeThisHandlerStreamBodyQuery(string body)
        {
            this._query = body;
        }

        public string Query
        {
        	get
            {
                return this._query;
            }
        }
    }
}

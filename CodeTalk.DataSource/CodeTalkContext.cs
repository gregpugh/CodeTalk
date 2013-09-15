﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTalk.Domain.Models;

namespace CodeTalk.DataSource
{
    class CodeTalkContext: DbContext
    {
        //public CodeTalkContext()
        //    : base("DefaultConnection")
        //{ 
        //}

        public DbSet<Talk> Talks { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTalk.Domain.Contracts;
using CodeTalk.Domain.Contracts.Repositories;
using CodeTalk.Domain.Models;
using System.Data.Entity;

namespace CodeTalk.DataSource.Repositories
{
    public class TalkRepository: ITalkRepository
    {

        private CodeTalkContext codeTalkContext;
        public TalkRepository()
        {
            codeTalkContext = new CodeTalkContext();
        }
        public IQueryable<Domain.Models.Talk> GetTalks()
        {
            var ctx = new CodeTalkContext();
            return ctx.Talks.Include("Comments");
        }

        public bool AddTalk(Domain.Models.Talk newTalk)
        {
            codeTalkContext.Talks.Add(newTalk);
            codeTalkContext.SaveChanges();
            return true;
        }


        public void EditTalk(Talk talk)
        {
            Talk serverTalk = codeTalkContext.Talks.FirstOrDefault(t => t.Id == talk.Id);
            serverTalk.Title = talk.Title;
            serverTalk.Description = talk.Description;
            serverTalk.DateCreated = talk.DateCreated;
            serverTalk.DateModified = DateTime.Now;
            codeTalkContext.SaveChanges();
        }

        public void DeleteTalk(Domain.Models.Talk talk)
        {
            throw new NotImplementedException();
        }

        public Domain.Models.Talk GetTalkById(int id)
        {
            return codeTalkContext.Talks.FirstOrDefault(t => t.Id == id);
        }
    }
}

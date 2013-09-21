using CodeTalk.Domain.Contracts.Services;
using CodeTalk.DataSource;
using CodeTalk.DataSource.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTalk.Domain.Models;
using CodeTalk.Domain.Contracts.Repositories;



namespace CodeTalk.ServiceLayer
{
    public class TalkService:ITalkService
    {
        private ITalkRepository talkRepository;
        //public TalkService(ITalkRepository talkRepository)
        public TalkService()
        {
            this.talkRepository = new TalkRepository();
        }
        public IList<Talk> GetTalks()
        {
            //var repo = new TalkRepository();
            return talkRepository.GetTalks().ToList();
        }

        public bool AddTalk(Talk newTalk)
        {
            //var repo = new TalkRepository();
            return talkRepository.AddTalk(newTalk);
        }

        public Talk GetTalkById(int id)
        {
            //var repo = new TalkRepository();
            return talkRepository.GetTalkById(id);
        }
        public void EditTalk(Talk talk)
        {
            //var repo = new TalkRepository();
            talkRepository.EditTalk(talk);
        }
        public void DeleteTalk(Talk talk)
        {
            //var repo = new TalkRepository();
            talkRepository.DeleteTalk(talk);
        }
    }
}

using CodeTalk.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTalk.Domain.Contracts.Repositories
{
    public interface ITalkRepository
    {
        IQueryable<Talk> GetTalks();
        bool AddTalk(Talk newTalk);
        void EditTalk(Talk talk);
        void DeleteTalk(Talk talk);
        Talk GetTalkById(int id);        
    }
}

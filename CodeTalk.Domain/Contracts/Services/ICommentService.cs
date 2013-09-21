using CodeTalk.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTalk.Domain.Contracts.Services
{
    public interface ICommentService
    {
        IList<Comment> GetComments();
        bool AddComment(Comment newComment);

    }
}

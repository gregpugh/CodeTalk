using CodeTalk.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTalk.Domain.Contracts.Repositories
{
    public interface ICommentRepository
    {
        IQueryable<Comment> GetComments();
        bool AddComment(Comment newComment);
        void EditComment(Comment comment);
        void DeleteComment(Comment comment);
        Comment GetCommentById(int id);        
    }
}

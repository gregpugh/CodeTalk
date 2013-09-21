using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTalk.Domain.Contracts;
using CodeTalk.Domain.Contracts.Repositories;
using CodeTalk.Domain.Models;

namespace CodeTalk.DataSource.Repositories
{
    public class CommentRepository : ICommentRepository
    {

        private CodeTalkContext codeTalkContext;
        public CommentRepository()
        {
            codeTalkContext = new CodeTalkContext();
        }
        public IQueryable<Comment> GetComments()
        {
            var ctx = new CodeTalkContext();
            return ctx.Comments;
                    }

        public bool AddComment(Domain.Models.Comment newComment)
        {
            codeTalkContext.Comments.Add(newComment);
            codeTalkContext.SaveChanges();
            return true;
        }


        public void EditComment(Comment comment)
        {
            Comment serverComment = codeTalkContext.Comments.FirstOrDefault(t => t.Id == comment.Id);
            serverComment.Body = comment.Body;
            serverComment.DateCreated = comment.DateCreated;
            serverComment.DateModified = DateTime.Now;

            codeTalkContext.SaveChanges();
        }

        public void DeleteComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Domain.Models.Comment GetCommentById(int id)
        {
            return codeTalkContext.Comments.FirstOrDefault(t => t.Id == id);
        }
    }
}

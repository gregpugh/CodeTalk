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
    public class CommentService:ICommentService
    {
        
        private ICommentRepository commentRepository;
        //public CommentService(ICommentRepository commentRepository)
        public CommentService()
        {
            this.commentRepository = new CommentRepository();
        }
        public IList<Comment> GetComments()
        {
            return commentRepository.GetComments().ToList();
        }

        public bool AddComment(Comment comment)
        {
            return commentRepository.AddComment(comment);
        }

        public Comment GetCommentById(int id)
        {
            return commentRepository.GetCommentById(id);
        }
        public void EditComment(Comment comment)
        {
            commentRepository.EditComment(comment);
        }
        public void DeleteTalk(Comment comment)
        {
            commentRepository.DeleteComment(comment);
        }
    }
}

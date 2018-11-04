using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewApp.Models;

namespace ReviewApp
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetCommentsForReviewId(int reviewId);
        void Create(Comment comment);
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewApp.Models
{
    public class CommentRepository : Repository<Models.Comment>, ICommentRepository
    {
        public CommentRepository(Context db) : base(db)
        {

        }

        public IEnumerable<Comment> GetCommentsForReviewId(int reviewId)
        {
            // This is using Linq and allows us to not have to use the foreach above
            return from comment in GetAll()
                   where comment.ReviewId == reviewId //must be true
                   orderby comment.CreatedAt // sorts by the date
                   select comment; //if we added .Text after comment, it would take just the text out of the comment
        }
    }
}

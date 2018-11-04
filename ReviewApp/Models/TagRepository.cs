using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ReviewApp.Models
{
    public class TagRepository : Repository<Tag>, ITagRepository
    {
        public TagRepository(Context db) : base(db)
        {
        }

        public IEnumerable<Tag> GetTagsForReviewId(int reviewId)
        {
            var query = from tags in GetAll()
                        from reviewTags in tags.ReviewTags
                        where reviewTags.ReviewId == reviewId
                        orderby tags.Text
                        select reviewTags.Tag;
               return query.ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ReviewApp.Models
{
    public class TagRepository : Repository<Models.Tag>, ITagRepository
    {
        public TagRepository(DbContext db) : base(db)
        {
        }

        public IEnumerable<Tag> GetTagsForReviewId(int reviewId)
        {
            return from tag in GetAll()
                   where tag.ReviewId == reviewId
                   orderby tag.Text
                   select tag;

        }
    }
}

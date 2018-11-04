using ReviewApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewApp
{
    public interface ITagRepository
    {
        IEnumerable<Tag> GetTagsForReviewId(int reviewId);
        void Create(Tag tag);
        IEnumerable<Tag> GetAll();
        Tag GetById(int id);
    }
}

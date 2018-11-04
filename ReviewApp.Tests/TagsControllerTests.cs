using NSubstitute;
using ReviewApp.Controllers.Api;
using ReviewApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewApp.Tests
{
    public class TagsControllerTests
    {
        [Fact]
        public void GetAll_Returns_All_Tags_For_Given_ToDo()
        {
            var reviewId = 42;
            var expectedModel = new List<Tag>();
            var tagRepo = Substitute.For<ITagRepository>();
            tagRepo.GetTagsForReviewId(reviewId).Returns(expectedModel);

            var underTest = new TagsController(tagRepo);

            var model = underTest.Get(reviewId);

            Assert.Same(expectedModel, model);
        }

        [Fact]
        public void Post_And_Save()
        {
            var tag = new Tag();
            var reviewId = 1;
            var tagRepo = Substitute.For<ITagRepository>();
            var underTest = new TagsController(tagRepo);

            underTest.Post(tag,reviewId);

            tagRepo.Received().Create(tag);
        }

    }
}

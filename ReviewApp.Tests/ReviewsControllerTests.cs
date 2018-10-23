using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using ReviewApp.Controllers;
using ReviewApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewApp.Tests
{
    public class ReviewsControllerTests
    {
        IReviewRepository reviewRepo;
        ReviewsController underTest;

        public ReviewsControllerTests()
        {
            reviewRepo = Substitute.For<IReviewRepository>();
            underTest = new ReviewsController(reviewRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Returns_All_Reviews()
        {
            var result = underTest.Index();
            reviewRepo.Received().GetAll();
        }

        [Fact]
        public void Index_Sets_AllReviews_As_Model()
        {
            var expectedModel = new List<Review>();
            reviewRepo.GetAll().Returns(expectedModel);

            var result = underTest.Index();

            var model = result.Model;
            Assert.Equal(expectedModel, model);
        }

        [Fact]
        public void Details_Returns_A_View()
        {
            var result = underTest.Details(1);
            Assert.IsType<ViewResult>(result);
        }
    }
}

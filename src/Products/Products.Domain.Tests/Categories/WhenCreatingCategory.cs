using System;
using Products.Domain.Categories;
using Xunit;

namespace Products.Domain.Tests.Categories
{
    public class WhenCreatingCategory
    {
        [Fact]
        public void CreatesSuccessfullyGivenValidInputs()
        {
            var categoryId = Guid.NewGuid();
            var category = new Category(categoryId, "Consoles");
            Assert.NotNull(category);
            Assert.Equal(categoryId, category.CategoryId);
            Assert.Equal("Consoles", category.Name);
        }

        [Fact]
        public void ThrowsExceptionGivenEmptyCategoryId()
        {
            Assert.Throws<Exception>(() =>
            {
                var category = new Category(Guid.Empty, "Consoles");
            });
        }

        [Fact]
        public void ThrowsExceptionGivenEmptyName()
        {
            Assert.Throws<Exception>(() =>
            {
                var category = new Category(Guid.NewGuid(), "");
            });
        }
    }
}
using Digivance.Data.EntityFramework.Tests.Contexts;
using Digivance.Data.EntityFramework.Tests.Models;

namespace Digivance.Data.EntityFramework.Tests.Entities
{
    /// <summary>
    /// Tests to ensure BaseEntity functions as expected
    /// </summary>
    [TestFixture]
    public class BaseEntityTests
    {
        /// <summary>
        /// Ensures we can cast to a custom model that inherits from BaseModel
        /// </summary>
        [Test]
        public void Can_CastToModel()
        {
            var entity = new SampleEntity { Id = Guid.NewGuid() };
            var model = entity.ToBaseModel<SampleModel>();

            Assert.That(model.Id, Is.EqualTo(entity.Id));
        }

        /// <summary>
        /// Ensures that our ConfigureBaseEntity() extension works as expected
        /// </summary>
        [Test]
        public void Can_ConfigureType()
        {
            var context = new SampleContext();

            var entity = new SampleEntity { SampleMessage = "Hello World" };
            context.SampleEntities.Add(entity);
            context.SaveChanges();

            var dataRow = context.SampleEntities
                .FirstOrDefault(x => x.SampleMessage == entity.SampleMessage);

            Assert.That(dataRow, Is.EqualTo(entity));
        }
    }
}

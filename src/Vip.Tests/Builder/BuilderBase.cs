using Bogus;

namespace Vip.Tests.Builder
{
    public abstract class BuilderBase
    {
        #region Propriedades

        protected readonly Faker faker;

        #endregion

        #region Construtores

        protected BuilderBase()
        {
            faker = new Faker("pt_BR");
        }

        #endregion
    }
}
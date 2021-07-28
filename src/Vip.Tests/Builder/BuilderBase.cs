using Bogus;

namespace Vip.Tests.Builder
{
    public abstract class BuilderBase
    {
        #region Propriedades

        protected readonly Faker _faker;

        #endregion

        #region Construtores

        protected BuilderBase()
        {
            _faker = new Faker("pt_BR");
        }

        #endregion
    }
}
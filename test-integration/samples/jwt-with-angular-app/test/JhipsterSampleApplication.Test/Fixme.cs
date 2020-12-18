using JhipsterSampleApplication.Infrastructure.Data;
using JhipsterSampleApplication.Domain;
using JhipsterSampleApplication.Test.Setup;

namespace JhipsterSampleApplication.Test {
    public static class Fixme {
        public static User ReloadUser<TEntryPoint>(NhipsterWebApplicationFactory<TEntryPoint> factory, User user)
            where TEntryPoint : class
        {
            var applicationDatabaseContext = factory.GetRequiredService<ApplicationDatabaseContext>();
            applicationDatabaseContext.Entry(user).Reload();
            return user;
        }
    }
}

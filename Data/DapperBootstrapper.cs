using Dapper;
using SurfTimer.Shared.Types.Handlers;

namespace SurfTimer.Shared.Data
{
    public static class DapperBootstrapper
    {
        private static bool _initialized;

        public static void Init()
        {
            if (_initialized)
                return;
            _initialized = true;

            // Configure Dapper settings
            DefaultTypeMap.MatchNamesWithUnderscores = true;

            // Register custom TypeHandlers
            SqlMapper.AddTypeHandler(new ReplayFramesStringHandler());
        }
    }
}

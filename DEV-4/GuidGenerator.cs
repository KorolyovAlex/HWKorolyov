using System;

namespace DEV_4
{
    class GuidGenerator
    {
        public static string GenerateGuid()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }
    }
}
